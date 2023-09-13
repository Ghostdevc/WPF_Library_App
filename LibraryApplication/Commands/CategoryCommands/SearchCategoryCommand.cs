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
    public class SearchCategoryCommand : CommandBase
    {

        private readonly CategoriesViewModel _viewModel;

        private CategoryService service;

        public SearchCategoryCommand(CategoriesViewModel viewModel)
        {
            service = new CategoryService();
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
                var objRecord = service.Search(_viewModel.CurrentRecord.Category_id);
                if (objRecord != null)
                {
                    _viewModel.CurrentRecord.Category_name = objRecord.Category_Name;
                }
                else
                {
                    _viewModel.Message = "Category Not Found";
                }
            }
            catch (Exception ex)
            {

                _viewModel.Message = ex.Message;
            }
        }

    }
}
