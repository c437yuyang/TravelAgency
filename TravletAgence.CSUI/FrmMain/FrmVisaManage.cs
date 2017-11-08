using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using TravletAgence.Common;
using TravletAgence.Common.Excel;
using TravletAgence.Common.Word.Japan;
using TravletAgence.CSUI.FrmSub;
using TravletAgence.CSUI.Properties;
using TravletAgence.Model;

namespace TravletAgence.CSUI.FrmMain
{
    public partial class FrmVisaManage : Form
    {
        private readonly TravletAgence.BLL.Visa _bllVisa = new TravletAgence.BLL.Visa();
        private readonly TravletAgence.BLL.VisaInfo _bllVisaInfo = new TravletAgence.BLL.VisaInfo();
        private int _curPage = 1;
        private int _pageCount = 0;
        private int _pageSize = 30;
        private int _recordCount = 0;
        private bool _init = false;
        private string _where = string.Empty;
        private bool _forAddToGroup = false; //为没有添加团号的用户添加到团号的时候选择团号而设计
        private List<Model.VisaInfo> _listToAddToGroup;

        public FrmVisaManage()
        {
            InitializeComponent();
        }

        public FrmVisaManage(bool forAddToGroup, List<Model.VisaInfo> list)
        {
            _forAddToGroup = forAddToGroup;
            _listToAddToGroup = list;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "请选择需要添加到的团号";
            InitializeComponent();
        }

        private void FrmVisaManage_Load(object sender, EventArgs e)
        {
            _recordCount = _bllVisa.GetRecordCount(string.Empty);
            _pageCount = (int)Math.Ceiling((double)_recordCount / _pageSize);
            cbPageSize.Items.Add("30");
            cbPageSize.Items.Add("50");
            cbPageSize.Items.Add("100");
            cbPageSize.SelectedIndex = 0;

            cbDisplayType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDisplayType.Items.Add("全部");
            cbDisplayType.Items.Add("未记录");
            cbDisplayType.Items.Add("个签");
            cbDisplayType.Items.Add("团签");
            cbDisplayType.SelectedIndex = 0;

            dataGridView1.AutoGenerateColumns = false; //不显示指定之外的列
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; //列宽自适应

            bgWorkerLoadData.WorkerReportsProgress = true;
            progressLoading.Visible = false;
            LoadDataToDgvAsyn();
            _init = true;
        }



        #region dgv用到的相关方法




        /// <summary>
        /// 显示进度条
        /// </summary>
        public void ShowProgress()
        {
            progressLoading.Visible = true;
            progressLoading.IsRunning = true;
        }


        public void LoadDataToDataGridView(int page) //刷新后保持选中
        {
            int curSelectedRow = -1;
            if (dataGridView1.SelectedRows.Count > 0)
                curSelectedRow = dataGridView1.SelectedRows[0].Index;

            dataGridView1.DataSource = _bllVisa.GetListByPage(page, _pageSize, _where);
            if (curSelectedRow != -1 && dataGridView1.Rows.Count > curSelectedRow)
                dataGridView1.CurrentCell = dataGridView1.Rows[curSelectedRow].Cells[0];

        }

        public void UpdateState()
        {
            _recordCount = _bllVisa.GetRecordCount(_where);
            _pageCount = (int)Math.Ceiling((double)_recordCount / (double)_pageSize);
            if (_curPage == 1)
                btnPagePre.Enabled = false;
            else
                btnPagePre.Enabled = true;
            if (_curPage == _pageCount)
                btnPageNext.Enabled = false;
            else
                btnPageNext.Enabled = true;
            lbRecordCount.Text = "共有记录:" + _recordCount + "条";
            lbCurPage.Text = "当前为第" + _curPage + "页";
        }
        #endregion


        #region dgv的bar栏
        private void btnPageNext_Click(object sender, EventArgs e)
        {
            ++_curPage;
            LoadDataToDgvAsyn();
        }

        private void btnPagePre_Click(object sender, EventArgs e)
        {
            --_curPage;
            LoadDataToDgvAsyn();
        }

        private void btnPageFirst_Click(object sender, EventArgs e)
        {
            _curPage = 1;
            LoadDataToDgvAsyn();
        }

        private void btnPageLast_Click(object sender, EventArgs e)
        {
            _curPage = _pageCount;
            LoadDataToDgvAsyn();
        }


