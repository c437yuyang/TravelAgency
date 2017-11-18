using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using TravelAgency.Model;

namespace TravelAgency.BLL
{
    /// <summary>
    /// VisaInfo_Tmp
    /// </summary>
    public partial class VisaInfo_Tmp
    {
        private BLL.VisaInfo _bllVisaInfo = new BLL.VisaInfo();

        public int MoveCheckedDataToVisaInfo()
        {
            int res = 0;
            var list = GetModelList(string.Empty);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].HasChecked==Common.Enums.HasChecked.Yes)
                {
                    Model.VisaInfo model = new Model.VisaInfo();
                    list[i].CopyToVisaInfo(model);
                    if(_bllVisaInfo.Add(model) &&  Delete(list[i].VisaInfo_id))
                        res++; 
                }
            }
            return res;
        }

        public List<Model.VisaInfo_Tmp> GetModelList(int top, string where, string order)
        {
            DataSet ds = dal.GetList(0, where, order);
            DataTable dt = ds.Tables[0];
            return DataTableToList(dt);
        }

        public List<Model.VisaInfo_Tmp> GetListByPageOrderByOutState(int pageIndex, int pageSize, string where)
        {
            int start = (pageIndex - 1) * pageSize + 1;
            int end = pageIndex * pageSize;

            DataSet ds = dal.GetDataByPageOrderByOutState(start, end, where);
            DataTable dt = ds.Tables[0];
            return DataTableToList(dt);

        }

        public List<Model.VisaInfo_Tmp> GetListByPageOrderByGroupNo(int pageIndex, int pageSize, string where)
        {
            int start = (pageIndex - 1) * pageSize + 1;
            int end = pageIndex * pageSize;

            DataSet ds = dal.GetDataByPageOrderByGroupNo(start, end, where);
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