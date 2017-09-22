using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace TravletAgence.Web.VisaInfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtVisa_id.Text.Trim().Length==0)
			{
				strErr+="Visa_id不能为空！\\n";	
			}
			if(this.txtGroupNo.Text.Trim().Length==0)
			{
				strErr+="GroupNo不能为空！\\n";	
			}
			if(this.txtName.Text.Trim().Length==0)
			{
				strErr+="姓名不能为空！\\n";	
			}
			if(this.txtEnglishName.Text.Trim().Length==0)
			{
				strErr+="英语姓名不能为空！\\n";	
			}
			if(this.txtSex.Text.Trim().Length==0)
			{
				strErr+="性别不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtBirthday.Text))
			{
				strErr+="生日格式错误！\\n";	
			}
			if(this.txtPassportNo.Text.Trim().Length==0)
			{
				strErr+="护照号不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtLicenceTime.Text))
			{
				strErr+="发证日期格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtExpiryDate.Text))
			{
				strErr+="有效期格式错误！\\n";	
			}
			if(this.txtBirthplace.Text.Trim().Length==0)
			{
				strErr+="出生地不能为空！\\n";	
			}
			if(this.txtIssuePlace.Text.Trim().Length==0)
			{
				strErr+="签发地不能为空！\\n";	
			}
			if(this.txtPost.Text.Trim().Length==0)
			{
				strErr+="职位不能为空！\\n";	
			}
			if(this.txtPhone.Text.Trim().Length==0)
			{
				strErr+="电话不能为空！\\n";	
			}
			if(this.txtGuideNo.Text.Trim().Length==0)
			{
				strErr+="领队编号不能为空！\\n";	
			}
			if(this.txtClient.Text.Trim().Length==0)
			{
				strErr+="客户不能为空！\\n";	
			}
			if(this.txtSalesperson.Text.Trim().Length==0)
			{
				strErr+="销售员不能为空！\\n";	
			}
			if(this.txtTypes.Text.Trim().Length==0)
			{
				strErr+="签证类型不能为空！\\n";	
			}
			if(this.txtTips.Text.Trim().Length==0)
			{
				strErr+="备注不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtEntryTime.Text))
			{
				strErr+="EntryTime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtEmbassyTime.Text))
			{
				strErr+="EmbassyTime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtInTime.Text))
			{
				strErr+="InTime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOutTime.Text))
			{
				strErr+="归国时间格式错误！\\n";	
			}
			if(this.txtRealOut.Text.Trim().Length==0)
			{
				strErr+="RealOut不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtRealOutTime.Text))
			{
				strErr+="RealOutTime格式错误！\\n";	
			}
			if(this.txtCountry.Text.Trim().Length==0)
			{
				strErr+="Country不能为空！\\n";	
			}
			if(this.txtCall.Text.Trim().Length==0)
			{
				strErr+="Call不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string Visa_id=this.txtVisa_id.Text;
			string GroupNo=this.txtGroupNo.Text;
			string Name=this.txtName.Text;
			string EnglishName=this.txtEnglishName.Text;
			string Sex=this.txtSex.Text;
			DateTime Birthday=DateTime.Parse(this.txtBirthday.Text);
			string PassportNo=this.txtPassportNo.Text;
			DateTime LicenceTime=DateTime.Parse(this.txtLicenceTime.Text);
			DateTime ExpiryDate=DateTime.Parse(this.txtExpiryDate.Text);
			string Birthplace=this.txtBirthplace.Text;
			string IssuePlace=this.txtIssuePlace.Text;
			string Post=this.txtPost.Text;
			string Phone=this.txtPhone.Text;
			string GuideNo=this.txtGuideNo.Text;
			string Client=this.txtClient.Text;
			string Salesperson=this.txtSalesperson.Text;
			string Types=this.txtTypes.Text;
			string Tips=this.txtTips.Text;
			DateTime EntryTime=DateTime.Parse(this.txtEntryTime.Text);
			DateTime EmbassyTime=DateTime.Parse(this.txtEmbassyTime.Text);
			DateTime InTime=DateTime.Parse(this.txtInTime.Text);
			DateTime OutTime=DateTime.Parse(this.txtOutTime.Text);
			string RealOut=this.txtRealOut.Text;
			DateTime RealOutTime=DateTime.Parse(this.txtRealOutTime.Text);
			string Country=this.txtCountry.Text;
			string Call=this.txtCall.Text;

			TravletAgence.Model.VisaInfo model=new TravletAgence.Model.VisaInfo();
			model.Visa_id=Visa_id;
			model.GroupNo=GroupNo;
			model.Name=Name;
			model.EnglishName=EnglishName;
			model.Sex=Sex;
			model.Birthday=Birthday;
			model.PassportNo=PassportNo;
			model.LicenceTime=LicenceTime;
			model.ExpiryDate=ExpiryDate;
			model.Birthplace=Birthplace;
			model.IssuePlace=IssuePlace;
			model.Post=Post;
			model.Phone=Phone;
			model.GuideNo=GuideNo;
			model.Client=Client;
			model.Salesperson=Salesperson;
			model.Types=Types;
			model.Tips=Tips;
			model.EntryTime=EntryTime;
			model.EmbassyTime=EmbassyTime;
			model.InTime=InTime;
			model.OutTime=OutTime;
			model.RealOut=RealOut;
			model.RealOutTime=RealOutTime;
			model.Country=Country;
			model.Call=Call;

			TravletAgence.BLL.VisaInfo bll=new TravletAgence.BLL.VisaInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
