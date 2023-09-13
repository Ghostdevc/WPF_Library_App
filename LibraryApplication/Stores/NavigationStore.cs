using LibraryApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Stores
{
    public class NavigationStore
    {

        public event Action CurrentViewModelChanged;

		private ViewModelBase currentViewModel;

		public ViewModelBase CurrentViewModel
		{
			get { return currentViewModel; }
			set { currentViewModel = value; OnCurrentViewModelChanged(); }
		}

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
