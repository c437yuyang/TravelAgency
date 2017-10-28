using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using TravletAgence.Model;
namespace TravletAgence.BLL
{
	/// <summary>
	/// Visa
	/// </summary>
	public partial class Visa
	{
		private readonly TravletAgence.DAL.Visa dal=new TravletAgence.DAL.Visa();
		public Visa()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid Visa_id)
		{
			return dal.Exists(Visa_id);
		}

		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(TravletAgence.Model.Visa model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(Guid Visa_id)
		{
			
			return dal.Delete(Visa_id);
		}
		

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public TravletAgence.Model.Visa GetModel(Guid Visa_id)
		{
			
			return dal.GetModel(Visa_id);
		}

        ///// <summary>
        ///// 得到一个对象实体，从缓存中
        ///// </summary>
        //public TravletAgence.Model.Visa GetModelByCache(Guid Visa_id)
        //{
			
        //    string CacheKey = "VisaModel-" + Visa_id;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(Visa_id);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (TravletAgence.Model.Visa)objModel;
        //}

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
		public List<TravletAgence.Model.Visa> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<TravletAgence.Model.Visa> DataTableToList(DataTable dt)
		{
			List<TravletAgence.Model.Visa> modelList = new List<TravletAgence.Model.Visa>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				TravletAgence.Model.Visa model;
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

