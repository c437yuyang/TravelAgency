using System;
using System.Diagnostics;
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
        public FrmUpdateMain()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void FrmUpdateMain_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
                MessageBoxEx.Show("发现新版本，即将开始更新");
                //获取更新文件列表
                string[] list = _model.update_files.Split('|');

                //显示更新描述
                labelX1.Text = _model.udapte_details;

                //执行更新
                if (!DoUpdate(list))
                {
                    MessageBoxEx.Show("更新失败，请联系技术人员!");
                    Application.Exit();
                    return;
                }
                XmlHandler.SetPropramVersion((float)_model.version);
                MessageBoxEx.Show("更新完成.");
            }
            
            Process.Start(GlobalUtils.AppPath + "\\TravelAgency.CSUI.exe");
            Application.Exit();
        }

        private bool NeedUpdate()
        {
            float localVersion = XmlHandler.GetPropramVersion();
            return localVersion < (float)_model.version;
        }

        private bool DoUpdate(string[] list)
        {
            string appPath = GlobalUtils.AppPath;
            //切换到根目录下面
            FtpHandler.ChangeFtpUri(XmlHandler.GetPropramPath());
            int res = 0;
            for (int i = 0; i < list.Length; i++)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem = new ListViewItem(list[i]);
                if (FtpHandler.Download(GlobalUtils.AppPath, list[i]))
                {
                    ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(listViewItem, "更新成功");
                    ++res;
                }
                else
                {
                    ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(listViewItem, "更新失败");
                }
                lvUpdateList.Items.Add(listViewItem);
            }

            return res == list.Length;
        }

    }
}
