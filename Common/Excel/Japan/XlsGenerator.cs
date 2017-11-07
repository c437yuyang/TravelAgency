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
                    //1.获取每个单元格
                    if (row.GetCell(c).ToString() == "{1}")
                        row.GetCell(c).SetCellValue(DateTime.Now.Year.ToString("yy"));

                    if (row.GetCell(c).ToString() == "{2}")
                        row.GetCell(c).SetCellValue(DateTime.Now.Year.ToString("mm"));


                    if (row.GetCell(c).ToString() == "{3}")
                        row.GetCell(c).SetCellValue(DateTime.Now.Year.ToString("dd"));
                }

                for (int i = 0; i < list.Count; i++)
                {
                    //姓名
                    row = sheet.GetRow(22 + i * 4);
                    for (int c = 0; c < row.LastCellNum; ++c)
                    {
                        if (row.GetCell(c).ToString() == "{" + (4 + i * 3) + "}")
                            row.GetCell(c).SetCellValue(list[i].Name);
                    }

                    if (IsOutSigned(list[i])) //是外签的话设置发行地
                    {
                        row = sheet.GetRow(24 + i * 4);
                        for (int c = 0; c < row.LastCellNum; ++c)
                        {
                            if (!string.IsNullOrEmpty(list[i].Identification))
                            {
                                if (row.GetCell(c).ToString() == "{" + (5 + i * 3) + "}")
                                    row.GetCell(c).SetCellValue(list[i].IssuePlace + "(" + list[i].Identification + ")");
                            }
                            else
                                row.GetCell(c).SetCellValue(list[i].IssuePlace);
                        }
                    }
                    
                    //居住地
                    row = sheet.GetRow(25 + i * 4);
                    for (int c = 0; c < row.LastCellNum; ++c)
                    {
                        if (row.GetCell(c).ToString() == "{" + (6 + i * 3) + "}")
                            row.GetCell(c).SetCellValue(list[i].Residence);
                    }

                }

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Excel2003 XLS|*.xls";
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