﻿using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using TravelAgency.Common;
using TravelAgency.Common.QRCode;

namespace TravelAgency.CSUI.FrmSub
{
    public partial class FrmQRCode : Form
    {
        private string _qrinfo;
        private readonly MyQRCode _qrCode = new MyQRCode();
        private readonly string _tmpFileName = GlobalUtils.AppPath + "\\tmp.png";

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
            this.MinimumSize = this.Size;
            SetQRCodeToPicBox();
        }

        private void SetQRCodeToPicBox()
        {
            _qrCode.EncodeToPng(_qrinfo, _tmpFileName, QRCodeSaveSize.Size165X165);

            picQRCode.Image = GlobalUtils.LoadImageFromFileNoBlock(_tmpFileName);
            txtQRCodeInfo.Text = _qrinfo;
        }

        private void btnUpdateQRCode_Click(object sender, EventArgs e)
        {
            _qrinfo = txtQRCodeInfo.Text;
            SetQRCodeToPicBox();
        }

        private void btnSavePic_Click(object sender, EventArgs e)
        {
            string defaultName = string.Empty;
            if(!_qrinfo.Contains("State:"))
                defaultName = _qrinfo.Split('|')[0] + "_QRCode.jpg";

            string dstName = GlobalUtils.OpenSaveFileDlg(defaultName,
                "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png");

            // If the file name is not an empty string open it for saving.
            if (!string.IsNullOrEmpty(dstName))
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                    File.OpenWrite(dstName);
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                string ext = dstName.Substring(dstName.LastIndexOf('.') + 1,
                    dstName.Length - dstName.LastIndexOf('.') - 1);
                if (ext == "jpg")
                {
                    this.picQRCode.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else if (ext == "bmp")
                {
                    this.picQRCode.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                }
                else if (ext == "gif")
                {
                    this.picQRCode.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                }
                else if (ext == "png")
                {
                    this.picQRCode.Image.Save(fs,
                        System.Drawing.Imaging.ImageFormat.Png);
                }
                else
                {
                    return;
                    
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