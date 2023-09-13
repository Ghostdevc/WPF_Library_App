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
    public class UpdateReservationCommand : CommandBase
    {

        private readonly ManageReservationViewModel _viewModel;

        private ReservationService service;

        public UpdateReservationCommand(ManageReservationViewModel viewModel)
        {
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

            //if (e.PropertyName == nameof(CategoriesViewModel.CurrentRecord))
            //{
            //    OnCanExecuteChanged();
            //}

        }

        public override void Execute(object parameter)
        {
            try
            {

                var isUpdated = service.Update(_viewModel.CurrentRecord);

                _viewModel.LoadAllReservations.Execute(null);

                if (isUpdated)
                {
                    _viewModel.ReservationManagementMessage = "Reservation Updated";
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
