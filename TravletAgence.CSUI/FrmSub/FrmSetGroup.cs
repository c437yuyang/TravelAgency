using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TravletAgence.Common;
using TravletAgence.Common.Enums;
using TravletAgence.Common.Excel;
using TravletAgence.CSUI.Properties;
using TravletAgence.Model;

namespace TravletAgence.CSUI.FrmSub
{
    /// <summary>
    /// 总的来说，两套逻辑，一套是从签证管理界面进来，选中那些还没设置过团号的人，然后设置团号
    /// 第二套是从团号管理界面进入，可以从当前团移出人以及删除团，以及修改团的信息
    /// 
    /// </summary>
    public partial class FrmSetGroup : Form
    {
        private List<Model.VisaInfo> _list; //保存所有传进来的visainfo
        private List<Model.VisaInfo> _dgvList = new List<VisaInfo>(); //保存所有进入dgv的visainfo
        private Model.Visa _visaModel;
        private readonly bool _initFromVisaModel;

        private readonly BLL.VisaInfo _bllVisaInfo = new BLL.VisaInfo();
        private readonly BLL.Visa _bllVisa = new BLL.Visa();
        private string _visaName = "QZC" + DateTime.Now.ToString("yyMMdd") + "|";
        private readonly Action<int> _updateDel; //副界面传来更新数据库的委托
        private readonly int _curPage; //主界面更新数据库需要一个当前页

        public FrmSetGroup()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 从已有list初始化窗口(还未设置团号)
        /// </summary>
        /// <param name="list"></param>
        public FrmSetGroup(List<Model.VisaInfo> list,Action<int> updateDel,int curpage)
        {
            InitializeComponent();
            _list = list;
            _initFromVisaModel = false;
            _updateDel = updateDel;
            _curPage = curpage;
        }

        /// <summary>
        /// 从已有list初始化窗口(还未设置团号)
        /// </summary>
        /// TODO:应该先校验是否都是还没分配等逻辑
        private void InitFrmFromList()
        {
            if (_list.Count == 0)
                return;

            //根据list加载列表
            for (int i = 0; i < _list.Count; i++)
            {
                ListViewItem liv = new ListViewItem(_list[i].Name);
                ListViewItem.ListViewSubItem livSubItem = new ListViewItem.ListViewSubItem(liv, DateTimeFormator.DateTimeToString(_list[i].EntryTime));
                ListViewItem.ListViewSubItem livSubItem1 = new ListViewItem.ListViewSubItem(liv, _list[i].IssuePlace);
                liv.SubItems.Add(livSubItem);
                liv.SubItems.Add(livSubItem1);
                liv.Tag = _list[i];
                lvOut.Items.Add(liv);
            }

            //初始化时间选择控件
            txtDepartureTime.Text = DateTime.Now.ToString();

            //从list初始化就不能reset
            btnReset.Enabled = false;

        }

        /// <summary>
        /// 从已有visaModel设置窗口(已经设置了团号)
        /// </summary>
        /// <param name="_visaModel"></param>
        public FrmSetGroup(Model.Visa model, Action<int> updateDel, int curpage)
        {
            InitializeComponent();
            _visaModel = model;
            _initFromVisaModel = true;
            _updateDel = updateDel;
            _curPage = curpage;
        }

        /// <summary>
        /// 从已有visaModel设置窗口(已经设置了团号)
        /// </summary>
        private void InitFrmFromVisaModel()
        {
            if (_visaModel == null)
                return;

            //查询得到所有的属于这个团的用户
            _list = _bllVisaInfo.GetModelList(" GroupNo = '" + _visaModel.GroupNo + "'");

            //根据list加载列表
            lvOut.Items.Clear();
            lvIn.Items.Clear();
            for (int i = 0; i < _list.Count; i++)
            {
                ListViewItem liv = new ListViewItem(_list[i].Name);
                ListViewItem.ListViewSubItem livSubItem = new ListViewItem.ListViewSubItem(liv, DateTimeFormator.DateTimeToString(_list[i].EntryTime));
                ListViewItem.ListViewSubItem livSubItem1 = new ListViewItem.ListViewSubItem(liv, _list[i].IssuePlace);
                liv.SubItems.Add(livSubItem);
                liv.SubItems.Add(livSubItem1);
                liv.Tag = _list[i];
                lvIn.Items.Add(liv); //这里是默认进入的在里面
            }

            //初始化团号
            updateGroupNo();

            //初始化dgv
            updateDgvData();

            //初始化时间选择控件
            txtDepartureTime.Text = DateTimeFormator.DateTimeToString(_visaModel.PredictTime);

            //初始化国家选择控件
            cbCountry.Text = _visaModel.Country;

        }

