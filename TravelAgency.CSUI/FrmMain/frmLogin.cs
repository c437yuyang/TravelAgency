using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using TravelAgency.BLL;
using TravelAgency.Common;

namespace TravelAgency.CSUI.FrmMain
{
    public partial class FrmLogin : Form
    {
        private BLL.AuthUser _bllUser = new AuthUser();
        BLL.ProgramVersion _bll = new ProgramVersion();
        Model.ProgramVersion _model = new Model.ProgramVersion();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //登录
            if (txtPswd.Text == "" || txtUserName.Text == "")
            {
                MessageBoxEx.Show("请输入登录口令!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var list = _bllUser.GetModelList(string.Format(" Account ='{0}' and Password = '{1}' ", txtUserName.Text, txtPswd.Text));
            if (list.Count < 1)
            {
                MessageBoxEx.Show("未找到指定用户!");
                return;
            }
            Common.GlobalUtils.LoginUser = list[0];
            FrmMain frm = new FrmMain();
            frm.Show();
            this.Visible = false;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            ////初始化界面信息
            ////提取用户列表
            //DataSet ds = new DataSet();
            //Dong.BLL.OperInfo mOper = new Dong.BLL.OperInfo();
            //ds = mOper.GetAllList();
            //txtUserName.ValueMember = "Code";
            //txtUserName.DisplayMember = "Code";
            //txtUserName.DataSource = ds.Tables[0];

            ////提取配置信息
            //Dong.BLL.ShopInfo bShop = new Dong.BLL.ShopInfo();
            //Dong.Model.ShopInfo mShop = new Dong.Model.ShopInfo();
            //mShop = bShop.GetModel(1);
            //Dong.Model.GlobalsInfo.shopName = mShop.Name;
            //this.Text = this.Text + " --【" + mShop.Name + "】";

            //Dong.Model.GlobalsInfo.shopAddr = mShop.Addr;

            _model = _bll.GetModel(_bll.GetMaxId() - 1); //取出来是错的，加了1
            if (_model == null)
            {
                MessageBoxEx.Show("检查更新失败，程序将退出");
                Application.Exit();
                return;
            }
            //执行检查更新操作
            if (NeedUpdate())
            {
                //获取更新文件列表
                string[] list = _model.update_files.Split('|');

                //显示更新描述
                labelX1.Text = _model.udapte_details;

                //执行更新
                MessageBoxEx.Show("发现新版本，即将开始升级");
                Process.Start(GlobalUtils.AppPath + "\\" + "TravelAgency.AutoUpdate.exe");
                Application.Exit();
                return;
            }

        }

        private bool NeedUpdate()
        {
            float localVersion = XmlHandler.GetPropramVersion();
            return localVersion < (float)_model.version;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Application.Exit();
                    return true;
                case Keys.Enter:
                    btnLogin_Click(null, null);
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }
    }
}
