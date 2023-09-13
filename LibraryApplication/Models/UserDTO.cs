using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    public class UserDTO : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private int user_id;

        public int User_id
        {
            get { return user_id; }
            set { user_id = value; OnPropertyChanged("User_id"); }
        }

        private int user_type_id;

        public int User_type_id
        {
            get { return user_type_id; }
            set { user_type_id = value; OnPropertyChanged("User_type_id"); }
        }

        private string user_name;

        public string User_name
        {
            get { return user_name; }
            set { user_name = value; OnPropertyChanged("User_name"); }
        }

        private string user_surname;

        public string User_surname
        {
            get { return user_surname; }
            set { user_surname = value; OnPropertyChanged("User_surname"); }
        }

        private string user_password;

        public string User_password
        {
            get { return user_password; }
            set { user_password = value; OnPropertyChanged("User_password"); }
        }

        private string user_nick;

        public string User_nick
        {
            get { return user_nick; }
            set { user_nick = value; OnPropertyChanged("User_nick"); }
        }






    }
}
