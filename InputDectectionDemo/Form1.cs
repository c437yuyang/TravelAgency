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
using TravelAgency.BLL;

namespace InputDectectionDemo
{



    public partial class Form1 : Form
    {
        class PersonInfo
        {
            public string passportNo { get; set; }
            public string name { get; set; }
        }

        private string _preTxt = String.Empty;
        TravelAgency.BLL.VisaInfo bll = new VisaInfo();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void printArray(string[] lines)
        {
            Console.WriteLine("=====start");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("=====stop");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string str = textBox1.Text.TrimEnd();

            if (_preTxt == str)
            {
                return;
            }
            _preTxt = str;
            string[] lines = str.Split(new string[] { "\r\n" }, StringSplitOptions.None);

            //printArray(lines);
            PersonInfo personInfo = new PersonInfo();
            personInfo.passportNo = lines[lines.Length - 1].Split('|')[0];
            personInfo.name = lines[lines.Length - 1].Split('|')[1];

            int i = bll.GetRecordCount(string.Empty);

            TravelAgency.Model.VisaInfo model = bll.GetModelByPassportNo(personInfo.passportNo);

            Console.WriteLine(model.EntryTime.ToString());


        }
    }
}
