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
    public class UpdateBookCommand : CommandBase
    {

        private readonly BooksViewModel _viewModel;

        private BookService service;

        public UpdateBookCommand(BooksViewModel viewModel)
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

                var isUpdated = service.UpdateBook(_viewModel.CurrentBook);

                _viewModel.LoadAllBooksCommand.Execute(parameter);

                if (isUpdated)
                {
                    _viewModel.Message = "Book Updated";
                    //_viewModel.LoadCategoriesRelayCommand.Execute(this);
                    //LoadData();
                }
                else
                {
                    _viewModel.Message = "Update operation failed";
                }
            }
            catch (Exception ex)
            {
                _viewModel.Message = ex.Message;
            }
        }

    }
}
