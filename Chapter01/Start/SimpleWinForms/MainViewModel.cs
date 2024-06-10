using System.ComponentModel;
using System.Diagnostics;

namespace SimpleWinForms
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private string name;
        
        public MainViewModel()
        {
            name = string.Empty; 
        }

        public string Name
        {
            get
            {
                Debug.WriteLine($"Getting Name {name}");
                return name;
            }
            set
            {
                Debug.WriteLine($"Setting Name to {value}");
                
                name = value;

                // fire Changed event for Name
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }
    }
}
