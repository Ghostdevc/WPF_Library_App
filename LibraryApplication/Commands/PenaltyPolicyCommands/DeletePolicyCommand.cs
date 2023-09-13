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
    public class DeletePolicyCommand : CommandBase
    {

        private readonly PenaltyPoliciesViewModel _viewModel;

        private PenalPolicyService service;

        public DeletePolicyCommand(PenaltyPoliciesViewModel viewModel)
        {
            service = new PenalPolicyService();
            _viewModel = viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
        }

        private void _viewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //if (e.PropertyName == nameof(CategoriesViewModel.CurrentRecord.Category_name) || e.PropertyName == nameof(CategoriesViewModel.CurrentRecord.Category_id))
            //{
            //    OnCanExecuteChanged();
            //}

            if (e.PropertyName == nameof(PenaltyPoliciesViewModel.CurrentPolicy))
            {
                OnCanExecuteChanged();
            }
        }

        public override void Execute(object parameter)
        {
            try
            {

                if (_viewModel.CurrentPolicy == null)
                {
                    _viewModel.CurrentPolicy = _viewModel.CurrentListRecord;
                }

                var isDeleted = service.Delete(_viewModel.CurrentPolicy);

                _viewModel.LoadPolicyCommand.Execute(null);
                //LoadData();

                if (isDeleted)
                {
                    _viewModel.Message = "Policy Deleted";
                }
                else { _viewModel.Message = "Delete Operation Failed"; }

            }
            catch (Exception ex)
            {

                _viewModel.Message = ex.Message;

            }
        }

    }
}
