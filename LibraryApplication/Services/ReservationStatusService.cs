using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    public class ReservationStatusService
    {

        DbLibraryEntities libraryEntities;

        public ReservationStatusService()
        {
            libraryEntities = new DbLibraryEntities();
        }

        public List<ReservationStatusDTO> GetAll()
        {
            List<ReservationStatusDTO> recordsList = new List<ReservationStatusDTO>();

            try
            {

                var objQuery = from records in libraryEntities.Tbl_Reservation_Status
                               select records;
                foreach (var row in objQuery)
                {
                    recordsList.Add(new ReservationStatusDTO { Reservation_status_id = row.Id_Reservation_Status, Reservation_status = row.Reservation_Status });
                }
            }
            catch (Exception)
            {

                throw;
            }
            return recordsList;
        }

        public bool Add(ReservationStatusDTO recordToAdd)
        {
            bool isAdded = false;

            try
            {

                var newRecord = new Tbl_Reservation_Status { Reservation_Status = recordToAdd.Reservation_status };

                libraryEntities.Tbl_Reservation_Status.Add(newRecord);
                var NoOfRowsEffected = libraryEntities.SaveChanges();
                isAdded = NoOfRowsEffected > 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return isAdded;
        }

        public bool Delete(ReservationStatusDTO recordToDelete)
        {
            bool isDeleted = false;

            try
            {
                var deletedRecord = new Tbl_Reservation_Status();

                deletedRecord = libraryEntities.Tbl_Reservation_Status.Find(recordToDelete.Reservation_status_id);

                libraryEntities.Tbl_Reservation_Status.Remove(deletedRecord);
                var NoOfRowsEffected = libraryEntities.SaveChanges();
                isDeleted = NoOfRowsEffected > 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return isDeleted;
        }

        public bool Update(ReservationStatusDTO recordToUpdate)
        {
            bool isUpdated = false;

            try
            {

                var updatedRecord = new Tbl_Reservation_Status { Id_Reservation_Status = recordToUpdate.Reservation_status_id, Reservation_Status = recordToUpdate.Reservation_status };

                libraryEntities.Tbl_Reservation_Status.AddOrUpdate(updatedRecord);
                var NoOfRowsEffected = libraryEntities.SaveChanges();
                isUpdated = NoOfRowsEffected > 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return isUpdated;
        }

        public Tbl_Reservation_Status Search(int id)
        {

            return libraryEntities.Tbl_Reservation_Status.Find(id);

        }

    }
}
