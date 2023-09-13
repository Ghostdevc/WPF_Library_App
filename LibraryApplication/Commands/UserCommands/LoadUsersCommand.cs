using LibraryApplication.Models;
using LibraryApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Commands.UserCommands
{
    public class LoadUsersCommand : CommandBase
    {

        private readonly UsersViewModel _viewModel;

        private UserService service;

        public LoadUsersCommand(UsersViewModel viewModel)
        {
            service = new UserService();
            _viewModel = viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
        }

        private void _viewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(UsersViewModel.UsersList))
            {
                OnCanExecuteChanged();
            }
        }

        public override void Execute(object parameter)
        {
            
            //_viewModel.UsersList = service.GetUsers();

            _viewModel.LoadUsersRelayCommand.Execute(parameter);


        }

    }
}
