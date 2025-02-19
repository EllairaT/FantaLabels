using System;
using FantaLabels.Core;


namespace FantaLabels.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public HomeViewModel HomeVM { get; set; }
        public LabelViewModel LabelVM { get; set; }

        private object _homeView;
        private object _labelView;

        public object HomeView
        {
            get { return _homeView; }
            set
            {
                _homeView = value;
                OnPropertyChanged();
            }
        }

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
            HomeVM = new HomeViewModel();
            LabelVM = new LabelViewModel();
            HomeView = HomeVM;
            LabelVM = LabelVM;  
        }
    }
}
