using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using TravelAgency.Common.Word;
using TravelAgency.Model;

namespace TravelAgency.Common.Excel.Japan
{
    /// <summary>
    /// 这个类是用占位符替换生成的报表
    /// </summary>
    public class XlsGenerator
    {
        public static bool IsOutSigned(VisaInfo model)
        {
            return model.IssuePlace != "云南" && model.IssuePlace != "四川" &&
                   model.IssuePlace != "贵州" && model.IssuePlace != "重庆";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="visaInfoList"></param>
        /// <param name="visaModel"></param>
        /// <param name="visaList"></param>
        public static void GetPre8List(List<Model.VisaInfo> visaInfoList, List<Model.Visa> visaList)
        {
            if (visaInfoList.Count > 8)
            {
                MessageBoxEx.Show("请选择8个人以下导出!");
                return;
            }

            //READEXCEL
            using (FileStream fs = File.OpenRead(GlobalUtils.AppPath + @"\Excel\Templates\template_(前8人）旅行社申请名单表_（表3）_添加占位符.xlsx"))
            {
                IWorkbook wkbook = new XSSFWorkbook(fs);
                ISheet sheet = wkbook.GetSheetAt(0);


                IRow row = sheet.GetRow(10);
                for (int c = 0; c < row.LastCellNum; ++c)
                {
                    string dtString = DateTimeFormator.DateTimeToString(DateTimeFormator.GetNextWorkDate(DateTime.Now));
                    string[] datearr = dtString.Split('/');
                    //1.获取每个单元格
                    if (row.GetCell(c).ToString() == "{1}")
                        row.GetCell(c).SetCellValue(datearr[0].Substring(2, 2));
                    if (row.GetCell(c).ToString() == "{2}")
                        row.GetCell(c).SetCellValue(datearr[1]);
                    if (row.GetCell(c).ToString() == "{3}")
                        row.GetCell(c).SetCellValue(datearr[2]);
                }

                for (int j = 0; j < 8; j++)
                {
                    row = sheet.GetRow(21 + j * 4);
                    for (int c = 0; c < row.LastCellNum; ++c)
                    {
                        if (row.GetCell(c).ToString() == "{" + (4 + j * 3) + "}")
                            if (j < visaInfoList.Count)
                            {
                                //外领送签条件不为空
                                if (IsOutSigned(visaInfoList[j]) && visaList[j] != null && !string.IsNullOrEmpty(visaList[j].SubmitCondition))
                                {
                                    row.GetCell(c).SetCellValue(visaInfoList[j].Name + "(" + visaList[j].SubmitCondition + ")");
                                    continue;
                                }
                                row.GetCell(c).SetCellValue(visaInfoList[j].Name);
                            }
                            else
                                row.GetCell(c).SetCellValue(string.Empty);
                    }

                    row = sheet.GetRow(23 + j * 4);
                    for (int c = 0; c < row.LastCellNum; ++c)
                    {
                        if (row.GetCell(c).ToString() == "{" + (5 + j * 3) + "}")
                        {
                            if (j < visaInfoList.Count) //是外签的话设置发行地
                                row.GetCell(c).SetCellValue(visaInfoList[j].IssuePlace);
                            else
                                row.GetCell(c).SetCellValue(string.Empty);
                        }
                    }

                    //居住地
                    row = sheet.GetRow(24 + j * 4);
                    for (int c = 0; c < row.LastCellNum; ++c)
                    {
                        if (row.GetCell(c).ToString() == "{" + (6 + j * 3) + "}")
                            if (j < visaInfoList.Count)
                            {
                                if (visaInfoList[j].Residence.Contains(" "))
                                {
                                    row.GetCell(c).SetCellValue(visaInfoList[j].Residence.Split(' ')[0]);
                                }
                                else
                                {
                                    row.GetCell(c).SetCellValue(visaInfoList[j].Residence);
                                }
                            }

                            else
                                row.GetCell(c).SetCellValue(string.Empty);
                    }
                }

                string dstName = GlobalUtils.OpenSaveFileDlg("8人申请表.xlsx", "Excel XLSX|*.xlsx");

                // If the file name is not an empty string open it for saving.
                if (!string.IsNullOrEmpty(dstName))
                {
                    try
                    {
                        using (FileStream fs1 = File.OpenWrite(dstName))
                        {
                            wkbook.Write(fs1);
                        }
                        Process.Start(dstName);
                    }
                    catch (Exception)
                    {
                        MessageBoxEx.Show("指定文件名的文件正在使用中，无法写入，请关闭后重试!");
                    }
                }

            }
        }

    }
}