using FantaLabels.MVVM.ViewModel;
using System;
using System.Windows;

namespace FantaLabels
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext=new MainViewModel();
        }
    }
}