using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravletAgence.Common.QRCode;

namespace TravletAgence.CSUI
{
    public partial class FrmQRCode : Form
    {
        private string _qrinfo;
        private MyQRCode _qrCode = new MyQRCode();
        private string _tmpFileName = "tmp.png";

        public FrmQRCode()
        {
            InitializeComponent();
        }

        public FrmQRCode(string qrinfo)
        {
            InitializeComponent();
            _qrinfo = qrinfo;
        }

        private void FrmQRCode_Load(object sender, EventArgs e)
        {
            SetQRCodeToPicBox();
        }

        private void SetQRCodeToPicBox()
        {
            _qrCode.EncodeToPng(_qrinfo, _tmpFileName, QRCodeSaveSize.Size165X165);

            FileStream fileStream = new FileStream(_tmpFileName, FileMode.Open, FileAccess.Read);
            int byteLength = (int)fileStream.Length;
            byte[] fileBytes = new byte[byteLength];
            fileStream.Read(fileBytes, 0, byteLength);
            //文件流关闭,文件解除锁定
            fileStream.Close();
            picQRCode.Image = Image.FromStream(new MemoryStream(fileBytes));
            txtQRCodeInfo.Text = _qrinfo;
        }

        private void btnUpdateQRCode_Click(object sender, EventArgs e)
        {
            _qrinfo = txtQRCodeInfo.Text;
            SetQRCodeToPicBox();
        }
    }
}
