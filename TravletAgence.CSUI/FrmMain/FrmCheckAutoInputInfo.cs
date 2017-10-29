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
using TravletAgence.Common.Enums;
using TravletAgence.CSUI.Properties;
using TravletAgence.Model;

namespace TravletAgence.CSUI.FrmMain
{
    public partial class FrmCheckAutoInputInfo : Form
    {
        private Model.VisaInfo _model;
        private List<Model.VisaInfo> _list;
        private BLL.VisaInfo _bll = new BLL.VisaInfo();
        private int _curPage = 1;
        private int _curIdx = 0;
        private int _pageSize = 20;

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

        private VisaInfo CtrlsToModel(TravletAgence.Model.VisaInfo model)
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
            }
            catch (Exception)
            {
                MessageBoxEx.Show(Resources.PleaseCheckDateTimeFormat);
                return null;
            }
            return model;
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

        private void GetNextModel()
        {
            if (++_curIdx >= _pageSize)
            {
                ++_curPage;
                _list = _bll.GetListByPageOrderByHasChecked(_curPage, _pageSize);
                _curIdx = 0;
            }
            _model = _list[_curIdx];
            btnPre.Enabled = true;
        }

        private void GetPreModel()
        {
            if (--_curIdx < 0)
            {
                if (--_curPage < 1) //当前就是第1个
                {
                    _curPage = 1;
                    _curIdx = 0;
                    btnPre.Enabled = false;
                    return;
                }
                _list = _bll.GetListByPageOrderByHasChecked(_curPage, _pageSize);
                _curIdx = _pageSize - 1;
            }
            if (_curIdx == 0 && _curPage == 1)
                btnPre.Enabled = false;
            _model = _list[_curIdx];
        }

        public void LoadDataToDataGridView(int page) //刷新后保持选中
        {
            dataGridView1.DataSource = _bll.GetListByPageOrderByGroupNo(page, _pageSize);
            dataGridView1.CurrentCell = dataGridView1.Rows[_curIdx].Cells[0];
            dataGridView1.Update();
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
            _model.HasChecked = Common.Enums.HasChecked.Yes;
            _model.CheckPerson = txtCheckPerson.Text;
            if (!_bll.Update(_model))
            {
                MessageBoxEx.Show(Resources.FailedUpdateVisaInfoState);
            }
            else
            {
                MessageBoxEx.Show("保存成功!");
                LoadDataToDataGridView(_curPage);
            }
        }

        /// <summary>
        /// 这个按钮只用来修改录入的信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            CtrlsToModel(_model);
            //_model.HasChecked = Common.Enums.HasChecked.Yes;
            //_model.CheckPerson = txtCheckPerson.Text;
            if (!_bll.Update(_model))
            {
                MessageBoxEx.Show(Resources.FailedUpdateVisaInfoState);
            }
            else
            {
                MessageBoxEx.Show("信息保存成功!");
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            GetPreModel();
            ModelToCtrls(_model);
            LoadImageFromModel(_model);
            LoadDataToDataGridView(_curPage);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            GetNextModel();
            ModelToCtrls(_model);
            LoadImageFromModel(_model);
            LoadDataToDataGridView(_curPage);
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
            }
        }

        #endregion








    }
}
