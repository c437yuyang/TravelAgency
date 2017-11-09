using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using TravletAgence.Common;
using TravletAgence.Common.Enums;
using TravletAgence.Common.Excel.Japan;
using TravletAgence.Common.IDCard;
using TravletAgence.Common.QRCode;
using TravletAgence.Common.Word;
using TravletAgence.Common.Word.Japan;
using TravletAgence.CSUI.FrmSub;
using TravletAgence.CSUI.Properties;
using TravletAgence.Model;
using Timer = System.Windows.Forms.Timer;

namespace TravletAgence.CSUI.FrmMain
{
    public partial class FrmVisaTypeIn : Form
    {
        private readonly TravletAgence.BLL.VisaInfo _bll = new BLL.VisaInfo();
        private Model.VisaInfo _model; //当前对应的所有编辑框对应的model
        private List<Model.VisaInfo> _list; //当前dgv对应的list

        private int _curPage = 1;
        private int _pageCount = 0;
        private int _pageSize = 30;
        private int _recordCount = 0;
        private readonly IDCard _idCard = new IDCard();
        private bool _autoRead = false;
        private bool _autoReadThreadRun = false;
        private readonly Timer _t = new Timer();
        private readonly MyQRCode _qrCode = new MyQRCode(); //只用于批量生成二维码
        //private readonly Thread _thLoadDataToDgvAndUpdateState;
        private bool _init = false;
        private string _where = string.Empty;



        public FrmVisaTypeIn()
        {
            InitializeComponent();
            //_t.Tick += AutoClassAndRecognize;
            //_t.Interval = 200;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _recordCount = _bll.GetRecordCount(_where);
            _pageCount = (int)Math.Ceiling(_recordCount / (double)_pageSize);

            //初始化一些控件
            txtPicPath.Text = GlobalInfo.AppPath;
            //cbPageSize.Items.Add("30");
            //cbPageSize.Items.Add("50");
            //cbPageSize.Items.Add("100");
            //cbPageSize.SelectedIndex = 0;
            //dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //cbDisplayType.Items.Add("全部");
            //cbDisplayType.Items.Add("未记录");
            //cbDisplayType.Items.Add("个签");
            //cbDisplayType.Items.Add("团签");
            //cbDisplayType.DropDownStyle = ComboBoxStyle.DropDownList;

            //cbDisplayType.SelectedIndex = 0;
            checkShowConfirm.Checked = true;
            checkRegSucShowDlg.Checked = true;

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
            //progressLoading.Visible = false;

            //LoadDataToDgvAsyn();
            _init = true;
        }

        #region model与control
        private void ModelToCtrls(TravletAgence.Model.VisaInfo_Tmp model)
        {
            //添加多线程情况的时候的判断
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    //model.Types = "个签";
                    model.EntryTime = DateTime.Now;
                    model.outState = OutState.Type01NoRecord;
                    txtName.Text = model.Name;
                    txtEnglishName.Text = model.EnglishName;
                    txtSex.Text = model.Sex;
                    txtBirthday.Text = model.Birthday.ToString();
                    txtPassNo.Text = model.PassportNo;
                    txtLicenseTime.Text = model.LicenceTime.ToString();
                    txtExpireDate.Text = model.ExpiryDate.ToString();
                    txtBirthPlace.Text = model.Birthplace;
                    txtIssuePlace.Text = model.IssuePlace;
                }));
                return;
            }
            //model.Types = "个签";
            model.EntryTime = DateTime.Now;
            model.outState = OutState.Type01NoRecord;
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
            //model.Types = "个签";
            model.EntryTime = DateTime.Now;
            model.outState = OutState.Type01NoRecord;
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
                MessageBoxEx.Show(Resources.PleaseCheckDateTimeFormat);
                return null;
            }
            return model;
        }
        #endregion

        #region 自己的按钮

        private void btnLoadKernel_Click(object sender, EventArgs e)
        {
            _idCard.LoadKernel();
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {
            TravletAgence.Model.VisaInfo_Tmp model = _idCard.RecogoInfo(txtPicPath.Text);
            if (model == null) return;
            ModelToCtrls(model);
            ConfirmAddToDataBase(model, checkShowConfirm.Checked);
        }


        private void btnFreeKernel_Click(object sender, EventArgs e)
        {
            _idCard.FreeKernel();
        }


        private void ConfirmAddToDataBase(VisaInfo_Tmp model, bool showConfirm = true)
        {
            if (showConfirm)
            {
                if (MessageBoxEx.Show(Resources.WhetherAddToDatabase, Resources.Confirm, MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (_bll.Add(model))
                    {
                        //LoadDataToDataGridView(_curPage);
                        //UpdateState();
                        //LoadDataToDgvAsyn();
                    }
                    else
                        MessageBoxEx.Show(Resources.FailedAddToDatabase);
                }
            }
            else
            {
                if (_bll.Add(model))
                {
                    //LoadDataToDgvAsyn();
                }
                else
                    MessageBoxEx.Show(Resources.FailedAddToDatabase);
            }

        }

        private void btnAutoRead_Click(object sender, EventArgs e)
        {
            if (!_idCard.KernelLoaded)
            {
                MessageBoxEx.Show("Please press load kernel button first!");
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

        /// <summary>
        /// 自动识别回调函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void AutoClassAndRecognize(object sender, EventArgs eventArgs)
        {
            Model.VisaInfo_Tmp model = _idCard.AutoClassAndRecognize(this.txtPicPath.Text, checkRegSucShowDlg.Checked);
            if (model == null) return;
            ModelToCtrls(model);
            ConfirmAddToDataBase(model, checkShowConfirm.Checked);
        }

        /// <summary>
        /// 自动识别线程函数
        /// </summary>
        /// <param name="o"></param>
        private void AutoClassAndRecognize(object o)
        {
            while (_autoReadThreadRun)
            {
                Thread.Sleep(200);
                Model.VisaInfo_Tmp model = _idCard.AutoClassAndRecognize(this.txtPicPath.Text, checkRegSucShowDlg.Checked);
                if (model == null) continue;
                ModelToCtrls(model);
                ConfirmAddToDataBase(model, checkShowConfirm.Checked);
            }
        }

        /// <summary>
        /// 开启自动识别线程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAutoReadThreadStart_Click(object sender, EventArgs e)
        {
            if (!_idCard.KernelLoaded)
            {
                MessageBoxEx.Show("Please press load kernel button first!");
                return;
            }
            if (!_autoReadThreadRun)
            {
                // t.AutoReset = true;//设置是执行一次（false）还是一直执行(true)； 
                this.btnAutoReadThreadStart.Text = "■停止自动读取";
                _autoReadThreadRun = true;
                Thread th = new Thread(this.AutoClassAndRecognize);
                th.IsBackground = true;
                th.Start();
            }
            else
            {
                this.btnAutoReadThreadStart.Text = "开始自动读取";
                _autoReadThreadRun = false;
            }


        }


        private void buttonAddToDatabase_Click(object sender, EventArgs e)
        {
            VisaInfo model = CtrlsToModel();
            if (model == null) return;
            if (!_bll.Add(model))
            {
                MessageBoxEx.Show(Resources.FailedAddToDatabase);
                return;
            }
            //LoadDataToDgvAsyn();
        }



        #endregion

        private void FrmVisaTypeIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            //_idCard.FreeKernel();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }




    }
}
