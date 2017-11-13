using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace DocXDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DocX document = DocX.Load("template_成都金桥大名单_添加占位符1-31.docx"))
            {
                for (int i = 0; i < 31; i++)
                {
                    document.ReplaceText("{" + (i+1) + "}","abc");
                }
                document.SaveAs(@"replaced_template_成都金桥大名单_添加占位符1-31.docx");
            }
        } 
    }
}
