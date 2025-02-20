using FantaLabels.MVVM.Model;
using System.Windows.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FantaLabels.MVVM.ViewModel
{
    public class LabelViewModel : ObservableObject
    {
        private Label _label;

        private string _name;
        private string _owner;
        private DateTime _entryDate;
        private DateTime _expiryDate;
        private string _purpose;


        public Label Label
        {
            get => _label;
            set => SetProperty(ref _label, value);
        }

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        public string Owner
        {
            get => _owner;
            set => SetProperty(ref _owner, value);
        }
        public DateTime EntryDate
        {
            get => _entryDate;
            set => SetProperty(ref _entryDate, value);
        }
        public DateTime ExpiryDate
        {
            get => _expiryDate;
            set => SetProperty(ref _expiryDate, value);
        }

        // Formatted entry date that binds to the UI (formatted as dd/MM/yyyy)
        public string EntryDateFormatted
        {
            get => Label.EntryDate.ToString("dd/MM/yyyy");
            set
            {
                if (DateTime.TryParse(value, out DateTime newDate))
                {
                    Label.EntryDate = newDate;
                    OnPropertyChanged(nameof(EntryDateFormatted)); // Trigger notification for the formatted property
                }
            }
        }

        // Formatted expiration date that binds to the UI (formatted as dd/MM/yyyy)
        public string ExpiryDateFormatted
        {
           
            get => Label.ExpirationDate.ToString("dd/MM/yyyy");
            set
            {
                if (DateTime.TryParse(value, out DateTime newDate))
                {
                    Label.ExpirationDate = newDate;
                    OnPropertyChanged(nameof(ExpiryDateFormatted)); // Trigger notification for the formatted property
                }
            }
       
        }

        public string Purpose
        {
            get => _purpose;
            set => SetProperty(ref _purpose, value);
        }
        public LabelViewModel()
        {
            // Initialize with placeholder data
            _label = new Label("ExamplePartX1", "John Doe", DateTime.Now, DateTime.Now, "Placeholder text");
        }
    }
}
