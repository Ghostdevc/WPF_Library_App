using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    public class UserService
    {

        DbLibraryEntities libraryEntities;

        public UserService()
        {
            libraryEntities = new DbLibraryEntities();
        }

        public List<UserDTO> GetUsers()
        {
            List<UserDTO> users = new List<UserDTO>();

            try
            {

                var objQuery = from user in libraryEntities.Tbl_User
                               select user;
                foreach (var user in objQuery)
                {
                    users.Add(new UserDTO { User_id = user.Id_User, User_name = user.User_Name, User_surname = user.User_Surname, User_nick = user.User_UserNick, User_password = user.User_Password, User_type_id = (int)user.FK_UserTypeID });
                }
            }
            catch (Exception)
            {

                throw;
            }
            return users;
        }

        public bool AddUser(UserDTO userToAdd)
        {
            bool isAdded = false;

            try
            {

                var newUser = new Tbl_User{ Id_User = userToAdd.User_id, User_Name = userToAdd.User_name, FK_UserTypeID = userToAdd.User_type_id, User_Surname = userToAdd.User_surname, User_Password = userToAdd.User_password, User_UserNick = userToAdd.User_nick };

                libraryEntities.Tbl_User.Add(newUser);
                var NoOfRowsEffected = libraryEntities.SaveChanges();
                isAdded = NoOfRowsEffected > 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return isAdded;
        }

        public bool DeleteUser(UserDTO userToDelete)
        {
            bool isDeleted = false;

            try
            {
                var user = new Tbl_User();

                user = libraryEntities.Tbl_User.Find(userToDelete.User_id);

                libraryEntities.Tbl_User.Remove(user);
                var NoOfRowsEffected = libraryEntities.SaveChanges();
                isDeleted = NoOfRowsEffected > 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return isDeleted;
        }

        public bool UpdateUser(UserDTO userToUpdate)
        {
            bool isUpdated = false;

            try
            {

                var user = new Tbl_User { Id_User = userToUpdate.User_id, User_Name = userToUpdate.User_name, FK_UserTypeID = userToUpdate.User_type_id, User_Surname = userToUpdate.User_surname, User_Password = userToUpdate.User_password, User_UserNick = userToUpdate.User_nick };

                libraryEntities.Tbl_User.AddOrUpdate(user);
                var NoOfRowsEffected = libraryEntities.SaveChanges();
                isUpdated = NoOfRowsEffected > 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return isUpdated;
        }

        public Tbl_User SearchUser(int id)
        {

            return libraryEntities.Tbl_User.Find(id);

        }

    }
}
