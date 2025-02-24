using FantaLabels.MVVM.View;
using FantaLabels.MVVM.ViewModel;
using Microsoft.Win32;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace FantaLabels
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext =new MainViewModel();
        }

        // Making sure LabelView is initialised because things break otherwise
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var labelView = new LabelView();
            LabelViewContainer.Content = labelView;
            if (labelView != null)
            {          
                Debug.WriteLine("LabelView has been initialized!");
            }
            else
            {
                Debug.WriteLine("LabelView is still null.");
            }
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            var labelViewControl = LabelViewContainer.Content as UserControl;

            if (labelViewControl != null)
            {
                PrintLabel(labelViewControl);
            }
            else
            {
                MessageBox.Show("LabelViewControl is not available.");
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