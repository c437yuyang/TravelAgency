using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtrlsDemos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimeInput1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimeInput1.Text);
        }

        private void monthCalendarAdv1_ItemClick(object sender, EventArgs e)
        {

        }
    }
}
