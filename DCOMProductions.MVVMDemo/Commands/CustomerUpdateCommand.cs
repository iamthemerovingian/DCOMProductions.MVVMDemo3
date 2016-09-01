
namespace DCOMProductions.MVVMDemo.Commands
{
    using System;
    using System.Windows.Input;
    using DCOMProductions.MVVMDemo.ViewModels;
    internal class CustomerUpdateCommand : ICommand
    {
        private CustomerViewModel viewModel;

        public CustomerUpdateCommand(CustomerViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        #region ICommand Members

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            //return _ViewModel.CanUpdate;
            return string.IsNullOrWhiteSpace(viewModel.Customer.Error);
        }

        public void Execute(object parameter)
        {
            viewModel.SaveChanges();   
        }

        #endregion
    }
}
