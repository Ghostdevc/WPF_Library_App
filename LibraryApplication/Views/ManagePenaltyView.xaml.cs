using LibraryApplication.Models;
using LibraryApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibraryApplication.Views
{
    /// <summary>
    /// Interaction logic for ManagePenaltyView.xaml
    /// </summary>
    public partial class ManagePenaltyView : UserControl
    {
        public ManagePenaltyView()
        {
            InitializeComponent();

            txtBookID.Text = string.Empty;
            txtBookingDate.Text = string.Empty;
            txtExpectedToReturnDate.Text = string.Empty;
            txtPenaltyExpiresOn.Text = string.Empty;
            txtPenaltyId.Text = string.Empty;
            txtPunishedReservation_id.Text = string.Empty;
            txtPunishedUserID.Text = string.Empty;
            txtReservationStatus.Text = string.Empty;
            txtUserID.Text = string.Empty;
            txtReturnDate.Text = string.Empty;
        }



        public ReservationDTO ReservationDp
        {
            get { return (ReservationDTO)GetValue(ReservationDpProperty); }
            set { SetValue(ReservationDpProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ReservationDp.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ReservationDpProperty =
            DependencyProperty.Register("ReservationDp", typeof(ReservationDTO), typeof(ManagePenaltyView), new PropertyMetadata(null));




        public ReservationDTO ReservationTxtDp
        {
            get { return (ReservationDTO)GetValue(ReservationTxtDpProperty); }
            set { SetValue(ReservationTxtDpProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ReservationTxtDp.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ReservationTxtDpProperty =
            DependencyProperty.Register("ReservationTxtDp", typeof(ReservationDTO), typeof(ManagePenaltyView), new PropertyMetadata(null));






        public PenaltyDTO PenaltyDp
        {
            get { return (PenaltyDTO)GetValue(PenaltyDpProperty); }
            set { SetValue(PenaltyDpProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PenaltyDp.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PenaltyDpProperty =
            DependencyProperty.Register("PenaltyDp", typeof(PenaltyDTO), typeof(ManagePenaltyView), new PropertyMetadata(null));




        public PenaltyDTO PenaltyTxtDp
        {
            get { return (PenaltyDTO)GetValue(PenaltyTxtDpProperty); }
            set { SetValue(PenaltyTxtDpProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PenaltyTxtDp.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PenaltyTxtDpProperty =
            DependencyProperty.Register("PenaltyTxtDp", typeof(PenaltyDTO), typeof(ManagePenaltyView), new PropertyMetadata(null));


        #region PenaltyManagementSide


        private void lvPenalties_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            PenaltyDp = lvPenalties.SelectedValue as PenaltyDTO;

            if (PenaltyDp != null)
            {
                txtPenaltyId.Text = PenaltyDp.Penalty_id.ToString();
                txtPunishedUserID.Text = PenaltyDp.Penalized_user_id.ToString();
                txtPenaltyPolicyID.Text = PenaltyDp.Penalty_policy_id.ToString();

                txtPenaltyExpiresOn.Text = PenaltyDp.Penalty_expires_on.ToString();
                txtPunishedReservation_id.Text = PenaltyDp.Punished_reservation_id.ToString();
            }
        }


        private void txtPenaltyId_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtPenaltyId.Text != "")
            {
                PenaltyTxtDp.Penalty_id = int.Parse(txtPenaltyId.Text);
            }
        }

        private void txtPunishedUserID_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtPunishedUserID.Text != "")
            {
                PenaltyTxtDp.Penalized_user_id = int.Parse(txtPunishedUserID.Text);
            }
        }

        private void txtPenaltyPolicyID_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtPenaltyPolicyID.Text != "")
            {
                PenaltyTxtDp.Penalty_policy_id = int.Parse(txtPenaltyPolicyID.Text);
            }
        }

        private void txtPenaltyExpiresOn_TextChanged(object sender, TextChangedEventArgs e)
        {

            

            if (txtPenaltyExpiresOn.Text != "")
            {
                
                //if (DateTime.TryParse(txtPenaltyExpiresOn.Text, out DateTime bookingDate))
                //{
                //    PenaltyTxtDp.Penalty_expires_on = Convert.ToDateTime(txtPenaltyExpiresOn.Text);


                //}
                //DateTime.ParseExact(txtPenaltyExpiresOn.Text, "G", CultureInfo.InvariantCulture);

                PenaltyTxtDp.Penalty_expires_on = DateTime.Parse(txtPenaltyExpiresOn.Text);


            }
        }

        private void txtPunishedReservation_id_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtPunishedReservation_id.Text != "")
            {
                PenaltyTxtDp.Punished_reservation_id = int.Parse(txtPunishedReservation_id.Text);
            }
        }






        #endregion

        #region PenaltyCreationSide


        private void lvReservations_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ReservationDp = lvReservations.SelectedValue as ReservationDTO;

            if (ReservationDp != null)
            {
                txtReservationID.Text = ReservationDp.Reservation_id.ToString();
                txtBookID.Text = ReservationDp.Reserved_book_id.ToString();
                txtUserID.Text = ReservationDp.Reserved_to_user_id.ToString();
                txtBookingDate.Text = ReservationDp.Booking_date.ToString();
                txtExpectedToReturnDate.Text = ReservationDp.Expected_to_return_date.ToString();
                txtReturnDate.Text = ReservationDp.Return_date.ToString();
                txtReservationStatus.Text = ReservationDp.Reservation_status_id.ToString();
            }
        }



        private void txtReservationID_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtReservationID.Text != "")
            {
                ReservationTxtDp.Reservation_id = int.Parse(txtReservationID.Text);
            }
        }

        private void txtBookID_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtBookID.Text != "")
            {
                ReservationTxtDp.Reserved_book_id = int.Parse(txtBookID.Text);
            }
        }

        private void txtUserID_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtUserID.Text != "")
            {
                ReservationTxtDp.Reserved_to_user_id = int.Parse(txtUserID.Text);
            }
        }

        private void txtBookingDate_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txtBookingDate.Text != "")
            {

                if (DateTime.TryParse(txtBookingDate.Text, out DateTime bookingDate))
                {
                    ReservationTxtDp.Booking_date = Convert.ToDateTime(txtBookingDate.Text);
                }

                //var dateString = txtBookingDate.Text;
                //var format = "MM/dd/yyyy hh:mm:ss tt";
                //var dateTime = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);

                //ReservationTxtDp.Booking_date = dateTime;


            }
        }

        private void txtExpectedToReturnDate_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtExpectedToReturnDate.Text != "")
            {
                if (DateTime.TryParse(txtExpectedToReturnDate.Text, out DateTime bookingDate))
                {
                    ReservationTxtDp.Expected_to_return_date = DateTime.Parse(txtExpectedToReturnDate.Text);
                }      
            }
        }

        private void txtReturnDate_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtReturnDate.Text != "")
            {

                if (DateTime.TryParse(txtReturnDate.Text, out DateTime bookingDate))
                {
                    ReservationTxtDp.Return_date = DateTime.Parse(txtReturnDate.Text);
                }

                
            }
        }

        private void txtReservationStatus_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtReservationStatus.Text != "")
            {
                ReservationTxtDp.Reservation_status_id = int.Parse(txtReservationStatus.Text);
            }
        }

        

        #endregion

    }
}
