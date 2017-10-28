using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using BorderStyle = NPOI.SS.UserModel.BorderStyle;
using HorizontalAlignment = NPOI.SS.UserModel.HorizontalAlignment;

namespace TravletAgence.Common.Excel
{
    public static class GroupExcel
    {

        public static bool GenGroupInfoExcel(List<TravletAgence.Model.VisaInfo> list, string remark, string groupNo)
        {
            //1.创建工作簿对象
            IWorkbook wkbook = new HSSFWorkbook();
            //2.创建工作表对象
            ISheet sheet = wkbook.CreateSheet("签证申请名单");

            //2.1创建表头
            IRow row = sheet.CreateRow(0);
            row.CreateCell(0).SetCellValue("编号");
            row.CreateCell(1).SetCellValue("姓名(中文)");
            row.CreateCell(2).SetCellValue("姓名(英文)");
            row.CreateCell(3).SetCellValue("性别");
            row.CreateCell(4).SetCellValue("护照发行地");
            row.CreateCell(5).SetCellValue("居住地点");
            row.CreateCell(6).SetCellValue("出生年月日");
            row.CreateCell(7).SetCellValue("职业");
            row.CreateCell(8).SetCellValue("出境记录");
            row.CreateCell(9).SetCellValue("婚姻");
            row.CreateCell(10).SetCellValue("身份确认");
            row.CreateCell(11).SetCellValue("经济能力确认");
            row.CreateCell(12).SetCellValue("备注");
            row.CreateCell(13).SetCellValue("旅行社意见");
            row.CreateCell(14).SetCellValue("护照号");
            row.CreateCell(15).SetCellValue("手机号");

            //2.2设置列宽度
            sheet.SetColumnWidth(0, 5 * 256);//编号
            sheet.SetColumnWidth(1, 15 * 256);//姓名(中文)
            sheet.SetColumnWidth(2, 20 * 256);//姓名(英文)
            sheet.SetColumnWidth(3, 5 * 256);//性别
            sheet.SetColumnWidth(4, 10 * 256);//护照发行地
            sheet.SetColumnWidth(5, 25 * 256); //居住地点
            sheet.SetColumnWidth(6, 15 * 256);//出生年月日
            sheet.SetColumnWidth(7, 10 * 256);//职业
            sheet.SetColumnWidth(8, 10 * 256);//出境记录
            sheet.SetColumnWidth(9, 10 * 256);//婚姻
            sheet.SetColumnWidth(10, 20 * 256);//身份确认
            sheet.SetColumnWidth(11, 25 * 256);//经济能力确认
            sheet.SetColumnWidth(12, 10 * 256);//备注
            sheet.SetColumnWidth(13, 10 * 256);//旅行社意见
            sheet.SetColumnWidth(14, 15 * 256);//护照号
            sheet.SetColumnWidth(15, 15 * 256);//手机号
            //3.插入行和单元格
            for (int i = 0; i != list.Count; ++i)
            {
                //创建单元格
                row = sheet.CreateRow(i + 1);
                //设置行高
                row.HeightInPoints = 50;
                //设置值
                row.CreateCell(0).SetCellValue(i + 1);
                row.CreateCell(1).SetCellValue(list[i].Name);
                row.CreateCell(2).SetCellValue(list[i].EnglishName);
                row.CreateCell(3).SetCellValue(list[i].Sex);
                row.CreateCell(4).SetCellValue(list[i].IssuePlace);
                row.CreateCell(5).SetCellValue(list[i].Residence);
                row.CreateCell(6).SetCellValue(DateTimeFormator.DateTimeToString(list[i].Birthday));
                row.CreateCell(7).SetCellValue(list[i].Occupation);
                row.CreateCell(8).SetCellValue(list[i].DepartureRecord);
                row.CreateCell(9).SetCellValue(list[i].Marriaged);
                row.CreateCell(10).SetCellValue(list[i].Identification);
                row.CreateCell(11).SetCellValue(list[i].FinancialCapacity);
                row.CreateCell(12).SetCellValue(remark);
                row.CreateCell(13).SetCellValue(list[i].AgencyOpinion);
                row.CreateCell(14).SetCellValue(list[i].PassportNo);
                row.CreateCell(15).SetCellValue(list[i].Phone);
            }

            //4.1设置对齐风格和边框
            ICellStyle style = wkbook.CreateCellStyle();
            style.VerticalAlignment = VerticalAlignment.CENTER;
            style.Alignment = HorizontalAlignment.CENTER;
            style.BorderTop = BorderStyle.THIN;
            style.BorderBottom = BorderStyle.THIN;
            style.BorderLeft = BorderStyle.THIN;
            style.BorderRight = BorderStyle.THIN;
            for (int i = 0; i <= sheet.LastRowNum; i++)
            {
                row = sheet.GetRow(i);
                for (int c = 0; c < row.LastCellNum; ++c)
                {
                    row.GetCell(c).CellStyle = style;
                }
            }
            //4.2合并单元格
            sheet.AddMergedRegion(new CellRangeAddress(1,sheet.LastRowNum,12, 12));

            //5.执行写入磁盘

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "office 2003 excel|*.xls";
            saveFileDialog1.Title = "Save";
            if (groupNo.Length > 0)
            {
                saveFileDialog1.FileName = groupNo + ".xls"; //TODO:处理文件名太长
            }
               
            if(saveFileDialog1.ShowDialog()== DialogResult.Cancel)
                return true;
            
            if (saveFileDialog1.FileName != "")
            {
                using (FileStream fs = (FileStream)saveFileDialog1.OpenFile())
                {
                    wkbook.Write(fs);
                }
            }
            Process.Start(saveFileDialog1.FileName);
            return true;

        }

    }
}
