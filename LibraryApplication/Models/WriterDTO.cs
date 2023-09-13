using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    public class WriterDTO : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private int writer_id;

        public int Writer_id
        {
            get { return writer_id; }
            set { writer_id = value; OnPropertyChanged("Writer_id"); }
        }

        private string writer_name_surname;

        public string Writer_name_surname
        {
            get { return writer_name_surname; }
            set { writer_name_surname = value; OnPropertyChanged("Writer_name_surname"); }
        }



    }
}
