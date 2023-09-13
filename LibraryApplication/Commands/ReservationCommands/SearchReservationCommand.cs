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
    public class SearchReservationCommand : CommandBase
    {

        private readonly ManageReservationViewModel _viewModel;

        private ReservationService service;

        public SearchReservationCommand(ManageReservationViewModel viewModel)
        {
            service = new ReservationService();
            _viewModel = viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
        }

        private void _viewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ManageReservationViewModel.CurrentRecord))
            {
                OnCanExecuteChanged();
            }
        }

        public override void Execute(object parameter)
        {
            try
            {

                if (_viewModel.IsReservationIdChecked)
                {
                    var objRecord = service.SearchByReservationId(_viewModel.SearchInput);
                    if (objRecord != null)
                    {
                        _viewModel.CurrentRecord.Reservation_id = (int)objRecord.Id_Reservation;
                        _viewModel.CurrentRecord.Reserved_to_user_id = (int)objRecord.FK_Booked_to_UserID;
                        _viewModel.CurrentRecord.Reserved_book_id = (int)objRecord.FK_BookID;
                        _viewModel.CurrentRecord.Reservation_status_id = (int)objRecord.FK_Reservation_Status_ID;
                        _viewModel.CurrentRecord.Booking_date = (DateTime)objRecord.Booking_Date;
                        _viewModel.CurrentRecord.Expected_to_return_date = (DateTime)objRecord.ExpectedToReturn_Date;
                        _viewModel.CurrentRecord.Return_date = (DateTime)objRecord.Return_date;
                    }
                    else
                    {
                        _viewModel.ReservationManagementMessage = "Reservation Not Found";
                    }
                }
                else if (_viewModel.IsBookIdChecked)
                {
                    _viewModel.LoadSearchByBookIdDataRelayCommand.Execute(null);
                }
                else if (_viewModel.IsUserIdChecked)
                {
                    _viewModel.LoadSearchByUserIdDataRelayCommand.Execute(null);
                }

                
            }
            catch (Exception ex)
            {

                _viewModel.Message = ex.Message;
            }
        }

    }
}
