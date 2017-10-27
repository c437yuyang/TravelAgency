using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravletAgence.BLL
{
    public partial class Visa
    {
        public List<Model.Visa> GetListByPage(int pageIndex, int pageSize)
        {
            int start = (pageIndex - 1) * pageSize + 1;
            int end = pageIndex * pageSize;

            DataSet ds = dal.GetDataByPage(start, end);
            DataTable dt = ds.Tables[0];
            return DataTableToList(dt);
        }

        public bool DeleteVisaAndModifyVisaInfos(Model.Visa model)
        {

            //1.更新对应visainfo
            BLL.VisaInfo bllVisaInfo = new VisaInfo();
            List<Model.VisaInfo> list = bllVisaInfo.GetModelList(" Visa_id = '" + model.Visa_id + "'");

            //修改对应项
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Country = null;
                list[i].Visa_id = null;
                list[i].GroupNo = null;
                //TODO:资料录入情况怎么处理
                if (!bllVisaInfo.Update(list[i]))
                {
                    return false;
                }
            }
            //2.删除自身
            return Delete(model.Visa_id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public Guid Add(TravletAgence.Model.Visa model)
        {
            return dal.Add(model);
        }

    }
}
