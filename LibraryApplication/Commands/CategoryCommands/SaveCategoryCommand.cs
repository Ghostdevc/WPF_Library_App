using LibraryApplication.Commands.CategoryCommands;
using LibraryApplication.Models;
using LibraryApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryApplication.Commands
{
    public class SaveCategoryCommand : CommandBase
    {

        private readonly CategoriesViewModel _viewModel;

        private CategoryService service;

        public SaveCategoryCommand(CategoriesViewModel viewModel)
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

            if (e.PropertyName == nameof(CategoriesViewModel.CurrentRecord))
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

                var isSaved = service.Add(_viewModel.CurrentRecord);

                _viewModel.LoadCategoriesRelayCommand.Execute(null);

                if (isSaved)
                {
                    _viewModel.Message = "Category Saved";
                }
                else
                {
                    _viewModel.Message = "Save Operation Failed";
                }
            }
            catch (Exception ex)
            {
                _viewModel.Message = ex.Message;
            }
        }

        
    }
}
