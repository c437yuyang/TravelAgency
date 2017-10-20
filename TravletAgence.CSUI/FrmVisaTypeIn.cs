using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using TravletAgence.Common;
using TravletAgence.Common.QRCode;
using TravletAgence.Model;

namespace TravletAgence.CSUI
{
    public partial class FrmVisaTypeIn : Form
    {
        private readonly TravletAgence.BLL.VisaInfo bll = new TravletAgence.BLL.VisaInfo();
        private int _curPage = 1;
        private int _pageCount = 0;
        private readonly int _pageSize = 30;
        private int _recordCount = 0;
        private readonly IDCard _idCard = new IDCard();
        private bool _autoRead = false;
        private System.Windows.Forms.Timer _t = new System.Windows.Forms.Timer();
        private MyQRCode _qrCode = new MyQRCode(); //只用于批量生成二维码

        public FrmVisaTypeIn()
        {
            InitializeComponent();
            _t.Tick += new System.EventHandler(this.AutoClassAndRecognize);
            _t.Interval = 200;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _recordCount = bll.GetRecordCount(string.Empty);
            _pageCount = (int)Math.Ceiling((double)_recordCount / (double)_pageSize);
            txtPicPath.Text = System.Windows.Forms.Application.StartupPath;
            cbPageSize.Items.Add(_pageSize.ToString());
            cbPageSize.SelectedIndex = 0;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //加载数据
            loadDataToDataGridView(_curPage);
            UpdateState();
        }



        private void btnLoadKernel_Click(object sender, EventArgs e)
        {
            _idCard.LoadKernel();
        }

        private void ModelToCtrls(TravletAgence.Model.VisaInfo model)
        {
            model.Types = "个签";
            model.EntryTime = DateTime.Now;
            model.outState = OutState.TYPE01NoRecord;
            txtName.Text = model.Name;
            txtEnglishName.Text = model.EnglishName;
            txtSex.Text = model.Sex;
            txtBirthday.Text = model.Birthday.ToString();
            txtPassNo.Text = model.PassportNo;
            txtLicenseTime.Text = model.LicenceTime.ToString();
            txtExpireDate.Text = model.ExpiryDate.ToString();
            txtBirthPlace.Text = model.Birthplace;
            txtIssuePlace.Text = model.IssuePlace;
        }

