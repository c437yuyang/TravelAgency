using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using TravletAgence.Common;
using TravletAgence.Common.Enums;
using TravletAgence.Common.QRCode;
using TravletAgence.CSUI.FrmSub;
using TravletAgence.CSUI.Properties;
using VisaInfo = TravletAgence.Model.VisaInfo;

namespace TravletAgence.CSUI.FrmMain
{
    enum Inputmode
    {
        Single,
        Batch
    }
    public partial class FrmVisaSubmit : Form
    {
        private readonly TravletAgence.BLL.VisaInfo bll = new TravletAgence.BLL.VisaInfo();
        private int _curPage = 1;
        private int _pageCount = 0;
        private readonly int _pageSize = 30;
        private int _recordCount = 0;
        private string _preTxt = string.Empty;
        private string _outState = string.Empty; //Single模式下的状态设置
        private Inputmode _inputMode = Inputmode.Single;
        private readonly MyQRCode _qrCode = new MyQRCode();

        //class PersonInfo
        //{
        //    public string passportNo { get; set; }
        //    public string englishName { get; set; }
        //}

        public FrmVisaSubmit()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (_inputMode == Inputmode.Single)
            {
                if (_preTxt + "\r\n" != txtInput.Text)
                {
                    _preTxt = txtInput.Text;
                    return;
                }
                _preTxt = txtInput.Text;
                UpdateByLines(txtInput.Text, _inputMode);
            }

            //Console.WriteLine(model.EntryTime.ToString());
        }

        private int UpdateByLines(string txt, Inputmode inputMode)
        {
            int count = 0; //成功记录数
            string str = txtInput.Text.TrimEnd(); //去掉最后的\r\n
            string[] lines = str.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            bool updateSingle = !(lines.Length > 20); //多行模式下设置显示更新模式
            if (inputMode == Inputmode.Single)
            {
                VisaInfo model = GetModelByLine(lines[lines.Length - 1]);
                if (model == null)
                {
                    MessageBoxEx.Show(Resources.FindModelFailedPleaseCheckInfoCorrect);
                    return count;
                }

                UpdateModelState(model, _outState);
                if (!bll.Update(model))
                {
                    MessageBoxEx.Show(Resources.FailedUpdateVisaInfoState);
                    return count;
                }
                ++count;
                LoadDataToDataGridView(_curPage);
            }
            else if (inputMode == Inputmode.Batch)
            {
                string outState = string.Empty;

                for (int i = 0; i != lines.Length; ++i)
                {
                    if (lines[i].Equals(OutStateString.Type02In))
                        outState = OutState.Type02In;
                    else if (lines[i].Equals(OutStateString.Type03NormalOut))
                        outState = OutState.Type03NormalOut;
                    else if (lines[i].Equals(OutStateString.Type04AbnormalOut))
                        outState = OutState.TYPE04AbnormalOut;
                    else
                    {
                        if (outState.Length == 0)
                        {
                            MessageBoxEx.Show(Resources.OutStateLengthEqualZero);
                            return count;
                        }
                        VisaInfo model = GetModelByLine(lines[i]);
                        if (model == null)
                        {
                            MessageBoxEx.Show(Resources.FindModelFailedPleaseCheckInfoCorrect);
                            return count;
                        }

                        UpdateModelState(model, outState);

                        if (!bll.Update(model))
                        {
                            MessageBoxEx.Show(Resources.FailedUpdateVisaInfoState);
                            return count;
                        }
                        ++count;
                        if (updateSingle)
                            LoadDataToDataGridView(_curPage);
                    }
                }
            }
            if (!updateSingle)
                LoadDataToDataGridView(_curPage);
            return count;
        }

        private void UpdateModelState(VisaInfo model, string outState1)
        {
            //TODO:添加判断逻辑，
            model.outState = outState1;
            if (outState1 == OutState.Type02In)
                model.InTime = DateTime.Now;
            else if (outState1 == OutState.Type03NormalOut)
                model.OutTime = DateTime.Now;
            else if (outState1 == OutState.TYPE04AbnormalOut)
                model.AbnormalOutTime = DateTime.Now;
            else
                MessageBoxEx.Show(Resources.OutStateLengthEqualZero);
        }

        private VisaInfo GetModelByLine(string line)
        {
            if (!line.Contains('|'))
            {
                MessageBoxEx.Show(Resources.LineNotContainDelimeter);
                return null;
            }

            Model.VisaInfo model;
            try
            {
                model = bll.GetModelByPassportNo(line.Split('|')[0]);
                return model;
            }
            catch (Exception)
            {
                MessageBoxEx.Show(Resources.LineNotContainDelimeter);
                return null;
            }
        }


