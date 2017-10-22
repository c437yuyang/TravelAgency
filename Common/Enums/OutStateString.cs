namespace TravletAgence.Common.Enums
{
    /// <summary>
    /// 用来做判断的分隔符字符串
    /// </summary>
    public static class OutStateString
    {
        public static string Type02In
        {
            get
            {
                return "==========" + "02:In" + "==========";
            }

        }

        public static string Type03NormalOut
        {
            get
            {
                return "==========" + "03:NormalOut" + "==========";
            }

        }

        public static string Type04AbnormalOut
        {
            get
            {
                return "==========" + "04:AbnormalOut" + "==========";
            }

        }
    }
}
