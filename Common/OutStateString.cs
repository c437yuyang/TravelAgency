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
                return "==========" + "02进签" + "==========";
            }

        }

        public static string TYPE03NormalOut
        {
            get
            {
                return "==========" + "03出签" + "==========";
            }

        }

        public static string TYPE04AbnormalOut
        {
            get
            {
                return "==========" + "04未正常出签" + "==========";
            }

        }
    }
}
