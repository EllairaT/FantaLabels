using System;
using CommunityToolkit.Mvvm.ComponentModel;


namespace FantaLabels.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public LabelViewModel LabelVM { get; set; }
        private object _labelView {  get; set; }


        public object LabelView
        {
            get { return _labelView; }
            set 
            { 
                _labelView = value; 
                OnPropertyChanged();
            }
        }
        public MainViewModel() 
        {
            LabelVM = new LabelViewModel();
            _labelView = LabelVM;
        }
    }
}
