using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    public class PenalPolicyService
    {

        DbLibraryEntities libraryEntities;

        public PenalPolicyService()
        {
            libraryEntities = new DbLibraryEntities();
        }

        public List<PenalPolicyDTO> GetAll()
        {
            List<PenalPolicyDTO> recordsList = new List<PenalPolicyDTO>();

            try
            {

                var objQuery = from records in libraryEntities.Tbl_PenalPolicy
                               select records;
                foreach (var row in objQuery)
                {
                    recordsList.Add(new PenalPolicyDTO { Penal_policy_id = row.Id_PenalPolicy, Penalty_days = (int)row.Penalty_Days });
                }
            }
            catch (Exception)
            {

                throw;
            }
            return recordsList;
        }

        public bool Add(PenalPolicyDTO recordToAdd)
        {
            bool isAdded = false;

            try
            {

                var newRecord = new Tbl_PenalPolicy { Penalty_Days = recordToAdd.Penalty_days, Id_PenalPolicy = recordToAdd.Penal_policy_id };

                libraryEntities.Tbl_PenalPolicy.Add(newRecord);
                var NoOfRowsEffected = libraryEntities.SaveChanges();
                isAdded = NoOfRowsEffected > 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return isAdded;
        }

        public bool Delete(PenalPolicyDTO recordToDelete)
        {
            bool isDeleted = false;

            try
            {
                var deletedRecord = new Tbl_PenalPolicy();

                deletedRecord = libraryEntities.Tbl_PenalPolicy.Find(recordToDelete.Penal_policy_id);

                libraryEntities.Tbl_PenalPolicy.Remove(deletedRecord);
                var NoOfRowsEffected = libraryEntities.SaveChanges();
                isDeleted = NoOfRowsEffected > 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return isDeleted;
        }

        public bool Update(PenalPolicyDTO recordToUpdate)
        {
            bool isUpdated = false;

            try
            {

                var updatedRecord = new Tbl_PenalPolicy { Id_PenalPolicy = recordToUpdate.Penal_policy_id, Penalty_Days = recordToUpdate.Penalty_days };

                libraryEntities.Tbl_PenalPolicy.AddOrUpdate(updatedRecord);
                var NoOfRowsEffected = libraryEntities.SaveChanges();
                isUpdated = NoOfRowsEffected > 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return isUpdated;
        }

        public Tbl_PenalPolicy Search(int id)
        {

            return libraryEntities.Tbl_PenalPolicy.Find(id);

        }

    }
}
