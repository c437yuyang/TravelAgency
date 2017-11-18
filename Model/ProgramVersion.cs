using System;
namespace TravelAgency.Model
{
	/// <summary>
	/// ProgramVersion:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ProgramVersion
	{
		public ProgramVersion()
		{}
		#region Model
		private int _id;
		private decimal? _version;
		private string _update_files;
		private string _udapte_details;
		private string _version_name;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 对应实际的版本
		/// </summary>
		public decimal? version
		{
			set{ _version=value;}
			get{return _version;}
		}
		/// <summary>
		/// 需要更新的文件名，用|分开
		/// </summary>
		public string update_files
		{
			set{ _update_files=value;}
			get{return _update_files;}
		}
		/// <summary>
		/// 更新的细则
		/// </summary>
		public string udapte_details
		{
			set{ _udapte_details=value;}
			get{return _udapte_details;}
		}
		/// <summary>
		/// 对应显示在程序上的版本
		/// </summary>
		public string version_name
		{
			set{ _version_name=value;}
			get{return _version_name;}
		}
		#endregion Model

	}
}