        private void FrmSetGroup_Load(object sender, EventArgs e)
        {
            dgvGroupInfo.AutoGenerateColumns = false;
            dgvGroupInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; //列宽自适应
            dgvGroupInfo.Columns["Birthday"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;//某一些列关闭自适应
            //设置列表多选
            lvIn.MultiSelect = true;
            lvOut.MultiSelect = true;

            if (_list != null && _visaModel == null && !_initFromVisaModel)
                InitFrmFromList();
            if (_list == null && _visaModel != null && _initFromVisaModel)
                InitFrmFromVisaModel();
        }

        #region 状态更新函数
        private void updateGroupNo()
        {
            _visaName = "QZC" + txtDepartureTime.Value.ToString("yyMMdd");
            for (int i = 0; i < lvIn.Items.Count; ++i)
            {
                _visaName += ((Model.VisaInfo)lvIn.Items[i].Tag).Name;
                if (i == lvIn.Items.Count - 1)
                    break;
                _visaName += "、";
            }
            txtGroupNo.Text = _visaName;
            lbCount.Text = "团队人数:" + lvIn.Items.Count + "人";
        }

        private void updateDgvData()
        {
            _dgvList.Clear();
            for (int i = 0; i < lvIn.Items.Count; ++i)
            {
                _dgvList.Add((Model.VisaInfo)lvIn.Items[i].Tag);
            }
            dgvGroupInfo.DataSource = null; //必须加，不然报错，不知道为什么
            dgvGroupInfo.DataSource = _dgvList;
            //dgvGroupInfo.Invalidate();
            //dgvGroupInfo.Update();
        }

        /// <summary>
        /// 第一套逻辑
        /// </summary>
        /// <param name="list"></param>
        private void UpdateInListVisaInfo(List<Model.VisaInfo> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].GroupNo = _visaModel.GroupNo;
                list[i].HasTypeIn = HasTypeIn.Yes; //修改为已录入状态
                list[i].Country = cbCountry.Text;
                list[i].Visa_id = _visaModel.Visa_id.ToString(); //修改visainfo对应visa_id
            }
            int res = _bllVisaInfo.UpdateByList(_dgvList);
            MessageBox.Show(res + "条记录成功更新," + (list.Count - res) + "条记录更新失败.");
        }

        #endregion

        #region dgv响应
        /// <summary>
        /// 显示行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvGroupInfo_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgvGroupInfo.Rows.Count; i++)
            {
                dgvGroupInfo.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        /// <summary>
        /// 备注批量修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvGroupInfo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvGroupInfo.Columns[e.ColumnIndex].Name == "Remark")
            {
                string remark = dgvGroupInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                for (int i = 0; i < dgvGroupInfo.Rows.Count; i++)
                {
                    dgvGroupInfo.Rows[i].Cells[e.ColumnIndex].Value = remark;

                }
            }
        }


        private void dgvGroupInfo_KeyUp(object sender, KeyEventArgs e)
        {


        }