        private VisaInfo CtrlsToModel()
        {
            VisaInfo model = new VisaInfo();
            model.Types = "个签";
            model.EntryTime = DateTime.Now;
            model.outState = OutState.TYPE01NoRecord;
            try
            {
                model.Name = txtName.Text;
                model.EnglishName = txtEnglishName.Text;
                model.Sex = txtSex.Text;
                model.Birthday = DateTime.Parse(txtBirthday.Text);
                model.PassportNo = txtPassNo.Text;
                model.LicenceTime = DateTime.Parse(txtLicenseTime.Text);
                model.ExpiryDate = DateTime.Parse(txtExpireDate.Text);
                model.Birthplace = txtBirthPlace.Text;
                model.IssuePlace = txtIssuePlace.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("请确保信息格式正确\n如日期为:2010-10-19");
                return null;
            }
            return model;
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {
            TravletAgence.Model.VisaInfo model = _idCard.RecogoInfo(txtPicPath.Text);
            if (model == null) return;
            ModelToCtrls(model);
            ConfirmAddToDataBase(model);
        }


        private void btnFreeKernel_Click(object sender, EventArgs e)
        {
            _idCard.FreeKernel();
        }

        private void AutoClassAndRecognize(object sender, EventArgs eventArgs)
        {
            Model.VisaInfo model = _idCard.AutoClassAndRecognize(this.txtPicPath.Text);
            if (model == null) return;
            ModelToCtrls(model);
            ConfirmAddToDataBase(model);
        }

        private void ConfirmAddToDataBase(VisaInfo model)
        {
            if (MessageBox.Show("是否添加指定数据到数据库?", "确认", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (bll.Add(model))
                {
                    loadDataToDataGridView(_curPage);
                    UpdateState();
                }
                else
                    MessageBox.Show("添加到数据库失败！");
            }
        }

        private void btnAutoRead_Click(object sender, EventArgs e)
        {
            if (!_idCard.KernelLoaded)
            {
                MessageBox.Show("Please press load kernel button first!");
                return;
            }
            if (!_autoRead)
            {
                // t.AutoReset = true;//设置是执行一次（false）还是一直执行(true)； 
                _t.Enabled = true;
                this.btnAutoRead.Text = "停止自动读取";
                _autoRead = true;
            }
            else
            {
                _t.Enabled = false;
                this.btnAutoRead.Text = "开始自动读取";
                _autoRead = false;
            }
        }

        private void buttonAddToDatabase_Click(object sender, EventArgs e)
        {
            VisaInfo model = CtrlsToModel();
            if (model == null) return;
            if (!bll.Add(model))
            {
                MessageBox.Show("添加到数据库失败!");
                return;
            }
            loadDataToDataGridView(_curPage);
            UpdateState();
        }


        #region dgv用到的相关方法
        public void loadDataToDataGridView(int page) //刷新后保持选中
        {
            int curSelectedRow = -1;
            if (dataGridView1.SelectedRows.Count > 0)
                curSelectedRow = dataGridView1.SelectedRows[0].Index;
            dataGridView1.DataSource = bll.GetListByPage(page, _pageSize);
            if (curSelectedRow != -1)
                dataGridView1.CurrentCell = dataGridView1.Rows[curSelectedRow].Cells[0];
        }

        private void UpdateState()
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
            loadDataToDataGridView(++_curPage);
            UpdateState();
        }

        private void btnPagePre_Click(object sender, EventArgs e)
        {
            loadDataToDataGridView(--_curPage);
            UpdateState();
        }

        private void btnPageFirst_Click(object sender, EventArgs e)
        {
            _curPage = 1;
            loadDataToDataGridView(_curPage);
            UpdateState();
        }

        private void btnPageLast_Click(object sender, EventArgs e)
        {
            _curPage = _pageCount;
            loadDataToDataGridView(_curPage);
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
            if (e.ColumnIndex == 9)
            {
                DataGridViewX dgv = (DataGridViewX)sender;
                Color c = Color.Empty;
                switch (e.Value.ToString())
                {
                    case "01未记录":
                        c = Color.AliceBlue;
                        break;
                    case "02进签":
                        c = Color.Yellow;
                        break;
                    case "03出签":
                        c = Color.Green;
                        break;
                    case "04未正常出签":
                        c = Color.Red;
                        break;
                    default:
                        c = Color.Black;
                        break;
                }
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
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
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
                        {
                            dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[0];
                        }

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
            loadDataToDataGridView(_curPage);
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
                MessageBox.Show("请选择一行数据进行查看");
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

            MessageBox.Show("成功保存" + count + "条记录二维码.");

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
                MessageBox.Show("请选择一行数据进行编辑");
                return;
            }

            string visainfoid = dataGridView1.SelectedRows[0].Cells["VisaInfo_id"].Value.ToString();
            Model.VisaInfo model = bll.GetModel(new Guid(visainfoid));
            if (model == null)
            {
                MessageBox.Show("数据查询出错，请重试!");
                return;
            }

            Action<int> updateDel = new Action<int>(loadDataToDataGridView);
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
            if (MessageBox.Show("确认删除" + count + "条记录?", "确认", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i != count; ++i)
            {
                sb.Append("'");
                sb.Append(dataGridView1.SelectedRows[i].Cells["Visainfo_id"].Value);
                sb.Append("'");
                if (i == count - 1)
                    break;
                sb.Append(",");
            }

            int n = bll.DeleteList(sb.ToString());
            MessageBox.Show(n + "条记录删除成功," + (count - n) + "条记录删除失败.");
            loadDataToDataGridView(_curPage);
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

            List<Model.VisaInfo> list = new List<VisaInfo>();


            for (int i = 0; i != count; ++i)
            {
                Model.VisaInfo model = bll.GetModel(new Guid(dataGridView1.SelectedRows[i].Cells["Visainfo_id"].Value.ToString()));
                if (model != null)
                    list.Add(model);
            }

            FrmSetGroup frmSetGroup = new FrmSetGroup(list);
            frmSetGroup.ShowDialog();

        }

        #endregion

        




    }
}
