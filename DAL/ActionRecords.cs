using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TravelAgency.DAL
{
	/// <summary>
	/// 数据访问类:ActionRecords
	/// </summary>
	public partial class ActionRecords
	{
		public ActionRecords()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "ActionRecords"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ActionRecords");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(TravelAgency.Model.ActionRecords model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ActionRecords(");
			strSql.Append("ActType,WorkId,UserName,VisaInfo_id,Visa_id,Type,EntryTime)");
			strSql.Append(" values (");
			strSql.Append("@ActType,@WorkId,@UserName,@VisaInfo_id,@Visa_id,@Type,@EntryTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ActType", SqlDbType.VarChar,50),
					new SqlParameter("@WorkId", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,100),
					new SqlParameter("@VisaInfo_id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@Visa_id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@Type", SqlDbType.VarChar,50),
					new SqlParameter("@EntryTime", SqlDbType.DateTime)};
			parameters[0].Value = model.ActType;
			parameters[1].Value = model.WorkId;
			parameters[2].Value = model.UserName;
			parameters[3].Value = Guid.NewGuid();
			parameters[4].Value = Guid.NewGuid();
			parameters[5].Value = model.Type;
			parameters[6].Value = model.EntryTime;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(TravelAgency.Model.ActionRecords model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ActionRecords set ");
			strSql.Append("ActType=@ActType,");
			strSql.Append("WorkId=@WorkId,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("VisaInfo_id=@VisaInfo_id,");
			strSql.Append("Visa_id=@Visa_id,");
			strSql.Append("Type=@Type,");
			strSql.Append("EntryTime=@EntryTime");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@ActType", SqlDbType.VarChar,50),
					new SqlParameter("@WorkId", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,100),
					new SqlParameter("@VisaInfo_id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@Visa_id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@Type", SqlDbType.VarChar,50),
					new SqlParameter("@EntryTime", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.ActType;
			parameters[1].Value = model.WorkId;
			parameters[2].Value = model.UserName;
			parameters[3].Value = model.VisaInfo_id;
			parameters[4].Value = model.Visa_id;
			parameters[5].Value = model.Type;
			parameters[6].Value = model.EntryTime;
			parameters[7].Value = model.id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ActionRecords ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ActionRecords ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public TravelAgency.Model.ActionRecords GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,ActType,WorkId,UserName,VisaInfo_id,Visa_id,Type,EntryTime from ActionRecords ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			TravelAgency.Model.ActionRecords model=new TravelAgency.Model.ActionRecords();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public TravelAgency.Model.ActionRecords DataRowToModel(DataRow row)
		{
			TravelAgency.Model.ActionRecords model=new TravelAgency.Model.ActionRecords();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["ActType"]!=null)
				{
					model.ActType=row["ActType"].ToString();
				}
				if(row["WorkId"]!=null)
				{
					model.WorkId=row["WorkId"].ToString();
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["VisaInfo_id"]!=null && row["VisaInfo_id"].ToString()!="")
				{
					model.VisaInfo_id= new Guid(row["VisaInfo_id"].ToString());
				}
				if(row["Visa_id"]!=null && row["Visa_id"].ToString()!="")
				{
					model.Visa_id= new Guid(row["Visa_id"].ToString());
				}
				if(row["Type"]!=null)
				{
					model.Type=row["Type"].ToString();
				}
				if(row["EntryTime"]!=null && row["EntryTime"].ToString()!="")
				{
					model.EntryTime=DateTime.Parse(row["EntryTime"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,ActType,WorkId,UserName,VisaInfo_id,Visa_id,Type,EntryTime ");
			strSql.Append(" FROM ActionRecords ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" id,ActType,WorkId,UserName,VisaInfo_id,Visa_id,Type,EntryTime ");
			strSql.Append(" FROM ActionRecords ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM ActionRecords ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from ActionRecords T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "ActionRecords";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

