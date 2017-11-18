using System;
using System.Windows.Forms;
using System.Xml.Linq;
using DevComponents.DotNetBar;

namespace TravelAgency.Common
{
    public static  class XmlHandler
    {
        public static float GetPropramVersion()
        {
            float version = -1.0f;
            try
            {
                string configpath = GlobalUtils.AppPath + "\\" + "TravelAgency.CSUI.exe.config";
                XDocument xDoc = XDocument.Load(configpath);
                try
                {
                    XElement rootElem = xDoc.Root;
                    XElement settings = rootElem.Element("appSettings");
                    
                    foreach (XElement xElement in settings.Elements())
                    {
                        if (xElement.Attribute("key").Value == "Version")
                        {
                            version = float.Parse(xElement.Attribute("value").Value);
                            return version;
                        }
                    }
                    return version;
                }
                catch (Exception)
                {
                    MessageBoxEx.Show("解析版本号出错，程序将关闭!");
                    Application.Exit();
                }
            }
            catch (Exception e)
            {
                MessageBoxEx.Show("无法找到配置文件，程序将关闭!");
                Application.Exit();
                
            }
            return version;
        }

        public static bool SetPropramVersion(float version)
        {
            try
            {
                string configpath = GlobalUtils.AppPath + "\\" + "TravelAgency.CSUI.exe.config";
                XDocument xDoc = XDocument.Load(configpath);
                try
                {
                    XElement rootElem = xDoc.Root;
                    XElement settings = rootElem.Element("appSettings");

                    foreach (XElement xElement in settings.Elements())
                    {
                        if (xElement.Attribute("key").Value == "Version")
                        {
                            xElement.Attribute("value").SetValue(version);
                            xDoc.Save(GlobalUtils.AppPath + "\\" + "TravelAgency.CSUI.exe.config");
                            return true;
                        }
                    }
                    return false;
                }
                catch (Exception)
                {
                    MessageBoxEx.Show("解析版本号出错，程序将关闭!");
                    Application.Exit();
                }
            }
            catch (Exception e)
            {
                MessageBoxEx.Show("无法找到配置文件，程序将关闭!");
                Application.Exit();

            }
            return false;
        }


        public static string GetPropramPath()
        {
            string path = null;
            try
            {
                string configpath = GlobalUtils.AppPath + "\\" + "TravelAgency.CSUI.exe.config";
                XDocument xDoc = XDocument.Load(configpath);
                try
                {
                    XElement rootElem = xDoc.Root;
                    XElement settings = rootElem.Element("appSettings");

                    foreach (XElement xElement in settings.Elements())
                    {
                        if (xElement.Attribute("key").Value == "ServerProgramPath")
                        {
                            path = xElement.Attribute("value").Value;
                            return path;
                        }
                    }
                    return path;
                }
                catch (Exception)
                {
                    MessageBoxEx.Show("解析服务器路径出错，程序将关闭!");
                    Application.Exit();
                }
            }
            catch (Exception e)
            {
                MessageBoxEx.Show("无法找到配置文件，程序将关闭!");
                Application.Exit();

            }
            return path;
        }


    }
}