using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gma.QrCodeNet.Encoding;
namespace QRCodeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write(@"Type some text to QR code: ");
            //string sampleText = Console.ReadLine();
            string sampleText = "我们hello world哈哈\n";
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.M);
            QrCode qrCode = qrEncoder.Encode(sampleText);
            for (int j = 0; j < qrCode.Matrix.Width; j++)
            {
                for (int i = 0; i < qrCode.Matrix.Width; i++)
                {

                    char charToPrint = qrCode.Matrix[i, j] ? '█' : ' ';
                    Console.Write(charToPrint);
                }
                Console.WriteLine();
            }
            Console.WriteLine(@"Press any key to quit.");
            Console.ReadKey();
        }
    }
}
