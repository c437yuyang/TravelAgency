using System;
namespace TravelAgency.Model
{
	/// <summary>
	/// Visa:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Visa
	{
		public Visa()
		{}
		#region Model
		private Guid _visa_id;
		private string _groupno;
		private string _name;
		private string _types;
		private string _tips;
		private DateTime? _predicttime;
		private DateTime? _realtime;
		private DateTime? _finishtime;
		private string _satus;
		private string _person;
		private int? _number;
		private decimal? _picture;
		private decimal? _listcount;
		private string _list;
		private string _salesperson;
		private decimal? _receipt;
		private decimal? _quidco;
		private decimal? _cost;
		private decimal? _othercost;
		private string _expressno;
		private string _call;
		private Guid _sale_id;
		private Guid _departmentid;
		private DateTime? _entrytime= DateTime.Now;
		private string _country;
		private string _passengers;
		private string _workid;
		private string _documenter;
		private decimal? _price;
		private decimal? _consulatecost;
		private decimal? _visapersoncost;
		private decimal? _mailcost;
		private string _tips2;
		private int? _submitflag;
		private decimal? _groupprice;
		private decimal? _invitationcost;
		private string _remark;
		private DateTime? _submittime;
		private DateTime? _intime;
		private DateTime? _outtime;
		private string _client;
		private string _departuretype;
		private string _submitcondition;
		private string _fetchcondition;
		private string _typeinperson;
		private string _checkperson;
		private bool _isurgent;
		/// <summary>
		/// 
		/// </summary>
		public Guid Visa_id
		{
			set{ _visa_id=value;}
			get{return _visa_id;}
		}
		/// <summary>
		/// 团号
		/// </summary>
		public string GroupNo
		{
			set{ _groupno=value;}
			get{return _groupno;}
		}
		/// <summary>
		/// 姓名(客人姓名/领队姓名)
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 签证类型(团签\个签\其他)
		/// </summary>
		public string Types
		{
			set{ _types=value;}
			get{return _types;}
		}
		/// <summary>
		/// 对团签个签进行备注说明.比如做单次、三年、五年
		/// </summary>
		public string Tips
		{
			set{ _tips=value;}
			get{return _tips;}
		}
		/// <summary>
		/// 预计送签时间
		/// </summary>
		public DateTime? PredictTime
		{
			set{ _predicttime=value;}
			get{return _predicttime;}
		}
		/// <summary>
		/// 实际送签时间
		/// </summary>
		public DateTime? RealTime
		{
			set{ _realtime=value;}
			get{return _realtime;}
		}
		/// <summary>
		/// 出签时间
		/// </summary>
		public DateTime? FinishTime
		{
			set{ _finishtime=value;}
			get{return _finishtime;}
		}
		/// <summary>
		/// 办理签证的状态
		/// </summary>
		public string Satus
		{
			set{ _satus=value;}
			get{return _satus;}
		}
		/// <summary>
		/// 送签社担当
		/// </summary>
		public string Person
		{
			set{ _person=value;}
			get{return _person;}
		}
		/// <summary>
		/// 人数
		/// </summary>
		public int? Number
		{
			set{ _number=value;}
			get{return _number;}
		}
		/// <summary>
		/// 洗照片
		/// </summary>
		public decimal? Picture
		{
			set{ _picture=value;}
			get{return _picture;}
		}
		/// <summary>
		/// 出境名单费用
		/// </summary>
		public decimal? ListCount
		{
			set{ _listcount=value;}
			get{return _listcount;}
		}
		/// <summary>
		/// 出境名单社
		/// </summary>
		public string List
		{
			set{ _list=value;}
			get{return _list;}
		}
		/// <summary>
		/// 销售人员姓名
		/// </summary>
		public string SalesPerson
		{
			set{ _salesperson=value;}
			get{return _salesperson;}
		}
		/// <summary>
		/// 收款
		/// </summary>
		public decimal? Receipt
		{
			set{ _receipt=value;}
			get{return _receipt;}
		}
		/// <summary>
		/// 返款
		/// </summary>
		public decimal? Quidco
		{
			set{ _quidco=value;}
			get{return _quidco;}
		}
		/// <summary>
		/// 签证成本
		/// </summary>
		public decimal? Cost
		{
			set{ _cost=value;}
			get{return _cost;}
		}
		/// <summary>
		/// 杂费
		/// </summary>
		public decimal? OtherCost
		{
			set{ _othercost=value;}
			get{return _othercost;}
		}
		/// <summary>
		/// 快递号
		/// </summary>
		public string ExpressNo
		{
			set{ _expressno=value;}
			get{return _expressno;}
		}
		/// <summary>
		/// 是否归国回访
		/// </summary>
		public string Call
		{
			set{ _call=value;}
			get{return _call;}
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
		public string Country
		{
			set{ _country=value;}
			get{return _country;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Passengers
		{
			set{ _passengers=value;}
			get{return _passengers;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WorkId
		{
			set{ _workid=value;}
			get{return _workid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Documenter
		{
			set{ _documenter=value;}
			get{return _documenter;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ConsulateCost
		{
			set{ _consulatecost=value;}
			get{return _consulatecost;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? VisaPersonCost
		{
			set{ _visapersoncost=value;}
			get{return _visapersoncost;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? MailCost
		{
			set{ _mailcost=value;}
			get{return _mailcost;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Tips2
		{
			set{ _tips2=value;}
			get{return _tips2;}
		}
		/// <summary>
		/// 提交给财务后是1  未提交为0
		/// </summary>
		public int? SubmitFlag
		{
			set{ _submitflag=value;}
			get{return _submitflag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? GroupPrice
		{
			set{ _groupprice=value;}
			get{return _groupprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? InvitationCost
		{
			set{ _invitationcost=value;}
			get{return _invitationcost;}
		}
		/// <summary>
		/// 备注:如一家人
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 交资料时间
		/// </summary>
		public DateTime? SubmitTime
		{
			set{ _submittime=value;}
			get{return _submittime;}
		}
		/// <summary>
		/// 客人人境时间
		/// </summary>
		public DateTime? InTime
		{
			set{ _intime=value;}
			get{return _intime;}
		}
		/// <summary>
		/// 客人出境时间
		/// </summary>
		public DateTime? OutTime
		{
			set{ _outtime=value;}
			get{return _outtime;}
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
		/// 出境类型:如三年多往，五年多往
		/// </summary>
		public string DepartureType
		{
			set{ _departuretype=value;}
			get{return _departuretype;}
		}
		/// <summary>
		/// 外领送签条件
		/// </summary>
		public string SubmitCondition
		{
			set{ _submitcondition=value;}
			get{return _submitcondition;}
		}
		/// <summary>
		/// 客人取签方式
		/// </summary>
		public string FetchCondition
		{
			set{ _fetchcondition=value;}
			get{return _fetchcondition;}
		}
		/// <summary>
		/// 录入人员
		/// </summary>
		public string TypeInPerson
		{
			set{ _typeinperson=value;}
			get{return _typeinperson;}
		}
		/// <summary>
		/// 审查人员
		/// </summary>
		public string CheckPerson
		{
			set{ _checkperson=value;}
			get{return _checkperson;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsUrgent
		{
			set{ _isurgent=value;}
			get{return _isurgent;}
		}
		#endregion Model

	}
}

