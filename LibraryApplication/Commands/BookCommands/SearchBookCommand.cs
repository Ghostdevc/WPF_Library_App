using LibraryApplication.Models;
using LibraryApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Commands.BookCommands
{
    public class SearchBookCommand : CommandBase
    {

        private readonly BooksViewModel _viewModel;

        private BookService service;

        public SearchBookCommand(BooksViewModel viewModel)
        {
            service = new BookService();
            _viewModel = viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
        }

        private void _viewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(BooksViewModel.CurrentBook))
            {
                OnCanExecuteChanged();
            }
        }

        public override void Execute(object parameter)
        {
            try
            {
                var objRecord = service.SearchBook(_viewModel.CurrentBook.Book_id);
                if (objRecord != null)
                {
                    _viewModel.CurrentBook.Book_id = (int)objRecord.Id_Book;
                    _viewModel.CurrentBook.Book_name = objRecord.Book_Name;
                    _viewModel.CurrentBook.Writer_id = (int)objRecord.FK_Writer_Id;
                    _viewModel.CurrentBook.Category_id = (int)objRecord.FK_Category_Id;
                    _viewModel.CurrentBook.Status_id = (int)objRecord.FK_Status_Id;
                }
                else
                {
                    _viewModel.Message = "Book Not Found";
                }
            }
            catch (Exception ex)
            {

                _viewModel.Message = ex.Message;
            }
        }

    }
}
