using LibraryApplication.Stores;
using LibraryApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Commands.NavigationCommands
{
    public class NavigateToPolicyCommand : CommandBase
    {

        private readonly NavigationStore _navigationStore;

        public NavigateToPolicyCommand(NavigationStore navigationStore)
        {

            _navigationStore = navigationStore;

        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new PenaltyPoliciesViewModel(_navigationStore);

        }
    }
}

