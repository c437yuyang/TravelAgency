using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using TravletAgence.Common;
using TravletAgence.Common.Enums;
using TravletAgence.Common.Excel.Japan;
using TravletAgence.Common.IDCard;
using TravletAgence.Common.QRCode;
using TravletAgence.Common.Word.Japan;
using TravletAgence.CSUI.FrmSub;
using TravletAgence.CSUI.Properties;
using TravletAgence.Model;
using Timer = System.Windows.Forms.Timer;

namespace TravletAgence.CSUI.FrmMain
{
    public partial class FrmVisaInfoManage : Form
    {
        private readonly TravletAgence.BLL.VisaInfo _bll = new TravletAgence.BLL.VisaInfo();
        private int _curPage = 1;
        private int _pageCount = 0;
        private int _pageSize = 30;
        private int _recordCount = 0;
        //private readonly IDCard _idCard = new IDCard();
        //private bool _autoRead = false;
        //private bool _autoReadThreadRun = false;
        //private readonly Timer _t = new Timer();
        private readonly MyQRCode _qrCode = new MyQRCode(); //只用于批量生成二维码
        //private readonly Thread _thLoadDataToDgvAndUpdateState;
        private bool _init = false;
        private string _where = string.Empty;



        public FrmVisaInfoManage()
        {
            InitializeComponent();
            //_t.Tick += AutoClassAndRecognize;
            //_t.Interval = 200;
            //_thLoadDataToDgvAndUpdateState = new Thread(LoadAndUpdate);

            //_thLoadDataToDgvAndUpdateState.IsBackground = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _recordCount = _bll.GetRecordCount(_where);
            _pageCount = (int)Math.Ceiling(_recordCount / (double)_pageSize);

            //初始化一些控件
            //txtPicPath.Text = GlobalInfo.AppPath;
            cbPageSize.Items.Add("30");
            cbPageSize.Items.Add("50");
            cbPageSize.Items.Add("100");
            cbPageSize.SelectedIndex = 0;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            cbDisplayType.Items.Add("全部");
            cbDisplayType.Items.Add("未记录");
            cbDisplayType.Items.Add("个签");
            cbDisplayType.Items.Add("团签");
            cbDisplayType.DropDownStyle = ComboBoxStyle.DropDownList;

            cbDisplayType.SelectedIndex = 0;
            //checkShowConfirm.Checked = true;
            //checkRegSucShowDlg.Checked = true;

            //设置可跨线程访问窗体
            //TODO:这里可能需要修改
            //Control.CheckForIllegalCrossThreadCalls = false;

            //加载数据

            //
            bgWorkerLoadData.WorkerReportsProgress = true;

            //使用异步加载
            //_thLoadDataToDgvAndUpdateState.Start();
            //LoadDataToDataGridView(_curPage);
            //UpdateState();
            progressLoading.Visible = false;

            LoadDataToDgvAsyn();
            _init = true;
        }

        #region model与control
        //private void ModelToCtrls(TravletAgence.Model.VisaInfo model)
        //{
        //    //添加多线程情况的时候的判断
        //    if (this.InvokeRequired)
        //    {
        //        this.Invoke(new Action(() =>
        //        {
        //            //model.Types = "个签";
        //            model.EntryTime = DateTime.Now;
        //            model.outState = OutState.Type01NoRecord;
        //            txtName.Text = model.Name;
        //            txtEnglishName.Text = model.EnglishName;
        //            txtSex.Text = model.Sex;
        //            txtBirthday.Text = model.Birthday.ToString();
        //            txtPassNo.Text = model.PassportNo;
        //            txtLicenseTime.Text = model.LicenceTime.ToString();
        //            txtExpireDate.Text = model.ExpiryDate.ToString();
        //            txtBirthPlace.Text = model.Birthplace;
        //            txtIssuePlace.Text = model.IssuePlace;
        //        }));
        //        return;
        //    }
        //    //model.Types = "个签";
        //    model.EntryTime = DateTime.Now;
        //    model.outState = OutState.Type01NoRecord;
        //    txtName.Text = model.Name;
        //    txtEnglishName.Text = model.EnglishName;
        //    txtSex.Text = model.Sex;
        //    txtBirthday.Text = model.Birthday.ToString();
        //    txtPassNo.Text = model.PassportNo;
        //    txtLicenseTime.Text = model.LicenceTime.ToString();
        //    txtExpireDate.Text = model.ExpiryDate.ToString();
        //    txtBirthPlace.Text = model.Birthplace;
        //    txtIssuePlace.Text = model.IssuePlace;
        //}

