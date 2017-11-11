using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTPDemo
{
    public partial class Form1 : Form
    {
        FtpHandler ftpHandler = new FtpHandler();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ftpHandler.SetParams("127.0.0.1:50001", "I:/pictures", string.Empty, string.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(ftpHandler.FileExist("E18158985.jpg"));
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            ftpHandler.Download("I:\\pictures1","E18158985.jpg");

        }


    }
}
