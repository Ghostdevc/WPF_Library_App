using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using LibraryApplication.Commands;
using LibraryApplication.Commands.BookCommands;
using LibraryApplication.Commands.NavigationCommands;
using LibraryApplication.Models;

namespace LibraryApplication.ViewModels
{
    public class BooksViewModel : ViewModelBase
    {
        

        BookService bookService;

        public BooksViewModel(Stores.NavigationStore navigationStore)
        {
            
            bookService = new BookService();
            currentBook = new BookDTO();

            SaveBookCommand = new SaveBookCommand(this);

            SearchBookCommand = new SearchBookCommand(this);

            UpdateBookCommand = new UpdateBookCommand(this);

            DeleteBookCommand = new DeleteBookCommand(this);


            loadAllBooksCommand = new RelayCommand(LoadData);
            loadAvailableBooksCommand = new RelayCommand(LoadAvailableBookData);

            NavigateMainCommand = new NavigateToAdminMainCommand(navigationStore);

            NavigateContentInterfaceCommand = new NavigateToContentInterfaceCommand(navigationStore);


        }

        public ICommand NavigateContentInterfaceCommand { get; }

        public ICommand NavigateMainCommand { get; }


        #region Display_Operation
        private List<BookDTO> booksList;

        public List<BookDTO> BooksList
        {
            get { return booksList; }
            set { booksList = value; OnPropertyChanged("BooksList"); }
        }

        private RelayCommand loadAllBooksCommand;

        public RelayCommand LoadAllBooksCommand
        {
            get { return loadAllBooksCommand; }
        }


        private RelayCommand loadAvailableBooksCommand;

        public RelayCommand LoadAvailableBooksCommand
        {
            get { return loadAvailableBooksCommand; }
        }



        private void LoadData()
        {
            BooksList = new List<BookDTO>(bookService.GetBooks());
            Message = "All books listed";
        }


        private void LoadAvailableBookData()
        {
            BooksList = new List<BookDTO>(bookService.GetAvailableBooks());
            Message = "Available books listed";
        }

        #endregion


        private BookDTO currentListRecord;

        public BookDTO CurrentListRecord
        {
            get { return currentListRecord; }
            set { currentListRecord = value; OnPropertyChanged(nameof(CurrentListRecord)); }
        }



        private BookDTO currentBook;

        public BookDTO CurrentBook
        {
            get { return currentBook; }
            set { currentBook = value; OnPropertyChanged("CurrentBook"); }
        }

        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged("Message"); }
        }

        #region SaveOperation

        public ICommand SaveBookCommand { get; set; }

        #endregion

        #region SearchOperation

        public ICommand SearchBookCommand { get; set; }

        #endregion

        #region UpdateOperation

        public ICommand UpdateBookCommand { get; set; }

        #endregion

        #region DeleteOperation

        public ICommand DeleteBookCommand { get; set; }

        #endregion



    }
}
