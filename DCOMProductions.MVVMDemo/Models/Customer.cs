﻿namespace DCOMProductions.MVVMDemo.Models
{
    using System;
    using System.ComponentModel;
    public class Customer : INotifyPropertyChanged, IDataErrorInfo
    {
        public Customer(string customerName)
        {
            Name = customerName;  
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
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

        #region IDataErrorInfo Members
        public string Error
        {
            get;
            private set;
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "Name")
                {
                    if (string.IsNullOrWhiteSpace(Name))
                    {
                        Error = "Name cannot be null or empty. ";
                    }
                    else
                    {
                        Error = null;
                    }
                }
                return Error;
            }
        }

        #endregion
    }
}
