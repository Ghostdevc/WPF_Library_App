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
    public class DeleteReservationCommand : CommandBase
    {

        private readonly ManageReservationViewModel _viewModel;

        private ReservationService service;

        private BookService bookService;

        public DeleteReservationCommand(ManageReservationViewModel viewModel)
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
                ReservationDTO reservationToDelete = new ReservationDTO();

                reservationToDelete = _viewModel.CurrentRecord;

                BookDTO bookToUpdate = new BookDTO();

                var bookObject = bookService.SearchBook(reservationToDelete.Reserved_book_id);

                bookToUpdate.Writer_id = (int)bookObject.FK_Writer_Id;
                bookToUpdate.Book_id = (int)bookObject.Id_Book;
                bookToUpdate.Book_name = (string)bookObject.Book_Name;
                bookToUpdate.Category_id = (int)bookObject.FK_Category_Id;
                bookToUpdate.Status_id = 3;

                bookService.UpdateBook(bookToUpdate);

                var isDeleted = service.Delete(_viewModel.CurrentRecord);

                _viewModel.LoadAllReservations.Execute(null);
                //LoadData();

                if (isDeleted)
                {
                    _viewModel.ReservationManagementMessage = "Reservation Deleted";
                }
                else { _viewModel.ReservationManagementMessage = "Delete Operation Failed"; }

            }
            catch (Exception ex)
            {

                _viewModel.Message = ex.Message;

            }
        }

    }
}
