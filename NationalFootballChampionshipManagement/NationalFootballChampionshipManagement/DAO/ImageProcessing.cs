using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NationalFootballChampionshipManagement.DAO
{
    public class ImageProcessing
    {

        private static ImageProcessing instance;
        public static ImageProcessing Instance
        {
            get { if (instance == null) instance = new ImageProcessing(); return instance; }
            set => instance = value;
        }
        public byte[] convertImgToByte(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public Image ByteToImg(Byte[] byteString)
        {
            MemoryStream ms = new MemoryStream(byteString, 0, byteString.Length);
            ms.Write(byteString, 0, byteString.Length);
            Image image = Image.FromStream(ms, true);

            return image;
        }
    }
}
