using LibraryApplication.Stores;
using LibraryApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Commands.NavigationCommands
{
    public class LogoutCommand : CommandBase
    {

        private readonly NavigationStore _navigationStore;

        public LogoutCommand(NavigationStore navigationStore)
        {

            _navigationStore = navigationStore;

        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new LoginViewModel(_navigationStore);
        }

    }
}
