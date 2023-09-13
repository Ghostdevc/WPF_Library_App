using LibraryApplication.Models;
using LibraryApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Commands.ReservationCommands
{
    public class SaveReservationCommand : CommandBase
    {

        private readonly ManageReservationViewModel _viewModel;

        private ReservationService service;

        private BookService bookService;

        public SaveReservationCommand(ManageReservationViewModel viewModel)
        {
            bookService = new BookService();
            service = new ReservationService();
            _viewModel = viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
        }


        private void _viewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //if (e.PropertyName == nameof(CategoriesViewModel.CurrentRecord.Category_name) || e.PropertyName == nameof(CategoriesViewModel.CurrentRecord.Category_id))
            //{
            //    OnCanExecuteChanged();
            //}

            if (e.PropertyName == nameof(ManageReservationViewModel.CurrentRecord))
            {
                OnCanExecuteChanged();
            }

        }


        public override void Execute(object parameter)
        {
            try
            {
                _viewModel.ReservationToCreate.Reserved_book_id = _viewModel.BooksViewModel.CurrentBook.Book_id;

                _viewModel.ReservationToCreate.Reserved_to_user_id = _viewModel.UsersViewModel.CurrentUser.User_id;

                var isSaved = service.Add(_viewModel.ReservationToCreate);

                BookDTO bookToStatusToBeChanged = _viewModel.BooksViewModel.CurrentBook;

                bookToStatusToBeChanged.Status_id = 2;





                bookService.UpdateBook(bookToStatusToBeChanged);

                _viewModel.LoadAllReservations.Execute(null);


                if (isSaved)
                {
                    _viewModel.Message = "Reservation Saved";
                }
                else
                {
                    _viewModel.Message = "Save Operation Failed";
                }
            }
            catch (Exception ex)
            {
                _viewModel.Message = ex.Message;
            }
        }

    }
}
