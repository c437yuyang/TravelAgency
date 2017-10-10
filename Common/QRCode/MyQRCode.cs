using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Forms;
using Gma.QrCodeNet.Encoding.Windows.Render;
using Gma.QrCodeNet.Encoding.Windows.WPF;

namespace TravletAgence.Common.QRCode
{
    public enum QRCodeSaveSize
    {
        Size165X165 = 5,
        Size330X330 = 10,
        Size660X660 = 20
    }

    public class MyQRCode
    {

        private QrEncoder _qrEncoder { get; set; }

        public MyQRCode(ErrorCorrectionLevel errorlevel = ErrorCorrectionLevel.M)
        {
            _qrEncoder = new QrEncoder(errorlevel);

        }

        public void EncodeToPng(string str, string picpath,QRCodeSaveSize saveSize)
        {
            QrCode qrCode = _qrEncoder.Encode(str);
            //保存成png文件
            GraphicsRenderer render = new GraphicsRenderer(new FixedModuleSize(Convert.ToInt32(saveSize), QuietZoneModules.Two), Brushes.Black, Brushes.White);
            using (FileStream stream = new FileStream(picpath, FileMode.OpenOrCreate| FileMode.Truncate))
            {
                render.WriteToStream(qrCode.Matrix, ImageFormat.Png, stream);
            }
        }

        public void EncodeToCtrl(string str, QrCodeGraphicControl qcgtrl)
        {
            qcgtrl.Text = str;
        }

        

    }
}
