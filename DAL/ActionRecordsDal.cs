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
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(TravelAgency.Model.ActionRecords model)
        {
            StringBuilder strSql = new StringBuilder();
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
            parameters[3].Value = model.VisaInfo_id;//这里不能是new GUID
            parameters[4].Value = model.Visa_id;
            parameters[5].Value = model.Type;
            parameters[6].Value = model.EntryTime;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

	}
}

