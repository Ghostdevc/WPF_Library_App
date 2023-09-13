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
    public class LoadReservationStatusOptionsCommand : CommandBase
    {

        private readonly ManageReservationViewModel _viewModel;

        private ReservationService service;

        private ReservationStatusService reservationStatusService;

        public LoadReservationStatusOptionsCommand(ManageReservationViewModel viewModel)
        {
            service = new ReservationService();
            reservationStatusService = new ReservationStatusService();
            _viewModel = viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
        }

        private void _viewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ManageReservationViewModel.Reservations))
            {
                OnCanExecuteChanged();
            }
        }

        public override void Execute(object parameter)
        {
            
            //_viewModel.ReservationStatuses = reservationStatusService.GetAll();

            _viewModel.LoadReservationStatusOptionsRelayCommand.Execute(parameter);


        }

    }
}
