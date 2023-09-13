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
    public class UpdateUserCommand : CommandBase
    {

        private readonly UsersViewModel _viewModel;

        private UserService service;

        public UpdateUserCommand(UsersViewModel viewModel)
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

            //if (e.PropertyName == nameof(CategoriesViewModel.CurrentRecord))
            //{
            //    OnCanExecuteChanged();
            //}

        }

        public override void Execute(object parameter)
        {
            try
            {

                if (_viewModel.CurrentUser == null)
                {
                    _viewModel.CurrentUser = _viewModel.CurrentListRecord;
                }

                var isUpdated = service.UpdateUser(_viewModel.CurrentUser);

                _viewModel.LoadUsersRelayCommand.Execute(null);

                if (isUpdated)
                {
                    _viewModel.Message = "User Updated";
                    //_viewModel.LoadCategoriesRelayCommand.Execute(this);
                    //LoadData();
                }
                else
                {
                    _viewModel.Message = "Update operation failed";
                }
            }
            catch (Exception ex)
            {
                _viewModel.Message = ex.Message;
            }
        }

    }
}
