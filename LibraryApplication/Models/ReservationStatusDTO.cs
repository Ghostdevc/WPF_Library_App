using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    public class ReservationStatusDTO : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private int reservation_status_id;

        public int Reservation_status_id
        {
            get { return reservation_status_id; }
            set { reservation_status_id = value; OnPropertyChanged("Reservation_status_id"); }
        }

        private string reservation_status;

        public string Reservation_status
        {
            get { return reservation_status; }
            set { reservation_status = value; OnPropertyChanged("Reservation_status"); }
        }


    }
}
