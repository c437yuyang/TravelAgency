namespace TravelAgency.Common.Enums
{
    /// <summary>
    /// 状态文本
    /// </summary>
    public static class OutState
    {
        public static string Type01NoRecord
        {
            get
            {
                return "01未记录";
            }
            
        }

        public static string Type02In
        {
            get
            {
                return "02进签";
            }
            
        }

        public static string Type03NormalOut
        {
            get
            {
                return "03出签";
            }
            
        }

        public static string TYPE04AbnormalOut
        {
            get
            {
                return "04未正常出签";
            }
        }
    }
}