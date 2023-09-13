using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    public class UserTypeDTO : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private int user_type_id;

        public int User_type_id
        {
            get { return user_type_id; }
            set { user_type_id = value; OnPropertyChanged("User_type_id"); }
        }

        private string user_type_name;

        public string User_type_name
        {
            get { return user_type_name; }
            set { user_type_name = value; OnPropertyChanged("User_type_name"); }
        }


    }
}
