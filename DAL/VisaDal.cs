using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maticsoft.DBUtility;

namespace TravletAgence.DAL
{
    public partial class Visa
    {
        public DataSet GetDataByPage(int start, int end)
        {
            string sql = "SELECT * from(SELECT *,ROW_NUMBER() OVER(ORDER BY EntryTime desc) as num from Visa) as t WHERE t.num>=@Start AND t.num<=@End order by EntryTime desc";
            SqlParameter[] pams = new SqlParameter[]{
                new SqlParameter("@Start",SqlDbType.Int){Value=start},
                new SqlParameter("@End",SqlDbType.Int){Value=end}
            };
            return DbHelperSQL.Query(sql, pams);
        }
    }
}
