namespace DCOMProductions.MVVMDemo.ViewModels
{
    using System;
    using System.Diagnostics;
    using System.Windows.Input;
    using DCOMProductions.MVVMDemo.Models;
    using DCOMProductions.MVVMDemo.Commands;
    using DCOMProductions.MVVMDemo.Views;

    internal class CustomerViewModel
    {
        private Customer customer;
        private CustomerInfoViewModel childViewModel;
        public CustomerViewModel()

        {
            customer = new Customer("David");
            UpdateCommand = new CustomerUpdateCommand(this);
            childViewModel = new CustomerInfoViewModel() { Info = "Instantiated in CustomerViewModel() ctor. "};

        }

        public Customer Customer
        {
            get
            {
                return customer;
            }
        }

        public ICommand UpdateCommand
        {
            get;
            private set;
        }
        //public bool CanUpdate
        //{
        //    get
        //    {
        //        if (Customer == null)
        //        {
        //            return false;
        //        }
        //        return !String.IsNullOrWhiteSpace(Customer.Name);
        //    }
        //}

        public void SaveChanges()
        {
            //Debug.Assert(false, string.Format("{0} was updated.", Customer.Name));
            CustomerInfoView view = new CustomerInfoView();
            view.DataContext = childViewModel;
            childViewModel.Info = customer.Name + " was updated in the database. ";
            view.ShowDialog();
        }
    }
}
