using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    public class LoginService
    {

        DbLibraryEntities libraryEntities;

        public LoginService()
        {
            libraryEntities = new DbLibraryEntities();
        }


        public UserDTO Login(UserDTO user)
        {
            UserDTO userToLogin = new UserDTO();

            try
            {
                var loggedUser = libraryEntities.Tbl_User.Where(x => x.User_UserNick == user.User_nick && x.User_Password == user.User_password);
                foreach (var item in loggedUser)
                {

                    userToLogin.User_id = item.Id_User;
                    userToLogin.User_type_id = (int)item.FK_UserTypeID;

                }
                

            }
            catch (Exception)
            {

                throw;
            }


            return userToLogin;
        }

    }
}
