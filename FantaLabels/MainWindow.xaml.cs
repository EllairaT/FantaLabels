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

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            //PrintHelper.PrintVisual(LabelUserControl, "Label Print");
            System.Diagnostics.Debug.WriteLine("hi");
        }
    }
}