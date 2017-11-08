using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using TravletAgence.Common.Word;
using TravletAgence.Model;

namespace TravletAgence.Common.Excel.Japan
{
    public class XlsGenerator
    {

        public static bool IsOutSigned(VisaInfo model)
        {
            return model.IssuePlace != "云南" && model.IssuePlace != "四川" &&
                   model.IssuePlace != "贵州" && model.IssuePlace != "重庆";
        }

        public static void GetPre8List(List<Model.VisaInfo> list)
        {
            if (list.Count > 8)
            {
                MessageBoxEx.Show("请选择8个人以下导出!");
                return;
            }

            //READEXCEL
            using (FileStream fs = File.OpenRead(GlobalInfo.AppPath + @"\Excel\Templates\template_(前8人）旅行社申请名单表_（表3）_添加占位符.xlsx"))
            {
                IWorkbook wkbook = new XSSFWorkbook(fs);
                ISheet sheet = wkbook.GetSheetAt(0);


                IRow row = sheet.GetRow(10);
                for (int c = 0; c < row.LastCellNum; ++c)
                {
                    string dtString = DateTimeFormator.DateTimeToString(DateTime.Now);
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
                            if (j < list.Count)
                                row.GetCell(c).SetCellValue(list[j].Name);
                            else
                                row.GetCell(c).SetCellValue(string.Empty);
                    }

                    row = sheet.GetRow(23 + j * 4);
                    for (int c = 0; c < row.LastCellNum; ++c)
                    {
                        if (row.GetCell(c).ToString() == "{" + (5 + j * 3) + "}")
                        {
                            if (j < list.Count && IsOutSigned(list[j])) //是外签的话设置发行地
                            {
                                if (!string.IsNullOrEmpty(list[j].Identification)) //身份认证不为空
                                    row.GetCell(c).SetCellValue(list[j].IssuePlace + "(" + list[j].Identification + ")");
                                else
                                    row.GetCell(c).SetCellValue(list[j].IssuePlace);
                            }
                            else
                                row.GetCell(c).SetCellValue(string.Empty);
                        }
                    }

                    //居住地
                    row = sheet.GetRow(24 + j * 4);
                    for (int c = 0; c < row.LastCellNum; ++c)
                    {
                        if (row.GetCell(c).ToString() == "{" + (6 + j * 3) + "}")
                            if (j < list.Count)
                                row.GetCell(c).SetCellValue(list[j].Residence);
                            else
                                row.GetCell(c).SetCellValue(string.Empty);
                    }
                }

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Excel XLSX|*.xlsx";
                saveFileDialog1.Title = "保存到文件";
                saveFileDialog1.FileName = "8人申请表";
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;

                // If the file name is not an empty string open it for saving.
                if (saveFileDialog1.FileName != "")
                {
                    using (FileStream fs1 = File.OpenWrite(saveFileDialog1.FileName))
                    {
                        wkbook.Write(fs1);
                    }
                }
                Process.Start(saveFileDialog1.FileName);
            }
        }

    }
}