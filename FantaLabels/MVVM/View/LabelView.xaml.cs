using FantaLabels.MVVM.ViewModel;
using System.Windows;
using System.Windows.Controls;


namespace FantaLabels.MVVM.View
{
    /// <summary>
    /// Interaction logic for LabelView.xaml
    /// </summary>
    public partial class LabelView : UserControl
    {
        public LabelView()
        {
            InitializeComponent();
            // We need the datacontext to be MainViewModel because it has our LabelViewModel. We want to use that.
            DataContext = (Application.Current.MainWindow as MainWindow)?.DataContext as MainViewModel;
            //Debug.WriteLine($"LabelView DataContext: {this.DataContext?.GetType().Name}");
        }
    }
}
