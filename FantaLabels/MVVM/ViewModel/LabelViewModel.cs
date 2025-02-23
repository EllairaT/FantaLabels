using FantaLabels.MVVM.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Media.Imaging;
using QRCoder;

namespace FantaLabels.MVVM.ViewModel
{
    public class LabelViewModel : ObservableObject
    {
        private Label _label;
      
        private BitmapImage _qrCodeImage;

        public Label Label
        {
            get => _label;
            set => SetProperty(ref _label, value);
        }

          
        public BitmapImage QRCodeImage
        {
            get => _qrCodeImage;
            set => SetProperty(ref _qrCodeImage, value);
        }

        public void FinalizeLabel()
        {
            QRCodeImage = QrCodeHelper.GenerateQrCode(Label.ToString());
            System.Diagnostics.Debug.WriteLine(Label.ToString());
        }

        public LabelViewModel()
        {       
            // Initialize with placeholder data
            _label = new Label("ExamplePartX1", "John Doe", DateTime.Now, DateTime.Now, "Placeholder text");
            //Label = new Label();
        }
    }
}
