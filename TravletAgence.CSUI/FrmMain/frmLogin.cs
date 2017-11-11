using System;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using TravletAgence.BLL;

namespace TravletAgence.CSUI.FrmMain
{
    public partial class frmLogin : Form
    {
        private BLL.AuthUser _bll = new AuthUser();
        public frmLogin()
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
            var list = _bll.GetModelList(string.Format(" Account ='{0}' and Password = '{1}' ", txtUserName.Text, txtPswd.Text));
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
