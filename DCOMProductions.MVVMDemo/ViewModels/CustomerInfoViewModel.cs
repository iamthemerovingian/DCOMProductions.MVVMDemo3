
namespace DCOMProductions.MVVMDemo.ViewModels
{
    using System;
    using System.ComponentModel;
    
    internal class CustomerInfoViewModel : INotifyPropertyChanged
    {
        private string info;
        public string Info
        {
            get
            {
                return info;
            }

            set
            {
                info = value;
                OnPropertyChanged("Info");
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
