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
    public class PenaltyInterfaceViewModel : ViewModelBase
    {

        public PenaltyInterfaceViewModel(Stores.NavigationStore navigationStore)
        {
            NavigatePenaltyCommand = new NavigateToPenaltyCommand(navigationStore);

            NavigatePolicyCommand = new NavigateToPolicyCommand(navigationStore);
            
            NavigateMainCommand = new NavigateToAdminMainCommand(navigationStore);
        }

        public ICommand NavigatePenaltyCommand { get; }

        public ICommand NavigatePolicyCommand { get; }

        public ICommand NavigateMainCommand { get; }

    }
}
