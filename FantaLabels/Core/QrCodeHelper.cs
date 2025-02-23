using System.IO;
using System.Windows.Media.Imaging;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;

namespace FantaLabels.MVVM.Model
{
    public static class QrCodeHelper
    {
        public static BitmapImage GenerateQrCode(string data)
        {
            using QRCodeGenerator qrGenerator = new();
            using QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
            using QRCode qrCode = new(qrCodeData);
            Bitmap qrBitmap = qrCode.GetGraphic(10); 
            return BitmapToImageSource(qrBitmap);
        }

        private static BitmapImage BitmapToImageSource(Bitmap bitmap)
        {
            using MemoryStream stream = new();
            bitmap.Save(stream, ImageFormat.Png);
            stream.Position = 0;
            BitmapImage image = new();
            image.BeginInit();
            image.StreamSource = stream;
            image.CacheOption = BitmapCacheOption.OnLoad;
            image.EndInit();
            return image;
        }
    }
}
