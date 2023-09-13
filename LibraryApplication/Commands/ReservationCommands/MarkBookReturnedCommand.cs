using LibraryApplication.Controls;
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
    public class MarkBookReturnedCommand : CommandBase
    {

        private readonly ManageReservationViewModel _viewModel;

        private BookService bookService;

        private ReservationService service;

        private ReservationControls Controls;

        public MarkBookReturnedCommand(ManageReservationViewModel viewModel)
        {
           bookService = new BookService();
            service = new ReservationService();
            _viewModel = viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
            Controls = new ReservationControls();
        }

        private void _viewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //if (e.PropertyName == nameof(CategoriesViewModel.CurrentRecord.Category_name) || e.PropertyName == nameof(CategoriesViewModel.CurrentRecord.Category_id))
            //{
            //    OnCanExecuteChanged();
            //}

            //if (e.PropertyName == nameof(CategoriesViewModel.CurrentRecord))
            //{
            //    OnCanExecuteChanged();
            //}

        }

        public override void Execute(object parameter)
        {
            try
            {
                ReservationDTO reservationToUpdate = new ReservationDTO();

                reservationToUpdate = _viewModel.CurrentRecord;

                bool isUpdated = false;

                if (Controls.IsStatusSuitableToMarkReturned(reservationToUpdate))
                {
                    int statusID = reservationToUpdate.Reservation_status_id;

                    switch (statusID)
                    {

                        case 1:
                            statusID = 4;
                            reservationToUpdate.Reservation_status_id = statusID;
                            break;

                        case 3:
                            statusID = 9;
                            reservationToUpdate.Reservation_status_id = statusID;
                            break;

                        case 7:
                            statusID = 6;
                            reservationToUpdate.Reservation_status_id = statusID;
                            break;

                        default:
                            break;
                    }

                    reservationToUpdate.Return_date = DateTime.Now;

                    isUpdated = service.Update(reservationToUpdate);

                    BookDTO bookToUpdate = new BookDTO();

                    var bookObject = bookService.SearchBook(reservationToUpdate.Reserved_book_id);

                    bookToUpdate.Writer_id = (int)bookObject.FK_Writer_Id;
                    bookToUpdate.Book_id = (int)bookObject.Id_Book;
                    bookToUpdate.Book_name = (string)bookObject.Book_Name;
                    bookToUpdate.Category_id = (int)bookObject.FK_Category_Id;
                    bookToUpdate.Status_id = 3;

                    bookService.UpdateBook(bookToUpdate);

                }

                
                _viewModel.LoadAllReservations.Execute(null);

                if (isUpdated)
                {
                    _viewModel.ReservationManagementMessage = "Reserved Book Marked Returned";
                    //_viewModel.LoadCategoriesRelayCommand.Execute(this);
                    //LoadData();
                }
                else
                {
                    _viewModel.ReservationManagementMessage = "Update operation failed";
                }
            }
            catch (Exception ex)
            {
                _viewModel.Message = ex.Message;
            }
        }

    }
}
