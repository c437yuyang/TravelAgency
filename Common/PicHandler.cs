using System.Drawing;

namespace TravelAgency.Common
{
    public static class PicHandler
    {

        /// <summary>
        /// 画到图像的下面，这个函数就是计算了坐标
        /// </summary>
        /// <param name="image"></param>
        public static void DrawStringOnPicture(Image image)
        {
            
        }

        /// <summary>
        /// 把文字画到图像的指定位置
        /// </summary>
        /// <param name="image"></param>
        public static void DrawStringOnPicture(Image image,PointF pointF)
        {
            Graphics g = Graphics.FromImage(image);
            Font font = new Font("华为宋体", 12);
            g.DrawString("我是Kimisme", font, Brushes.Coral, pointF);

        }
         
    }
}