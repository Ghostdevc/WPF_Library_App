using LibraryApplication.Commands;
using LibraryApplication.Commands.NavigationCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryApplication.ViewModels
{
    public class ContentInterfaceViewModel : ViewModelBase
    {

        public ContentInterfaceViewModel(Stores.NavigationStore navigationStore)
        {
            
            NavigateCategoryCommand = new NavigateToCategoryCommand(navigationStore);

            NavigateWriterCommand = new NavigateToWriterCommand(navigationStore);

            NavigateBookCommand = new NavigateToBookCommand(navigationStore);

            NavigateMainCommand = new NavigateToAdminMainCommand(navigationStore);

        }


        public ICommand NavigateCategoryCommand { get; }

        public ICommand NavigateWriterCommand { get; }

        public ICommand NavigateBookCommand { get; }

        public ICommand NavigateMainCommand { get; }

    }
}
