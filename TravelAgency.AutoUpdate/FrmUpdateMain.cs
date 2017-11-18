using System;
using System.Configuration;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using TravelAgency.BLL;
using TravelAgency.Common;
using TravelAgency.Common.FTP;

namespace TravelAgency.AutoUpdate
{
    public partial class FrmUpdateMain : Form
    {
        BLL.ProgramVersion _bll = new ProgramVersion();
        Model.ProgramVersion _model = new Model.ProgramVersion();
        private float _localVersion = -1.0f;
        public FrmUpdateMain()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void FrmUpdateMain_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            new Thread(CheckAndDoUpdate) { IsBackground = true }.Start();
        }

        void CheckAndDoUpdate()
        {
            _model = _bll.GetModel(_bll.GetMaxId() - 1);
            if (_model == null)
            {
                MessageBoxEx.Show("检查更新失败，程序将退出");
                Application.Exit();
                return;
            }
            //执行检查更新操作
            if (NeedUpdate())
            {
                Thread.Sleep(2000); //延时两秒，防止进程没有退出
                //MessageBoxEx.Show("发现新版本，即将开始更新");
                //获取更新文件列表
                string[] list = _model.update_files.Split('|');

                //显示更新描述
                this.Invoke(new Action(() =>
                {
                    labelX1.Text = _model.udapte_details;
                    lbVersion.Text = "V" + _localVersion + " -> V" + _model.version;
                }));

                //执行更新
                if (!DoUpdate(list))
                {
                    MessageBoxEx.Show("更新失败，请联系技术人员!");
                    Application.Exit();
                    return;
                }
                XmlHandler.SetPropramVersion((float)_model.version);
                ConfigurationManager.AppSettings["Version"] = _model.version.ToString();
                MessageBoxEx.Show("更新完成.");
            }
            else
            {
                btnStart_Click(null, null);
            }
        }

        private bool NeedUpdate()
        {
            _localVersion = XmlHandler.GetPropramVersion();
            return _localVersion < (float)_model.version;
        }

        private bool DoUpdate(string[] list)
        {
            //切换到根目录下面
            FtpHandler.ChangeFtpUri(XmlHandler.GetPropramPath());
            int res = 0;
            for (int i = 0; i < list.Length; i++)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem = new ListViewItem(list[i]);
                ListViewItem.ListViewSubItem subItem;
                if (FtpHandler.Download(GlobalUtils.AppPath, list[i]))
                {
                    subItem = new ListViewItem.ListViewSubItem(listViewItem, "更新成功");
                    ++res;
                }
                else
                {
                    subItem = new ListViewItem.ListViewSubItem(listViewItem, "更新失败");
                }
                listViewItem.SubItems.Add(subItem);
                this.Invoke(new Action(() =>
                {
                    lvUpdateList.Items.Add(listViewItem);
                }));
            }
            return res == list.Length;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Process.Start(GlobalUtils.AppPath + "\\TravelAgency.CSUI.exe");
            Application.Exit();
        }

    }
}
