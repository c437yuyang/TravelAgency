﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using TravelAgency.Common;
using TravelAgency.Common.Enums;
using TravelAgency.Common.Excel.Japan;
using TravelAgency.CSUI.Properties;
using TravelAgency.Model;

namespace TravelAgency.CSUI.FrmSub
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
        private readonly TravelAgency.BLL.ActionRecords _bllLoger = new TravelAgency.BLL.ActionRecords();

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
        /// <param name="updateDel"></param>
        /// <param name="curpage"></param>
        public FrmSetGroup(List<Model.VisaInfo> list, Action<int> updateDel, int curpage)
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
        /// 校验是否都是还没分配写在了调用者那边
        private void InitFrmFromList()
        {
            if (_list.Count == 0)
                return;

            //根据list加载列表
            for (int i = 0; i < _list.Count; i++)
            {
                ListViewItem liv = new ListViewItem(_list[i].Name);
                //ListViewItem.ListViewSubItem livSubItem1 = new ListViewItem.ListViewSubItem(liv, DateTimeFormator.DateTimeToString(_list[i].EntryTime));
                //ListViewItem.ListViewSubItem livSubItem2 = new ListViewItem.ListViewSubItem(liv, _list[i].IssuePlace);
                ListViewItem.ListViewSubItem livSubItem3 = new ListViewItem.ListViewSubItem(liv, _list[i].PassportNo);
                //liv.SubItems.Add(livSubItem1);
                //liv.SubItems.Add(livSubItem2);
                liv.SubItems.Add(livSubItem3);
                liv.Tag = _list[i];
                lvOut.Items.Add(liv);
            }

            //初始化时间选择控件
            //还是不初始化的比较好   

            //从list初始化就不能reset和删除团号
            btnReset.Enabled = false;
            btnDelete.Enabled = false;

            //没设置过的默认设置日本
            cbCountry.Text = "日本"; //这个默认值应该只是在还没设置的时候默认日本


        }

        /// <summary>
        /// 从已有visaModel设置窗口(已经设置了团号)
        /// </summary>
        /// <param name="model"></param>
        /// <param name="updateDel"></param>
        /// <param name="curpage"></param>
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
            _list = _bllVisaInfo.GetModelList(" Visa_id = '" + _visaModel.Visa_id.ToString() + "'");

            //根据list加载列表
            lvOut.Items.Clear();
            lvIn.Items.Clear();
            for (int i = 0; i < _list.Count; i++)
            {
                ListViewItem liv = new ListViewItem(_list[i].Name);

                //ListViewItem.ListViewSubItem livSubItem1 = new ListViewItem.ListViewSubItem(liv, DateTimeFormator.DateTimeToString(_list[i].EntryTime));
                //ListViewItem.ListViewSubItem livSubItem2 = new ListViewItem.ListViewSubItem(liv, _list[i].IssuePlace);
                ListViewItem.ListViewSubItem livSubItem3 = new ListViewItem.ListViewSubItem(liv, _list[i].PassportNo);
                //liv.SubItems.Add(livSubItem1);
                //liv.SubItems.Add(livSubItem2);
                liv.SubItems.Add(livSubItem3);
                liv.Tag = _list[i];
                lvIn.Items.Add(liv); //这里是默认进入的在里面
            }

            //初始化团号
            UpdateGroupNo();

            //初始化dgv
            UpdateDgvAndListViaListView();

            //初始化备注项
            for (int i = 0; i < dgvGroupInfo.Rows.Count; i++)
            {
                dgvGroupInfo.Rows[i].Cells["Remark"].Value = _visaModel.Remark;
            }

            //初始数据项
            txtDepartureTime.Text = DateTimeFormator.DateTimeToString(_visaModel.PredictTime);
            cbCountry.Text = _visaModel.Country;
            txtSalesPerson.Text = _visaModel.SalesPerson;
            txtSubmitTime.Text = DateTimeFormator.DateTimeToString(_visaModel.SubmitTime);
            txtInTime.Text = DateTimeFormator.DateTimeToString(_visaModel.InTime);
            txtOutTime.Text = DateTimeFormator.DateTimeToString(_visaModel.OutTime);
            txtClient.Text = _visaModel.Client;
            txtDepartureType.Text = _visaModel.DepartureType;
            txtSubmitCondition.Text = _visaModel.SubmitCondition;
            txtFetchType.Text = _visaModel.FetchCondition;
            //txtTypeInPerson.Text = _visaModel.TypeInPerson;
            //txtTypeInPerson.Text = GlobalUtils.LoginUser.UserName; //在Frm load里面设置，因为都要设置操作员
            txtCheckPerson.Text = _visaModel.CheckPerson;
            chbIsUrgent.Checked = _visaModel.IsUrgent;
            txtPerson.Text = _visaModel.Person;
        }

        private void FrmSetGroup_Load(object sender, EventArgs e)
        {
            //设置最小尺寸
            this.MinimumSize = this.Size;
            //不允许调整大小
            //this.FormBorderStyle = FormBorderStyle.FixedDialog;
            dgvGroupInfo.AutoGenerateColumns = false;
            dgvGroupInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; //列宽自适应
            dgvGroupInfo.Columns["Birthday"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;//某一些列关闭自适应

            this.btnReset.Enabled = false;


            //设置列表多选
            lvIn.MultiSelect = true;
            lvOut.MultiSelect = true;
            //初始化comboBox的成员
            //出境类型
            txtDepartureType.Items.Add("单次");
            txtDepartureType.Items.Add("三年多往");
            txtDepartureType.Items.Add("五年多往");
            txtDepartureType.Items.Add("十年多往");
            txtDepartureType.Items.Add("其他");
            //外领送签条件
            txtSubmitCondition.Items.Add("暂住证");
            txtSubmitCondition.Items.Add("居住证明");
            txtSubmitCondition.Items.Add("结婚证");
            txtSubmitCondition.Items.Add("身份证");
            txtSubmitCondition.Items.Add("户口本");
            txtSubmitCondition.Items.Add("其他");
            //客人取签方式
            txtFetchType.Items.Add("回签证部");
            txtFetchType.Items.Add("快递");
            txtFetchType.Items.Add("机场自提");
            txtFetchType.Items.Add("重庆自取");
            txtFetchType.Items.Add("车托到五桂桥");
            txtFetchType.Items.Add("其他");
            txtFetchType.SelectedIndex = 1;

            //设置操作员
            txtTypeInPerson.Text = Common.GlobalUtils.LoginUser.UserName;
            txtTypeInPerson.Enabled = false;
            //设置国家默认值
            //cbCountry.Text = "日本"; //这个默认值应该只是在还没设置的时候默认日本
            cbCountry.DropDownStyle = ComboBoxStyle.DropDown;
            txtDepartureType.SelectedIndex = 0;

            if (_list != null && _visaModel == null && !_initFromVisaModel)
                InitFrmFromList();
            if (_list == null && _visaModel != null && _initFromVisaModel)
                InitFrmFromVisaModel();

            SetCountryPicBox();
        }

        #region 状态更新函数

        private void SetCountryPicBox()
        {
            if (cbCountry.Text == "日本")
                pictureBox1.Image = Resources.Japan;
            else if (cbCountry.Text == "韩国")
                pictureBox1.Image = Resources.Korea;
            else if (cbCountry.Text == "泰国")
                pictureBox1.Image = Resources.Thailand;
            else
                pictureBox1.Image = null;

        }
        private void UpdateGroupNo()
        {
            string prefix = "QZC";
            if (cbCountry.Text == "日本")
                prefix += "JP";
            if (cbCountry.Text == "韩国")
                prefix += "KR";

            if (txtDepartureTime.Value.ToString() != "0001/1/1 0:00:00")
            {
                _visaName = prefix + txtDepartureTime.Value.ToString("yyMMdd");

            }
            else
                _visaName = prefix+ DateTime.Now.ToString("yyMMdd");

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

        private void UpdateDgvAndListViaListView()
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
        /// 根据输入信息更新LisitViewIn里面的人的visainfo数据库(一些没有在dgv里面的信息)
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
                list[i].Client = txtClient.Text;
                list[i].Salesperson = txtSalesPerson.Text;
                list[i].Types = Common.Enums.Types.Individual; //设置为个签
            }
            int res = _bllVisaInfo.UpdateByList(_dgvList);
            MessageBoxEx.Show(res + "条记录成功更新," + (list.Count - res) + "条记录更新失败.");
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
            //if (e.ColumnIndex >= 0 && dgvGroupInfo.Columns[e.ColumnIndex].Name == "Remark")
            //{
            //    string remark = dgvGroupInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //    for (int i = 0; i < dgvGroupInfo.Rows.Count; i++)
            //    {
            //        dgvGroupInfo.Rows[i].Cells[e.ColumnIndex].Value = remark;
            //    }
            //}

            //if (e.ColumnIndex >= 0 && dgvGroupInfo.Columns[e.ColumnIndex].Name == "ReturnTime")
            //{
            //    string time = dgvGroupInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //    for (int i = 0; i < dgvGroupInfo.Rows.Count; i++)
            //    {
            //        dgvGroupInfo.Rows[i].Cells[e.ColumnIndex].Value = time;
            //    }
            //}
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
        /// TODO:右键菜单实现这些功能
        private void dgvGroupInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvGroupInfo.SelectedCells.Count != 0 && e.Control && e.KeyCode == Keys.C)
            {
                SendCellToClipboard();
            }

            if (dgvGroupInfo.SelectedCells.Count != 0 && e.Control && e.KeyCode == Keys.V)
            {
                SetCellsFromClipboard();
            }

            if (dgvGroupInfo.SelectedCells.Count != 0 && e.KeyCode == Keys.Delete)
            {
                ClearCells();
            }

        }

        /// <summary>
        /// 右键菜单弹出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvGroupInfo_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0) //除去表头
                {

                    //如果没选中当前活动行则选中这一行
                    if (dgvGroupInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected == false)
                    {
                        dgvGroupInfo.ClearSelection();
                        dgvGroupInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                    }

                    //只有在选中的单元格上
                    if (dgvGroupInfo.SelectedCells.Contains(dgvGroupInfo.Rows[e.RowIndex].Cells[e.ColumnIndex]))
                        //弹出操作菜单
                        cmsDgvRb.Show(MousePosition.X, MousePosition.Y);


                }
            }
        }

        #endregion


        #region 自己的按钮
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAllIn_Click(object sender, EventArgs e)
        {
            for (int i = lvOut.Items.Count - 1; i >= 0; --i)
            {
                ListViewItem lvItem = lvOut.Items[i];
                lvOut.Items.Remove(lvOut.Items[i]);
                lvIn.Items.Add(lvItem);
            }
            UpdateGroupNo();
            UpdateDgvAndListViaListView();
        }

        private void btnAllOut_Click(object sender, EventArgs e)
        {
            for (int i = lvIn.Items.Count - 1; i >= 0; --i)
            {
                ListViewItem lvItem = lvIn.Items[i];
                lvIn.Items.Remove(lvIn.Items[i]);
                lvOut.Items.Add(lvItem);
            }
            UpdateGroupNo();
            UpdateDgvAndListViaListView();

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            for (int i = lvOut.SelectedItems.Count - 1; i >= 0; --i)
            {
                ListViewItem lvItem = lvOut.SelectedItems[i];
                lvOut.Items.Remove(lvOut.SelectedItems[i]);
                lvIn.Items.Insert(0, lvItem);
            }
            UpdateGroupNo();
            UpdateDgvAndListViaListView();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            for (int i = lvIn.SelectedItems.Count - 1; i >= 0; --i)
            {
                ListViewItem lvItem = lvIn.SelectedItems[i];
                lvIn.Items.Remove(lvIn.SelectedItems[i]);
                lvOut.Items.Insert(0, lvItem);
            }
            UpdateGroupNo();
            UpdateDgvAndListViaListView();
        }


        /// <summary>
        /// 生成报表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            if (dgvGroupInfo.Rows[0].Cells["Remark"].Value != null)
                ExcelGenerator.GetIndividualVisaExcel(_dgvList, dgvGroupInfo.Rows[0].Cells["Remark"].Value.ToString(), txtGroupNo.Text);
            else
                ExcelGenerator.GetIndividualVisaExcel(_dgvList, string.Empty, txtGroupNo.Text);
        }

        /// <summary>
        /// 提交修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// TODO:处理需要修改团号的逻辑
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //检查团号为空?
            if (string.IsNullOrEmpty(txtGroupNo.Text))
            {
                MessageBoxEx.Show("团号不能为空!");
                return;
            }
            DialogResult res = MessageBoxEx.Show("是否提交修改?", "确认", MessageBoxButtons.OKCancel);
            if (res == DialogResult.Cancel)
                return;
            if (!_initFromVisaModel) //从List列表初始化
            {
                //1.保存团号信息修改到数据库,Visa表（sales_person,country,GroupNo,PredictTime）
                if (_visaModel != null)
                {
                    MessageBoxEx.Show("内部错误!");
                    return;
                }
                if (!CtrlsToVisaModel())
                    return;

                if ((_visaModel.Visa_id = _bllVisa.Add(_visaModel)) == Guid.Empty) //执行更新,返回值是新插入的visamodel的guid
                {
                    MessageBoxEx.Show("添加团号到数据库失败，请重试!");
                    return;
                }

                //2.更新model,设置资料已录入，团号，国家等
                _dgvList = (List<Model.VisaInfo>)dgvGroupInfo.DataSource;
                //2.1更新VisaInfo数据库
                UpdateInListVisaInfo(_dgvList);
                bool hasTypedIn = _bllLoger.HasVisaBeenTypedIn(_visaModel);
                //3.1更新这些人的录入情况到ActionResult里面
                for (int i = 0; i < _dgvList.Count; i++)
                {
                    Model.ActionRecords log = new ActionRecords();
                    if(!hasTypedIn) //第一次打开进行设置团号，就是录入,这里的判断其实是多余的。。。因为这里进来就一定是还没做团号的....
                        log.ActType = Common.Enums.ActType._01TypeIn;
                    else //第二次是做资料
                        log.ActType = Common.Enums.ActType._02TypeInData;
                    log.WorkId = Common.GlobalUtils.LoginUser.WorkId;
                    log.UserName = Common.GlobalUtils.LoginUser.UserName;
                    log.VisaInfo_id = _dgvList[i].VisaInfo_id;
                    log.Visa_id = _visaModel.Visa_id;
                    log.Type = Common.Enums.Types.Individual;
                    log.EntryTime = DateTime.Now;
                    _bllLoger.Add(log);
                }

                //添加完成后，删除这几个人
                for (int i = 0; i < lvIn.Items.Count; i++)
                    _list.Remove((Model.VisaInfo)lvIn.Items[i].Tag);
                lvIn.Items.Clear();
                _visaModel = null;
                UpdateDgvAndListViaListView();
                if (_list.Count == 0)
                {
                    _updateDel(_curPage);
                    Close();
                }

            }
            else
            {
                //从model初始化的，只考虑信息的修改以及移出人

                //如果所有人都移出了，提示请点击删除
                if (lvIn.Items.Count == 0)
                {
                    MessageBoxEx.Show("若需要将全部成员移出此团号，请点击\"删除团号\"按钮");
                    return;
                }

                //1.保存团号信息修改到数据库,Visa表（sales_person,country,GroupNo,PredictTime）
                if (!CtrlsToVisaModel(_visaModel))
                    return;

                if (!_bllVisa.Update(_visaModel)) //执行更新
                {
                    MessageBoxEx.Show("更新团号信息失败!");
                    return;
                }
                //2.更新model,设置资料已录入，团号，国家等
                _dgvList = (List<Model.VisaInfo>)dgvGroupInfo.DataSource;
                //2.1更新还留在团内的人的VisaInfo数据库
                UpdateInListVisaInfo(_dgvList);
                //添加记录
                bool hasTypedIn = _bllLoger.HasVisaBeenTypedIn(_visaModel);
                for (int i = 0; i < _dgvList.Count; i++)
                {
                    Model.ActionRecords log = new ActionRecords();
                    if (!hasTypedIn) 
                        log.ActType = Common.Enums.ActType._01TypeIn;
                    else //第二次是做资料
                        log.ActType = Common.Enums.ActType._02TypeInData;
                    log.WorkId = Common.GlobalUtils.LoginUser.WorkId;
                    log.UserName = Common.GlobalUtils.LoginUser.UserName;
                    log.VisaInfo_id = _dgvList[i].VisaInfo_id;
                    log.Visa_id = _visaModel.Visa_id;
                    log.Type = Common.Enums.Types.Individual;
                    log.EntryTime = DateTime.Now;
                    _bllLoger.Add(log);
                }

                //2.2更新移出的人的数据库
                UpdateOutListVisaInfo();
                _updateDel(_curPage);
                Close();
            }


            //
            //Close();
        }

        private bool CtrlsToVisaModel()
        {
            _visaModel = new Visa();
            //_visaModel.Visa_id = Guid.NewGuid(); //这里必须要给一个，虽然这里不给也会入库正确，数据库会赋给默认值，但是后面更新对应visainfo就会有错
            //这里代码生成器默认给了一个guid，不能再自己给了
            try
            {
                //单独处理remark
                if (!string.IsNullOrEmpty((string)dgvGroupInfo.Rows[0].Cells["Remark"].Value))
                    _visaModel.Remark = (string)dgvGroupInfo.Rows[0].Cells["Remark"].Value;

                if (!string.IsNullOrEmpty(txtDepartureTime.Text))
                    _visaModel.PredictTime = DateTime.Parse(txtDepartureTime.Text);
                if (!string.IsNullOrEmpty(txtSubmitTime.Text))
                    _visaModel.SubmitTime = DateTime.Parse(txtSubmitTime.Text);
                if (!string.IsNullOrEmpty(txtInTime.Text))
                    _visaModel.InTime = DateTime.Parse(txtInTime.Text);
                if (!string.IsNullOrEmpty(txtOutTime.Text))
                    _visaModel.OutTime = DateTime.Parse(txtOutTime.Text);

                _visaModel.EntryTime = DateTime.Now;
                _visaModel.GroupNo = txtGroupNo.Text;
                _visaModel.SalesPerson = txtSalesPerson.Text;
                _visaModel.Country = cbCountry.Text;
                _visaModel.Number = lvIn.Items.Count; //团号的人数
                _visaModel.Client = txtClient.Text;
                _visaModel.DepartureType = txtDepartureType.Text;
                _visaModel.SubmitCondition = txtSubmitCondition.Text;
                _visaModel.FetchCondition = txtFetchType.Text;
                _visaModel.TypeInPerson = txtTypeInPerson.Text;
                _visaModel.CheckPerson = txtCheckPerson.Text;
                _visaModel.Types = Common.Enums.Types.Individual; //设置为个签
                _visaModel.IsUrgent = chbIsUrgent.Checked;
                _visaModel.Person = txtPerson.Text;
                return true;
            }
            catch (Exception)
            {
                _visaModel = null; //一定要这里重新赋值为null
                MessageBoxEx.Show(Resources.PleaseCheckDateTimeFormat);
                return false;

            }


        }

        private bool CtrlsToVisaModel(Model.Visa model)
        {
            try
            {
                //单独处理remark
                if (!string.IsNullOrEmpty((string)dgvGroupInfo.Rows[0].Cells["Remark"].Value))
                    model.Remark = (string)dgvGroupInfo.Rows[0].Cells["Remark"].Value;

                //1.保存团号信息修改到数据库,Visa表（sales_person,country,GroupNo,PredictTime）
                model.GroupNo = txtGroupNo.Text;
                model.SalesPerson = txtSalesPerson.Text;
                model.Country = cbCountry.Text;
                model.Number = lvIn.Items.Count;

                if (!string.IsNullOrEmpty(txtDepartureTime.Text))
                    model.PredictTime = DateTime.Parse(txtDepartureTime.Text);
                if (!string.IsNullOrEmpty(txtSubmitTime.Text))
                    model.SubmitTime = DateTime.Parse(txtSubmitTime.Text);
                if (!string.IsNullOrEmpty(txtInTime.Text))
                    model.InTime = DateTime.Parse(txtInTime.Text);
                if (!string.IsNullOrEmpty(txtOutTime.Text))
                    model.OutTime = DateTime.Parse(txtOutTime.Text);

                //_visaModel.SubmitTime = DateTime.Parse(txtSubmitTime.Text);
                //_visaModel.InTime = DateTime.Parse(txtInTime.Text);
                //_visaModel.OutTime = DateTime.Parse(txtOutTime.Text);
                model.Client = txtClient.Text;
                model.DepartureType = txtDepartureType.Text;
                model.SubmitCondition = txtSubmitCondition.Text;
                model.FetchCondition = txtFetchType.Text;
                model.TypeInPerson = txtTypeInPerson.Text;
                model.CheckPerson = txtCheckPerson.Text;
                model.Types = Common.Enums.Types.Individual; //设置为个签
                model.IsUrgent = chbIsUrgent.Checked;
                model.Person = txtPerson.Text;
                return true;
            }
            catch (Exception)
            {
                MessageBoxEx.Show(Resources.PleaseCheckDateTimeFormat);
                return false;
            }
        }

        /// <summary>
        /// 更新移出了的人的数据库
        /// </summary>
        private void UpdateOutListVisaInfo()
        {
            for (int i = 0; i < lvOut.Items.Count; i++)
            {
                Model.VisaInfo model = lvOut.Items[i].Tag as Model.VisaInfo;
                model.Visa_id = null;
                model.GroupNo = null;
                model.Country = null;
                model.Types = null;
                //TODO:资料录入情况怎么处理
                //执行更新
                if (_bllVisaInfo.Update(model) == false)
                {
                    MessageBoxEx.Show(Resources.FailedUpdateVisaInfoState);
                    return;
                }
                MessageBoxEx.Show("成功从当前团移出" + lvOut.Items.Count + "条记录.");
            }

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
            if (MessageBoxEx.Show("是否删除该团号?", "警告", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            if (!_bllVisa.DeleteVisaAndModifyVisaInfos(_visaModel))
            {
                MessageBoxEx.Show("删除团号失败!");
                return;
            }
            MessageBoxEx.Show("删除团号成功!");
            _updateDel(_curPage);
            Close();
        }

        #endregion

        #region 右键菜单及按键的消息
        private void SendCellToClipboard()
        {
            if (dgvGroupInfo.SelectedCells.Count > 1)
            {
                MessageBoxEx.Show("请选中一条记录复制!");
                return;
            }
            if (!string.IsNullOrEmpty((string)dgvGroupInfo.SelectedCells[0].Value))
                Clipboard.SetText(dgvGroupInfo.SelectedCells[0].Value.ToString());
        }

        private void SetCellsFromClipboard()
        {
            for (int i = 0; i < dgvGroupInfo.SelectedCells.Count; i++)
            {
                dgvGroupInfo.SelectedCells[i].Value = Clipboard.GetText();
            }
        }

        private void ClearCells()
        {
            for (int i = 0; i < dgvGroupInfo.SelectedCells.Count; i++)
            {
                dgvGroupInfo.SelectedCells[i].Value = null;
            }
        }
        #endregion


        #region dgv右键弹出菜单响应

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendCellToClipboard();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCellsFromClipboard();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearCells();
        }

        private void 上移ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvGroupInfo.SelectedCells.Count > 1)
            {
                MessageBoxEx.Show(Resources.SelectEditMoreThanOne);
                return;
            }
            int selIdx = dgvGroupInfo.SelectedCells[0].RowIndex;
            int selColIdx = dgvGroupInfo.SelectedCells[0].ColumnIndex;
            if (selIdx == 0)
                return;

            var lvItemTmp = lvIn.Items[selIdx];
            lvIn.Items.Remove(lvItemTmp);
            lvIn.Items.Insert(selIdx - 1,lvItemTmp);

            UpdateDgvAndListViaListView();
            UpdateGroupNo();

            dgvGroupInfo.CurrentCell = dgvGroupInfo.Rows[selIdx - 1].Cells[selColIdx];

        }

        private void 下移ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvGroupInfo.SelectedCells.Count > 1)
            {
                MessageBoxEx.Show(Resources.SelectEditMoreThanOne);
                return;
            }
            int selIdx = dgvGroupInfo.SelectedCells[0].RowIndex;
            int selColIdx = dgvGroupInfo.SelectedCells[0].ColumnIndex;

            if (selIdx == lvIn.Items.Count - 1)
                return;

            var lvItemTmp = lvIn.Items[selIdx];
            lvIn.Items.Remove(lvItemTmp);
            lvIn.Items.Insert(selIdx + 1, lvItemTmp);

            UpdateDgvAndListViaListView();
            UpdateGroupNo();

            dgvGroupInfo.CurrentCell = dgvGroupInfo.Rows[selIdx + 1].Cells[selColIdx];

        }

        private void 移到顶部ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvGroupInfo.SelectedCells.Count > 1)
            {
                MessageBoxEx.Show(Resources.SelectEditMoreThanOne);
                return;
            }
            int selIdx = dgvGroupInfo.SelectedCells[0].RowIndex;
            int selColIdx = dgvGroupInfo.SelectedCells[0].ColumnIndex;

            if (selIdx == 0)
                return;

            var lvItemTmp = lvIn.Items[selIdx];
            lvIn.Items.Remove(lvItemTmp);
            lvIn.Items.Insert(0, lvItemTmp);
            UpdateDgvAndListViaListView();
            UpdateGroupNo();
           
            dgvGroupInfo.CurrentCell = dgvGroupInfo.Rows[0].Cells[selColIdx];
        }

        private void 移到底部ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvGroupInfo.SelectedRows.Count > 1)
            {
                MessageBoxEx.Show(Resources.SelectEditMoreThanOne);
                return;
            }
            int selIdx = dgvGroupInfo.SelectedCells[0].RowIndex;
            int selColIdx = dgvGroupInfo.SelectedCells[0].ColumnIndex;

            if (selIdx == lvIn.Items.Count - 1)
                return;

            var lvItemTmp = lvIn.Items[selIdx];
            lvIn.Items.Remove(lvItemTmp);
            lvIn.Items.Add( lvItemTmp);
            UpdateDgvAndListViaListView();
            UpdateGroupNo();

            dgvGroupInfo.CurrentCell = dgvGroupInfo.Rows[lvIn.Items.Count - 1].Cells[selColIdx];
        }

        #endregion


        #region 编辑框响应事件
        /// <summary>
        /// 根据选中的出发时间设置团号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDepartureTime_TextChanged(object sender, EventArgs e)
        {
            UpdateGroupNo();
        }

        private void cbCountry_TextChanged(object sender, EventArgs e)
        {
            UpdateGroupNo();
            SetCountryPicBox();
        }



        #endregion

        private void dgvGroupInfo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvGroupInfo.Columns[e.ColumnIndex].Name == "Remark")
            {
                string remark = dgvGroupInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                for (int i = 0; i < dgvGroupInfo.Rows.Count; i++)
                {
                    dgvGroupInfo.Rows[i].Cells[e.ColumnIndex].Value = remark;
                }
            }

            if (e.ColumnIndex >= 0 && dgvGroupInfo.Columns[e.ColumnIndex].Name == "ReturnTime")
            {
                string time = dgvGroupInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                for (int i = 0; i < dgvGroupInfo.Rows.Count; i++)
                {
                    dgvGroupInfo.Rows[i].Cells[e.ColumnIndex].Value = time;
                }
            }
        }







    }



}
