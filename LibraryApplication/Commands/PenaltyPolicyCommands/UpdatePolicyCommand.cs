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
    public class UpdatePolicyCommand : CommandBase
    {

        private readonly PenaltyPoliciesViewModel _viewModel;

        private PenalPolicyService service;

        public UpdatePolicyCommand(PenaltyPoliciesViewModel viewModel)
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

            //if (e.PropertyName == nameof(CategoriesViewModel.CurrentRecord))
            //{
            //    OnCanExecuteChanged();
            //}

        }

        public override void Execute(object parameter)
        {
            try
            {
                if (_viewModel.CurrentPolicy == null)
                {
                    _viewModel.CurrentPolicy = _viewModel.CurrentListRecord;
                }

                var isUpdated = service.Update(_viewModel.CurrentPolicy);

                _viewModel.LoadPolicyCommand.Execute(null);

                if (isUpdated)
                {
                    _viewModel.Message = "Policy Updated";
                    //_viewModel.LoadCategoriesRelayCommand.Execute(this);
                    //LoadData();
                }
                else
                {
                    _viewModel.Message = "Update operation failed";
                }
            }
            catch (Exception ex)
            {
                _viewModel.Message = ex.Message;
            }
        }

    }
}
