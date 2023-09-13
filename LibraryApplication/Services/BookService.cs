using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    public class BookService
    {

        DbLibraryEntities libraryEntities;

        public BookService()
        {
                libraryEntities = new DbLibraryEntities();
        }

        public List<BookDTO> GetBooks()
        {
            List<BookDTO> books = new List<BookDTO>();

            try
            {
                
                var objQuery = from book in libraryEntities.Tbl_Book
                               select book;
                foreach (var book in objQuery)
                {
                    books.Add(new BookDTO { Book_id = book.Id_Book, Book_name = book.Book_Name, Category_id = (int)book.FK_Category_Id , Status_id = (int)book.FK_Status_Id , Writer_id = (int)book.FK_Writer_Id });
                }
            }
            catch (Exception)
            {

                throw;
            }
            return books;
        }


        public List<BookDTO> GetAvailableBooks()
        {

            List<BookDTO> availableBooks = new List<BookDTO>();

            try
            {
                var objQuery = from book in libraryEntities.Tbl_Book
                               select book;

                var query = objQuery.Where(x => x.FK_Status_Id == 3);

                foreach (var book in query)
                {
                    availableBooks.Add(new BookDTO { Book_id = book.Id_Book, Book_name = book.Book_Name, Category_id = (int)book.FK_Category_Id, Status_id = (int)book.FK_Status_Id, Writer_id = (int)book.FK_Writer_Id });
                }

            }
            catch (Exception)
            {

                throw;
            }

            return availableBooks;

        }

        public bool AddBook(BookDTO bookToAdd)
        {
            bool isAdded = false;

            try
            {

                var newBook = new Tbl_Book();

                newBook.Id_Book = bookToAdd.Book_id;
                newBook.Book_Name = bookToAdd.Book_name;
                newBook.FK_Category_Id = bookToAdd.Category_id;
                newBook.FK_Status_Id = bookToAdd.Status_id;
                newBook.FK_Writer_Id = bookToAdd.Writer_id;

                libraryEntities.Tbl_Book.Add(newBook);
                var NoOfRowsEffected = libraryEntities.SaveChanges();
                isAdded = NoOfRowsEffected > 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return isAdded;
        }

        public bool DeleteBook(BookDTO bookToDelete)
        {
            bool isDeleted = false;

            try
            {
                var book = new Tbl_Book();

                book = libraryEntities.Tbl_Book.Find(bookToDelete.Book_id);

                libraryEntities.Tbl_Book.Remove(book);
                var NoOfRowsEffected = libraryEntities.SaveChanges();
                isDeleted = NoOfRowsEffected > 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return isDeleted;
        }

        public bool UpdateBook(BookDTO bookToUpdate)
        {
            bool isUpdated = false;

            try
            {

                var book = new Tbl_Book();

                book.Id_Book = bookToUpdate.Book_id;
                book.Book_Name = bookToUpdate.Book_name;
                book.FK_Category_Id = bookToUpdate.Category_id;
                book.FK_Status_Id = bookToUpdate.Status_id;
                book.FK_Writer_Id = bookToUpdate.Writer_id;

                libraryEntities.Tbl_Book.AddOrUpdate(book);
                var NoOfRowsEffected = libraryEntities.SaveChanges();
                isUpdated = NoOfRowsEffected > 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return isUpdated;
        }

        public Tbl_Book SearchBook(int id)
        {

            return libraryEntities.Tbl_Book.Find(id);

        }

    }
}
