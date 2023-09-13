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
    public class DeleteUserCommand : CommandBase
    {

        private readonly UsersViewModel _viewModel;

        private UserService service;

        public DeleteUserCommand(UsersViewModel viewModel)
        {
            service = new UserService();
            _viewModel = viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
        }

        private void _viewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //if (e.PropertyName == nameof(CategoriesViewModel.CurrentRecord.Category_name) || e.PropertyName == nameof(CategoriesViewModel.CurrentRecord.Category_id))
            //{
            //    OnCanExecuteChanged();
            //}

            if (e.PropertyName == nameof(UsersViewModel.CurrentUser))
            {
                OnCanExecuteChanged();
            }
        }

        public override void Execute(object parameter)
        {
            try
            {

                if (_viewModel.CurrentUser == null)
                {
                    _viewModel.CurrentUser = _viewModel.CurrentListRecord;
                }

                var isDeleted = service.DeleteUser(_viewModel.CurrentUser);

                _viewModel.LoadUsersRelayCommand.Execute(null);
                //LoadData();

                if (isDeleted)
                {
                    _viewModel.Message = "User Deleted";
                }
                else { _viewModel.Message = "Delete Operation Failed"; }

            }
            catch (Exception ex)
            {

                _viewModel.Message = ex.Message;

            }
        }

    }
}
