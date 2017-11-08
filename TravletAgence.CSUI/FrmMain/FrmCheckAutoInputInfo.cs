using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using TravletAgence.Common;
using TravletAgence.Common.Enums;
using TravletAgence.Common.IDCard;
using TravletAgence.CSUI.Properties;
using TravletAgence.Model;

namespace TravletAgence.CSUI.FrmMain
{
    public partial class FrmCheckAutoInputInfo : Form
    {
        private Model.VisaInfo _model; //当前对应的所有编辑框对应的model
        private List<Model.VisaInfo> _list; //当前dgv对应的list
        private readonly BLL.VisaInfo _bll = new BLL.VisaInfo();
        private int _curPage = 1;
        private int _curIdx = 0;
        private int _pageSize = 15;
        private int _recordCount = 0;
        private int _pageCount = 0;
        private readonly IDCard _idCard = new IDCard();
        private bool _autoRead = false;
        private bool _autoReadThreadRun = false;

        public FrmCheckAutoInputInfo()
        {
            InitializeComponent();
        }


        private void FrmCheckAutoInputInfo_Load(object sender, EventArgs e)
        {
            //初始化控件
            txtPicPath.Text = GlobalInfo.AppPath;
            checkShowConfirm.Checked = true;
            checkRegSucShowDlg.Checked = true;
            this.picPassportNo.SizeMode = PictureBoxSizeMode.Zoom;
            btnPre.Enabled = false;
            dataGridView1.AutoGenerateColumns = false; //dgv初始化
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            txtCheckPerson.Text = GlobalInfo.LoginUser.UserName; //初始化操作员
            txtCheckPerson.Enabled = false;

            //加载数据（list和dgv的数据都在这里面）
            LoadDataToDgvAndList(_curPage);
            
            //初始化bar栏及按钮状态
            UpdateState();

            //初始化数据项
            if (_list.Count > 0)
                _model = _list[_curIdx]; //如果没有指定model加载，就直接找第一个

            //初始化数据信息
            ModelToCtrls(_model);

            //加载图片
            LoadImageFromModel(_model);
        }

        #region 状态更新函数
        private void ModelToCtrls(TravletAgence.Model.VisaInfo model)
        {
            if (model == null)
            {
                txtName.Text = string.Empty;
                txtEnglishName.Text = string.Empty;
                txtSex.Text = string.Empty;
                txtBirthday.Text = string.Empty;
                txtPassNo.Text = string.Empty;
                txtLicenseTime.Text = string.Empty;
                txtExpireDate.Text = string.Empty;
                txtBirthPlace.Text = string.Empty;
                txtIssuePlace.Text = string.Empty;
                return;
            }
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

        private Model.VisaInfo CtrlsToModel()
        {
            Model.VisaInfo model = new VisaInfo();
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
                return model;
            }
            catch (Exception)
            {
                MessageBoxEx.Show(Resources.PleaseCheckDateTimeFormat);
                return null;
            }
        }

        private void LoadImageFromModel(Model.VisaInfo model)
        {
            if (model == null)
                return;
            if (File.Exists(model.PassportNo + ".jpg"))
            {
                picPassportNo.Image = Image.FromFile(model.PassportNo + ".jpg");
            }
            else
                picPassportNo.Image = Resources.PassportPictureNotFound;
        }

        /// <summary>
        /// 更新list以及dgv里的数据
        /// </summary>
        /// <param name="page"></param>
        public void LoadDataToDgvAndList(int page) //刷新后保持选中
        {
            _list = _bll.GetListByPageOrderByHasChecked(page, _pageSize);
            dataGridView1.DataSource = _list;
            if (_list.Count > 0)
                dataGridView1.CurrentCell = dataGridView1.Rows[_curIdx].Cells[0]; //每次录入后刷新当前选中项为新录入的
            dataGridView1.Update();
        }

        private void UpdateDataGridViewDisplay()
        {
            //更新dgv显示
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _list;
            //更新选中项
            dataGridView1.CurrentCell = dataGridView1.Rows[_curIdx].Cells[0];
        }

        public void UpdateState()
        {
            _recordCount = _bll.GetRecordCount(string.Empty);
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
            //lbCurPage.Text = "当前为第" + _curPage + "页";

            LoadImageFromModel(_model);

        }
        #endregion



