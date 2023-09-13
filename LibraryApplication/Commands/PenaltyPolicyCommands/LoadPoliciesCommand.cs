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
    public class LoadPoliciesCommand : CommandBase
    {

        private readonly PenaltyPoliciesViewModel _viewModel;

        private PenalPolicyService service;


        public LoadPoliciesCommand(PenaltyPoliciesViewModel viewModel)
        {
            service = new PenalPolicyService();
            _viewModel = viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
        }

        private void _viewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(PenaltyPoliciesViewModel.PenaltyPolicies))
            {
                OnCanExecuteChanged();
            }
        }

        public override void Execute(object parameter)
        {
            
            //_viewModel.PenaltyPolicies = service.GetAll();

            _viewModel.LoadPolicyCommand.Execute(parameter);


        }

    }
}
