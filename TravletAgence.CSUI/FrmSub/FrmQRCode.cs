using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using TravletAgence.Common.QRCode;

namespace TravletAgence.CSUI.FrmSub
{
    public partial class FrmQRCode : Form
    {
        private string _qrinfo;
        private MyQRCode _qrCode = new MyQRCode();
        private string _tmpFileName = System.Windows.Forms.Application.StartupPath +"\\tmp.png";

        public FrmQRCode()
        {
            InitializeComponent();
        }

        public FrmQRCode(string qrinfo)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent; //不能写在form_load里面，是已经加载完成了
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

        private void btnSavePic_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";
            saveFileDialog1.Title = "Save";
            if(!_qrinfo.Contains("State:"))
                saveFileDialog1.FileName = _qrinfo.Split('|')[0] + "_QRCode.jpg";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        this.picQRCode.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        this.picQRCode.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        this.picQRCode.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case 4:
                        this.picQRCode.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }

                fs.Close();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //TODO:打印了后，改变数据库里的签证状态，所以这里最好还是用model
            PrintDialog printDialog1 = new PrintDialog();
            PrintDocument printDocument1 = new PrintDocument();
            printDialog1.Document = printDocument1;
            DialogResult r = printDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                printDocument1.Print();
            }      
        }
    }
}
