using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravletAgence.BLL;
using TravletAgence.Common;

namespace TravletAgence.CSUI
{
    public partial class FrmInfoTypeIn : Form
    {

        private Model.VisaInfo _model;
        private readonly BLL.VisaInfo bll = new BLL.VisaInfo();
        private Action<int> _updateDel;
        private int _curPage;

        public FrmInfoTypeIn(Model.VisaInfo model, Action<int> updateDel,int page)
        {
            InitializeComponent();
            this._model = model;
            _updateDel = updateDel;
            _curPage = page;
            ModelToCtrls(this._model);
        }

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
        }

        private void CtrlsToModel()
        {
            if (_model == null)
                return;
            try
            {
                _model.Name = txtName.Text;
                _model.EnglishName = txtEnglishName.Text;
                _model.Sex = txtSex.Text;
                _model.IssuePlace = txtIssuePlace.Text;
                _model.Residence = txtResidence.Text;
                _model.Birthday = DateTime.Parse(txtBirthday.Text);
                _model.Occupation = txtOccupation.Text;
                _model.Identification = txtIdentification.Text;
                _model.Marriaged = txtMarrige.Text;
                _model.FinancialCapacity = txtFinancialCapacity.Text;
                _model.PassportNo = txtPassportNo.Text;
                _model.LicenceTime = DateTime.Parse(txtLicenseTime.Text);
                _model.ExpiryDate = DateTime.Parse(txtExpireDate.Text);
                _model.Birthplace = txtBirthPlace.Text;
                _model.GroupNo = txtGroupNo.Text;
                _model.DepartureRecord = txtDepartureRecord.Text; //这里应该做校验,以及给用户做成comboBox那种
            }
            catch (Exception)
            {
                MessageBox.Show("请确保日期输入信息正确!");
                return;
            }

        }
        private void FrmInfoTypeIn_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterParent; //不能写在form_load里面，是已经加载完成了
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("是否同时更新为已录入状态?", "确认", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Cancel)
                return;
            CtrlsToModel();
            if (res == DialogResult.Yes)
                _model.HasTypeIn = HasTypeIn.Yes;
            if (!bll.Update(_model))
            {
                MessageBox.Show("更新失败，请重试!");
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
