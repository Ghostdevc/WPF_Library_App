using LibraryApplication.Commands;
using LibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace LibraryApplication.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {

        

        LoginService loginService;

        public LoginViewModel(Stores.NavigationStore navigationStore)
        {

            loginService = new LoginService();

            currentUserToLogin = new UserDTO();

            loginCommand = new RelayCommand(Login);

            NavigateToMainCommand = new NavigateToAdminMainCommand(navigationStore);
            
        }


        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged("Message"); }
        }

        private string password = "";

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }



        private UserDTO currentUserToLogin;

        public UserDTO CurrentUserToLogin
        {
            get { return currentUserToLogin; }
            set { currentUserToLogin = value; OnPropertyChanged("CurrentUserToLogin"); }
        }



        private RelayCommand loginCommand;

        public RelayCommand LoginCommand
        {
            get { return loginCommand; }
        }


        public async void Login()
        {

            try
            {
                CurrentUserToLogin.User_nick = Username;
                CurrentUserToLogin.User_password = Password;

                var isLoggedInUserObject = loginService.Login(currentUserToLogin);

                if (isLoggedInUserObject.User_type_id != 0 && isLoggedInUserObject.User_id != 0 && isLoggedInUserObject.User_id != null && isLoggedInUserObject.User_type_id != null)
                {
                    int userType = isLoggedInUserObject.User_type_id;
                    Message = "Login Successfull";
                    await Task.Delay(1000);
                    NavigateToMainCommand.Execute(null);
                    //Navigation
                }
                else
                {
                    Message = "Login Failed";
                }
            }
            catch (Exception ex)
            {

                Message = ex.Message;
            }
            

        }


        public ICommand NavigateToMainCommand { get; } 



    }
}
