using LibraryApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    public class ReservationDTO : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private int reservation_id;

        public int Reservation_id
        {
            get { return reservation_id; }
            set { reservation_id = value; OnPropertyChanged("Reservation_id"); }
        }

        private int reserved_book_id;

        public int Reserved_book_id
        {
            get { return reserved_book_id; }
            set { reserved_book_id = value; OnPropertyChanged("Reserved_book_id"); }
        }

        private int reserved_to_user_id;

        public int Reserved_to_user_id
        {
            get { return reserved_to_user_id; }
            set { reserved_to_user_id = value; OnPropertyChanged("Reserved_to_user_id"); }
        }

        private int reservation_status_id;

        public int Reservation_status_id
        {
            get { return reservation_status_id; }
            set { reservation_status_id = value; OnPropertyChanged("Reservation_status_id"); }
        }

        private DateTime booking_date;

        public DateTime Booking_date
        {
            get { return booking_date; }
            set { booking_date = value; OnPropertyChanged("Booking_date"); }
        }

        private DateTime expected_to_return_date;

        public DateTime Expected_to_return_date
        {
            get { return expected_to_return_date; }
            set { expected_to_return_date = value; OnPropertyChanged("Expected_to_return_date"); }
        }


        private DateTime return_date;

        public DateTime Return_date
        {
            get { return return_date; }
            set { return_date = value; OnPropertyChanged("Return_date"); }
        }

    }
}
