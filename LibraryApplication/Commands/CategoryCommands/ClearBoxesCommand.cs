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
    internal class ClearBoxesCommand : CommandBase
    {

        private readonly CategoriesViewModel _viewModel;

        private CategoryService service;

        public ClearBoxesCommand(CategoriesViewModel viewModel)
        {
            service = new CategoryService();
            _viewModel = viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
        }

        private void _viewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(CategoriesViewModel.RecordsList))
            {
                OnCanExecuteChanged();
            }
        }

        public override void Execute(object parameter)
        {
            if (_viewModel.CurrentRecord != null)
            {
                _viewModel.CurrentRecord.Category_name = "";
                _viewModel.CurrentRecord.Category_id = 0;
                _viewModel.Message = "";
            }
            
        }

    }
}
