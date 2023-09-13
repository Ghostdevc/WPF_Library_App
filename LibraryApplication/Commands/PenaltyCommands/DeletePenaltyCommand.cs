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
    public class DeletePenaltyCommand : CommandBase
    {

        private readonly ManagePenaltyViewModel _viewModel;

        private PenaltyService service;

        public DeletePenaltyCommand(ManagePenaltyViewModel viewModel)
        {
            service = new PenaltyService();
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

                var isDeleted = service.Delete(_viewModel.CurrentRecord);
                _viewModel.LoadPenaltyCommand.Execute(null);
                //LoadData();

                if (isDeleted)
                {
                    _viewModel.Message = "Penalty Deleted";
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
