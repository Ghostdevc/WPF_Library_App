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
    public class SearchUserCommand : CommandBase
    {

        private readonly UsersViewModel _viewModel;

        private UserService service;

        public SearchUserCommand(UsersViewModel viewModel)
        {
            service = new UserService();
            _viewModel = viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
        }

        private void _viewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(UsersViewModel.CurrentUser))
            {
                OnCanExecuteChanged();
            }
        }

        public override void Execute(object parameter)
        {
            try
            {
                var objRecord = service.SearchUser(_viewModel.CurrentUser.User_id);
                if (objRecord != null)
                {
                    _viewModel.CurrentUser.User_name = objRecord.User_Name;
                    _viewModel.CurrentUser.User_surname = objRecord.User_Surname;
                    _viewModel.CurrentUser.User_nick = objRecord.User_UserNick;
                    _viewModel.CurrentUser.User_password = objRecord.User_Password;
                    _viewModel.CurrentUser.User_type_id = (int)objRecord.FK_UserTypeID;
                }
                else
                {
                    _viewModel.Message = "User Not Found";
                }
            }
            catch (Exception ex)
            {

                _viewModel.Message = ex.Message;
            }
        }

    }
}
