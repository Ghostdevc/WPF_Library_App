using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    public class CategoryDTO : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private int category_id;

        public int Category_id
        {
            get { return category_id; }
            set { category_id = value; OnPropertyChanged("Category_id"); }
        }

        private string category_name;

        public string Category_name
        {
            get { return category_name; }
            set { category_name = value; OnPropertyChanged("Category_name"); }
        }


    }
}
