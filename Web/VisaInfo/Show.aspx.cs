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
namespace TravletAgence.Web.VisaInfo
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					Guid VisaInfo_id=new Guid(strid);
					ShowInfo(VisaInfo_id);
				}
			}
		}
		
	private void ShowInfo(Guid VisaInfo_id)
	{
		TravletAgence.BLL.VisaInfo bll=new TravletAgence.BLL.VisaInfo();
		TravletAgence.Model.VisaInfo model=bll.GetModel(VisaInfo_id);
		this.lblVisaInfo_id.Text=model.VisaInfo_id.ToString();
		this.lblVisa_id.Text=model.Visa_id;
		this.lblGroupNo.Text=model.GroupNo;
		this.lblName.Text=model.Name;
		this.lblEnglishName.Text=model.EnglishName;
		this.lblSex.Text=model.Sex;
		this.lblBirthday.Text=model.Birthday.ToString();
		this.lblPassportNo.Text=model.PassportNo;
		this.lblLicenceTime.Text=model.LicenceTime.ToString();
		this.lblExpiryDate.Text=model.ExpiryDate.ToString();
		this.lblBirthplace.Text=model.Birthplace;
		this.lblIssuePlace.Text=model.IssuePlace;
		this.lblPost.Text=model.Post;
		this.lblPhone.Text=model.Phone;
		this.lblGuideNo.Text=model.GuideNo;
		this.lblClient.Text=model.Client;
		this.lblSalesperson.Text=model.Salesperson;
		this.lblTypes.Text=model.Types;
		this.lblSale_id.Text=model.Sale_id.ToString();
		this.lblDepartmentId.Text=model.DepartmentId.ToString();
		this.lblTips.Text=model.Tips;
		this.lblEntryTime.Text=model.EntryTime.ToString();
		this.lblEmbassyTime.Text=model.EmbassyTime.ToString();
		this.lblInTime.Text=model.InTime.ToString();
		this.lblOutTime.Text=model.OutTime.ToString();
		this.lblRealOut.Text=model.RealOut;
		this.lblRealOutTime.Text=model.RealOutTime.ToString();
		this.lblCountry.Text=model.Country;
		this.lblCall.Text=model.Call;

	}


    }
}
