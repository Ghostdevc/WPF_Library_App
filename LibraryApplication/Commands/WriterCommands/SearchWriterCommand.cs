using LibraryApplication.Models;
using LibraryApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Commands.CategoryCommands
{
    public class SearchWriterCommand : CommandBase
    {

        private readonly WritersViewModel _viewModel;

        private WriterService service;

        public SearchWriterCommand(WritersViewModel viewModel)
        {
            service = new WriterService();
            _viewModel = viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
        }

        private void _viewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(CategoriesViewModel.CurrentRecord.Category_name) || e.PropertyName == nameof(CategoriesViewModel.CurrentRecord.Category_id))
            {
                OnCanExecuteChanged();
            }
        }

        public override void Execute(object parameter)
        {
            try
            {
                var objRecord = service.Search(_viewModel.CurrentRecord.Writer_id);
                if (objRecord != null)
                {
                    _viewModel.CurrentRecord.Writer_name_surname = objRecord.Writer_Name_Surname;
                }
                else
                {
                    _viewModel.Message = "Writer Not Found";
                }
            }
            catch (Exception ex)
            {

                _viewModel.Message = ex.Message;
            }
        }

    }
}
