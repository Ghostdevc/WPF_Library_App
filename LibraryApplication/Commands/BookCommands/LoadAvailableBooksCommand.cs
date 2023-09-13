﻿using LibraryApplication.Models;
using LibraryApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Commands.BookCommands
{
    public class LoadAvailableBooksCommand : CommandBase
    {

        private readonly BooksViewModel _viewModel;

        private BookService service;

        public LoadAvailableBooksCommand(BooksViewModel viewModel)
        {
            service = new BookService();
            _viewModel = viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
        }

        private void _viewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(BooksViewModel.BooksList))
            {
                OnCanExecuteChanged();
            }
        }

        public override void Execute(object parameter)
        {
            
            //_viewModel.BooksList = service.GetAvailableBooks();

            _viewModel.LoadAvailableBooksCommand.Execute(parameter);


        }

    }
}
