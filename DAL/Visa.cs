using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TravelAgency.DAL
{
	/// <summary>
	/// 数据访问类:Visa
	/// </summary>
	public partial class Visa
	{
		public Visa()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid Visa_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Visa");
			strSql.Append(" where Visa_id=@Visa_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Visa_id", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = Visa_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(TravelAgency.Model.Visa model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Visa set ");
			strSql.Append("GroupNo=@GroupNo,");
			strSql.Append("Name=@Name,");
			strSql.Append("Types=@Types,");
			strSql.Append("Tips=@Tips,");
			strSql.Append("PredictTime=@PredictTime,");
			strSql.Append("RealTime=@RealTime,");
			strSql.Append("FinishTime=@FinishTime,");
			strSql.Append("Satus=@Satus,");
			strSql.Append("Person=@Person,");
			strSql.Append("Number=@Number,");
			strSql.Append("Picture=@Picture,");
			strSql.Append("ListCount=@ListCount,");
			strSql.Append("List=@List,");
			strSql.Append("SalesPerson=@SalesPerson,");
			strSql.Append("Receipt=@Receipt,");
			strSql.Append("Quidco=@Quidco,");
			strSql.Append("Cost=@Cost,");
			strSql.Append("OtherCost=@OtherCost,");
			strSql.Append("ExpressNo=@ExpressNo,");
			strSql.Append("Call=@Call,");
			strSql.Append("Sale_id=@Sale_id,");
			strSql.Append("DepartmentId=@DepartmentId,");
			strSql.Append("EntryTime=@EntryTime,");
			strSql.Append("Country=@Country,");
			strSql.Append("Passengers=@Passengers,");
			strSql.Append("WorkId=@WorkId,");
			strSql.Append("Documenter=@Documenter,");
			strSql.Append("Price=@Price,");
			strSql.Append("ConsulateCost=@ConsulateCost,");
			strSql.Append("VisaPersonCost=@VisaPersonCost,");
			strSql.Append("MailCost=@MailCost,");
			strSql.Append("Tips2=@Tips2,");
			strSql.Append("SubmitFlag=@SubmitFlag,");
			strSql.Append("GroupPrice=@GroupPrice,");
			strSql.Append("InvitationCost=@InvitationCost,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("SubmitTime=@SubmitTime,");
			strSql.Append("InTime=@InTime,");
			strSql.Append("OutTime=@OutTime,");
			strSql.Append("Client=@Client,");
			strSql.Append("DepartureType=@DepartureType,");
			strSql.Append("SubmitCondition=@SubmitCondition,");
			strSql.Append("FetchCondition=@FetchCondition,");
			strSql.Append("TypeInPerson=@TypeInPerson,");
			strSql.Append("CheckPerson=@CheckPerson,");
			strSql.Append("IsUrgent=@IsUrgent");
			strSql.Append(" where Visa_id=@Visa_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@GroupNo", SqlDbType.VarChar,500),
					new SqlParameter("@Name", SqlDbType.VarChar,150),
					new SqlParameter("@Types", SqlDbType.VarChar,50),
					new SqlParameter("@Tips", SqlDbType.VarChar,150),
					new SqlParameter("@PredictTime", SqlDbType.DateTime,3),
					new SqlParameter("@RealTime", SqlDbType.DateTime,3),
					new SqlParameter("@FinishTime", SqlDbType.DateTime,3),
					new SqlParameter("@Satus", SqlDbType.VarChar,50),
					new SqlParameter("@Person", SqlDbType.VarChar,50),
					new SqlParameter("@Number", SqlDbType.Int,4),
					new SqlParameter("@Picture", SqlDbType.Float,8),
					new SqlParameter("@ListCount", SqlDbType.Float,8),
					new SqlParameter("@List", SqlDbType.VarChar,50),
					new SqlParameter("@SalesPerson", SqlDbType.VarChar,50),
					new SqlParameter("@Receipt", SqlDbType.Float,8),
					new SqlParameter("@Quidco", SqlDbType.Float,8),
					new SqlParameter("@Cost", SqlDbType.Float,8),
					new SqlParameter("@OtherCost", SqlDbType.Float,8),
					new SqlParameter("@ExpressNo", SqlDbType.VarChar,50),
					new SqlParameter("@Call", SqlDbType.VarChar,50),
					new SqlParameter("@Sale_id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@DepartmentId", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@EntryTime", SqlDbType.DateTime),
					new SqlParameter("@Country", SqlDbType.VarChar,50),
					new SqlParameter("@Passengers", SqlDbType.VarChar,-1),
					new SqlParameter("@WorkId", SqlDbType.VarChar,50),
					new SqlParameter("@Documenter", SqlDbType.VarChar,50),
					new SqlParameter("@Price", SqlDbType.Float,8),
					new SqlParameter("@ConsulateCost", SqlDbType.Float,8),
					new SqlParameter("@VisaPersonCost", SqlDbType.Float,8),
					new SqlParameter("@MailCost", SqlDbType.Float,8),
					new SqlParameter("@Tips2", SqlDbType.VarChar,50),
					new SqlParameter("@SubmitFlag", SqlDbType.Int,4),
					new SqlParameter("@GroupPrice", SqlDbType.Float,8),
					new SqlParameter("@InvitationCost", SqlDbType.Float,8),
					new SqlParameter("@Remark", SqlDbType.VarChar,20),
					new SqlParameter("@SubmitTime", SqlDbType.DateTime),
					new SqlParameter("@InTime", SqlDbType.DateTime),
					new SqlParameter("@OutTime", SqlDbType.DateTime),
					new SqlParameter("@Client", SqlDbType.VarChar,50),
					new SqlParameter("@DepartureType", SqlDbType.VarChar,50),
					new SqlParameter("@SubmitCondition", SqlDbType.VarChar,50),
					new SqlParameter("@FetchCondition", SqlDbType.VarChar,50),
					new SqlParameter("@TypeInPerson", SqlDbType.VarChar,50),
					new SqlParameter("@CheckPerson", SqlDbType.VarChar,50),
					new SqlParameter("@IsUrgent", SqlDbType.Bit,1),
					new SqlParameter("@Visa_id", SqlDbType.UniqueIdentifier,16)};
			parameters[0].Value = model.GroupNo;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.Types;
			parameters[3].Value = model.Tips;
			parameters[4].Value = model.PredictTime;
			parameters[5].Value = model.RealTime;
			parameters[6].Value = model.FinishTime;
			parameters[7].Value = model.Satus;
			parameters[8].Value = model.Person;
			parameters[9].Value = model.Number;
			parameters[10].Value = model.Picture;
			parameters[11].Value = model.ListCount;
			parameters[12].Value = model.List;
			parameters[13].Value = model.SalesPerson;
			parameters[14].Value = model.Receipt;
			parameters[15].Value = model.Quidco;
			parameters[16].Value = model.Cost;
			parameters[17].Value = model.OtherCost;
			parameters[18].Value = model.ExpressNo;
			parameters[19].Value = model.Call;
			parameters[20].Value = model.Sale_id;
			parameters[21].Value = model.DepartmentId;
			parameters[22].Value = model.EntryTime;
			parameters[23].Value = model.Country;
			parameters[24].Value = model.Passengers;
			parameters[25].Value = model.WorkId;
			parameters[26].Value = model.Documenter;
			parameters[27].Value = model.Price;
			parameters[28].Value = model.ConsulateCost;
			parameters[29].Value = model.VisaPersonCost;
			parameters[30].Value = model.MailCost;
			parameters[31].Value = model.Tips2;
			parameters[32].Value = model.SubmitFlag;
			parameters[33].Value = model.GroupPrice;
			parameters[34].Value = model.InvitationCost;
			parameters[35].Value = model.Remark;
			parameters[36].Value = model.SubmitTime;
			parameters[37].Value = model.InTime;
			parameters[38].Value = model.OutTime;
			parameters[39].Value = model.Client;
			parameters[40].Value = model.DepartureType;
			parameters[41].Value = model.SubmitCondition;
			parameters[42].Value = model.FetchCondition;
			parameters[43].Value = model.TypeInPerson;
			parameters[44].Value = model.CheckPerson;
			parameters[45].Value = model.IsUrgent;
			parameters[46].Value = model.Visa_id;

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
		public bool Delete(Guid Visa_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Visa ");
			strSql.Append(" where Visa_id=@Visa_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Visa_id", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = Visa_id;

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
		public bool DeleteList(string Visa_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Visa ");
			strSql.Append(" where Visa_id in ("+Visa_idlist + ")  ");
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
		public TravelAgency.Model.Visa GetModel(Guid Visa_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Visa_id,GroupNo,Name,Types,Tips,PredictTime,RealTime,FinishTime,Satus,Person,Number,Picture,ListCount,List,SalesPerson,Receipt,Quidco,Cost,OtherCost,ExpressNo,Call,Sale_id,DepartmentId,EntryTime,Country,Passengers,WorkId,Documenter,Price,ConsulateCost,VisaPersonCost,MailCost,Tips2,SubmitFlag,GroupPrice,InvitationCost,Remark,SubmitTime,InTime,OutTime,Client,DepartureType,SubmitCondition,FetchCondition,TypeInPerson,CheckPerson,IsUrgent from Visa ");
			strSql.Append(" where Visa_id=@Visa_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Visa_id", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = Visa_id;

			TravelAgency.Model.Visa model=new TravelAgency.Model.Visa();
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
		public TravelAgency.Model.Visa DataRowToModel(DataRow row)
		{
			TravelAgency.Model.Visa model=new TravelAgency.Model.Visa();
			if (row != null)
			{
				if(row["Visa_id"]!=null && row["Visa_id"].ToString()!="")
				{
					model.Visa_id= new Guid(row["Visa_id"].ToString());
				}
				if(row["GroupNo"]!=null)
				{
					model.GroupNo=row["GroupNo"].ToString();
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Types"]!=null)
				{
					model.Types=row["Types"].ToString();
				}
				if(row["Tips"]!=null)
				{
					model.Tips=row["Tips"].ToString();
				}
				if(row["PredictTime"]!=null && row["PredictTime"].ToString()!="")
				{
					model.PredictTime=DateTime.Parse(row["PredictTime"].ToString());
				}
				if(row["RealTime"]!=null && row["RealTime"].ToString()!="")
				{
					model.RealTime=DateTime.Parse(row["RealTime"].ToString());
				}
				if(row["FinishTime"]!=null && row["FinishTime"].ToString()!="")
				{
					model.FinishTime=DateTime.Parse(row["FinishTime"].ToString());
				}
				if(row["Satus"]!=null)
				{
					model.Satus=row["Satus"].ToString();
				}
				if(row["Person"]!=null)
				{
					model.Person=row["Person"].ToString();
				}
				if(row["Number"]!=null && row["Number"].ToString()!="")
				{
					model.Number=int.Parse(row["Number"].ToString());
				}
				if(row["Picture"]!=null && row["Picture"].ToString()!="")
				{
					model.Picture=decimal.Parse(row["Picture"].ToString());
				}
				if(row["ListCount"]!=null && row["ListCount"].ToString()!="")
				{
					model.ListCount=decimal.Parse(row["ListCount"].ToString());
				}
				if(row["List"]!=null)
				{
					model.List=row["List"].ToString();
				}
				if(row["SalesPerson"]!=null)
				{
					model.SalesPerson=row["SalesPerson"].ToString();
				}
				if(row["Receipt"]!=null && row["Receipt"].ToString()!="")
				{
					model.Receipt=decimal.Parse(row["Receipt"].ToString());
				}
				if(row["Quidco"]!=null && row["Quidco"].ToString()!="")
				{
					model.Quidco=decimal.Parse(row["Quidco"].ToString());
				}
				if(row["Cost"]!=null && row["Cost"].ToString()!="")
				{
					model.Cost=decimal.Parse(row["Cost"].ToString());
				}
				if(row["OtherCost"]!=null && row["OtherCost"].ToString()!="")
				{
					model.OtherCost=decimal.Parse(row["OtherCost"].ToString());
				}
				if(row["ExpressNo"]!=null)
				{
					model.ExpressNo=row["ExpressNo"].ToString();
				}
				if(row["Call"]!=null)
				{
					model.Call=row["Call"].ToString();
				}
				if(row["Sale_id"]!=null && row["Sale_id"].ToString()!="")
				{
					model.Sale_id= new Guid(row["Sale_id"].ToString());
				}
				if(row["DepartmentId"]!=null && row["DepartmentId"].ToString()!="")
				{
					model.DepartmentId= new Guid(row["DepartmentId"].ToString());
				}
				if(row["EntryTime"]!=null && row["EntryTime"].ToString()!="")
				{
					model.EntryTime=DateTime.Parse(row["EntryTime"].ToString());
				}
				if(row["Country"]!=null)
				{
					model.Country=row["Country"].ToString();
				}
				if(row["Passengers"]!=null)
				{
					model.Passengers=row["Passengers"].ToString();
				}
				if(row["WorkId"]!=null)
				{
					model.WorkId=row["WorkId"].ToString();
				}
				if(row["Documenter"]!=null)
				{
					model.Documenter=row["Documenter"].ToString();
				}
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(row["Price"].ToString());
				}
				if(row["ConsulateCost"]!=null && row["ConsulateCost"].ToString()!="")
				{
					model.ConsulateCost=decimal.Parse(row["ConsulateCost"].ToString());
				}
				if(row["VisaPersonCost"]!=null && row["VisaPersonCost"].ToString()!="")
				{
					model.VisaPersonCost=decimal.Parse(row["VisaPersonCost"].ToString());
				}
				if(row["MailCost"]!=null && row["MailCost"].ToString()!="")
				{
					model.MailCost=decimal.Parse(row["MailCost"].ToString());
				}
				if(row["Tips2"]!=null)
				{
					model.Tips2=row["Tips2"].ToString();
				}
				if(row["SubmitFlag"]!=null && row["SubmitFlag"].ToString()!="")
				{
					model.SubmitFlag=int.Parse(row["SubmitFlag"].ToString());
				}
				if(row["GroupPrice"]!=null && row["GroupPrice"].ToString()!="")
				{
					model.GroupPrice=decimal.Parse(row["GroupPrice"].ToString());
				}
				if(row["InvitationCost"]!=null && row["InvitationCost"].ToString()!="")
				{
					model.InvitationCost=decimal.Parse(row["InvitationCost"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["SubmitTime"]!=null && row["SubmitTime"].ToString()!="")
				{
					model.SubmitTime=DateTime.Parse(row["SubmitTime"].ToString());
				}
				if(row["InTime"]!=null && row["InTime"].ToString()!="")
				{
					model.InTime=DateTime.Parse(row["InTime"].ToString());
				}
				if(row["OutTime"]!=null && row["OutTime"].ToString()!="")
				{
					model.OutTime=DateTime.Parse(row["OutTime"].ToString());
				}
				if(row["Client"]!=null)
				{
					model.Client=row["Client"].ToString();
				}
				if(row["DepartureType"]!=null)
				{
					model.DepartureType=row["DepartureType"].ToString();
				}
				if(row["SubmitCondition"]!=null)
				{
					model.SubmitCondition=row["SubmitCondition"].ToString();
				}
				if(row["FetchCondition"]!=null)
				{
					model.FetchCondition=row["FetchCondition"].ToString();
				}
				if(row["TypeInPerson"]!=null)
				{
					model.TypeInPerson=row["TypeInPerson"].ToString();
				}
				if(row["CheckPerson"]!=null)
				{
					model.CheckPerson=row["CheckPerson"].ToString();
				}
				if(row["IsUrgent"]!=null && row["IsUrgent"].ToString()!="")
				{
					if((row["IsUrgent"].ToString()=="1")||(row["IsUrgent"].ToString().ToLower()=="true"))
					{
						model.IsUrgent=true;
					}
					else
					{
						model.IsUrgent=false;
					}
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
			strSql.Append("select Visa_id,GroupNo,Name,Types,Tips,PredictTime,RealTime,FinishTime,Satus,Person,Number,Picture,ListCount,List,SalesPerson,Receipt,Quidco,Cost,OtherCost,ExpressNo,Call,Sale_id,DepartmentId,EntryTime,Country,Passengers,WorkId,Documenter,Price,ConsulateCost,VisaPersonCost,MailCost,Tips2,SubmitFlag,GroupPrice,InvitationCost,Remark,SubmitTime,InTime,OutTime,Client,DepartureType,SubmitCondition,FetchCondition,TypeInPerson,CheckPerson,IsUrgent ");
			strSql.Append(" FROM Visa ");
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
			strSql.Append(" Visa_id,GroupNo,Name,Types,Tips,PredictTime,RealTime,FinishTime,Satus,Person,Number,Picture,ListCount,List,SalesPerson,Receipt,Quidco,Cost,OtherCost,ExpressNo,Call,Sale_id,DepartmentId,EntryTime,Country,Passengers,WorkId,Documenter,Price,ConsulateCost,VisaPersonCost,MailCost,Tips2,SubmitFlag,GroupPrice,InvitationCost,Remark,SubmitTime,InTime,OutTime,Client,DepartureType,SubmitCondition,FetchCondition,TypeInPerson,CheckPerson,IsUrgent ");
			strSql.Append(" FROM Visa ");
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
			strSql.Append("select count(1) FROM Visa ");
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
				strSql.Append("order by T.Visa_id desc");
			}
			strSql.Append(")AS Row, T.*  from Visa T ");
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
			parameters[0].Value = "Visa";
			parameters[1].Value = "Visa_id";
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