        //private VisaInfo CtrlsToModel()
        //{
        //    VisaInfo model = new VisaInfo();
        //    //model.Types = "个签";
        //    model.EntryTime = DateTime.Now;
        //    model.outState = OutState.Type01NoRecord;
        //    try
        //    {
        //        model.Name = txtName.Text;
        //        model.EnglishName = txtEnglishName.Text;
        //        model.Sex = txtSex.Text;
        //        model.Birthday = DateTime.Parse(txtBirthday.Text);
        //        model.PassportNo = txtPassNo.Text;
        //        model.LicenceTime = DateTime.Parse(txtLicenseTime.Text);
        //        model.ExpiryDate = DateTime.Parse(txtExpireDate.Text);
        //        model.Birthplace = txtBirthPlace.Text;
        //        model.IssuePlace = txtIssuePlace.Text;
        //    }
        //    catch (Exception)
        //    {
        //        MessageBoxEx.Show(Resources.PleaseCheckDateTimeFormat);
        //        return null;
        //    }
        //    return model;
        //}
        #endregion

        #region 自己的按钮



        //private void ConfirmAddToDataBase(VisaInfo model, bool showConfirm = true)
        //{
        //    if (showConfirm)
        //    {
        //        if (MessageBoxEx.Show(Resources.WhetherAddToDatabase, Resources.Confirm, MessageBoxButtons.OKCancel) == DialogResult.OK)
        //        {
        //            if (_bll.Add(model))
        //            {
        //                //LoadDataToDataGridView(_curPage);
        //                //UpdateState();
        //                LoadDataToDgvAsyn();
        //            }
        //            else
        //                MessageBoxEx.Show(Resources.FailedAddToDatabase);
        //        }
        //    }
        //    else
        //    {
        //        if (_bll.Add(model))
        //        {
        //            LoadDataToDgvAsyn();
        //        }
        //        else
        //            MessageBoxEx.Show(Resources.FailedAddToDatabase);
        //    }

        //}




        private void btnShowToday_Click(object sender, EventArgs e)
        {
            txtSchEntryTimeFrom.Text = DateTimeFormator.DateTimeToString(DateTime.Today);
            txtSchEntryTimeTo.Text = DateTimeFormator.DateTimeToString(DateTime.Today);
            btnSearch_Click(null, null);
        }

        #endregion




        #region dgv用到的相关方法

        //        //用于异步加载
        //        public void LoadAndUpdate()
        //        {
        //            this.Invoke(new Action(() =>
        //            {
        //LoadDataToDgvAsyn();
        //            }));
        //            _init = true;
        //        }

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
            dataGridView1.DataSource = _bll.GetListByPageOrderByGroupNo(page, _pageSize, _where);
            if (curSelectedRow != -1 && dataGridView1.Rows.Count > curSelectedRow)
                dataGridView1.CurrentCell = dataGridView1.Rows[curSelectedRow].Cells[0];
            dataGridView1.Update();
        }

        private void UpdateState()
        {
            _recordCount = _bll.GetRecordCount(_where);
            _pageCount = (int)Math.Ceiling((double)_recordCount / (double)_pageSize);
            if (_curPage == 1)
                btnPagePre.Enabled = false;
            else
                btnPagePre.Enabled = true;
            if (_curPage == _pageCount)
                btnPageNext.Enabled = false;
            else
                btnPageNext.Enabled = true;
            //lbRecordCount.Text = "当前为第:" + Convert.ToInt32(_curPage)
            //                + "页,共" + Convert.ToInt32(_pageCount) + "页,每页共" + _pageSize + "条.";
            lbRecordCount.Text = "共有记录:" + _recordCount + "条";
            lbCurPage.Text = "当前为第" + _curPage + "页";
        }
        #endregion

        #region dgv的bar栏和搜索栏
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

