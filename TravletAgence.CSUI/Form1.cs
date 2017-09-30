using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravletAgence.Model;

namespace TravletAgence.CSUI
{
    public partial class Form1 : Form
    {
        private readonly TravletAgence.BLL.VisaInfo bll = new TravletAgence.BLL.VisaInfo();
        private int _curPage = 1;
        private int _pageCount = 0;
        private readonly int _pageSize = 30;
        private readonly IDCard _idCard = new IDCard();
        private bool _autoRead = false;
        private System.Windows.Forms.Timer _t = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
            _t.Tick += new System.EventHandler(this.AutoClassAndRecognize);
            _t.Interval = 200;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int count = bll.GetRecordCount(string.Empty);
            _pageCount = (int)Math.Ceiling((double)count / (double)_pageSize);
            txtPicPath.Text = System.Windows.Forms.Application.StartupPath;

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
            int count = bll.GetRecordCount(string.Empty);
            _pageCount = (int)Math.Ceiling((double)count / (double)_pageSize);
            if (_curPage == 1)
                btn_pageUp.Enabled = false;
            else
                btn_pageUp.Enabled = true;
            if (_curPage == _pageCount)
                btn_pageDown.Enabled = false;
            else
                btn_pageDown.Enabled = true;
            lb_page.Text = "当前为第:" + Convert.ToInt32(_curPage)
                            + "页,共" + Convert.ToInt32(_pageCount) + "页,每页共" + _pageSize + "条.";
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

        private void btn_pageUp_Click(object sender, EventArgs e)
        {
            loadDataToDataGridView(--_curPage);
            UpdateState();
        }

        private void btn_pageDown_Click(object sender, EventArgs e)
        {
            loadDataToDataGridView(++_curPage);
            UpdateState();
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
                this.btnAutoRead.Text = "Stop";
                _autoRead = true;
            }
            else
            {
                _t.Enabled = false;
                this.btnAutoRead.Text = "AutoRead";
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
    }
}