        #region 右边校验部分按钮点击事件
        /// <summary>
        /// 用来确认标志校验完毕的按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNoFault_Click(object sender, EventArgs e)
        {
            //修改Model
            _model = CtrlsToModel();
            if (_model == null)
                return;

            _model.HasChecked = Common.Enums.HasChecked.Yes;
            _model.CheckPerson = txtCheckPerson.Text;

            UpdateDataGridViewDisplay();
        }

        /// <summary>
        /// 保存当前页的所有状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            //保存修改

            int res = _bll.UpdateByList(_list);

            MessageBoxEx.Show(res.ToString() + "条记录更新成功," + (_list.Count - res) + "条记录更新失败！");
            //重新加载数据
            LoadDataToDgvAndList(_curPage);

        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (_curIdx > 0)
                --_curIdx;

            UpdateState();
            _model = _list[_curIdx];

            ModelToCtrls(_model);
            LoadImageFromModel(_model);
            UpdateDataGridViewDisplay();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_curIdx < _pageSize - 1)
                ++_curIdx;

            UpdateState();
            _model = _list[_curIdx];

            ModelToCtrls(_model);
            LoadImageFromModel(_model);
            UpdateDataGridViewDisplay();

        }

        private void btnLoadKernel_Click(object sender, EventArgs e)
        {
            _idCard.LoadKernel();
        }

        private void btnFreeKernel_Click(object sender, EventArgs e)
        {
            _idCard.FreeKernel();
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {
            _model = _idCard.RecogoInfo(txtPicPath.Text,checkRegSucShowDlg.Checked);
            ModelToCtrls(_model);
            ConfirmAddToDataBase(_model, checkShowConfirm.Checked);
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
                _model = _idCard.AutoClassAndRecognize(this.txtPicPath.Text, checkRegSucShowDlg.Checked);
                ModelToCtrls(_model);
                ConfirmAddToDataBase(_model, checkShowConfirm.Checked);
            }
        }

        private void ConfirmAddToDataBase(VisaInfo model, bool showConfirm = true)
        {
            if (model == null)
                return;
            if (showConfirm)
            {
                if (MessageBoxEx.Show(Resources.WhetherAddToDatabase, Resources.Confirm, MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (_bll.Add(model))
                    {
                        LoadDataToDgvAndList(_curPage);
                        UpdateState();
                    }
                    else
                        MessageBoxEx.Show(Resources.FailedAddToDatabase);
                }
            }
            else
            {
                if (_bll.Add(model))
                {
                    LoadDataToDgvAndList(_curPage);
                    UpdateState();
                }
                else
                    MessageBoxEx.Show(Resources.FailedAddToDatabase);
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
                btnAutoReadThreadStart.Text = "■停止自动读取";
                _autoReadThreadRun = true;
                Thread th = new Thread(AutoClassAndRecognize) {IsBackground = true};
                th.Start();
            }
            else
            {
                btnAutoReadThreadStart.Text = "开始自动读取";
                _autoReadThreadRun = false;
            }
        }

        private void btnAddToDatabase_Click(object sender, EventArgs e)
        {
            _model = CtrlsToModel();
            if (model == null) 
                return;
            if (!_bll.Add(model))
            {
                MessageBoxEx.Show(Resources.FailedAddToDatabase);
                return;
            }
            LoadDataToDgvAndList(_curPage);
            UpdateState();
        }

        #endregion
        #region dgv响应

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                row.HeaderCell.Value = (i + 1).ToString(); //添加行号显示
            }
        }

        /// <summary>
        /// 单击选中行时，修改对应编辑框等项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < _pageSize)
            {
                _model = _list[e.RowIndex];
                _curIdx = e.RowIndex;
                ModelToCtrls(_model);
                LoadImageFromModel(_model);
            }
        }

        #endregion

        #region bar栏
        private void btnPageFirst_Click(object sender, EventArgs e)
        {
            _curPage = 1;
            LoadDataToDgvAndList(_curPage);
        }

        private void btnPagePre_Click(object sender, EventArgs e)
        {
            LoadDataToDgvAndList(--_curPage);
        }

        private void btnPageNext_Click(object sender, EventArgs e)
        {
            LoadDataToDgvAndList(++_curPage);

        }

        private void btnPageLast_Click(object sender, EventArgs e)
        {
            _curPage = _pageCount;
            LoadDataToDgvAndList(_curPage);
        }
        #endregion






    }
}
