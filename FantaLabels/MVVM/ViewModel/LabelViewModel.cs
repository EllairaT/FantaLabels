using FantaLabels.MVVM.Model;
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
        private string _formattedEntry;
        private string _formattedExpiry;

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
            set
            {
                SetProperty(ref _entryDate, value);
            }
        }

        public DateTime ExpiryDate
        {
            get => _expiryDate;
            set
            {
                SetProperty(ref _expiryDate, value);
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
            //Label = new Label();
        }
    }
}
