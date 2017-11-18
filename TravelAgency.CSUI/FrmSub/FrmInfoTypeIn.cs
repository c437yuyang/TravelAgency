using System;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using TravelAgency.Common;
using TravelAgency.Common.Enums;
using TravelAgency.CSUI.Properties;

namespace TravelAgency.CSUI.FrmSub
{
    public partial class FrmInfoTypeIn : Form
    {

        private readonly Model.VisaInfo _model; //readonly本身是修饰的这个引用，只要后面(构造函数之外)不再重新new来指向另外的对象即可
        private readonly BLL.VisaInfo bll = new BLL.VisaInfo();
        private readonly Action<int> _updateDel; //副界面传来更新数据库的委托
        private readonly int _curPage; //主界面更新数据库需要一个当前页

        public FrmInfoTypeIn(Model.VisaInfo model, Action<int> updateDel, int page)
        {
            this.StartPosition = FormStartPosition.CenterParent; //不能写在form_load里面，是已经加载完成了
            InitializeComponent();
            this._model = model;
            _updateDel = updateDel;
            _curPage = page;
            
        }

        private void FrmInfoTypeIn_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //this.pictureBox1.MouseWheel += pictureBox1_MouseWheel;
            this.txtGroupNo.Enabled = false;
            ModelToCtrls(this._model);
            LoadImageFromModel(_model);
            SetLabelStates();
        }

        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {

        
        }

        #region 状态更新函数
        private void ModelToCtrls(Model.VisaInfo model)
        {
            if (model == null)
                return;

            txtName.Text = model.Name;
            txtEnglishName.Text = model.EnglishName;
            txtSex.Text = model.Sex;
            txtIssuePlace.Text = model.IssuePlace;
            txtResidence.Text = model.Residence;
            txtBirthday.Text = DateTimeFormator.DateTimeToString(model.Birthday);
            txtOccupation.Text = model.Occupation;
            txtMarrige.Text = model.Marriaged;
            txtIdentification.Text = model.Identification;
            txtFinancialCapacity.Text = model.FinancialCapacity;
            txtPassportNo.Text = model.PassportNo;
            txtLicenseTime.Text = DateTimeFormator.DateTimeToString(model.LicenceTime);
            txtExpireDate.Text = DateTimeFormator.DateTimeToString(model.ExpiryDate);
            txtBirthPlace.Text = model.Birthplace;
            txtGroupNo.Text = model.GroupNo;
            txtDepartureRecord.Text = model.DepartureRecord;

            txtPhone.Text = model.Phone;
            txtClient.Text = model.Client;
            txtSalesPerson.Text = model.Salesperson;
            
        }

        /// <summary>
        /// 这里不让修改团号
        /// </summary>
        private void CtrlsToModel()
        {
            if (_model == null)
                return;
            try
            {
                //会出错的放到前面
                if (txtPhone.Text.Length > 11)
                {
                    MessageBoxEx.Show("手机号码不能多于11位!");
                    return;
                }
                _model.Phone = txtPhone.Text;

                _model.Birthday = DateTime.Parse(txtBirthday.Text);
                _model.LicenceTime = DateTime.Parse(txtLicenseTime.Text);
                _model.ExpiryDate = DateTime.Parse(txtExpireDate.Text);

                _model.Name = txtName.Text;
                _model.EnglishName = txtEnglishName.Text;
                _model.Sex = txtSex.Text;
                _model.IssuePlace = txtIssuePlace.Text;
                _model.Residence = txtResidence.Text;
                _model.Occupation = txtOccupation.Text;
                _model.Identification = txtIdentification.Text;
                _model.Marriaged = txtMarrige.Text;
                _model.FinancialCapacity = txtFinancialCapacity.Text;
                _model.PassportNo = txtPassportNo.Text;
                _model.Birthplace = txtBirthPlace.Text;
                _model.GroupNo = txtGroupNo.Text;
                _model.DepartureRecord = txtDepartureRecord.Text; //这里应该做校验,以及给用户做成comboBox那种
            }
            catch (Exception)
            {
                MessageBoxEx.Show("请确保日期输入信息正确!");
                return;
            }

        }

        private void LoadImageFromModel(Model.VisaInfo model)
        {
            if (model == null)
            {
                pictureBox1.Image = Resources.PassportPictureNotFound;
                return;
            }

            if (!PassportPicHandler.CheckAndDownloadIfNotExist(model.PassportNo, PassportPicHandler.PicType.Type01Normal))
            {
                pictureBox1.Image = Resources.PassportPictureNotFound;
                return;
            }
            pictureBox1.Image = Image.FromFile(GlobalUtils.PassportPicPath + "\\" + model.PassportNo + ".jpg");

        }

        private void SetLabelStates()
        {
            if (!string.IsNullOrEmpty(_model.EntryTime.ToString()))
                lbTimeTypeIn.Text = _model.EntryTime.ToString();
            lbPersonTypeIn.Text = "";
            lbTimeCheck.Text = "";
            if (!string.IsNullOrEmpty(_model.CheckPerson))
                lbPersonCheck.Text = _model.CheckPerson;

            //if(!string.IsNullOrEmpty(_model.Salesperson))

        }


        #endregion







        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBoxEx.Show("是否同时更新为已录入状态?", "确认", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Cancel)
                return;
            CtrlsToModel();
            if (res == DialogResult.Yes)
                _model.HasTypeIn = HasTypeIn.Yes;
            if (!bll.Update(_model))
            {
                MessageBoxEx.Show("更新失败，请重试!");
                return;
            }
            _updateDel(_curPage);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }




    }
}
