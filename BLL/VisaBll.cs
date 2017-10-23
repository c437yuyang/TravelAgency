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
    }
}
