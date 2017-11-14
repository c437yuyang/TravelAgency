using System;
using System.CodeDom;
using System.Reflection;

namespace TravletAgence.Model
{
    public partial class VisaInfo_Tmp
    {
        public void CopyToVisaInfo(VisaInfo model)
        {
            model.VisaInfo_id = this.VisaInfo_id;
            model.Visa_id = this.Visa_id;
            model.GroupNo = this.GroupNo;
            model.Name = this.Name;
            model.EnglishName = this.EnglishName;
            model.Sex = this.Sex;
            model.Birthday = this.Birthday;
            model.PassportNo = this.PassportNo;
            model.LicenceTime = this.LicenceTime;
            model.ExpiryDate = this.ExpiryDate;
            model.Birthplace = this.Birthplace;
            model.IssuePlace = this.IssuePlace;
            model.Post = this.Post;
            model.Phone = this.Phone;
            model.GuideNo = this.GuideNo;
            model.Client = this.Client;
            model.Salesperson = this.Salesperson;
            model.Types = this.Types;
            model.Sale_id = this.Sale_id;
            model.DepartmentId = this.DepartmentId;
            model.Tips = this.Tips;
            model.EntryTime = this.EntryTime;
            model.EmbassyTime = this.EmbassyTime;
            model.InTime = this.InTime;
            model.OutTime = this.OutTime;
            model.RealOut = this.RealOut;
            model.RealOutTime = this.RealOutTime;
            model.Country = this.Country;
            model.Call = this.Call;
            model.outState = this.outState;
            model.Residence = this.Residence;
            model.Occupation = this.Occupation;
            model.DepartureRecord = this.DepartureRecord;
            model.Marriaged = this.Marriaged;
            model.Identification = this.Identification;
            model.FinancialCapacity = this.FinancialCapacity;
            model.AgencyOpinion = this.AgencyOpinion;
            model.HasTypeIn = this.HasTypeIn;
            model.AbnormalOutTime = this.AbnormalOutTime;
            model.HasChecked = this.HasChecked;
            model.CheckPerson = this.CheckPerson;
        }
    }
}