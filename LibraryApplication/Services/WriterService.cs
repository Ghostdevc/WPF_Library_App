using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    public class WriterService
    {

        DbLibraryEntities libraryEntities;

        public WriterService()
        {
            libraryEntities = new DbLibraryEntities();
        }

        public List<WriterDTO> GetAll()
        {
            List<WriterDTO> recordsList = new List<WriterDTO>();

            try
            {

                var objQuery = from records in libraryEntities.Tbl_Writer
                               select records;
                foreach (var row in objQuery)
                {
                    recordsList.Add(new WriterDTO { Writer_id = row.Id_Writer, Writer_name_surname = row.Writer_Name_Surname });
                }
            }
            catch (Exception)
            {

                throw;
            }
            return recordsList;
        }

        public bool Add(WriterDTO recordToAdd)
        {
            bool isAdded = false;

            try
            {

                var newRecord = new Tbl_Writer { Writer_Name_Surname = recordToAdd.Writer_name_surname };

                libraryEntities.Tbl_Writer.Add(newRecord);
                var NoOfRowsEffected = libraryEntities.SaveChanges();
                isAdded = NoOfRowsEffected > 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return isAdded;
        }

        public bool Delete(WriterDTO recordToDelete)
        {
            bool isDeleted = false;

            try
            {
                var deletedRecord = new Tbl_Writer();

                deletedRecord = libraryEntities.Tbl_Writer.Find(recordToDelete.Writer_id);

                libraryEntities.Tbl_Writer.Remove(deletedRecord);
                var NoOfRowsEffected = libraryEntities.SaveChanges();
                isDeleted = NoOfRowsEffected > 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return isDeleted;
        }

        public bool Update(WriterDTO recordToUpdate)
        {
            bool isUpdated = false;

            try
            {

                var updatedRecord = new Tbl_Writer { Id_Writer = recordToUpdate.Writer_id, Writer_Name_Surname = recordToUpdate.Writer_name_surname };

                libraryEntities.Tbl_Writer.AddOrUpdate(updatedRecord);
                var NoOfRowsEffected = libraryEntities.SaveChanges();
                isUpdated = NoOfRowsEffected > 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return isUpdated;
        }

        public Tbl_Writer Search(int id)
        {

            return libraryEntities.Tbl_Writer.Find(id);

        }

    }
}
