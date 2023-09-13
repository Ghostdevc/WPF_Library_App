using LibraryApplication.Models;
using LibraryApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Commands.WriterCommands
{
    public class LoadWritersCommand : CommandBase
    {

        private readonly WritersViewModel _viewModel;

        private WriterService service;

        public LoadWritersCommand(WritersViewModel viewModel)
        {
            service = new WriterService();
            _viewModel = viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
        }

        private void _viewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(WritersViewModel.WritersList))
            {
                OnCanExecuteChanged();
            }
        }

        public override void Execute(object parameter)
        {
            
            //_viewModel.WritersList = service.GetAll();

            _viewModel.LoadWritersRelayCommand.Execute(parameter);


        }

    }
}
