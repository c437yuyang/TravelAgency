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
            picPassportNo.SizeMode = PictureBoxSizeMode.Zoom;
            btnPre.Enabled = false;
            dgvWait4Check.AutoGenerateColumns = false; //dgv初始化
            dgvWait4Check.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvWait4Check.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWait4Check.MultiSelect = false;
            txtCheckPerson.Text = GlobalInfo.LoginUser.UserName; //初始化操作员
            txtCheckPerson.Enabled = false;

            //加载数据（list和dgv的数据都在这里面）,会加载之前还没有进行校验的那些VisaInfo
            LoadDataToDgvAndList();

            //初始化bar栏及按钮状态及图片控件
            UpdateState();

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
                //picPassportNo.Image = Image.FromFile("G49457929" + ".jpg");
            }
            else
                picPassportNo.Image = Resources.PassportPictureNotFound;
        }

        /// <summary>
        /// 更新list以及dgv里的数据
        /// </summary>
        /// <param name="page"></param>
        public void LoadDataToDgvAndList() //刷新后保持选中
        {
            _list = _bll.GetModelList(" HasChecked = '" + Common.Enums.HasChecked.No + "' "); //里面的DataTableToList保证了不会是null,只可能是空的list
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = _list;
            //if (_list.Count > 0)
            //    dataGridView1.CurrentCell = dataGridView1.Rows[_curIdx].Cells[0]; //每次录入后刷新当前选中项为新录入的
            //dataGridView1.Update();
        }


        /// <summary>
        /// 根据curIdx更新标签，待检查数量，_model,picbox,ctrls,dgv显示
        /// </summary>
        public void UpdateState()
        {
            _recordCount = _list.Count;
            if (_curIdx == 0)
                btnPre.Enabled = false;
            else
                btnPre.Enabled = true;
            if (_curIdx == _recordCount - 1)
                btnNext.Enabled = false;
            else
                btnNext.Enabled = true;

            lbRecordCount.Text = "待校验信息:" + _recordCount + "条.";
            if (_list.Count > _curIdx)
            {
                _model = _list[_curIdx];
                ModelToCtrls(_model);
                LoadImageFromModel(_model);
            }

            //更新dgv显示

            int curSelectedCol = -1; //保持列选中，有点问题还
            if (dgvWait4Check.SelectedCells.Count > 0)
                curSelectedCol = dgvWait4Check.SelectedCells[0].ColumnIndex;

            dgvWait4Check.DataSource = null;
            if (_list != null && _list.Count > 0) //这里必须判断count大于0，不然有bug,参见https://www.cnblogs.com/seasons1987/p/3513135.html
                dgvWait4Check.DataSource = _list;
            if (_recordCount == 0)
                return;
            if (curSelectedCol != -1 && dgvWait4Check.Rows.Count > _curIdx)
                dgvWait4Check.CurrentCell = dgvWait4Check.Rows[_curIdx].Cells[curSelectedCol];
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
            if (_model == null)
                return;
            _model.HasChecked = Common.Enums.HasChecked.Yes;
            _model.CheckPerson = txtCheckPerson.Text;
            UpdateState();
        }

        /// <summary>
        /// 保存当前页的所有状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            bool HasDataNotChecked = false;
            for (int i = 0; i < _list.Count; i++)
            {
                if (_list[i].HasChecked == Common.Enums.HasChecked.No)
                {
                    HasDataNotChecked = true;
                    break;
                }
            }

            if (HasDataNotChecked && MessageBoxEx.Show("还有数据未校验，保存修改将会丢失，是否继续?", "提示", MessageBoxButtons.YesNo) == DialogResult.No)
                return;


            //保存修改
            int res = 0;
            for (int i = 0; i < _list.Count; i++)
            {
                if (_list[i].HasChecked == Common.Enums.HasChecked.Yes)
                {
                    if (string.IsNullOrEmpty(_list[i].VisaInfo_id.ToString())) //不存在的数据（新录入的）执行添加
                        res += _bll.Add(_list[i]) ? 1 : 0;
                    else res += _bll.Update(_list[i]) ? 1 : 0; //以前存在的但是没校验的执行update
                }

            }
            MessageBoxEx.Show(res + "条记录更新成功.");
            //重新从数据库加载数据
            LoadDataToDgvAndList();
            _curIdx = 0;
            UpdateState();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            --_curIdx;
            UpdateState();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ++_curIdx;
            UpdateState();
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
            VisaInfo model = _idCard.RecogoInfo(txtPicPath.Text, checkRegSucShowDlg.Checked);
            if (model == null)
                return;
            //读取成功了
            _list.Insert(0, model);
            _curIdx = 0;
            UpdateState();
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
                Model.VisaInfo model = _idCard.AutoClassAndRecognize(this.txtPicPath.Text, checkRegSucShowDlg.Checked);
                if (model != null)
                {
                    _list.Insert(0, model);
                    _curIdx = 0;
                    UpdateState();
                }
            }
        }

        //private void ConfirmAddToDataBase(VisaInfo model, bool showConfirm = true)
        //{
        //    if (model == null)
        //        return;
        //    if (showConfirm)
        //    {
        //        if (MessageBoxEx.Show(Resources.WhetherAddToDatabase, Resources.Confirm, MessageBoxButtons.OKCancel) == DialogResult.OK)
        //        {
        //            if (_bll.Add(model))
        //            {
        //                LoadDataToDgvAndList();
        //                UpdateState();
        //            }
        //            else
        //                MessageBoxEx.Show(Resources.FailedAddToDatabase);
        //        }
        //    }
        //    else
        //    {
        //        if (_bll.Add(model))
        //        {
        //            LoadDataToDgvAndList();
        //            UpdateState();
        //        }
        //        else
        //            MessageBoxEx.Show(Resources.FailedAddToDatabase);
        //    }
        //}

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
                Thread th = new Thread(AutoClassAndRecognize) { IsBackground = true };
                th.Start();
            }
            else
            {
                btnAutoReadThreadStart.Text = "开始自动读取";
                _autoReadThreadRun = false;
            }
        }

        /// <summary>
        /// 手动添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddToDatabase_Click(object sender, EventArgs e)
        {
            Model.VisaInfo model = CtrlsToModel();
            if (model == null)
                return;

            _list.Insert(0, model);
            _curIdx = 0;
            UpdateState();
        }

        #endregion
        #region dgv响应

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgvWait4Check.Rows.Count; i++)
            {
                DataGridViewRow row = dgvWait4Check.Rows[i];
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
            if (e.RowIndex >= 0 && e.RowIndex < _recordCount)
            {
                _curIdx = e.RowIndex;
                UpdateState();
            }
        }

        #endregion

        #region bar栏
        //private void btnPageFirst_Click(object sender, EventArgs e)
        //{
        //    _curPage = 1;
        //    LoadDataToDgvAndList(_curPage);
        //}

        //private void btnPagePre_Click(object sender, EventArgs e)
        //{
        //    LoadDataToDgvAndList(--_curPage);
        //}

        //private void btnPageNext_Click(object sender, EventArgs e)
        //{
        //    LoadDataToDgvAndList(++_curPage);

        //}

        //private void btnPageLast_Click(object sender, EventArgs e)
        //{
        //    _curPage = _pageCount;
        //    LoadDataToDgvAndList(_curPage);
        //}
        #endregion






    }
}
