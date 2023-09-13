using LibraryApplication.Models;
using LibraryApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LibraryApplication.Commands.CategoryCommands
{
    public class LoadCategoriesCommand : CommandBase
    {

        private readonly CategoriesViewModel _viewModel;

        private CategoryService service;

        public LoadCategoriesCommand(CategoriesViewModel viewModel)
        {
            service = new CategoryService();
            _viewModel = viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
        }

        private void _viewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(CategoriesViewModel.RecordsList.Count))
            {
                OnCanExecuteChanged();
            }
        }

        public override void Execute(object parameter)
        {
            //List<CategoryDTO> categories = new List<CategoryDTO>(service.GetAll());

            //_viewModel.RecordsList = categories;
            _viewModel.LoadCategoriesRelayCommand.Execute(null);

            
            
            
        }

    }
}
