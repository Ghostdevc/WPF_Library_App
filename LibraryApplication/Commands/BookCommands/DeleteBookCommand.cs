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
    public class DeleteBookCommand : CommandBase
    {

        private readonly BooksViewModel _viewModel;

        private BookService service;

        public DeleteBookCommand(BooksViewModel viewModel)
        {
            service = new BookService();
            _viewModel = viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
        }

        private void _viewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //if (e.PropertyName == nameof(CategoriesViewModel.CurrentRecord.Category_name) || e.PropertyName == nameof(CategoriesViewModel.CurrentRecord.Category_id))
            //{
            //    OnCanExecuteChanged();
            //}

            if (e.PropertyName == nameof(BooksViewModel.CurrentBook))
            {
                OnCanExecuteChanged();
            }
        }

        public override void Execute(object parameter)
        {
            try
            {

                if (_viewModel.CurrentBook == null)
                {
                    _viewModel.CurrentBook = _viewModel.CurrentListRecord;
                }

                var isDeleted = service.DeleteBook(_viewModel.CurrentBook);

                _viewModel.LoadAllBooksCommand.Execute(null);
                //LoadData();

                if (isDeleted)
                {
                    _viewModel.Message = "Book Deleted";
                }
                else { _viewModel.Message = "Delete Operation Failed"; }

            }
            catch (Exception ex)
            {

                _viewModel.Message = ex.Message;

            }
        }

    }
}
