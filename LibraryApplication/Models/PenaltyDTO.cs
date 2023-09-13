using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    public class PenaltyDTO : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private int penalty_id;

        public int Penalty_id
        {
            get { return penalty_id; }
            set { penalty_id = value; OnPropertyChanged("Penalty_id"); }
        }

        private int penalized_user_id;

        public int Penalized_user_id
        {
            get { return penalized_user_id; }
            set { penalized_user_id = value; OnPropertyChanged("Penalized_user_id"); }
        }

        private int penalty_policy_id;

        public int Penalty_policy_id
        {
            get { return penalty_policy_id; }
            set { penalty_policy_id = value; OnPropertyChanged("Penalty_policy_id"); }
        }

        private DateTime penalty_expires_on;

        public DateTime Penalty_expires_on
        {
            get { return penalty_expires_on; }
            set { penalty_expires_on = value; OnPropertyChanged("Penalty_expires_on"); }
        }

        private int punished_reservation_id;

        public int Punished_reservation_id
        {
            get { return punished_reservation_id; }
            set { punished_reservation_id = value; OnPropertyChanged("Punished_reservation_id"); }
        }





    }
}