        private void cbPageSize_TextChanged(object sender, EventArgs e)
        {
            if (!_init) //因为窗口初始化的时候也会调用，所以禁止多次调用
                return;

            _pageSize = int.Parse(cbPageSize.Text);
            LoadDataToDgvAsyn();
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            _where = GetWhereCondition();

            LoadDataToDgvAsyn();

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            _where = string.Empty;

            LoadDataToDgvAsyn();

        }

        private string GetWhereCondition()
        {
            List<string> conditions = new List<string>();
            if (cbDisplayType.Text == "全部")
            {
            }
            else if (cbDisplayType.Text == "未记录")
            {
                conditions.Add(" Types is null or Types='' ");
            }
            else if (cbDisplayType.Text == "个签")
            {
                conditions.Add(" Types = '个签' ");
            }
            else if (cbDisplayType.Text == "团签")
            {
                conditions.Add(" Types = '团签' ");
            }



            if (!string.IsNullOrEmpty(txtSchGroupNo.Text.Trim()))
            {
                conditions.Add(" (GroupNo like '%" + txtSchGroupNo.Text + "%') ");
            }

            if (!string.IsNullOrEmpty(txtSchEntryTimeFrom.Text.Trim()) && !string.IsNullOrEmpty(txtSchEntryTimeTo.Text.Trim()))
            {
                conditions.Add(" (EntryTime between '" + txtSchEntryTimeFrom.Text + " 00:00:0.000' and " + " '" + txtSchEntryTimeTo.Text +
                               " 23:59:59.999') ");
            }
            if (!string.IsNullOrEmpty(txtSchSalesPerson.Text.Trim()))
            {
                conditions.Add(" (SalesPerson like '%" + txtSchSalesPerson.Text + "%') ");
            }

            string[] arr = conditions.ToArray();
            string where = string.Join(" and ", arr);
            return where;
        }

        private void btnClearSchConditions_Click(object sender, EventArgs e)
        {
            cbDisplayType.Text = "全部";
            txtSchEntryTimeFrom.Text = string.Empty;
            txtSchEntryTimeTo.Text = string.Empty;
            txtSchGroupNo.Text = string.Empty;
        }


        private void btnShowToday_Click(object sender, EventArgs e)
        {
            txtSchEntryTimeFrom.Text = DateTimeFormator.DateTimeToString(DateTime.Today);
            txtSchEntryTimeTo.Text = DateTimeFormator.DateTimeToString(DateTime.Today);
            btnSearch_Click(null, null);
        }

        #endregion


