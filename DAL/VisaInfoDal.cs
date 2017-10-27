using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references

namespace TravletAgence.DAL
{
    /// <summary>
    /// 数据访问类:VisaInfo
    /// </summary>
    public partial class VisaInfo
    {
        public DataSet GetDataByPageOrderByOutState(int start, int end)
        {
            string sql = "SELECT * from(SELECT *," +
                         "ROW_NUMBER() OVER(ORDER BY EntryTime desc) " +
                         "as num from VisaInfo) as t " +
                         "WHERE t.num>=@Start AND t.num<=@End " +
                         "order by EntryTime desc,OutState desc,GroupNo desc";
            SqlParameter[] pams = new SqlParameter[]{
                new SqlParameter("@Start",SqlDbType.Int){Value=start},
                new SqlParameter("@End",SqlDbType.Int){Value=end}
            };
            return DbHelperSQL.Query(sql, pams);
        }

        public DataSet GetDataByPageOrderByGroupNo(int start, int end)
        {
            string sql = "SELECT * from(SELECT *,ROW_NUMBER() OVER(ORDER BY EntryTime desc) as num from VisaInfo) as t WHERE t.num>=@Start AND t.num<=@End order by EntryTime desc,GroupNo desc,OutState desc";
            SqlParameter[] pams = new SqlParameter[]{
                new SqlParameter("@Start",SqlDbType.Int){Value=start},
                new SqlParameter("@End",SqlDbType.Int){Value=end}
            };
            return DbHelperSQL.Query(sql, pams);
        }

        /// <summary>
        /// 获取总记录条数
        /// </summary>
        /// <returns></returns>
        public int GetRecordCount()
        {
            string sql = "select count(1) from VisaInfo";
            return (int)DbHelperSQL.GetSingle(sql);
        }


        public int DeleteListByPassNo(List<string> passNums)
        {
            int ret = 0; //执行成功的数目
            for (int i = 0; i < passNums.Count; i++)
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("delete from VisaInfo ");
                strSql.Append(" where PassportNo=@passportNo ");
                SqlParameter[] parameters = {
					new SqlParameter("@passportNo", SqlDbType.VarChar,50)};
                parameters[0].Value = passNums[i];

                int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
                ret = rows > 0 ? ret + 1 : ret;
            }
            return ret;
        }

        /// <summary>
        /// 批量删除数据
        /// </summary>
        public int DeleteList(string VisaInfo_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from VisaInfo ");
            strSql.Append(" where VisaInfo_id in (" + VisaInfo_idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            return rows;
        }


        public TravletAgence.Model.VisaInfo GetModelByPassportNo(string passportNo)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 * from VisaInfo ");
            strSql.Append(" where PassportNo=@PassportNo ");
            SqlParameter[] parameters = {
					new SqlParameter("@PassportNo", SqlDbType.VarChar,50)			};
            parameters[0].Value = passportNo;

            TravletAgence.Model.VisaInfo model = new TravletAgence.Model.VisaInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

    }
}