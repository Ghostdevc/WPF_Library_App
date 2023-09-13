using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    public class CategoryService
    {

        DbLibraryEntities libraryEntities;

        public CategoryService()
        {
            libraryEntities = new DbLibraryEntities();
        }

        public List<CategoryDTO> GetAll()
        {
            List<CategoryDTO> recordsList = new List<CategoryDTO>();

            try
            {

                var objQuery = from records in libraryEntities.Tbl_Category
                               select records;
                foreach (var row in objQuery)
                {
                    recordsList.Add(new CategoryDTO { Category_id = row.Id_Category, Category_name = row.Category_Name });
                }
            }
            catch (Exception)
            {

                throw;
            }
            return recordsList;
        }

        public bool Add(CategoryDTO recordToAdd)
        {
            bool isAdded = false;

            try
            {

                var newRecord = new Tbl_Category { Category_Name = recordToAdd.Category_name };

                libraryEntities.Tbl_Category.Add(newRecord);
                var NoOfRowsEffected = libraryEntities.SaveChanges();
                isAdded = NoOfRowsEffected > 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return isAdded;
        }

        public bool Delete(CategoryDTO recordToDelete)
        {
            bool isDeleted = false;

            try
            {
                var deletedRecord = new Tbl_Category();

                deletedRecord = libraryEntities.Tbl_Category.Find(recordToDelete.Category_id);

                libraryEntities.Tbl_Category.Remove(deletedRecord);
                var NoOfRowsEffected = libraryEntities.SaveChanges();
                isDeleted = NoOfRowsEffected > 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return isDeleted;
        }

        public bool Update(CategoryDTO recordToUpdate)
        {
            bool isUpdated = false;

            try
            {

                var updatedRecord = new Tbl_Category { Id_Category = recordToUpdate.Category_id, Category_Name = recordToUpdate.Category_name };

                libraryEntities.Tbl_Category.AddOrUpdate(updatedRecord);
                var NoOfRowsEffected = libraryEntities.SaveChanges();
                isUpdated = NoOfRowsEffected > 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return isUpdated;
        }

        public Tbl_Category Search(int id)
        {

            return libraryEntities.Tbl_Category.Find(id);

        }

    }
}
