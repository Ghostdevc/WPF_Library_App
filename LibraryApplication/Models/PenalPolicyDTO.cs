using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    public class PenalPolicyDTO : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private int penal_policy_id;

        public int Penal_policy_id
        {
            get { return penal_policy_id; }
            set { penal_policy_id = value; OnPropertyChanged("Penal_policy_id"); }
        }

        private int penalty_days;

        public int Penalty_days
        {
            get { return penalty_days; }
            set { penalty_days = value; OnPropertyChanged("Penalty_days"); }
        }


    }
}