        private void dgvGroupInfo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        /// <summary>
        /// 实现赋值粘贴,Ctrl+C,Ctrl+V响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 现在只能单条记录，多条记录其实也可以
        /// TODO:多条记录赋值粘贴，用|做分割
        private void dgvGroupInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvGroupInfo.SelectedCells.Count != 0 && e.Control && e.KeyCode == Keys.C)
            {
                if (dgvGroupInfo.SelectedCells[0].Value != null)
                    Clipboard.SetText(dgvGroupInfo.SelectedCells[0].Value.ToString());
            }

            if (dgvGroupInfo.SelectedCells.Count != 0 && e.Control && e.KeyCode == Keys.V)
            {

                for (int i = 0; i < dgvGroupInfo.SelectedCells.Count; i++)
                {
                    dgvGroupInfo.SelectedCells[i].Value = Clipboard.GetText();
                }


            }
        }
        #endregion


        #region 自己的按钮

        private void btnAllIn_Click(object sender, EventArgs e)
        {
            for (int i = lvOut.Items.Count - 1; i >= 0; --i)
            {
                ListViewItem lvItem = lvOut.Items[i];
                lvOut.Items.Remove(lvOut.Items[i]);
                lvIn.Items.Add(lvItem);
            }
            updateGroupNo();
            updateDgvData();
        }

        private void btnAllOut_Click(object sender, EventArgs e)
        {
            for (int i = lvIn.Items.Count - 1; i >= 0; --i)
            {
                ListViewItem lvItem = lvIn.Items[i];
                lvIn.Items.Remove(lvIn.Items[i]);
                lvOut.Items.Add(lvItem);
            }
            updateGroupNo();
            updateDgvData();

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            for (int i = lvOut.SelectedItems.Count - 1; i >= 0; --i)
            {
                ListViewItem lvItem = lvOut.SelectedItems[i];
                lvOut.Items.Remove(lvOut.SelectedItems[i]);
                lvIn.Items.Insert(0, lvItem);
            }
            updateGroupNo();
            updateDgvData();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            for (int i = lvIn.SelectedItems.Count - 1; i >= 0; --i)
            {
                ListViewItem lvItem = lvIn.SelectedItems[i];
                lvIn.Items.Remove(lvIn.SelectedItems[i]);
                lvOut.Items.Insert(0, lvItem);
            }
            updateGroupNo();
            updateDgvData();
        }


        /// <summary>
        /// 生成报表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            if (dgvGroupInfo.Rows[0].Cells["Remark"].Value != null)
                GroupExcel.GenGroupInfoExcel(_dgvList, dgvGroupInfo.Rows[0].Cells["Remark"].Value.ToString(), txtGroupNo.Text);
            else
                GroupExcel.GenGroupInfoExcel(_dgvList, string.Empty, txtGroupNo.Text);
        }

        /// <summary>
        /// 提交修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// TODO:处理需要修改团号的逻辑
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("是否提交修改?", "确认", MessageBoxButtons.OKCancel);
            if (res == DialogResult.Cancel)
                return;
            if (!_initFromVisaModel)
            {
                //1.保存团号信息修改到数据库,Visa表（sales_person,country,GroupNo,PredictTime）
                if (_visaModel != null)
                {
                    MessageBox.Show("内部错误!");
                    return;
                }
                _visaModel = new Visa();
                //_visaModel.Visa_id = Guid.NewGuid(); //这里必须要给一个，虽然这里不给也会入库正确，数据库会赋给默认值，但是后面更新对应visainfo就会有错
                //这里代码生成器默认给了一个guid，不能再自己给了
                _visaModel.EntryTime = DateTime.Now;
                _visaModel.GroupNo = txtGroupNo.Text;
                _visaModel.SalesPerson = txtSalesPerson.Text;
                _visaModel.PredictTime = DateTime.Parse(txtDepartureTime.Text);
                _visaModel.Country = cbCountry.Text;
                _visaModel.Number = lvIn.Items.Count; //团号的人数
                if ((_visaModel.Visa_id = _bllVisa.Add(_visaModel)) == Guid.Empty) //执行更新,返回值是新插入的visamodel的guid
                {
                    MessageBox.Show("添加团号到数据库失败，请重试!");
                    return;
                }

                //2.更新model,设置资料已录入，团号，国家等
                _dgvList = (List<Model.VisaInfo>)dgvGroupInfo.DataSource;
                //2.1更新VisaInfo数据库
                UpdateInListVisaInfo(_dgvList);
            }
            else
            {
                //从model初始化的，只考虑信息的修改以及移出人
                //1.保存团号信息修改到数据库,Visa表（sales_person,country,GroupNo,PredictTime）
                _visaModel.GroupNo = txtGroupNo.Text;
                _visaModel.SalesPerson = txtSalesPerson.Text;
                _visaModel.PredictTime = DateTime.Parse(txtDepartureTime.Text);
                _visaModel.Country = cbCountry.Text;
                _visaModel.Number = lvIn.Items.Count;
                if (!_bllVisa.Update(_visaModel)) //执行更新
                {
                    MessageBox.Show("更新团号信息失败!");
                    return;
                }
                //2.更新model,设置资料已录入，团号，国家等
                _dgvList = (List<Model.VisaInfo>)dgvGroupInfo.DataSource;
                //2.1更新还留在团内的人的VisaInfo数据库
                UpdateInListVisaInfo(_dgvList);
                //2.2更新移出的人的数据库
                UpdateOutListVisaInfo();
            }
            _updateDel(_curPage);
            Close();
        }

        /// <summary>
        /// 更新移出了的人的数据库
        /// </summary>
        private void UpdateOutListVisaInfo()
        {
            for (int i = 0; i < lvOut.Items.Count; i++)
            {
                Model.VisaInfo model = lvOut.Items[i].Tag as Model.VisaInfo;
                model.Visa_id = string.Empty;
                model.GroupNo = string.Empty;
                model.Country = string.Empty;
                //TODO:资料录入情况怎么处理
                //执行更新
                if (_bllVisaInfo.Update(model) == false)
                {
                    MessageBox.Show(Resources.FailedUpdateVisaInfoState);
                    return;
                }
            }
            MessageBox.Show("成功从当前团移出" + lvOut.Items.Count + "条记录.");
        }


        /// <summary>
        /// 从visaModel初始化有一个恢复功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// TODO:是否应该备份一份visaModel，不备份的话先提交过修改再reset就没用了
        private void btnReset_Click(object sender, EventArgs e)
        {
            InitFrmFromVisaModel();
        }

        /// <summary>
        /// 删除团号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该团号?", "警告", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            if (!_bllVisa.DeleteVisaAndModifyVisaInfos(_visaModel))
            {
                MessageBox.Show("删除团号失败!");
                return;
            }
            MessageBox.Show("删除团号成功!");
            _updateDel(_curPage);
            Close();
        }

        #endregion


    }



}
