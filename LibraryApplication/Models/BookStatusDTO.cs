using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    public class BookStatusDTO : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private int book_status_id;

        public int Book_status_id
        {
            get { return book_status_id; }
            set { book_status_id = value; OnPropertyChanged("Book_status_id"); }
        }

        private string book_status_name;

        public string Book_status_name
        {
            get { return book_status_name; }
            set { book_status_name = value; OnPropertyChanged("Book_status_name"); }
        }


    }
}
