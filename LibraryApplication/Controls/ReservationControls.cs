using LibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Controls
{
    public class ReservationControls
    {
        DbLibraryEntities libraryEntities;

        public ReservationControls()
        {
            libraryEntities = new DbLibraryEntities();
        }

        public bool IsUserHasActivePenalty(ReservationDTO reservationToCheck)
        {


            if (libraryEntities.Tbl_Penalty.Where(x => x.FK_UserID == reservationToCheck.Reserved_to_user_id && (DateTime.Today < (DateTime)x.Penalty_Expires_On)).ToList().Count != 0)
            {
                return true;
            }
            else return false;

        }

        public bool IsStatusSuitableToMarkReturned(ReservationDTO reservationToCheck)
        {

            int reservationStatusID = reservationToCheck.Reservation_status_id;

            if (reservationStatusID == 1 || reservationStatusID == 3 || reservationStatusID == 7)
            {
                return true;
            }
            else return false;
        }

    }
}