        #region dgv消息响应
        /// <summary>
        /// dgv设置行号以及国家图标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                if (dataGridView1.Rows[i].Cells["Country"].Value != null)
                {
                    string countryName = dataGridView1.Rows[i].Cells["Country"].Value.ToString();
                    if (countryName == "日本")
                        dataGridView1.Rows[i].Cells["CountryImage"].Value = Resources.Japan;
                    else if (countryName == "韩国")
                        dataGridView1.Rows[i].Cells["CountryImage"].Value = Resources.Korea;
                    else if (countryName == "泰国")
                        dataGridView1.Rows[i].Cells["CountryImage"].Value = Resources.Thailand;

                }
            }
        }

        /// <summary>
        /// dgv右键响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {

                    //若行已是选中状态就不再进行设置
                    //如果没选中当前活动行则选中这一行
                    if (dataGridView1.Rows[e.RowIndex].Selected == false)
                    {
                        dataGridView1.ClearSelection();
                        dataGridView1.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (dataGridView1.SelectedRows.Count == 1)
                    {
                        if (e.ColumnIndex != -1) //选中表头了
                            dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        else
                            dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[0];
                    }
                    //弹出操作菜单
                    if (!_forAddToGroup)
                    {
                        cmsDgv.Show(MousePosition.X, MousePosition.Y);
                    }
                    else
                    {
                        cmsAddToGroup.Show(MousePosition.X, MousePosition.Y);
                    }
                }
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 1)
            {
                MessageBoxEx.Show(Resources.SelectShowMoreThanOne);
                return;
            }
            if (!_forAddToGroup)
            {
                Model.Visa model = _bllVisa.GetModel((Guid)dataGridView1.SelectedRows[0].Cells["Visa_id"].Value);
                if (model == null)
                {
                    MessageBoxEx.Show(Resources.FindModelFailedPleaseCheckInfoCorrect);
                    return;
                }

                if (model.Types == Common.Enums.Types.Individual)
                {
                    FrmSetGroup frm = new FrmSetGroup(model, LoadDataToDataGridView, _curPage);
                    frm.ShowDialog();
                }
                else if (model.Types == Common.Enums.Types.Team)
                {
                    FrmSetTeamVisaGroup frm = new FrmSetTeamVisaGroup(model, LoadDataToDataGridView, _curPage);
                    frm.ShowDialog();
                }
            }
            else //添加用户的情况
            {
                //执行添加到此团号的逻辑
                AddToSelectGroup();
            }
        }

        #endregion


        #region backgroundworker load data to datagridview

        private void LoadDataToDgvAsyn()
        {
            while (bgWorkerLoadData.IsBusy)
            {
                ;
            }
            ShowProgress();
            bgWorkerLoadData.RunWorkerAsync();
        }

        private void bgWorkerLoadData_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    LoadDataToDataGridView(_curPage);
                    UpdateState();
                }));
            }
            else
            {
                LoadDataToDataGridView(_curPage);
                UpdateState();
            }
        }

        private void bgWorkerLoadData_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            //this.progressLoading.Visible = true;
            //this.progressLoading.IsRunning = true;
        }

        private void bgWorkerLoadData_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            this.progressLoading.Visible = false;
            this.progressLoading.IsRunning = false;
        }
        #endregion
        #region dgv右键响应
        /// <summary>
        /// 查看选中团号，可以移出团号里的人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmsItemShowGroupNo_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 1)
            {
                MessageBoxEx.Show(Resources.SelectShowMoreThanOne);
                return;
            }

            Model.Visa model = _bllVisa.GetModel((Guid)dataGridView1.SelectedRows[0].Cells["Visa_id"].Value);
            if (model == null)
            {
                MessageBoxEx.Show(Resources.FindModelFailedPleaseCheckInfoCorrect);
                return;
            }

            if (model.Types == Common.Enums.Types.Individual)
            {
                FrmSetGroup frm = new FrmSetGroup(model, LoadDataToDataGridView, _curPage);
                frm.ShowDialog();
            }
            else if (model.Types == Common.Enums.Types.Team)
            {
                FrmSetTeamVisaGroup frm = new FrmSetTeamVisaGroup(model, LoadDataToDataGridView, _curPage);
                frm.ShowDialog();
            }

        }

        private void cmsItemRefreshDatabase_Click(object sender, EventArgs e)
        {
            LoadDataToDataGridView(_curPage);
        }

        /// <summary>
        /// 右键删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = this.dataGridView1.SelectedRows.Count;
            if (MessageBoxEx.Show("确认删除" + count + "条记录?", Resources.Confirm, MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            int n = 0;
            for (int i = 0; i != count; ++i)
            {
                Model.Visa model =
                    _bllVisa.GetModel(Guid.Parse(dataGridView1.SelectedRows[i].Cells["Visa_id"].Value.ToString()));
                if (!_bllVisa.DeleteVisaAndModifyVisaInfos(model))
                {
                    MessageBoxEx.Show("删除失败!");
                }
                ++n;
            }
            MessageBoxEx.Show(n + "条记录删除成功," + (count - n) + "条记录删除失败.");
            LoadDataToDataGridView(_curPage);
            UpdateState();
        }

        private void 添加到团号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddToSelectGroup();
        }


        private void AddToSelectGroup()
        {
            if (MessageBoxEx.Show("是否添加到选中团号?", "确认", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            //执行添加到团号的逻辑
            Model.Visa visaModel = _bllVisa.GetModel(Guid.Parse(dataGridView1.SelectedRows[0].Cells["Visa_id"].Value.ToString()));
            //
            for (int i = 0; i != _listToAddToGroup.Count; ++i)
            {
                _listToAddToGroup[i].Visa_id = visaModel.Visa_id.ToString();
                _listToAddToGroup[i].GroupNo = visaModel.GroupNo;
                _listToAddToGroup[i].Types = visaModel.Types;
            }


            //更新团号的人数
            visaModel.Number += _listToAddToGroup.Count;
            if (visaModel.Types == Common.Enums.Types.Individual)
            {
                if (MessageBoxEx.Show("是否自动更新团号名称?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    visaModel.GroupNo += "、";
                    for (int i = 0; i < _listToAddToGroup.Count; ++i)
                    {
                        visaModel.GroupNo += _listToAddToGroup[i].Name;
                        if (i == _listToAddToGroup.Count - 1)
                            break;
                        visaModel.GroupNo += "、";
                    }

                    for (int i = 0; i < _listToAddToGroup.Count; ++i)
                    {
                        _listToAddToGroup[i].GroupNo = visaModel.GroupNo;
                    }
                }

            }

            int n = _bllVisaInfo.UpdateByList(_listToAddToGroup);
            MessageBoxEx.Show(n.ToString() + "条记录更新成功," + (_listToAddToGroup.Count - n) + "条记录更新失败!");

            if (!_bllVisa.Update(visaModel))
            {
                MessageBoxEx.Show("更新团号信息失败!");
                return;
            }
            //之后询问用户是否重新设置资料
            if (MessageBoxEx.Show("是否进入资料设置？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (visaModel.Types == Common.Enums.Types.Individual)
                {
                    FrmSetGroup frm = new FrmSetGroup(visaModel, this.LoadDataToDataGridView, _curPage);
                    frm.ShowDialog();
                }
                else if (visaModel.Types == Common.Enums.Types.Team)
                {
                    FrmSetTeamVisaGroup frm = new FrmSetTeamVisaGroup(visaModel, this.LoadDataToDataGridView, _curPage);
                    frm.ShowDialog();

                }
            }
            this.Close();
        }

        private void 生成金桥报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 个签意见书ToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (this.dataGridView1.SelectedRows.Count > 1)
            {
                MessageBoxEx.Show(Resources.SelectShowMoreThanOne);
                return;
            }
            Model.Visa visaModel = _bllVisa.GetModel((Guid)dataGridView1.SelectedRows[0].Cells["Visa_id"].Value);
            if (visaModel == null)
            {
                MessageBoxEx.Show(Resources.FindModelFailedPleaseCheckInfoCorrect);
                return;
            }

            if (visaModel.Types == Common.Enums.Types.Team)
            {
                MessageBoxEx.Show("团签类型不能导出此报表!");
                return;
            }

            var list = _bllVisaInfo.GetModelList(" visa_id = '" + visaModel.Visa_id + "' ");

            ExcelGenerator.GetIndividualVisaExcel(list, visaModel.Remark, visaModel.GroupNo);

        }

        private void 日本团队综合名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (this.dataGridView1.SelectedRows.Count > 1)
            {
                MessageBoxEx.Show(Resources.SelectShowMoreThanOne);
                return;
            }
            Model.Visa visaModel = _bllVisa.GetModel((Guid)dataGridView1.SelectedRows[0].Cells["Visa_id"].Value);
            if (visaModel == null)
            {
                MessageBoxEx.Show(Resources.FindModelFailedPleaseCheckInfoCorrect);
                return;
            }

            if (visaModel.Types == Common.Enums.Types.Individual)
            {
                MessageBoxEx.Show("个签类型不能导出此报表!");
                return;
            }

            var list = _bllVisaInfo.GetModelList(" visa_id = '" + visaModel.Visa_id + "' ");
            ExcelGenerator.GetTeamVisaExcelOfJapan(list, visaModel.GroupNo);
        }

        #endregion

        private void 金桥大名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 1)
            {
                MessageBoxEx.Show(Resources.SelectShowMoreThanOne);
                return;
            }
            Model.Visa visaModel = _bllVisa.GetModel((Guid)dataGridView1.SelectedRows[0].Cells["Visa_id"].Value);
            if (visaModel == null)
            {
                MessageBoxEx.Show(Resources.FindModelFailedPleaseCheckInfoCorrect);
                return;
            }
            var visainfoList = _bllVisaInfo.GetModelList(" visa_id = '" + visaModel.Visa_id + "' ");
            List<string> list = new List<string>();
            for (int i = 0; i < visainfoList.Count; i++)
            {
                list.Add(visainfoList[i].Name);
            }
            DocGenerator docGenerator = new DocGenerator(DocGenerator.DocType.Type01JinQiaoList);
            docGenerator.Generate(list);
        }







    }
}
