using System;
namespace TravletAgence.Model
{
	/// <summary>
	/// VisaInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class VisaInfo
	{
		public VisaInfo()
		{}
		#region Model
		private Guid _visainfo_id;
		private string _visa_id;
		private string _groupno;
		private string _name;
		private string _englishname;
		private string _sex;
		private DateTime? _birthday;
		private string _passportno;
		private DateTime? _licencetime;
		private DateTime? _expirydate;
		private string _birthplace;
		private string _issueplace;
		private string _post;
		private string _phone;
		private string _guideno;
		private string _client;
		private string _salesperson;
		private string _types;
		private Guid _sale_id;
		private Guid _departmentid;
		private string _tips;
		private DateTime? _entrytime= DateTime.Now;
		private DateTime? _embassytime;
		private DateTime? _intime;
		private DateTime? _outtime;
		private string _realout;
		private DateTime? _realouttime;
		private string _country;
		private string _call;
		/// <summary>
		/// 
		/// </summary>
		public Guid VisaInfo_id
		{
			set{ _visainfo_id=value;}
			get{return _visainfo_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Visa_id
		{
			set{ _visa_id=value;}
			get{return _visa_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GroupNo
		{
			set{ _groupno=value;}
			get{return _groupno;}
		}
		/// <summary>
		/// 姓名
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 英语姓名
		/// </summary>
		public string EnglishName
		{
			set{ _englishname=value;}
			get{return _englishname;}
		}
		/// <summary>
		/// 性别
		/// </summary>
		public string Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 生日
		/// </summary>
		public DateTime? Birthday
		{
			set{ _birthday=value;}
			get{return _birthday;}
		}
		/// <summary>
		/// 护照号
		/// </summary>
		public string PassportNo
		{
			set{ _passportno=value;}
			get{return _passportno;}
		}
		/// <summary>
		/// 发证日期
		/// </summary>
		public DateTime? LicenceTime
		{
			set{ _licencetime=value;}
			get{return _licencetime;}
		}
		/// <summary>
		/// 有效期
		/// </summary>
		public DateTime? ExpiryDate
		{
			set{ _expirydate=value;}
			get{return _expirydate;}
		}
		/// <summary>
		/// 出生地
		/// </summary>
		public string Birthplace
		{
			set{ _birthplace=value;}
			get{return _birthplace;}
		}
		/// <summary>
		/// 签发地
		/// </summary>
		public string IssuePlace
		{
			set{ _issueplace=value;}
			get{return _issueplace;}
		}
		/// <summary>
		/// 职位
		/// </summary>
		public string Post
		{
			set{ _post=value;}
			get{return _post;}
		}
		/// <summary>
		/// 电话
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 领队编号
		/// </summary>
		public string GuideNo
		{
			set{ _guideno=value;}
			get{return _guideno;}
		}
		/// <summary>
		/// 客户
		/// </summary>
		public string Client
		{
			set{ _client=value;}
			get{return _client;}
		}
		/// <summary>
		/// 销售员
		/// </summary>
		public string Salesperson
		{
			set{ _salesperson=value;}
			get{return _salesperson;}
		}
		/// <summary>
		/// 签证类型
		/// </summary>
		public string Types
		{
			set{ _types=value;}
			get{return _types;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid Sale_id
		{
			set{ _sale_id=value;}
			get{return _sale_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid DepartmentId
		{
			set{ _departmentid=value;}
			get{return _departmentid;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Tips
		{
			set{ _tips=value;}
			get{return _tips;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EntryTime
		{
			set{ _entrytime=value;}
			get{return _entrytime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EmbassyTime
		{
			set{ _embassytime=value;}
			get{return _embassytime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? InTime
		{
			set{ _intime=value;}
			get{return _intime;}
		}
		/// <summary>
		/// 归国时间
		/// </summary>
		public DateTime? OutTime
		{
			set{ _outtime=value;}
			get{return _outtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RealOut
		{
			set{ _realout=value;}
			get{return _realout;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? RealOutTime
		{
			set{ _realouttime=value;}
			get{return _realouttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Country
		{
			set{ _country=value;}
			get{return _country;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Call
		{
			set{ _call=value;}
			get{return _call;}
		}
		#endregion Model

	}
}

