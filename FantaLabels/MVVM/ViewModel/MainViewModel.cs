using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FantaLabels.MVVM.Model;
using FantaLabels.MVVM.View;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;


namespace FantaLabels.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        private LabelViewModel _labelVM;
        public ICommand FinalizeLabelCommand { get; }
        public LabelViewModel LabelVM
        {
            get => _labelVM;
            set => SetProperty(ref _labelVM, value);
        }

        public MainViewModel()
        {
            LabelVM = new LabelViewModel();
            FinalizeLabelCommand = new RelayCommand(LabelVM.FinalizeLabel);
        }
    }
}
