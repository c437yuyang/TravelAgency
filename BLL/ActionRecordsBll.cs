using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.BLL
{
    public partial class ActionRecords
    {
        /// <summary>
        /// 检查指定visa是否已经录入了，现在就是做资料了
        /// </summary>
        /// <param name="visaModel"></param>
        /// <returns></returns>
        public bool HasVisaBeenTypedIn(Model.Visa visaModel)
        {
            List<Model.ActionRecords> list = GetModelList(" visa_id = '" + visaModel.Visa_id + "' ");
            return list.Count > 0;
        }


        public void CheckStatesAndRemove(List<Model.Visa> list, string type)
        {
            for (int i = list.Count-1 ;i >=0; --i)
            {
                if (GetModelList(" visa_id='" + list[i].Visa_id + "' and ActType='" + type + "' ").Count <= 0)
                {
                    list.Remove(list[i]);
                }
            }
        }
    }
}
