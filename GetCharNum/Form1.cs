using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetCharNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int GetStringNum(string str)
        {
            var arr = str.ToCharArray();

            int res = 0;

            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                double radix = Math.Pow(26.0,i*1.0);
                
                res += (arr[len - 1 - i]-'A' + 1)*(int)radix;
                
            }
            return res;
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            textBoxX2.Text = GetStringNum(textBoxX1.Text).ToString();
        }
    }
}
