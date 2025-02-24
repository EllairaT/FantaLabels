
using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;

namespace FantaLabels.MVVM.Model
{
    public class Label : ObservableObject
    {
        private string _name;
        private string _owner;
        private DateTime _entryDate;
        private DateTime _expiryDate;
        private string _purpose;
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
        public Label(string name, string owner, DateTime entryDate, DateTime expiryDate, string purpose)
        {
            Name = name;
            Owner = owner;
            EntryDate = entryDate;
            ExpiryDate = expiryDate;
            Purpose = purpose;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        public Label() { }
    }
}
