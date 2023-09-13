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
    public class SelectedCategoryChangedCommand : CommandBase
    {
        private readonly CategoriesViewModel _viewModel;

        private CategoryService service;

        public SelectedCategoryChangedCommand(CategoriesViewModel viewModel)
        {
            service = new CategoryService();
            _viewModel = viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
        }

        private void _viewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(CategoriesViewModel.CurrentRecord))
            {
                OnCanExecuteChanged();
            }
        }

        public override void Execute(object parameter)
        {
            _viewModel.CurrentRecord = (CategoryDTO)parameter;
        }
    }
}
