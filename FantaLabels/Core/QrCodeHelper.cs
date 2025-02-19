using System.IO;
using System.Windows.Media.Imaging;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;

namespace FantaLabels.MVVM.Model
{
    public static class QrCodeHelper
    {
        public static BitmapImage GenerateQrCode(string text)
        {
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q))
            using (QRCode qrCode = new QRCode(qrCodeData))
            {
                Bitmap qrBitmap = qrCode.GetGraphic(10); // 10 = pixel per module
                return BitmapToImageSource(qrBitmap);
            }
        }

        private static BitmapImage BitmapToImageSource(Bitmap bitmap)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                bitmap.Save(stream, ImageFormat.Png);
                stream.Position = 0;
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.StreamSource = stream;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.EndInit();
                return image;
            }
        }
    }
}
