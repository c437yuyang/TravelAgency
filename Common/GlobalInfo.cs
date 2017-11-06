using Excel;
using Application = System.Windows.Forms.Application;

namespace TravletAgence.Common
{
    public static class GlobalInfo
    {
        public static Model.AuthUser LoginUser;

        public static string AppPath
        {
            get
            {
                return Application.StartupPath;
            }
        }
    }
}