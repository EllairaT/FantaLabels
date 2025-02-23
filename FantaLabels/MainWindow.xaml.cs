using FantaLabels.MVVM.View;
using FantaLabels.MVVM.ViewModel;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;


namespace FantaLabels
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var labelView = new LabelView();

            LabelViewContainer.Content = labelView;

            DataContext = new MainViewModel();

        }
        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {

            // Accessing the LabelViewControl directly
            var labelView = LabelViewContainer.Content as LabelView;

            if (labelView != null)
            {
                Debug.WriteLine("not null");
                PrintLabel(labelView);
            }
            else
            {
                Debug.WriteLine("im null????");
            }
        }

        private void PrintLabel(FrameworkElement elementToPrint)
        {
            // Create a PrintDialog instance
            PrintDialog printDialog = new PrintDialog();

            // Check if the print dialog was successfully opened
            if (printDialog.ShowDialog() == true)
            {
                // Print the content of the LabelView
                printDialog.PrintVisual(elementToPrint, "Label Print Job");
            }
        }
    }
}