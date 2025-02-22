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
        private string _formattedEntry;
        private string _formattedExpiry;
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
            set
            {
                if (SetProperty(ref _entryDate, value))
                {
                    System.Diagnostics.Debug.WriteLine($"EntryDate set to: {value}");
                    // Update FormattedEntry when EntryDate changes
                    FormattedEntry = FormatDate(value);
                }
            }
        }

        public DateTime ExpiryDate
        {
            get => _expiryDate;
            set
            {
                if (SetProperty(ref _expiryDate, value))
                {
                    // Update FormattedExpiry when ExpiryDate changes
                    FormattedExpiry = FormatDate(value);
                }
            }
        }

        public string Purpose
        {
            get => _purpose;
            set => SetProperty(ref _purpose, value);
        }

        public string FormattedEntry
        {
            get => _formattedEntry;
            set => SetProperty(ref _formattedEntry, value);
        }

        public string FormattedExpiry
        {
            get => _formattedExpiry;
            set => SetProperty(ref _formattedExpiry, value);
        }

        public static string FormatDate(DateTime date)
        {

            return date.ToString("dd/MM/yyyy");
        }

        public LabelViewModel()
        {
            EntryDate = DateTime.Now;
            ExpiryDate = DateTime.Now;
            // Initialize with placeholder data
            //_label = new Label("ExamplePartX1", "John Doe", DateTime.Now, DateTime.Now, "Placeholder text");
            Label = new Label();
        }
    }
}