        private void cbPageSize_Click(object sender, EventArgs e)
        {
            //_pageSize = int.Parse(cbPageSize.Text);
            //LoadDataToDataGridView(_curPage);
            //UpdateState();
        }
        private void cbPageSize_TextChanged(object sender, EventArgs e)
        {
            if (!_init) //因为窗口初始化的时候也会调用，所以禁止多次调用
                return;

            _pageSize = int.Parse(cbPageSize.Text);
            LoadDataToDgvAsyn();
        }


        //private void cbDisplayType_TextChanged(object sender, EventArgs e)
        //{
        //    if (!_init) //因为窗口初始化的时候也会调用，所以禁止多次调用
        //        return;
        //    LoadDataToDataGridView(_curPage);
        //    UpdateState();
        //}

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

            if (!string.IsNullOrEmpty(txtSchPassportNo.Text.Trim()))
            {
                conditions.Add(" (PassportNo like '%" + txtSchPassportNo.Text + "%') ");
            }

            if (!string.IsNullOrEmpty(txtSchName.Text.Trim()))
            {
                conditions.Add(" (Name like  '%" + txtSchName.Text + "%') ");
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

            string[] arr = conditions.ToArray();
            string where = string.Join(" and ", arr);
            return where;
        }

        private void btnClearSchConditions_Click(object sender, EventArgs e)
        {
            cbDisplayType.Text = "全部";
            txtSchPassportNo.Text = string.Empty;
            txtSchEntryTimeFrom.Text = string.Empty;
            txtSchEntryTimeTo.Text = string.Empty;
            txtSchGroupNo.Text = string.Empty;
            txtSchName.Text = string.Empty;
        }


