using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FantaLabels.MVVM.Model;
using System.Windows.Input;


namespace FantaLabels.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {

        private LabelViewModel _labelVM;
        public ICommand UpdateLabelCommand { get; }
        public LabelViewModel LabelVM
        {
            get => _labelVM;
            set => SetProperty(ref _labelVM, value);
        }

        public MainViewModel()
        {
            LabelVM = new LabelViewModel();
            UpdateLabelCommand = new RelayCommand(UpdateLabel);
        }

        private void UpdateLabel()
        {

            //System.Diagnostics.Debug.WriteLine($"Finalized Label: {LabelVM.Label.Name}, {LabelVM.Label.Purpose}, {LabelVM.FormattedEntry}, {LabelVM.FormattedExpiry}");
            System.Diagnostics.Debug.WriteLine(LabelVM.Label.ToString());
        }
    }
}
