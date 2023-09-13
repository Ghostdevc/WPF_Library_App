using LibraryApplication.Models;
using LibraryApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Commands.PenaltyPolicyCommands
{
    public class SearchPolicyCommand : CommandBase
    {

        private readonly PenaltyPoliciesViewModel _viewModel;

        private PenalPolicyService service;

        public SearchPolicyCommand(PenaltyPoliciesViewModel viewModel)
        {
            service = new PenalPolicyService();
            _viewModel = viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
        }

        private void _viewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(PenaltyPoliciesViewModel.CurrentPolicy.Penalty_days) || e.PropertyName == nameof(PenaltyPoliciesViewModel.CurrentPolicy.Penal_policy_id))
            {
                OnCanExecuteChanged();
            }
        }

        public override void Execute(object parameter)
        {
            try
            {
                var objRecord = service.Search(_viewModel.CurrentPolicy.Penal_policy_id);
                if (objRecord != null)
                {
                    _viewModel.CurrentPolicy.Penalty_days = (int)objRecord.Penalty_Days;
                }
                else
                {
                    _viewModel.Message = "Policy Not Found";
                }
            }
            catch (Exception ex)
            {

                _viewModel.Message = ex.Message;
            }
        }

    }
}
