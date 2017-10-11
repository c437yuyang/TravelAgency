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

        public List<Model.VisaInfo> GetListByPage(int pageIndex, int pageSize)
        {
            int start = (pageIndex - 1) * pageSize + 1;
            int end = pageIndex * pageSize;

            DataSet ds = dal.GetDataByPage(start, end);
            DataTable dt = ds.Tables[0];
            return DataTableToList(dt);
        }

        public int DeleteListByPassNo(List<string> passNums)
        {
            return dal.DeleteListByPassNo(passNums);
        }

        public Model.VisaInfo GetModelByPassportNo(string passportNo)
        {
            return dal.GetModelByPassportNo(passportNo);
        }



    }
}