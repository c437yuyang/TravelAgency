using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using TravelAgency.Common.FTP;

namespace TravelAgency.Common
{
    public class PassportPicHandler
    {
        [Flags]
        public enum PicType
        {
            Type01Normal = 0x01,
            Type02Head = 0x02,
            Type03IR = 0x04
        }

        public static bool CheckAndDownloadIfNotExist(string passportNo, PicType type)
        {
            FtpHandler.ChangeFtpUri(ConfigurationManager.AppSettings["PassportPicPath"]);
            string fileName = GetFileName(passportNo, type);

            string picName = GlobalUtils.PassportPicPath + "\\" + fileName;

            if (File.Exists(picName)) //先检查本地是否存在
            {
                //picPassportNo.Image = Image.FromFile(picName);
                return true;
            }

            if (FtpHandler.FileExist(fileName))
                if (FtpHandler.Download(GlobalUtils.PassportPicPath, fileName))
                {
                    //picPassportNo.Image = Image.FromFile(picName);
                    return true;
                }
            //picPassportNo.Image = Resources.PassportPictureNotFound;
            return false;
        }

        public static string GetFileName(string passportNo, PicType type)
        {
            string fileprefix = passportNo;
            if (type == PicType.Type02Head)
                fileprefix += "Head";
            if (type == PicType.Type03IR)
                fileprefix += "IR";
            return fileprefix + ".jpg";
        }

        /// <summary>
        /// 下载指定护照的指定类型图像
        /// </summary>
        /// <param name="passportNo"></param>
        /// <param name="type"></param>
        /// <param name="dstname"></param>
        /// <returns></returns>
        public static bool DownloadPic(string passportNo, PicType type, string dstname)
        {
            if (!CheckAndDownloadIfNotExist(passportNo, type))
            {
                MessageBoxEx.Show("找不到指定图像!");
                return false;
            }
            string fileName = GetFileName(passportNo, type);
            if (string.IsNullOrEmpty(dstname))
                return false;
            if (!File.Exists(dstname))
                File.Copy(GlobalUtils.PassportPicPath + "\\" + fileName, dstname);
            return true;
        }

        /// <summary>
        /// 批量下载护照指定类型图像
        /// </summary>
        /// <param name="passportNo"></param>
        /// <param name="type"></param>
        /// <param name="dstname"></param>
        /// <returns></returns>
        public static int DownloadPicBatch(string[] passportNoList, PicType type, string dstPath)
        {
            int res = 0;
            for (int i = 0; i < passportNoList.Length; i++)
            {
                string fileName = GetFileName(passportNoList[i], type);
                if (DownloadPic(passportNoList[i], type, dstPath + "\\" + fileName))
                    ++res;
            }
            return res;
        }


        /// <summary>
        /// 下载指定护照的全部类型图像
        /// </summary>
        /// <param name="passportNo"></param>
        /// <returns></returns>
        public static int DownloadSelectedTypes(string passportNo, string dstPath, PicType type = PicType.Type01Normal|PicType.Type02Head|PicType.Type03IR)
        {
            int res = 0;
            int expected = 0; //现在没用，先保留，以后用
            if (string.IsNullOrEmpty(dstPath))
                return 0;
            if (type.HasFlag(PicType.Type01Normal))
            {
                if (CheckAndDownloadIfNotExist(passportNo, PicType.Type01Normal))
                {
                    if (DownloadPic(passportNo, PicType.Type01Normal, dstPath + "\\" + GetFileName(passportNo, PicType.Type01Normal)))
                        ++res;
                }
                ++expected;
            }

            if (type.HasFlag(PicType.Type02Head))
            {
                if (CheckAndDownloadIfNotExist(passportNo, PicType.Type02Head))
                {
                    if (DownloadPic(passportNo, PicType.Type02Head, dstPath + "\\" + GetFileName(passportNo, PicType.Type02Head)))
                        ++res;
                }
                ++expected;
            }

            if (type.HasFlag(PicType.Type03IR))
            {
                if (CheckAndDownloadIfNotExist(passportNo, PicType.Type03IR))
                {
                    if (DownloadPic(passportNo, PicType.Type03IR, dstPath + "\\" + GetFileName(passportNo, PicType.Type03IR)))
                        ++res;
                }
                ++expected;
            }

            return res;
            //if (res > 0)
            //{
            //    if (showConfirm)
            //        if (MessageBoxEx.Show("保存成功，是否打开所在文件夹?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //            Process.Start(dstPath);
            //    return res;
            //}
            //if (showConfirm)
            //    MessageBoxEx.Show("保存失败");
            //return 0;
        }


        /// <summary>
        /// 批量下载指定护照的全部类型图像
        /// </summary>
        /// <param name="passportNo"></param>
        /// <returns></returns>
        public static int DownloadSelectedTypesBatch(string[] passportNoList, string dstPath, bool showConfirm = true, PicType type = PicType.Type01Normal|PicType.Type02Head|PicType.Type03IR)
        {
            int res = 0;
            for (int i = 0; i < passportNoList.Length; i++)
            {
                res += DownloadSelectedTypes(passportNoList[i], dstPath, type);
            }
            return res;
        }



    }
}