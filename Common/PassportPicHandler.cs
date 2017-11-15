using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using TravletAgence.Common.FTP;

namespace TravletAgence.Common
{
    public class PassportPicHandler
    {

        public enum PicType
        {
            Type01Normal,
            Type02Head,
            Type03IR
        }

        public static bool CheckAndDownloadIfNotExist(string passportNo, PicType type)
        {
            string fileprefix = passportNo;
            if (type == PicType.Type02Head)
                fileprefix += "Head";
            if (type == PicType.Type03IR)
                fileprefix += "IR";

            string picName = GlobalUtils.PassportPicPath + "\\" + fileprefix + ".jpg";

            if (File.Exists(picName)) //先检查本地是否存在
            {
                //picPassportNo.Image = Image.FromFile(picName);
                return true;
            }

            if (FtpHandler.FileExist(fileprefix + ".jpg"))
                if (FtpHandler.Download(GlobalUtils.PassportPicPath, fileprefix + ".jpg"))
                {
                    //picPassportNo.Image = Image.FromFile(picName);
                    return true;
                }
            //picPassportNo.Image = Resources.PassportPictureNotFound;
            return false;
        }

        public static bool DownloadPic(string passportNo, PicType type)
        {
            if (!CheckAndDownloadIfNotExist(passportNo, type))
            {
                MessageBoxEx.Show("找不到指定图像!");
                return false;
            }


            string fileprefix = passportNo;
            if (type == PicType.Type02Head)
                fileprefix += "Head";
            if (type == PicType.Type03IR)
                fileprefix += "IR";

            string dstname = GlobalUtils.OpenSaveFileDlg(fileprefix + ".jpg");
            if (string.IsNullOrEmpty(dstname))
                return false;
            if (!File.Exists(dstname))
                File.Copy(GlobalUtils.PassportPicPath + "\\" + fileprefix + ".jpg", dstname);
            return true;
        }

        public static int DownLoadAllType(string passportNo)
        {
            string savePath = GlobalUtils.OpenBrowseFolderDlg();
            int res = 0;
            if (string.IsNullOrEmpty(savePath))
                return 0;
            if (CheckAndDownloadIfNotExist(passportNo, PicType.Type01Normal))
            {
                if (!File.Exists(savePath + "\\" + passportNo + ".jpg"))
                    File.Copy(GlobalUtils.PassportPicPath + "\\" + passportNo + ".jpg", savePath + "\\" + passportNo + ".jpg");
                ++res;
            }
            if (CheckAndDownloadIfNotExist(passportNo, PicType.Type02Head))
            {
                if (!File.Exists(savePath + "\\" + passportNo + "Head.jpg"))
                    File.Copy(GlobalUtils.PassportPicPath + "\\" + passportNo + "Head.jpg", savePath + "\\" + passportNo + "Head.jpg");
                ++res;
            }
            if (CheckAndDownloadIfNotExist(passportNo, PicType.Type03IR))
            {
                if (!File.Exists(savePath + "\\" + passportNo + "IR.jpg"))
                    File.Copy(GlobalUtils.PassportPicPath + "\\" + passportNo + "IR.jpg", savePath + "\\" + passportNo + "IR.jpg");
                ++res;
            }
            if (res > 0)
            {
                if (MessageBoxEx.Show("保存成功，是否打开所在文件夹?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Process.Start(savePath);
                }
                return res;
            }
            MessageBoxEx.Show("保存失败");
            return 0;
        }

    }
}