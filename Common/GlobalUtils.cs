using System.Configuration;
using System.IO;
using Excel;
using TravletAgence.Common.FTP;
using Application = System.Windows.Forms.Application;

namespace TravletAgence.Common
{
    public static class GlobalUtils
    {
        public static Model.AuthUser LoginUser;

        static GlobalUtils()
        {
            InitFTP();
        }

        private static void InitFTP()
        {
            //初始化FTP参数
            string ftpServer = ConfigurationManager.AppSettings["FTPServer"];
            string ftpUserId = ConfigurationManager.AppSettings["FtpUserID"];
            string ftpPassword = ConfigurationManager.AppSettings["FtpPassword"];
            string passportPics = ConfigurationManager.AppSettings["PassportPicPath"];
            FtpHandler.SetParams(ftpServer, passportPics, ftpUserId, ftpPassword);
        }

        public static string AppPath
        {
            get
            {
                return Application.StartupPath;
            }
        }

        public static string PassportPicPath
        {
            get
            {
                string res = Application.StartupPath + "\\" + "护照图像保存路径";
                if (!Directory.Exists(res))
                {
                    Directory.CreateDirectory(res);
                }
                return res;
            }
        }

        

    }
}