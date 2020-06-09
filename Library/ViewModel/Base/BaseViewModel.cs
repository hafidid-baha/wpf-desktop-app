using System;
using System.ComponentModel;

namespace Library
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => {};

        public void OnPropertyChanged(String name)
        {            
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }

    
}
