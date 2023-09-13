using LibraryApplication.Models;
using LibraryApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Commands.PenaltyCommands
{
    public class SavePenaltyCommand : CommandBase
    {

        private readonly ManagePenaltyViewModel _viewModel;

        private PenaltyService service;

        private ReservationService reservationService;

        public SavePenaltyCommand(ManagePenaltyViewModel viewModel)
        {
            service = new PenaltyService();
            reservationService = new ReservationService();
            _viewModel = viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
        }


        private void _viewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //if (e.PropertyName == nameof(CategoriesViewModel.CurrentRecord.Category_name) || e.PropertyName == nameof(CategoriesViewModel.CurrentRecord.Category_id))
            //{
            //    OnCanExecuteChanged();
            //}

            if (e.PropertyName == nameof(ManagePenaltyViewModel.CurrentRecord))
            {
                OnCanExecuteChanged();
            }

        }


        public override void Execute(object parameter)
        {
            try
            {

                if (_viewModel.CurrentReservationToBePunished == null)
                {
                    _viewModel.CurrentReservationToBePunished = _viewModel.ReservationCurrentListRecord;
                }

                ReservationDTO reservation = _viewModel.CurrentReservationToBePunished;

                PenaltyDTO penalty = new PenaltyDTO();

                penalty.Punished_reservation_id = reservation.Reservation_id;
                penalty.Penalized_user_id = reservation.Reserved_to_user_id;
                penalty.Penalty_policy_id = _viewModel.SelectedPolicy;



                var isSaved = service.Add(penalty);


                ReservationDTO reservationStatusToBeChange = _viewModel.CurrentReservationToBePunished;

                int status_id = reservationStatusToBeChange.Reservation_status_id;
                if (status_id == 1 || status_id == 3 || status_id == 7)
                {


                    reservationStatusToBeChange.Reservation_status_id = 7;


                }

                if (status_id == 5)
                {
                    reservationStatusToBeChange.Reservation_status_id = 6;
                }





                reservationService.Update(reservationStatusToBeChange);

                _viewModel.ListPunishableReservationsCommand.Execute(null);

                _viewModel.LoadPenaltyCommand.Execute(null);

                if (isSaved)
                {
                    _viewModel.Message = "Penalty Saved";
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
