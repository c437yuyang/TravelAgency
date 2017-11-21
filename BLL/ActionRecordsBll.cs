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
    }
}
