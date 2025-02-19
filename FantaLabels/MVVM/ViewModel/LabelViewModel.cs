using FantaLabels.MVVM.Model;
using System.Windows.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FantaLabels.MVVM.ViewModel
{

    class LabelViewModel : ObservableObject
    {
        private Label _label;
        private BitmapImage _qrCodeImage;
        public Label Label
        {
            get => _label;
            set
            {
                SetProperty(ref _label, value);
                GenerateQrCode();
            }
        }

        public BitmapImage QrCodeImage
        {
            get => _qrCodeImage;
            set => SetProperty(ref _qrCodeImage, value);
        }

        public LabelViewModel(Label label)
        {
            Label = label;
        }

        private void GenerateQrCode()
        {
            string qrData = $"{Label.Name},{Label.Owner},{Label.ExpirationDate}";
            //QrCodeImage = QrCodeHelper.GenerateQrCode(qrData);
            QrCodeImage = QrCodeHelper.GenerateQrCode("hola");

        }
    }
}
