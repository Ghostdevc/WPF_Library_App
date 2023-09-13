using LibraryApplication.Controls;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    public class ReservationService
    {

        DbLibraryEntities libraryEntities;

        ReservationControls Controls;

        public ReservationService()
        {
            libraryEntities = new DbLibraryEntities();
            Controls = new ReservationControls();
        }

        public List<ReservationDTO> GetAll()
        {
            List<ReservationDTO> recordsList = new List<ReservationDTO>();

            try
            {

                var objQuery = from records in libraryEntities.Tbl_Reservation
                               select records;
                foreach (var row in objQuery)
                {
                    recordsList.Add(new ReservationDTO { Reservation_id = row.Id_Reservation, Reserved_book_id = (int)row.FK_BookID, Reserved_to_user_id = (int)row.FK_Booked_to_UserID, Booking_date = (DateTime)row.Booking_Date, Expected_to_return_date = (DateTime)row.ExpectedToReturn_Date,  Reservation_status_id = (int)row.FK_Reservation_Status_ID});
                }
            }
            catch (Exception)
            {

                throw;
            }
            return recordsList;
        }

        public bool Add(ReservationDTO recordToAdd)
        {
            bool isAdded = false;

            if (Controls.IsUserHasActivePenalty(recordToAdd))
            {
                return isAdded;
            }

            try
            {
                DateTime today = DateTime.Today;
                DateTime expectedToReturn = today.AddDays(15);
                var newRecord = new Tbl_Reservation { FK_BookID = (int)recordToAdd.Reserved_book_id, FK_Booked_to_UserID = (int)recordToAdd.Reserved_to_user_id, Booking_Date = today, ExpectedToReturn_Date = expectedToReturn ,  FK_Reservation_Status_ID = 1 };
                libraryEntities.Tbl_Reservation.Add(newRecord);



                var NoOfRowsEffected = libraryEntities.SaveChanges();
                isAdded = NoOfRowsEffected > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isAdded;
        }

        public bool Delete(ReservationDTO recordToDelete)
        {
            bool isDeleted = false;
            try
            {
                var deletedRecord = new Tbl_Reservation();
                deletedRecord = libraryEntities.Tbl_Reservation.Find(recordToDelete.Reservation_id);
                libraryEntities.Tbl_Reservation.Remove(deletedRecord);
                var NoOfRowsEffected = libraryEntities.SaveChanges();
                isDeleted = NoOfRowsEffected > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isDeleted;
        }

        public bool Update(ReservationDTO recordToUpdate)
        {
            bool isUpdated = false;
            try
            {
                var updatedRecord = new Tbl_Reservation { Id_Reservation = (int)recordToUpdate.Reservation_id, FK_BookID = (int)recordToUpdate.Reserved_book_id, FK_Booked_to_UserID = (int)recordToUpdate.Reserved_to_user_id, Booking_Date = (DateTime)recordToUpdate.Booking_date, ExpectedToReturn_Date = (DateTime)recordToUpdate.Expected_to_return_date, Return_date = (DateTime)recordToUpdate.Return_date, FK_Reservation_Status_ID = (int)recordToUpdate.Reservation_status_id };
                libraryEntities.Tbl_Reservation.AddOrUpdate(updatedRecord);
                var NoOfRowsEffected = libraryEntities.SaveChanges();
                isUpdated = NoOfRowsEffected > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isUpdated;
        }

        public Tbl_Reservation SearchByReservationId(int id)
        {
            return libraryEntities.Tbl_Reservation.Find(id);
        }



        public List<ReservationDTO> SearchByUserId(int id)
        {
            List<ReservationDTO> recordsList = new List<ReservationDTO>();

            try
            {

                var objQuery = libraryEntities.Tbl_Reservation.Where(x => x.FK_Booked_to_UserID == id);
                foreach (var row in objQuery)
                {
                    recordsList.Add(new ReservationDTO { Reservation_id = row.Id_Reservation, Reserved_book_id = (int)row.FK_BookID, Reserved_to_user_id = (int)row.FK_Booked_to_UserID, Booking_date = (DateTime)row.Booking_Date, Expected_to_return_date = (DateTime)row.ExpectedToReturn_Date, Reservation_status_id = (int)row.FK_Reservation_Status_ID });
                }
            }
            catch (Exception)
            {

                throw;
            }
            return recordsList;
        }

        public List<ReservationDTO> SearchByBookId(int id)
        {
            List<ReservationDTO> recordsList = new List<ReservationDTO>();

            try
            {

                var objQuery = libraryEntities.Tbl_Reservation.Where(x => x.FK_BookID == id);
                foreach (var row in objQuery)
                {
                    recordsList.Add(new ReservationDTO { Reservation_id = row.Id_Reservation, Reserved_book_id = (int)row.FK_BookID, Reserved_to_user_id = (int)row.FK_Booked_to_UserID, Booking_date = (DateTime)row.Booking_Date, Expected_to_return_date = (DateTime)row.ExpectedToReturn_Date, Reservation_status_id = (int)row.FK_Reservation_Status_ID });
                }
            }
            catch (Exception)
            {

                throw;
            }
            return recordsList;
        }



        public List<ReservationDTO> GetReservationsToBePenalized()
        {
            List<ReservationDTO> reservationsToBePenalized = new List<ReservationDTO>();
            var objQuery = from records in libraryEntities.Tbl_Reservation
                               select records;

            var query = objQuery.Where(x => (DateTime)x.ExpectedToReturn_Date < DateTime.Today && (x.FK_Reservation_Status_ID == 1 || x.FK_Reservation_Status_ID == 3 || x.FK_Reservation_Status_ID == 5));

            foreach ( var row in query )
            {

                reservationsToBePenalized.Add(new ReservationDTO { Reservation_id = row.Id_Reservation, Reserved_book_id = (int)row.FK_BookID, Reserved_to_user_id = (int)row.FK_Booked_to_UserID, Booking_date = (DateTime)row.Booking_Date, Expected_to_return_date = (DateTime)row.ExpectedToReturn_Date, Return_date = (DateTime)row.Return_date, Reservation_status_id = (int)row.FK_Reservation_Status_ID });

            }

            return reservationsToBePenalized;

        }


        public List<ReservationDTO> GetActiveReservations()
        {
            List<ReservationDTO> activeReservations = new List<ReservationDTO>();
            var objQuery = from records in libraryEntities.Tbl_Reservation
                           select records;

            var query = objQuery.Where(x => (int)x.FK_Reservation_Status_ID == 1);

            foreach (var row in query)
            {

                activeReservations.Add(new ReservationDTO { Reservation_id = row.Id_Reservation, Reserved_book_id = (int)row.FK_BookID, Reserved_to_user_id = (int)row.FK_Booked_to_UserID, Booking_date = (DateTime)row.Booking_Date, Expected_to_return_date = (DateTime)row.ExpectedToReturn_Date, Reservation_status_id = (int)row.FK_Reservation_Status_ID });

            }

            return activeReservations;

        }

    }
}
