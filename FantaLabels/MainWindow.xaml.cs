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
        private void SaveLabelViewToPdf(UserControl labelViewControl)
        {
            // Create a RenderTargetBitmap to capture the visual representation of the UserControl
            RenderTargetBitmap rtb = new RenderTargetBitmap(
                (int)labelViewControl.ActualWidth,
                (int)labelViewControl.ActualHeight,
                96,
                96,
                System.Windows.Media.PixelFormats.Pbgra32);

            rtb.Render(labelViewControl);

            // Convert the RenderTargetBitmap to a stream
            MemoryStream memoryStream = new MemoryStream();
            PngBitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(rtb));
            encoder.Save(memoryStream);

            // Create a PDF document with PdfSharp
            PdfDocument pdf = new PdfDocument();
            PdfPage page = pdf.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a PDF image from the MemoryStream
            memoryStream.Position = 0;  // Ensure we're at the beginning of the stream
            XImage img = XImage.FromStream(memoryStream);
            gfx.DrawImage(img, 0, 0, page.Width, page.Height);

            // Open SaveFileDialog to allow the user to select save location
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";

            // If the user selects a path and clicks save, save the PDF
            if (saveFileDialog.ShowDialog() == true)
            {
                string filePath = saveFileDialog.FileName;
                pdf.Save(filePath);
                MessageBox.Show($"Label saved to PDF: {filePath}");
            }
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            var labelViewControl = LabelViewContainer.Content as UserControl;

            if (labelViewControl != null)
            {
                SaveLabelViewToPdf(labelViewControl);
            }
            else
            {
                MessageBox.Show("LabelViewControl is not available.");
            }
        }
    }
}