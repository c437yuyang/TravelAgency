using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using TravelAgency.BLL;

namespace TelerikDemo
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
            ThemeResolutionService.ApplicationThemeName = "TelerikMetro";
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            TravelAgency.BLL.VisaInfo bll = new VisaInfo();

            this.radGridView1.DataSource = bll.GetListByPageOrderByHasChecked(1, 30);

        }
    }
}
