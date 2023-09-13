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
    public class SearchPenaltyCommand : CommandBase
    {

        private readonly ManagePenaltyViewModel _viewModel;

        private PenaltyService service;

        public SearchPenaltyCommand(ManagePenaltyViewModel viewModel)
        {
            service = new PenaltyService();
            _viewModel = viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
        }

        private void _viewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(UsersViewModel.CurrentUser))
            {
                OnCanExecuteChanged();
            }
        }

        public override void Execute(object parameter)
        {
            try
            {
                var objRecord = service.Search(_viewModel.CurrentRecord.Penalty_id);
                if (objRecord != null)
                {
                    _viewModel.CurrentRecord.Penalized_user_id = (int)objRecord.FK_UserID;
                    _viewModel.CurrentRecord.Punished_reservation_id = (int)objRecord.FK_Punished_Reservation_id;
                    _viewModel.CurrentRecord.Penalty_policy_id = (int)objRecord.FK_PenalPolicyID;
                    _viewModel.CurrentRecord.Penalty_expires_on = (DateTime)objRecord.Penalty_Expires_On;
                }
                else
                {
                    _viewModel.Message = "Penalty Not Found";
                }
            }
            catch (Exception ex)
            {

                _viewModel.Message = ex.Message;
            }
        }

    }
}
