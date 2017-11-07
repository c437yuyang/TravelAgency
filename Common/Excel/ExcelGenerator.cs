﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using BorderStyle = NPOI.SS.UserModel.BorderStyle;
using HorizontalAlignment = NPOI.SS.UserModel.HorizontalAlignment;

namespace TravletAgence.Common.Excel
{
    public static class ExcelGenerator
    {

        public static bool GetIndividualVisaExcel(List<TravletAgence.Model.VisaInfo> list, string remark, string groupNo)
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
            style.VerticalAlignment = VerticalAlignment.Center;
            style.Alignment = HorizontalAlignment.Center;
            style.BorderTop = BorderStyle.Thin;
            style.BorderBottom = BorderStyle.Thin;
            style.BorderLeft = BorderStyle.Thin;
            style.BorderRight = BorderStyle.Thin;
            for (int i = 0; i <= sheet.LastRowNum; i++)
            {
                row = sheet.GetRow(i);
                for (int c = 0; c < row.LastCellNum; ++c)
                {
                    row.GetCell(c).CellStyle = style;
                }
            }
            //4.2合并单元格
            sheet.AddMergedRegion(new CellRangeAddress(1, sheet.LastRowNum, 12, 12));

            //5.执行写入磁盘

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "office 2003 excel|*.xls";
            saveFileDialog1.Title = "Save";
            if (groupNo.Length > 0)
            {
                saveFileDialog1.FileName = groupNo + ".xls"; //TODO:处理文件名太长
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return true;

            if (saveFileDialog1.FileName != "")
            {
                try
                {
                    using (FileStream fs = (FileStream)saveFileDialog1.OpenFile())
                    {
                        wkbook.Write(fs);
                    }
                }
                catch (Exception)
                {

                    MessageBoxEx.Show("指定文件名的文件正在使用中，无法写入，请关闭后重试!");
                    return false;
                }

            }
            Process.Start(saveFileDialog1.FileName);
            return true;

        }
        public static bool GetTeamVisaExcelOfJapan(List<TravletAgence.Model.VisaInfo> list, string groupNo)
        {
            //1.创建工作簿对象
            IWorkbook wkbook = new HSSFWorkbook();
            //2.创建工作表对象
            ISheet sheet = wkbook.CreateSheet("签证申请名单");

            //2.1创建表头
            IRow row = sheet.CreateRow(0);
            row.CreateCell(0).SetCellValue("序号");
            row.CreateCell(1).SetCellValue("姓名");
            row.CreateCell(2).SetCellValue("英文姓名");
            row.CreateCell(3).SetCellValue("性别");
            row.CreateCell(4).SetCellValue("出生地");
            row.CreateCell(5).SetCellValue("出生日期");
            row.CreateCell(6).SetCellValue("护照号");
            row.CreateCell(7).SetCellValue("签发地");
            row.CreateCell(8).SetCellValue("签发日期");
            row.CreateCell(9).SetCellValue("有效期至");
            row.CreateCell(10).SetCellValue("职业");
            row.CreateCell(11).SetCellValue("联系电话");
            row.CreateCell(12).SetCellValue("客户");
            row.CreateCell(13).SetCellValue("销售");



            //2.2设置列宽度
            sheet.SetColumnWidth(0, 5 * 256);//序号
            sheet.SetColumnWidth(1, 15 * 256);//姓名
            sheet.SetColumnWidth(2, 25 * 256);//英文姓名
            sheet.SetColumnWidth(3, 5 * 256);//性别
            sheet.SetColumnWidth(4, 10 * 256);//出生地
            sheet.SetColumnWidth(5, 20 * 256); //出生日期
            sheet.SetColumnWidth(6, 20 * 256);//护照号
            sheet.SetColumnWidth(7, 10 * 256);//签发地
            sheet.SetColumnWidth(8, 20 * 256);//签发日期
            sheet.SetColumnWidth(9, 20 * 256);//有效期至
            sheet.SetColumnWidth(10, 20 * 256);//职业
            sheet.SetColumnWidth(11, 20 * 256);//联系电话
            sheet.SetColumnWidth(12, 20 * 256);//客户
            sheet.SetColumnWidth(13, 20 * 256);//销售

            //3.插入行和单元格
            for (int i = 0; i != list.Count; ++i)
            {
                //创建单元格
                row = sheet.CreateRow(i + 1);
                ////设置行高
                //row.HeightInPoints = 50;
                //设置值
                row.CreateCell(0).SetCellValue(i + 1);
                row.CreateCell(1).SetCellValue(list[i].Name);
                row.CreateCell(2).SetCellValue(list[i].EnglishName);
                row.CreateCell(3).SetCellValue(list[i].Sex);
                row.CreateCell(4).SetCellValue(list[i].Birthplace);
                row.CreateCell(5).SetCellValue(DateTimeFormator.DateTimeToString(list[i].Birthday));
                row.CreateCell(6).SetCellValue(list[i].PassportNo);
                row.CreateCell(7).SetCellValue(list[i].IssuePlace);
                row.CreateCell(8).SetCellValue(DateTimeFormator.DateTimeToString(list[i].LicenceTime));
                row.CreateCell(9).SetCellValue(DateTimeFormator.DateTimeToString(list[i].ExpiryDate));
                row.CreateCell(10).SetCellValue(list[i].Occupation);
                row.CreateCell(11).SetCellValue(list[i].Phone);
                row.CreateCell(12).SetCellValue(list[i].Client);
                row.CreateCell(13).SetCellValue(list[i].Salesperson);
            }

            //4.1设置对齐风格和边框
            ICellStyle style = wkbook.CreateCellStyle();
            style.VerticalAlignment = VerticalAlignment.Center;
            style.Alignment = HorizontalAlignment.Center;
            style.BorderTop = BorderStyle.Thin;
            style.BorderBottom = BorderStyle.Thin;
            style.BorderLeft = BorderStyle.Thin;
            style.BorderRight = BorderStyle.Thin;
            for (int i = 0; i <= sheet.LastRowNum; i++)
            {
                row = sheet.GetRow(i);
                for (int c = 0; c < row.LastCellNum; ++c)
                {
                    row.GetCell(c).CellStyle = style;
                }
            }
            //4.2合并单元格
            sheet.AddMergedRegion(new CellRangeAddress(1, sheet.LastRowNum, 12, 12));
            sheet.AddMergedRegion(new CellRangeAddress(1, sheet.LastRowNum, 13, 13));

            //5.执行写入磁盘

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "office 2003 excel|*.xls";
            saveFileDialog1.Title = "Save";
            if (groupNo.Length > 0)
            {
                saveFileDialog1.FileName = groupNo + ".xls"; //TODO:处理文件名太长
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return true;

            if (saveFileDialog1.FileName != "")
            {
                try
                {
                    using (FileStream fs = (FileStream)saveFileDialog1.OpenFile())
                    {
                        wkbook.Write(fs);
                    }
                }
                catch (Exception)
                {

                    MessageBoxEx.Show("指定文件名的文件正在使用中，无法写入，请关闭后重试!");
                    return false;
                }
            }
            Process.Start(saveFileDialog1.FileName);
            return true;

        }

        public static bool GetTeamVisaExcelOfThailand(List<TravletAgence.Model.VisaInfo> list, string groupNo)
        {
            //1.创建工作簿对象
            IWorkbook wkbook = new HSSFWorkbook();
            //2.创建工作表对象
            ISheet sheet = wkbook.CreateSheet("签证申请名单");

            //2.1创建表头
            IRow row = sheet.CreateRow(0);
            row.CreateCell(0).SetCellValue("姓名");
            row.CreateCell(1).SetCellValue("英文姓");
            row.CreateCell(2).SetCellValue("英文名");
            row.CreateCell(3).SetCellValue("性别");
            row.CreateCell(4).SetCellValue("出生日期");
            row.CreateCell(5).SetCellValue("护照号");
            row.CreateCell(6).SetCellValue("签发日期");
            row.CreateCell(7).SetCellValue("有效期至");
            row.CreateCell(8).SetCellValue("出生地点拼音");
            row.CreateCell(9).SetCellValue("签发地点拼音");
            row.CreateCell(10).SetCellValue("英文姓名");




            //2.2设置列宽度
            sheet.SetColumnWidth(0, 20 * 256);//序号
            sheet.SetColumnWidth(1, 20 * 256);//姓名
            sheet.SetColumnWidth(2, 20 * 256);//英文姓名
            sheet.SetColumnWidth(3, 20 * 256);//性别
            sheet.SetColumnWidth(4, 20 * 256);//出生地
            sheet.SetColumnWidth(5, 20 * 256); //出生日期
            sheet.SetColumnWidth(6, 20 * 256);//护照号
            sheet.SetColumnWidth(7, 20 * 256);//签发地
            sheet.SetColumnWidth(8, 20 * 256);//签发日期
            sheet.SetColumnWidth(9, 20 * 256);//有效期至
            sheet.SetColumnWidth(10, 20 * 256);//职业

            //3.插入行和单元格
            for (int i = 0; i != list.Count; ++i)
            {
                //创建单元格
                row = sheet.CreateRow(i + 1);
                ////设置行高
                //row.HeightInPoints = 50;
                //设置值
                row.CreateCell(0).SetCellValue(list[i].Name);
                row.CreateCell(1).SetCellValue(list[i].EnglishName.Split(' ')[0]);
                row.CreateCell(2).SetCellValue(list[i].EnglishName.Split(' ')[1]);
                if (list[i].Sex == "男")
                {
                    row.CreateCell(3).SetCellValue("F");
                }
                else
                {
                    row.CreateCell(3).SetCellValue("M");
                }

                row.CreateCell(4).SetCellValue(DateTimeFormator.DateTimeToStringOfThailand(list[i].Birthday));
                row.CreateCell(5).SetCellValue(list[i].PassportNo);
                row.CreateCell(6).SetCellValue(DateTimeFormator.DateTimeToStringOfThailand(list[i].LicenceTime));
                row.CreateCell(7).SetCellValue(DateTimeFormator.DateTimeToStringOfThailand(list[i].ExpiryDate));
                List<string> pinyins = Common.PinyinParse.PinYinConverterHelp.GetTotalPingYin(list[i].Birthplace).TotalPingYin;

                row.CreateCell(8).SetCellValue(pinyins[pinyins.Count - 1].ToUpper()); //TODO:这个地方拼音还有点问题，因为可能有多个
                pinyins = Common.PinyinParse.PinYinConverterHelp.GetTotalPingYin(list[i].IssuePlace).TotalPingYin;
                row.CreateCell(9).SetCellValue(pinyins[pinyins.Count - 1].ToUpper());
                row.CreateCell(10).SetCellValue(list[i].EnglishName);
            }

            //4.1设置对齐风格和边框
            ICellStyle style = wkbook.CreateCellStyle();
            style.VerticalAlignment = VerticalAlignment.Center;
            style.Alignment = HorizontalAlignment.Left;
            style.BorderTop = BorderStyle.Thin;
            style.BorderBottom = BorderStyle.Thin;
            style.BorderLeft = BorderStyle.Thin;
            style.BorderRight = BorderStyle.Thin;
            for (int i = 0; i <= sheet.LastRowNum; i++)
            {
                row = sheet.GetRow(i);
                for (int c = 0; c < row.LastCellNum; ++c)
                {
                    row.GetCell(c).CellStyle = style;
                }
            }
            ////4.2合并单元格
            //sheet.AddMergedRegion(new CellRangeAddress(1, sheet.LastRowNum, 12, 12));
            //sheet.AddMergedRegion(new CellRangeAddress(1, sheet.LastRowNum, 13, 13));

            //5.执行写入磁盘

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "office 2003 excel|*.xls";
            saveFileDialog1.Title = "Save";
            if (groupNo.Length > 0)
            {
                saveFileDialog1.FileName = groupNo + ".xls"; //TODO:处理文件名太长
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return true;

            if (saveFileDialog1.FileName != "")
            {
                try
                {
                    using (FileStream fs = (FileStream)saveFileDialog1.OpenFile())
                    {
                        wkbook.Write(fs);
                    }
                }
                catch (Exception)
                {

                    MessageBoxEx.Show("指定文件名的文件正在使用中，无法写入，请关闭后重试!");
                    return false;
                }
            }
            Process.Start(saveFileDialog1.FileName);
            return true;

        }


    }
}
