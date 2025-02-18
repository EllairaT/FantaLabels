using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace FantaLabels.Core
{
    // update UI when binding
    class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        // takes attribute CallerMemberName
        protected void OnPropertyChanged([CallerMemberName] string name = null) 
        { 
            // null check the actual event
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
