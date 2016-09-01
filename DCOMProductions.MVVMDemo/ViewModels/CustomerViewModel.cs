namespace DCOMProductions.MVVMDemo.ViewModels
{
    using System;
    using System.Diagnostics;
    using System.Windows.Input;
    using DCOMProductions.MVVMDemo.Models;
    using DCOMProductions.MVVMDemo.Commands;
    internal class CustomerViewModel
    {
        public CustomerViewModel()
        {
            _Customer = new Customer("David");
            UpdateCommand = new CustomerUpdateCommand(this);
        }

        private Customer _Customer;

        public Customer Customer
        {
            get
            {
                return _Customer;
            }
        }

        public ICommand UpdateCommand
        {
            get;
            private set;
        }
        public bool CanUpdate
        {
            get
            {
                if (Customer == null)
                {
                    return false;
                }

                return !String.IsNullOrWhiteSpace(Customer.Name);
            }
        }

        public void SaveChanges()
        {
            Debug.Assert(false, string.Format("{0} was updated.", Customer.Name));
        }
    }
}
