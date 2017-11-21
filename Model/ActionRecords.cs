using System;
namespace TravelAgency.Model
{
	/// <summary>
	/// ActionRecords:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ActionRecords
	{
		public ActionRecords()
		{}
		#region Model
		private int _id;
		private string _acttype;
		private string _workid;
		private string _username;
		private Guid _visainfo_id;
		private Guid _visa_id;
		private string _type;
		private DateTime? _entrytime;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ActType
		{
			set{ _acttype=value;}
			get{return _acttype;}
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
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
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
		public Guid Visa_id
		{
			set{ _visa_id=value;}
			get{return _visa_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EntryTime
		{
			set{ _entrytime=value;}
			get{return _entrytime;}
		}
		#endregion Model

	}
}