        private void FrmVisaSubmit_Load(object sender, EventArgs e)
        {
            _recordCount = bll.GetRecordCount(string.Empty);
            _pageCount = (int)Math.Ceiling((double)_recordCount / _pageSize);
            cbPageSize.Items.Add(_pageSize.ToString());
            cbPageSize.SelectedIndex = 0;
            dataGridView1.AutoGenerateColumns = false; //不显示指定之外的列
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; //列宽自适应
            rbtnIn.Select();
            rbtnSingle.Select();
            //加载数据
            LoadDataToDataGridView(_curPage);
            UpdateState();
        }

        private void btnShowInQR_Click(object sender, EventArgs e)
        {
            FrmQRCode frm = new FrmQRCode(OutStateString.Type02In);
            frm.ShowDialog();
        }

        private void btnShowAbnormalOutQR_Click(object sender, EventArgs e)
        {
            FrmQRCode frm = new FrmQRCode(OutStateString.Type04AbnormalOut);
            frm.ShowDialog();
        }

        private void btnShowNormalOutQR_Click(object sender, EventArgs e)
        {
            FrmQRCode frm = new FrmQRCode(OutStateString.Type03NormalOut);
            frm.ShowDialog();
        }

        private void rbtnIn_CheckedChanged(object sender, EventArgs e)
        {
            _outState = OutState.Type02In;
        }

        private void rBtnOut_CheckedChanged(object sender, EventArgs e)
        {
            _outState = OutState.Type03NormalOut;
        }

        private void rbtnAbOut_CheckedChanged(object sender, EventArgs e)
        {
            _outState = OutState.TYPE04AbnormalOut;
        }


        private void btnClearInput_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();
        }

        private void btnParseBatchInput_Click(object sender, EventArgs e)
        {
            string txt = txtInput.Text;
            if (txt == string.Empty ||
                (!txt.Contains(OutStateString.Type02In)
                 && !txt.Contains(OutStateString.Type03NormalOut)
                 && !txt.Contains(OutStateString.Type04AbnormalOut)))
            {
                MessageBoxEx.Show(Resources.InputNoStateInfo);
                return;
            }
            int count = UpdateByLines(txt, _inputMode);
            if (count > 0)
            {
                MessageBoxEx.Show("成功更新" + count + "条记录.");
            }
        }



        private void rbtnSingle_CheckedChanged(object sender, EventArgs e)
        {
            _inputMode = Inputmode.Single;
            btnParseBatchInput.Enabled = false;
            panelOutState.Enabled = true;
        }

        private void rbtnBatch_CheckedChanged(object sender, EventArgs e)
        {
            _inputMode = Inputmode.Batch;
            btnParseBatchInput.Enabled = true;
            panelOutState.Enabled = false;

        }

        #region dgv用到的相关方法
        public void LoadDataToDataGridView(int page) //刷新后保持选中
        {
            int curSelectedRow = -1;
            if (dataGridView1.SelectedRows.Count > 0)
                curSelectedRow = dataGridView1.SelectedRows[0].Index;
            dataGridView1.DataSource = bll.GetListByPageOrderByOutState(page, _pageSize);
            if (curSelectedRow != -1)
                dataGridView1.CurrentCell = dataGridView1.Rows[curSelectedRow].Cells[0];
        }

        public void UpdateState()
        {
            _recordCount = bll.GetRecordCount(string.Empty);
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


        #region dgv的bar栏
        private void btnPageNext_Click(object sender, EventArgs e)
        {
            LoadDataToDataGridView(++_curPage);
            UpdateState();
        }

        private void btnPagePre_Click(object sender, EventArgs e)
        {
            LoadDataToDataGridView(--_curPage);
            UpdateState();
        }

        private void btnPageFirst_Click(object sender, EventArgs e)
        {
            _curPage = 1;
            LoadDataToDataGridView(_curPage);
            UpdateState();
        }

        private void btnPageLast_Click(object sender, EventArgs e)
        {
            _curPage = _pageCount;
            LoadDataToDataGridView(_curPage);
            UpdateState();
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
            if (e.ColumnIndex == 10)
            {
                DataGridViewX dgv = (DataGridViewX)sender;
                Color c = Color.Empty;
                string state = e.Value.ToString();
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
                dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = c;
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

                if ((string)row.Cells["EnglishName"].Value != string.Empty && (string)row.Cells["PassportNo"].Value != string.Empty)
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
                    cmsDgvRb.Show(MousePosition.X, MousePosition.Y);
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

            //选择保存路径
            string path;
            FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
            if (fbd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            path = fbd.SelectedPath;
            for (int i = 0; i != count; ++i)
            {
                string passportNo = dataGridView1.SelectedRows[i].Cells["PassportNo"].Value.ToString();
                string name = dataGridView1.SelectedRows[i].Cells["EnglishName"].Value.ToString();
                _qrCode.EncodeToPng(passportNo + "|" + name, path + "\\" + passportNo + ".jpg", QRCodeSaveSize.Size165X165);
            }

            MessageBoxEx.Show("成功保存" + count + "条记录二维码.");

        }





        #endregion
    }
}
