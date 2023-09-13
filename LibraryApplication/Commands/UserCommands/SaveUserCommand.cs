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
    public class SaveUserCommand : CommandBase
    {

        private readonly UsersViewModel _viewModel;

        private UserService service;

        public SaveUserCommand(UsersViewModel viewModel)
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

                var isSaved = service.AddUser(_viewModel.CurrentUser);

                _viewModel.LoadUsersRelayCommand.Execute(null);

                if (isSaved)
                {
                    _viewModel.Message = "User Saved";
                }
                else
                {
                    _viewModel.Message = "Save Operation Failed";
                }
            }
            catch (Exception ex)
            {
                _viewModel.Message = ex.Message;
            }
        }

    }
}
