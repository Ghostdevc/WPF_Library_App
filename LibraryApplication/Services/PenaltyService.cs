using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    public class PenaltyService
    {

        DbLibraryEntities libraryEntities;

        public PenaltyService()
        {
            libraryEntities = new DbLibraryEntities();
        }

        public List<PenaltyDTO> GetAll()
        {
            List<PenaltyDTO> recordsList = new List<PenaltyDTO>();

            try
            {

                var objQuery = from records in libraryEntities.Tbl_Penalty
                               select records;
                foreach (var row in objQuery)
                {
                    //string formattedDateString = row.Penalty_Expires_On.Value.ToString("dd/MM/yyyy");
                    //row.Penalty_Expires_On = Convert.ToDateTime(formattedDateString);
                    recordsList.Add(new PenaltyDTO { Penalty_id = row.Id_Penalty, Penalized_user_id = (int)row.FK_UserID, Penalty_expires_on = (DateTime)row.Penalty_Expires_On, Punished_reservation_id = (int)row.FK_Punished_Reservation_id, Penalty_policy_id = (int)row.FK_PenalPolicyID });
                }
            }
            catch (Exception)
            {

                throw;
            }
            return recordsList;
        }

        public bool Add(PenaltyDTO recordToAdd)
        {
            bool isAdded = false;
            try
            {
                //DateTime date = 
                DateTime penaltyExpireDate = DateTime.Now.AddDays((int)libraryEntities.Tbl_PenalPolicy.Find(recordToAdd.Penalty_policy_id).Penalty_Days).Date;
                var newRecord = new Tbl_Penalty { FK_UserID = (int)recordToAdd.Penalized_user_id, Penalty_Expires_On = penaltyExpireDate, FK_Punished_Reservation_id = (int)recordToAdd.Punished_reservation_id, FK_PenalPolicyID = recordToAdd.Penalty_policy_id };
                libraryEntities.Tbl_Penalty.Add(newRecord);
                var NoOfRowsEffected = libraryEntities.SaveChanges();
                isAdded = NoOfRowsEffected > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isAdded;
        }
        public bool Delete(PenaltyDTO recordToDelete)
        {
            bool isDeleted = false;
            try
            {
                var deletedRecord = new Tbl_Penalty();
                deletedRecord = libraryEntities.Tbl_Penalty.Find(recordToDelete.Penalty_id);

                libraryEntities.Tbl_Penalty.Remove(deletedRecord);
                var NoOfRowsEffected = libraryEntities.SaveChanges();
                isDeleted = NoOfRowsEffected > 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return isDeleted;
        }

        public bool Update(PenaltyDTO recordToUpdate)
        {
            bool isUpdated = false;

            try
            {
                DateTime penaltyExpireDate = DateTime.Today.AddDays((int)libraryEntities.Tbl_PenalPolicy.Find(recordToUpdate.Penalty_policy_id).Penalty_Days);
                var updatedRecord = new Tbl_Penalty { Id_Penalty = recordToUpdate.Penalty_id, FK_Punished_Reservation_id = recordToUpdate.Punished_reservation_id, FK_PenalPolicyID = recordToUpdate.Penalty_policy_id, FK_UserID = recordToUpdate.Penalized_user_id, Penalty_Expires_On = penaltyExpireDate };

                libraryEntities.Tbl_Penalty.AddOrUpdate(updatedRecord);
                var NoOfRowsEffected = libraryEntities.SaveChanges();
                isUpdated = NoOfRowsEffected > 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return isUpdated;
        }




        public Tbl_Penalty Search(int id)
        {

            return libraryEntities.Tbl_Penalty.Find(id);

        }

    }
}
