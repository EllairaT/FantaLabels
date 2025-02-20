using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FantaLabels.MVVM.Model;
using System.Windows.Input;


namespace FantaLabels.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {

        public LabelViewModel LabelVM { get; set; }

        public ICommand UpdateLabelCommand { get; }

        public MainViewModel()
        {
            LabelVM = new LabelViewModel();
            UpdateLabelCommand = new RelayCommand(UpdateLabel);
        }

        private void UpdateLabel()
        {
            System.Diagnostics.Debug.WriteLine($"Finalized Label: {LabelVM.Label.Name}, {LabelVM.Label.Purpose}, {LabelVM.EntryDate}, {LabelVM.ExpiryDate}");
        }
    }
}
