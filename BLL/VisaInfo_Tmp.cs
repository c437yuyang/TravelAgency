﻿using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using TravletAgence.Model;
namespace TravletAgence.BLL
{
	/// <summary>
	/// VisaInfo_Tmp
	/// </summary>
	public partial class VisaInfo_Tmp
	{
		private readonly TravletAgence.DAL.VisaInfo_Tmp dal=new TravletAgence.DAL.VisaInfo_Tmp();
		public VisaInfo_Tmp()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid VisaInfo_id)
		{
			return dal.Exists(VisaInfo_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TravletAgence.Model.VisaInfo_Tmp model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(TravletAgence.Model.VisaInfo_Tmp model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(Guid VisaInfo_id)
		{
			
			return dal.Delete(VisaInfo_id);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public TravletAgence.Model.VisaInfo_Tmp GetModel(Guid VisaInfo_id)
		{
			
			return dal.GetModel(VisaInfo_id);
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<TravletAgence.Model.VisaInfo_Tmp> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<TravletAgence.Model.VisaInfo_Tmp> DataTableToList(DataTable dt)
		{
			List<TravletAgence.Model.VisaInfo_Tmp> modelList = new List<TravletAgence.Model.VisaInfo_Tmp>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				TravletAgence.Model.VisaInfo_Tmp model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}
