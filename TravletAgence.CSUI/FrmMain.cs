using System;
using System.Drawing;
using System.Windows.Forms;
using TravletAgence.Common.QRCode;
using TravletAgence.Model;

namespace TravletAgence.CSUI
{
    public partial class FrmMain : Form
    {
        private readonly TravletAgence.BLL.VisaInfo bll = new TravletAgence.BLL.VisaInfo();
        private int _curPage = 1;
        private int _pageCount = 0;
        private readonly int _pageSize = 30;
        private int _recordCount = 0;
        private readonly IDCard _idCard = new IDCard();
        private bool _autoRead = false;
        private System.Windows.Forms.Timer _t = new System.Windows.Forms.Timer();

        public FrmMain()
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
            //加载数据
            loadDataToDataGridView(_curPage);
            UpdateState();
        }

        private void loadDataToDataGridView(int page)
        {
            dataGridView1.DataSource = bll.GetListByPage(page, _pageSize);
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

        private void btnLoadKernel_Click(object sender, EventArgs e)
        {
            _idCard.LoadKernel();
        }

        private void ModelToCtrls(TravletAgence.Model.VisaInfo model)
        {
            model.Types = "个签";
            model.EntryTime = DateTime.Now;

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

        

        private void showQRCode_Click(object sender, EventArgs e)
        {

            if (this.dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("请选择一行数据进行查看");
                return;
            }

            string passportNo = dataGridView1.SelectedRows[0].Cells["PassportNo"].Value.ToString();
            string name = dataGridView1.SelectedRows[0].Cells["_Name"].Value.ToString();

            FrmQRCode dlg = new FrmQRCode(passportNo + "|" + name);
            dlg.ShowDialog();
        }

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
                        dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    //cmsDgvRb.Show(dataGridView1, e.Location);
                    cmsDgvRb.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }
    }
}
