using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravletAgence.Common
{
    /// <summary>
    /// 用来做判断的分隔符字符串
    /// </summary>
    public static class OutStateString
    {
        public static string TYPE02In
        {
            get
            {
                return "==========" + "02:In" + "==========";
            }

        }

        public static string TYPE03NormalOut
        {
            get
            {
                return "==========" + "03:NormalOut" + "==========";
            }

        }

        public static string TYPE04AbnormalOut
        {
            get
            {
                return "==========" + "04:AbnormalOut" + "==========";
            }

        }
    }
}
