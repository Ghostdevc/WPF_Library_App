using LibraryApplication.Models;
using LibraryApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Commands
{
    public class UpdateCategoryCommand : CommandBase
    {

        private readonly CategoriesViewModel _viewModel;

        private CategoryService service;

        public UpdateCategoryCommand(CategoriesViewModel viewModel)
        {
            service = new CategoryService();
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

                if (_viewModel.CurrentRecord == null)
                {
                    _viewModel.CurrentRecord = _viewModel.CurrentListRecord;
                }

                var isUpdated = service.Update(_viewModel.CurrentRecord);

                _viewModel.LoadCategoriesRelayCommand.Execute(null);

                if (isUpdated)
                {
                    _viewModel.Message = "Category Updated";
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
