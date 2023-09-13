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
    public class DeleteWriterCommand : CommandBase
    {

        private readonly WritersViewModel _viewModel;

        private WriterService service;

        public DeleteWriterCommand(WritersViewModel viewModel)
        {
            service = new WriterService();
            _viewModel = viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
        }

        private void _viewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //if (e.PropertyName == nameof(CategoriesViewModel.CurrentRecord.Category_name) || e.PropertyName == nameof(CategoriesViewModel.CurrentRecord.Category_id))
            //{
            //    OnCanExecuteChanged();
            //}

            if (e.PropertyName == nameof(WritersViewModel.CurrentRecord))
            {
                OnCanExecuteChanged();
            }
        }

        public override void Execute(object parameter)
        {
            try
            {

                if (_viewModel.CurrentRecord == null)
                {
                    _viewModel.CurrentRecord = _viewModel.CurrentListRecord;
                }

                var isDeleted = service.Delete(_viewModel.CurrentRecord);

                _viewModel.LoadWritersRelayCommand.Execute(null);
                //LoadData();

                if (isDeleted)
                {
                    _viewModel.Message = "Writer Deleted";
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
