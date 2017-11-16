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


        /// <summary>
        /// 增加一条数据
        /// 修改成返回默认生成的guid
        /// 失败返回Guid.Empty
        /// </summary>
        public Guid Add(TravletAgence.Model.Visa model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Visa(");
            strSql.Append("Visa_id,GroupNo,Name,Types,Tips,PredictTime,RealTime,FinishTime,Satus,Person,Number,Picture,ListCount,List,SalesPerson,Receipt,Quidco,Cost,OtherCost,ExpressNo,Call,Sale_id,DepartmentId,EntryTime,Country,Passengers,WorkId,Documenter,Price,ConsulateCost,VisaPersonCost,MailCost,Tips2,SubmitFlag,GroupPrice,InvitationCost,Remark,SubmitTime,InTime,OutTime,Client,DepartureType,SubmitCondition,FetchCondition,TypeInPerson,CheckPerson,IsUrgent)");
            strSql.Append(" values (");
            strSql.Append("@Visa_id,@GroupNo,@Name,@Types,@Tips,@PredictTime,@RealTime,@FinishTime,@Satus,@Person,@Number,@Picture,@ListCount,@List,@SalesPerson,@Receipt,@Quidco,@Cost,@OtherCost,@ExpressNo,@Call,@Sale_id,@DepartmentId,@EntryTime,@Country,@Passengers,@WorkId,@Documenter,@Price,@ConsulateCost,@VisaPersonCost,@MailCost,@Tips2,@SubmitFlag,@GroupPrice,@InvitationCost,@Remark,@SubmitTime,@InTime,@OutTime,@Client,@DepartureType,@SubmitCondition,@FetchCondition,@TypeInPerson,@CheckPerson,@IsUrgent)");
            SqlParameter[] parameters = {
					new SqlParameter("@Visa_id", SqlDbType.UniqueIdentifier,16),
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
                    new SqlParameter("@IsUrgent",SqlDbType.Bit)};
            parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = model.GroupNo;
            parameters[2].Value = model.Name;
            parameters[3].Value = model.Types;
            parameters[4].Value = model.Tips;
            parameters[5].Value = model.PredictTime;
            parameters[6].Value = model.RealTime;
            parameters[7].Value = model.FinishTime;
            parameters[8].Value = model.Satus;
            parameters[9].Value = model.Person;
            parameters[10].Value = model.Number;
            parameters[11].Value = model.Picture;
            parameters[12].Value = model.ListCount;
            parameters[13].Value = model.List;
            parameters[14].Value = model.SalesPerson;
            parameters[15].Value = model.Receipt;
            parameters[16].Value = model.Quidco;
            parameters[17].Value = model.Cost;
            parameters[18].Value = model.OtherCost;
            parameters[19].Value = model.ExpressNo;
            parameters[20].Value = model.Call;
            parameters[21].Value = Guid.NewGuid();
            parameters[22].Value = Guid.NewGuid();
            parameters[23].Value = model.EntryTime;
            parameters[24].Value = model.Country;
            parameters[25].Value = model.Passengers;
            parameters[26].Value = model.WorkId;
            parameters[27].Value = model.Documenter;
            parameters[28].Value = model.Price;
            parameters[29].Value = model.ConsulateCost;
            parameters[30].Value = model.VisaPersonCost;
            parameters[31].Value = model.MailCost;
            parameters[32].Value = model.Tips2;
            parameters[33].Value = model.SubmitFlag;
            parameters[34].Value = model.GroupPrice;
            parameters[35].Value = model.InvitationCost;
            parameters[36].Value = model.Remark;
            parameters[37].Value = model.SubmitTime;
            parameters[38].Value = model.InTime;
            parameters[39].Value = model.OutTime;
            parameters[40].Value = model.Client;
            parameters[41].Value = model.DepartureType;
            parameters[42].Value = model.SubmitCondition;
            parameters[43].Value = model.FetchCondition;
            parameters[44].Value = model.TypeInPerson;
            parameters[45].Value = model.CheckPerson;
            parameters[46].Value = model.IsUrgent;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return (Guid)(parameters[0].Value);
            }
            else
            {
                return Guid.Empty;
            }
        }


        public DataSet GetDataByPage(int start, int end,string where)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * from(SELECT *,ROW_NUMBER() OVER(ORDER BY EntryTime desc) as num from Visa");

            if (!string.IsNullOrEmpty(where))
            {
                sb.Append(" where ");
                sb.Append(where);
            }
            sb.Append(")");

            sb.Append(" as t WHERE t.num>=@Start AND t.num<=@End order by EntryTime desc");
            string sql = sb.ToString();
            SqlParameter[] pams = new SqlParameter[]{
                new SqlParameter("@Start",SqlDbType.Int){Value=start},
                new SqlParameter("@End",SqlDbType.Int){Value=end}
            };
            return DbHelperSQL.Query(sql, pams);
        }
    }
}
