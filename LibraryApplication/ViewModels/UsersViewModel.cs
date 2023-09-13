using LibraryApplication.Commands;
using LibraryApplication.Commands.UserCommands;
using LibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryApplication.ViewModels
{
    public class UsersViewModel : ViewModelBase
    {


        UserService userService;

        public UsersViewModel(Stores.NavigationStore navigationStore)
        {
            userService = new UserService();
            LoadData();
            currentUser = new UserDTO();
            
            SaveUserCommand = new SaveUserCommand(this);

            
            SearchUserCommand = new SearchUserCommand(this);

            
            UpdateUserCommand = new UpdateUserCommand(this);

            
            DeleteUserCommand = new DeleteUserCommand(this);

            loadUsersRelayCommand = new RelayCommand(LoadData);

            NavigateMainCommand = new NavigateToAdminMainCommand(navigationStore);
        }

        public ICommand NavigateMainCommand { get; }


        #region Display_Operation
        private List<UserDTO> usersList;

        public List<UserDTO> UsersList
        {
            get { return usersList; }
            set { usersList = value; OnPropertyChanged("UsersList"); }
        }


        private RelayCommand loadUsersRelayCommand;

        public RelayCommand LoadUsersRelayCommand
        {
            get { return loadUsersRelayCommand; }
        }


        private void LoadData()
        {
            UsersList = new List<UserDTO>(userService.GetUsers());
        }
        #endregion

        private UserDTO currentUser;

        public UserDTO CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; OnPropertyChanged("CurrentUser"); }
        }

        private UserDTO currentListRecord;

        public UserDTO CurrentListRecord
        {
            get { return currentListRecord; }
            set { currentListRecord = value; OnPropertyChanged(nameof(CurrentListRecord)); }
        }


        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged("Message"); }
        }

        #region SaveOperation

        public ICommand SaveUserCommand { get; set; }

        #endregion

        #region SearchOperation

        public ICommand SearchUserCommand { get; set; }
       
        #endregion

        #region UpdateOperation

        public ICommand UpdateUserCommand { get; set; }
       
        #endregion

        #region DeleteOperation

        public ICommand DeleteUserCommand { get; set; }
       
        #endregion

    }
}
