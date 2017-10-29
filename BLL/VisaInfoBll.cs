using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using TravletAgence.Model;

namespace TravletAgence.BLL
{
    /// <summary>
    /// VisaInfo
    /// </summary>
    public partial class VisaInfo
    {
        public List<Model.VisaInfo> GetListByPageOrderByOutState(int pageIndex, int pageSize)
        {
            int start = (pageIndex - 1) * pageSize + 1;
            int end = pageIndex * pageSize;

            DataSet ds = dal.GetDataByPageOrderByOutState(start, end);
            DataTable dt = ds.Tables[0];
            return DataTableToList(dt);
            
        }

        public List<Model.VisaInfo> GetListByPageOrderByGroupNo(int pageIndex, int pageSize)
        {
            int start = (pageIndex - 1) * pageSize + 1;
            int end = pageIndex * pageSize;

            DataSet ds = dal.GetDataByPageOrderByGroupNo(start, end);
            DataTable dt = ds.Tables[0];
            return DataTableToList(dt);
        }

        public List<Model.VisaInfo> GetListByPageOrderByHasChecked(int pageIndex, int pageSize)
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

        public Model.VisaInfo GetModelByPassportNo(string passportNo)
        {
            return dal.GetModelByPassportNo(passportNo);
        }

        public int UpdateByList(List<Model.VisaInfo> list)
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