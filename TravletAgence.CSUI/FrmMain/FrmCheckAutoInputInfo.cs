using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using TravletAgence.Common;
using TravletAgence.Common.Enums;
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

        public FrmCheckAutoInputInfo()
        {
            _list = _bll.GetListByPageOrderByHasChecked(_curPage, _pageSize); //每次取30条吧
            _model = _list[_curIdx]; //如果没有指定model加载，就直接找第一个
            InitializeComponent();
        }

        public FrmCheckAutoInputInfo(Model.VisaInfo model)
        {
            _model = model;
            _list = _bll.GetListByPageOrderByHasChecked(_curPage, _pageSize); //每次取30条吧
            InitializeComponent();
        }

        private void FrmCheckAutoInputInfo_Load(object sender, EventArgs e)
        {
            this.picPassportNo.SizeMode = PictureBoxSizeMode.Zoom;
            //picPassportNo.Image = Image.FromFile("E68526741.jpg");
            btnPre.Enabled = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            //初始化操作员
            txtCheckPerson.Text = GlobalInfo.LoginUser.UserName;
            txtCheckPerson.Enabled = false;

            //初始化数据信息
            ModelToCtrls(_model);

            //加载图片
            LoadImageFromModel(_model);

            //加载数据
            LoadDataToDataGridView(_curPage);

        }

        #region 状态更新函数
        private void ModelToCtrls(TravletAgence.Model.VisaInfo model)
        {
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

        private bool CtrlsToModel(TravletAgence.Model.VisaInfo model)
        {
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
                return true;
            }
            catch (Exception)
            {
                MessageBoxEx.Show(Resources.PleaseCheckDateTimeFormat);
                return false;
            }
        }

        private void LoadImageFromModel(Model.VisaInfo model)
        {
            if (File.Exists(model.PassportNo + ".jpg"))
            {
                picPassportNo.Image = Image.FromFile(model.PassportNo + ".jpg");
            }
            else
                picPassportNo.Image = Resources.PassportPictureNotFound;
        }

        public void LoadDataToDataGridView(int page) //刷新后保持选中
        {
            //更新list以及dgv里的数据
            _list = _bll.GetListByPageOrderByHasChecked(page, _pageSize);

            dataGridView1.DataSource = _list;
            dataGridView1.CurrentCell = dataGridView1.Rows[_curIdx].Cells[0];
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

        private void UpdateState()
        {
            //_recordCount = bll.GetRecordCount(string.Empty);
            //_pageCount = (int)Math.Ceiling((double)_recordCount / (double)_pageSize);
            if (_curIdx == 0)
                btnPre.Enabled = false;
            else
                btnPre.Enabled = true;
            if (_curIdx == _pageSize - 1)
                btnNext.Enabled = false;
            else
                btnNext.Enabled = true;

            ////lbRecordCount.Text = "当前为第:" + Convert.ToInt32(_curPage)
            ////                + "页,共" + Convert.ToInt32(_pageCount) + "页,每页共" + _pageSize + "条.";
            //lbRecordCount.Text = "共有记录:" + _recordCount + "条";
            //lbCurPage.Text = "当前为第" + _curPage + "页";
        }

        #endregion



        #region 按钮点击事件
        /// <summary>
        /// 用来确认标志校验完毕的按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNoFault_Click(object sender, EventArgs e)
        {
            //修改Model
            if (!CtrlsToModel(_model))
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
            LoadDataToDataGridView(_curPage);

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
        #endregion






        #region dgv响应
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                row.HeaderCell.Value = (i + 1).ToString();
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








    }
}
