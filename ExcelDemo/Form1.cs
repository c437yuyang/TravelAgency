using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XWPF.UserModel;

namespace ExcelDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //READEXCEL
            using (FileStream fs = File.OpenRead("ExcelTemplate.xls"))
            {
                IWorkbook wkbook = new HSSFWorkbook(fs);
                Console.WriteLine(wkbook.NumberOfSheets);

                for (int i = 0; i != wkbook.NumberOfSheets; ++i)
                {
                    ISheet sheet = wkbook.GetSheetAt(i);

                    for (int i1 = 0; i1 <= sheet.LastRowNum; ++i1)
                    {
                        IRow row = sheet.GetRow(i1);

                        //遍历单元格
                        for (int c = 0; c < row.LastCellNum; ++c)
                        {
                            //1.获取每个单元格
                            Console.Write(row.GetCell(c).ToString() + " |");

                        }
                        Console.WriteLine();
                    }
                }
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            using (FileStream fs = File.Open("ExcelTemplate.xls",FileMode.Append))
            {
                IWorkbook wkbook = new HSSFWorkbook(fs);
                Console.WriteLine(wkbook.NumberOfSheets);


                ISheet sheet = wkbook.GetSheetAt(0);

                for (int i1 = 0; i1 <= sheet.LastRowNum; ++i1)
                {
                    IRow row = sheet.GetRow(i1);

                    //遍历单元格
                    for (int c = 0; c < row.LastCellNum; ++c)
                    {
                        //1.获取每个单元格
                        Console.Write(row.GetCell(c).ToString() + " |");
                        row.GetCell(c).SetCellValue("杨小鹏");
                    }
                    Console.WriteLine();
                }
                wkbook.Write(fs);
            }

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            //List<Person> list = new List<Person>() {
            //    new Person() {Name="张三",Age=18,Email="zs@qq.com" },
            //    new Person() {Name="张s",Age=28,Email="zw@qq.com" },
            //    new Person() {Name="张w",Age=22,Email="zd@qq.com" }
            //};

            //XWPFDocument wkbook = new XWPFDocument();
            //wkbook.Document 
           
        }
    }
}
