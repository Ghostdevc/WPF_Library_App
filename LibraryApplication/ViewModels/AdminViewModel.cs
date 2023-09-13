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
    public class AdminViewModel : ViewModelBase
    {

        public AdminViewModel(Stores.NavigationStore navigationStore)
        {

            NavigateReservationCommand = new NavigateToReservationCommand(navigationStore);

            NavigateClientCommand = new NavigateToClientCommand(navigationStore);

            NavigatePenaltyInterfaceCommand = new NavigateToPenaltyInterfaceCommand(navigationStore);

            NavigateContentInterfaceCommand = new NavigateToContentInterfaceCommand(navigationStore);

            LogoutCommand = new LogoutCommand(navigationStore);

        }


        public ICommand NavigateReservationCommand { get; }

        public ICommand NavigateClientCommand { get; }

        public ICommand NavigatePenaltyInterfaceCommand { get; }

        public ICommand NavigateContentInterfaceCommand { get; }

        public ICommand LogoutCommand { get; }

        //test change
    }
}
