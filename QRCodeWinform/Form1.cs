using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Forms;
using Gma.QrCodeNet.Encoding.Windows.Render;
using TravelAgency.Common.QRCode;

namespace QRCodeWinform
{
    public partial class Form1 : Form
    {
        public string _demoString { get; set; }
        public Form1()
        {
            _demoString = "我是abc小天马def\n@、；";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            qrCodeGraphicControl1.Text = qrCodeGraphicControl1.Text + "1";
        }

        //这个方法的中文就是正确的了，推荐使用这个方法
        private void button2_Click(object sender, EventArgs e)
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.M);
            QrCode qrCode = qrEncoder.Encode(_demoString);
            //保存成png文件
            string filename = @"QRCode.png";
            GraphicsRenderer render = new GraphicsRenderer(new FixedModuleSize(5, QuietZoneModules.Two), Brushes.Black, Brushes.White);
            using (FileStream stream = new FileStream(filename, FileMode.Create))
            {
                render.WriteToStream(qrCode.Matrix, ImageFormat.Png, stream);
            }
        }

        //这个方法保存的图像会太大，不好
        private void button3_Click(object sender, EventArgs e)
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.M);
            QrCode qrCode = qrEncoder.Encode("我是abc小def天马\n@、");
            //保存成png文件
            string filename = @"QRCodeChinese.png";
            GraphicsRenderer render = new GraphicsRenderer(new FixedModuleSize(5, QuietZoneModules.Two), Brushes.Black, Brushes.White);

            Bitmap map = new Bitmap(500, 500);
            Graphics g = Graphics.FromImage(map);
            g.FillRectangle(Brushes.Red, 0, 0, 500, 500);
            render.Draw(g, qrCode.Matrix, new Point(20, 20));
            map.Save(filename, ImageFormat.Png);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            qrCodeGraphicControl1.Text = _demoString;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.M);
            QrCode qrCode = qrEncoder.Encode(_demoString);
            //保存成png文件
            string filename = @"QRCodeResize.png";
            //ModuleSize 设置图片大小  
            //QuietZoneModules 设置周边padding
            /*
                * 5----150*150    padding:5 最终165*165
                * 10----300*300   padding:10 最终330 * 330
                * 20----600*600   padding:20 最终660 * 660
                */
            //GraphicsRenderer render = new GraphicsRenderer(new FixedModuleSize(10, QuietZoneModules.Two), Brushes.Black, Brushes.White);
            GraphicsRenderer render = new GraphicsRenderer(new FixedModuleSize(20, QuietZoneModules.Two), Brushes.Black, Brushes.White);


            using (FileStream stream = new FileStream(filename, FileMode.Create))
            {
                render.WriteToStream(qrCode.Matrix, ImageFormat.Png, stream);
            }

            //Point padding = new Point(10, 10);
            //DrawingSize dSize = render.SizeCalculator.GetSize(qrCode.Matrix.Width);
            //Bitmap map = new Bitmap(dSize.CodeWidth + padding.X, dSize.CodeWidth + padding.Y);
            //Graphics g = Graphics.FromImage(map);
            //render.Draw(g, qrCode.Matrix, padding);
            //map.Save(filename, ImageFormat.Png);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            MyQRCode qrcode = new MyQRCode();
            //qrcode.EncodeToCtrl(this.qrCodeGraphicControl1.Text + 1, this.qrCodeGraphicControl1);

            //qrcode.EncodeToPng("aa","aa",QRCodeSaveSize.Size165X165);
            //qrcode.EncodeToImage(QRCodeSaveSize.Size165X165);

        }



    }
}
