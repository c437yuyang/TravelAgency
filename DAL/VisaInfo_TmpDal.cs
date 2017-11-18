using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references

namespace TravelAgency.DAL
{
    /// <summary>
    /// 数据访问类:VisaInfo_Tmp
    /// </summary>
    public partial class VisaInfo_Tmp
    {



        /// <summary>
        /// 按照entrytime,outstate,groupNo排序，给送签管理界面用的
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public DataSet GetDataByPageOrderByOutState(int start, int end,string where)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * from(SELECT *,ROW_NUMBER() OVER(ORDER BY EntryTime desc) as num from VisaInfo_Tmp");
            if (!string.IsNullOrEmpty(where))
            {
                sb.Append(" where ");
                sb.Append(where);
            }
            sb.Append(")");
            sb.Append(" as t WHERE t.num>=@Start AND t.num<=@End order by EntryTime desc,OutState desc,GroupNo desc");
            string sql = sb.ToString();
            SqlParameter[] pams = new SqlParameter[]{
                new SqlParameter("@Start",SqlDbType.Int){Value=start},
                new SqlParameter("@End",SqlDbType.Int){Value=end}
            };
            return DbHelperSQL.Query(sql, pams);
        }



        /// <summary>
        /// 按照entrytime,groupNo,outstate排序，给签证录入界面用的
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public DataSet GetDataByPageOrderByGroupNo(int start, int end,string where)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * from(SELECT *,ROW_NUMBER() OVER(ORDER BY EntryTime desc) as num from VisaInfo_Tmp");
            if (!string.IsNullOrEmpty(where))
            {
                sb.Append(" where ");
                sb.Append(where);
            }
            sb.Append(")");
            sb.Append(" as t WHERE t.num>=@Start AND t.num<=@End order by EntryTime desc,GroupNo desc,OutState desc");
            string sql = sb.ToString();
            SqlParameter[] pams = new SqlParameter[]{
                new SqlParameter("@Start",SqlDbType.Int){Value=start},
                new SqlParameter("@End",SqlDbType.Int){Value=end}
            };
            return DbHelperSQL.Query(sql, pams);
        }


        /// <summary>
        /// 这个是给检查信息界面用的
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public DataSet GetDataByPageOrderByHasChecked(int start, int end)
        {
            string sql = "SELECT * from(SELECT *," +
                         "ROW_NUMBER() OVER(ORDER BY EntryTime desc) " +
                         "as num from VisaInfo_Tmp " +
                         "where (HasChecked is null or HasChecked='否' or HasChecked=' ')) " +
                         "as t WHERE t.num>=@Start AND t.num<=@End order by EntryTime desc,GroupNo desc";
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
            string sql = "select count(1) from VisaInfo_Tmp";
            return (int)DbHelperSQL.GetSingle(sql);
        }


        public int DeleteListByPassNo(List<string> passNums)
        {
            int ret = 0; //执行成功的数目
            for (int i = 0; i < passNums.Count; i++)
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("delete from VisaInfo_Tmp ");
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
            strSql.Append("delete from VisaInfo_Tmp ");
            strSql.Append(" where VisaInfo_id in (" + VisaInfo_idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            return rows;
        }


        public TravelAgency.Model.VisaInfo_Tmp GetModelByPassportNo(string passportNo)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 * from VisaInfo_Tmp ");
            strSql.Append(" where PassportNo=@PassportNo ");
            SqlParameter[] parameters = {
					new SqlParameter("@PassportNo", SqlDbType.VarChar,50)			};
            parameters[0].Value = passportNo;

            TravelAgency.Model.VisaInfo_Tmp model = new TravelAgency.Model.VisaInfo_Tmp();
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