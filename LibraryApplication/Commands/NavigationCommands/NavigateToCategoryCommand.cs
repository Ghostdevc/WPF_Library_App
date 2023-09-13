using LibraryApplication.Stores;
using LibraryApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Commands.NavigationCommands
{
    public class NavigateToCategoryCommand : CommandBase
    {

        private readonly NavigationStore _navigationStore;

        public NavigateToCategoryCommand(NavigationStore navigationStore)
        {

            _navigationStore = navigationStore;

        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new CategoriesViewModel(_navigationStore);
        }

    }
}
