using MVVMworksample.ViewModel;
using System;
using System.Windows.Input;

namespace MVVMworksample.Commands
{
    //12,33
    internal class SaveCommand:ICommand
    {
        private UsersViewModel _usersViewModel;
        public SaveCommand(UsersViewModel viewModelUsers)
        {
            _usersViewModel = viewModelUsers;
        }

        public event EventHandler CanExecuteChanged
        {
            add {CommandManager.RequerySuggested+=value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return _usersViewModel.CanSaveButtonUpdate;
        }

        public void Execute(object? parameter)
        {
            _usersViewModel.SaveChangeButton();
        }
    }


    internal class UpdateCommand : ICommand
    {
        private UsersViewModel _usersViewModel;
        public UpdateCommand(UsersViewModel viewModelUsers)
        {
            _usersViewModel = viewModelUsers;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested+=value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return _usersViewModel.CanUpdateButtonUpdate;
        }

        public void Execute(object? parameter)
        {
            _usersViewModel.UpdateButton();
        }
    }

}
