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
    public class LoadPenaltiesCommand : CommandBase
    {

        private readonly ManagePenaltyViewModel _viewModel;

        private PenaltyService service;

        public LoadPenaltiesCommand(ManagePenaltyViewModel viewModel)
        {
            service = new PenaltyService();
            _viewModel = viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
        }

        private void _viewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ManagePenaltyViewModel.Penalties))
            {
                OnCanExecuteChanged();
            }
        }

        public override void Execute(object parameter)
        {
            
            //_viewModel.Penalties = service.GetAll();

            _viewModel.LoadPenaltyCommand.Execute(parameter);




        }

    }
}
