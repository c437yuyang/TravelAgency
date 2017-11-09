using System;
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
        public List<Model.VisaInfo_Tmp> GetListByPageOrderByOutState(int pageIndex, int pageSize,string where)
        {
            int start = (pageIndex - 1) * pageSize + 1;
            int end = pageIndex * pageSize;

            DataSet ds = dal.GetDataByPageOrderByOutState(start, end,where);
            DataTable dt = ds.Tables[0];
            return DataTableToList(dt);
            
        }

        public List<Model.VisaInfo_Tmp> GetListByPageOrderByGroupNo(int pageIndex, int pageSize,string where)
        {
            int start = (pageIndex - 1) * pageSize + 1;
            int end = pageIndex * pageSize;

            DataSet ds = dal.GetDataByPageOrderByGroupNo(start, end,where);
            DataTable dt = ds.Tables[0];
            return DataTableToList(dt);
        }

        public List<Model.VisaInfo_Tmp> GetListByPageOrderByHasChecked(int pageIndex, int pageSize)
        {
            int start = (pageIndex - 1) * pageSize + 1;
            int end = pageIndex * pageSize;

            DataSet ds = dal.GetDataByPageOrderByHasChecked(start, end);
            DataTable dt = ds.Tables[0];
            return DataTableToList(dt);
        }


        public int DeleteList(string VisaInfo_idlist)
        {
            return dal.DeleteList(VisaInfo_idlist);
        }

        public int DeleteListByPassNo(List<string> passNums)
        {
            return dal.DeleteListByPassNo(passNums);
        }

        public Model.VisaInfo_Tmp GetModelByPassportNo(string passportNo)
        {
            return dal.GetModelByPassportNo(passportNo);
        }

        public int UpdateByList(List<Model.VisaInfo_Tmp> list)
        {
            int res = 0;
            for (int i = 0; i < list.Count; i++)
            {
                res += Update(list[i]) ? 1 : 0;
            }
            return res;
        }


    }
}