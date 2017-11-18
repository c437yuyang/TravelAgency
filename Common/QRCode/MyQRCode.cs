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

namespace TravelAgency.Common.QRCode
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
            using (FileStream stream = new FileStream(picpath, FileMode.OpenOrCreate)) //OpenOrCreate打开新文件默认就是truncate的了，如果再显式指定Truncate反而会报错当文件不存在的时候
            {
                render.WriteToStream(qrCode.Matrix, ImageFormat.Png, stream);
            }

            Bitmap bitmap = new Bitmap(165,165);
            Graphics g = Graphics.FromImage(bitmap);
            render.Draw(g, qrCode.Matrix);
            bitmap.Save("a.bmp");


        }

        public Bitmap EncodeToImage(string str,QRCodeSaveSize saveSize)
        {
            QrCode qrCode = _qrEncoder.Encode(str);
            //保存成png文件
            GraphicsRenderer render = new GraphicsRenderer(new FixedModuleSize(Convert.ToInt32(saveSize), QuietZoneModules.Two), Brushes.Black, Brushes.White);

            MemoryStream ms = new MemoryStream();
            render.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            Bitmap bitmap = new Bitmap(ms);
            return bitmap;
        }

        //public void EncodeToCtrl(string str, QrCodeGraphicControl qcgtrl)
        //{
        //    qcgtrl.Text = str;
        //}

        

    }
}
