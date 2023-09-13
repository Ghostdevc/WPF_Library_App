using LibraryApplication.Stores;
using LibraryApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Commands.NavigationCommands
{
    public class NavigateToPenaltyCommand : CommandBase
    {

        private readonly NavigationStore _navigationStore;

        public NavigateToPenaltyCommand(NavigationStore navigationStore)
        {

            _navigationStore = navigationStore;

        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new ManagePenaltyViewModel(_navigationStore);
        }

    }
}
