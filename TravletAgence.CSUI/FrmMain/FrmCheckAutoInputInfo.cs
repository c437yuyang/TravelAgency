using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravletAgence.CSUI.FrmMain
{
    public partial class FrmCheckAutoInputInfo : Form
    {
        public FrmCheckAutoInputInfo()
        {
            InitializeComponent();
        }

        private void FrmCheckAutoInputInfo_Load(object sender, EventArgs e)
        {
            this.picPassportNo.SizeMode = PictureBoxSizeMode.Zoom;
            picPassportNo.Image = Image.FromFile("E68526741.jpg");
        }
    }
}
