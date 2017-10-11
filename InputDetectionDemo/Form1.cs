using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravletAgence.BLL;

namespace InputDetectionDemo
{

    class PersonInfo
    {
        public string passportNo { get; set; }
        public string name { get; set; }
    }

    public partial class Form1 : Form
    {
        private string _txt = String.Empty;
        TravletAgence.BLL.VisaInfo bll = new VisaInfo();
        public Form1()
        {
            InitializeComponent();
        }

        //changed是改变之后的文本
        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

            string[] lines = textBoxX1.Text.Split(new char[] { '|' });
            PersonInfo personInfo = new PersonInfo();
            personInfo.passportNo = lines[lines.Length - 3];
            personInfo.name = lines[lines.Length - 1];

            return;
            //根据passportNum 查询数据库，改变状态
            TravletAgence.Model.VisaInfo model = bll.GetModelByPassportNo(personInfo.passportNo);

            if (model == null)
            {
                MessageBox.Show("当前信息无效，请检查信息是否正确!");
                return;
            }

            //TODO:添加处理逻辑
            Console.WriteLine(model.EnglishName);

        }
    }
}