        #endregion
        #region dgv消息相应
        /// <summary>
        /// 根据送签状态设置单元格颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "outState")
            {
                Color c = Color.Empty;
                //string state = e.Value.ToString();
                string state = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (state == OutState.Type01NoRecord)
                    c = Color.AliceBlue;
                else if (state == OutState.Type02In)
                    c = Color.Yellow;
                else if (state == OutState.Type03NormalOut)
                    c = Color.Green;
                else if (state == OutState.TYPE04AbnormalOut)
                    c = Color.Red;
                else
                    c = Color.Black;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = c;
            }
        }

        /// <summary>
        /// dgv设置行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                row.HeaderCell.Value = (i + 1).ToString();

                if (!string.IsNullOrEmpty((string)row.Cells["EnglishName"].Value) && !string.IsNullOrEmpty((string)row.Cells["PassportNo"].Value))
                {
                    dataGridView1.Rows[i].Cells["QRCodeImage"].Value = _qrCode.EncodeToImage(row.Cells["EnglishName"].Value + "|" + row.Cells["PassportNo"].Value,
                        QRCodeSaveSize.Size165X165);
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
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
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
                        {
                            dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[0];
                        }

                    }
                    //弹出操作菜单
                    cmsDgvRb.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var row = dataGridView1.CurrentRow;
                if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["QRCodeImage"].Index)
                {
                    if (!string.IsNullOrEmpty((string)row.Cells["EnglishName"].Value) && !string.IsNullOrEmpty((string)row.Cells["PassportNo"].Value))
                    {
                        FrmQRCode frm = new FrmQRCode(row.Cells["EnglishName"].Value + "|" + row.Cells["PassportNo"].Value);
                        frm.ShowDialog();
                    }
                }
                else
                {
                    VisaInfo model = _bll.GetModel(Guid.Parse(dataGridView1.CurrentRow.Cells["VisaInfo_id"].Value.ToString()));
                    if (model == null)
                    {
                        MessageBoxEx.Show(Resources.FindModelFailedPleaseCheckInfoCorrect);
                        return;
                    }
                    FrmInfoTypeIn frm = new FrmInfoTypeIn(model, LoadDataToDataGridView, _curPage);
                    frm.ShowDialog();
                }

            }
        }
        #endregion

        #region dgv右键菜单相应
        /// <summary>
        /// 刷新dgv数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmsItemRefreshState_Click(object sender, EventArgs e)
        {
            LoadDataToDataGridView(_curPage);
        }

        /// <summary>
        /// 查看单个二维码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showQRCode_Click(object sender, EventArgs e)
        {

            if (this.dataGridView1.SelectedRows.Count > 1)
            {
                MessageBoxEx.Show(Resources.SelectShowMoreThanOne);
                return;
            }

            string passportNo = dataGridView1.SelectedRows[0].Cells["PassportNo"].Value.ToString();
            string name = dataGridView1.SelectedRows[0].Cells["EnglishName"].Value.ToString();

            FrmQRCode dlg = new FrmQRCode(passportNo + "|" + name);
            dlg.ShowDialog();
        }

        /// <summary>
        /// 批量生成二维码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmsItemQRCodeBatchGenerate_Click(object sender, EventArgs e)
        {

            int count = this.dataGridView1.SelectedRows.Count;

            ////选择保存路径
            //string path;
            //FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
            //if (fbd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            //    return;
            //path = fbd.SelectedPath;
            string path = GlobalUtils.OpenBrowseFolderDlg();
            if (string.IsNullOrEmpty(path))
                return;

            for (int i = 0; i != count; ++i)
            {
                string passportNo = dataGridView1.SelectedRows[i].Cells["PassportNo"].Value.ToString();
                string name = dataGridView1.SelectedRows[i].Cells["EnglishName"].Value.ToString();
                _qrCode.EncodeToPng(passportNo + "|" + name, path + "\\" + passportNo + ".jpg", QRCodeSaveSize.Size165X165);
            }

            MessageBoxEx.Show("成功保存" + count + "条记录二维码.");

        }

        /// <summary>
        /// 录入资料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmsItemTypeInInfo_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 1)
            {
                MessageBoxEx.Show(Resources.SelectEditMoreThanOne);
                return;
            }

            string visainfoid = dataGridView1.SelectedRows[0].Cells["VisaInfo_id"].Value.ToString();
            Model.VisaInfo model = _bll.GetModel(new Guid(visainfoid));
            if (model == null)
            {
                MessageBoxEx.Show(Resources.FindModelFailedPleaseCheckInfoCorrect);
                return;
            }

            Action<int> updateDel = new Action<int>(LoadDataToDataGridView);
            FrmInfoTypeIn dlg = new FrmInfoTypeIn(model, updateDel, _curPage);
            dlg.ShowDialog();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmsItemDelete_Click(object sender, EventArgs e)
        {
            int count = this.dataGridView1.SelectedRows.Count;
            if (MessageBoxEx.Show("确认删除" + count + "条记录?", Resources.Confirm, MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i != count; ++i)
            {
                if (!string.IsNullOrEmpty((string)dataGridView1.SelectedRows[i].Cells["Visa_id"].Value))
                {
                    MessageBoxEx.Show("选中用户已经在团号中，若需删除请先将其移出团号!");
                    return;
                }
                sb.Append("'");
                sb.Append(dataGridView1.SelectedRows[i].Cells["Visainfo_id"].Value);
                sb.Append("'");
                if (i == count - 1)
                    break;
                sb.Append(",");
            }

            int n = _bll.DeleteList(sb.ToString());
            MessageBoxEx.Show(n + "条记录删除成功," + (count - n) + "条记录删除失败.");
            LoadDataToDataGridView(_curPage);
            UpdateState();
        }

        /// <summary>
        /// 设置团号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmsItemSetGroup_Click(object sender, EventArgs e)
        {

            int count = this.dataGridView1.SelectedRows.Count;
            var list = GetDgvSelNotSetGroupList();
            if (list == null)
                return;
            FrmGroupOrIndividual frmGroupOrIndividual = new FrmGroupOrIndividual(list, LoadDataToDataGridView, _curPage);
            frmGroupOrIndividual.ShowDialog();

        }

        /// <summary>
        /// 获取没有设置过团号的list,若有设置过的会报错
        /// </summary>
        /// <returns></returns>
        private List<Model.VisaInfo> GetDgvSelNotSetGroupList()
        {
            int count = this.dataGridView1.SelectedRows.Count;
            List<Model.VisaInfo> list = new List<VisaInfo>();
            for (int i = 0; i != count; ++i)
            {
                Model.VisaInfo model = _bll.GetModel(new Guid(dataGridView1.SelectedRows[i].Cells["Visainfo_id"].Value.ToString()));
                if (model == null)
                {
                    MessageBoxEx.Show(Resources.FindModelFailedPleaseCheckInfoCorrect);
                    return null;
                }
                if (!string.IsNullOrEmpty(model.Visa_id))
                {
                    MessageBoxEx.Show("选中项中有已经设置过团号的签证!");
                    return null;
                }
                if (model != null)
                    list.Add(model);
            }
            return list;
        }

        /// <summary>
        /// 获取选中项的list
        /// </summary>
        /// <returns></returns>
        private List<Model.VisaInfo> GetDgvSelList()
        {
            int count = this.dataGridView1.SelectedRows.Count;
            List<Model.VisaInfo> list = new List<VisaInfo>();
            for (int i = 0; i != count; ++i)
            {
                Model.VisaInfo model = _bll.GetModel(new Guid(dataGridView1.SelectedRows[i].Cells["Visainfo_id"].Value.ToString()));
                if (model == null)
                {
                    MessageBoxEx.Show(Resources.FindModelFailedPleaseCheckInfoCorrect);
                    return null;
                }
                if (model != null)
                    list.Add(model);
            }
            return list;
        }

        private void 添加到团号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var list = GetDgvSelNotSetGroupList();
            if (list == null)
                return;
            FrmVisaManage frm = new FrmVisaManage(true, list);
            frm.ShowDialog();
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

        //private void 金桥大名单ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    var visainfos = GetDgvSelList();
        //    List<string> list = new List<string>();
        //    for (int i = 0; i < visainfos.Count; i++)
        //    {
        //        list.Add(visainfos[i].Name);
        //    }
        //    DocGenerator docGenerator = new DocGenerator(DocGenerator.DocType.Type01JinQiaoList);
        //    docGenerator.Generate(list);
        //}

        //TODO:增加进度条显示
        private void 外领担保函ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DocComGenerator docComGenerator = new DocComGenerator(DocComGenerator.DocType.Type02WaiLingDanBaohan);
            GlobalUtils.DocDocxGenerator.SetDocType(DocDocxGenerator.DocType.Type02WaiLingDanBaohan);
            var visainfos = GetDgvSelList();

            if (this.dataGridView1.SelectedRows.Count > 1)
            {
                //多余一条的时候生成二维list用于打印
                List<List<string>> stringinfos = new List<List<string>>();
                for (int i = 0; i < visainfos.Count; i++)
                {
                    List<string> list = new List<string>();
                    list.Add(visainfos[i].Name);
                    list.Add(visainfos[i].PassportNo);
                    list.Add(visainfos[i].IssuePlace);
                    list.Add(DateTimeFormator.DateTimeToStringOfChinese(DateTime.Today));
                    stringinfos.Add(list);
                }
                //多余1条的时候选择保存文件夹
                string path = GlobalUtils.OpenBrowseFolderDlg();
                if (string.IsNullOrEmpty(path))
                    return;
                GlobalUtils.DocDocxGenerator.GenerateBatch(stringinfos, path);
            }
            else //一条单独的时候就直接获取就行
            {
                //生成需要替换的list
                List<string> list = new List<string>();
                list.Add(visainfos[0].Name);
                list.Add(visainfos[0].PassportNo);
                list.Add(visainfos[0].IssuePlace);
                list.Add(DateTimeFormator.DateTimeToStringOfChinese(DateTime.Today));
                GlobalUtils.DocDocxGenerator.Generate(list);
            }
        }

        private void 人申请表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var visainfos = GetDgvSelList();
            XlsGenerator.GetPre8List(visainfos);
        }

        private void 机票报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DocComGenerator docComGenerator = new DocComGenerator(DocComGenerator.DocType.Type03JiPiao);
            GlobalUtils.DocDocxGenerator.SetDocType(DocDocxGenerator.DocType.Type03JiPiao);

            var visainfos = GetDgvSelList();
            List<string> list = new List<string>();
            list.Add(RngWord.GetRandomWord());
            for (int i = 0; i < visainfos.Count; i++)
            {
                //由于这里可能出现多个空格，采用正则表达式进行替换
                string pattern = @"([a-zA-Z]+)(\s+)([a-zA-Z]+)";
                string englishName = visainfos[i].EnglishName;
                Match m = Regex.Match(englishName, pattern);
                list.Add(Regex.Replace(englishName, pattern, "${1}" + @"/" + "${3}"));
            }
            GlobalUtils.DocDocxGenerator.Generate(list);
        }

        private void FrmVisaInfoManage_FormClosed(object sender, FormClosedEventArgs e)
        {
        }




    }
}
