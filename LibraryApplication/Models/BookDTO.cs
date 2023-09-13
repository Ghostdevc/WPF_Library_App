using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    public class BookDTO : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private int book_id;

        public int Book_id
        {
            get { return book_id; }
            set { book_id = value; OnPropertyChanged("Book_id"); }
        }

        private string book_name;

        public string Book_name
        {
            get { return book_name; }
            set { book_name = value; OnPropertyChanged("Book_name"); }
        }

        private int status_id;

        public int Status_id
        {
            get { return status_id; }
            set { status_id = value; OnPropertyChanged("Status_id"); }
        }

        private int writer_id;

        public int Writer_id
        {
            get { return writer_id; }
            set { writer_id = value; OnPropertyChanged("Writer_id"); }
        }

        private int category_id;

        public int Category_id
        {
            get { return category_id; }
            set { category_id = value; OnPropertyChanged("Category_id"); }
        }








    }
}
