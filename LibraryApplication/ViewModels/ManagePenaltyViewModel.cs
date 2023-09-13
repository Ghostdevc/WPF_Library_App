using LibraryApplication.Commands;
using LibraryApplication.Commands.NavigationCommands;
using LibraryApplication.Commands.PenaltyCommands;
using LibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryApplication.ViewModels
{
    public class ManagePenaltyViewModel : ViewModelBase
    {
        

        PenaltyService service;
        ReservationService reservationService;


        public ManagePenaltyViewModel(Stores.NavigationStore navigationStore)
        {
            reservationService = new ReservationService();
            service = new PenaltyService();

            LoadReservationsToBePenalized(); 
            
            LoadPenaltyData();

            penaltyPoliciesViewModel = new PenaltyPoliciesViewModel(navigationStore);

            //manageReservationViewModel = new ManageReservationViewModel();

            currentReservationToBePunished = new ReservationDTO();

            currentRecord = new PenaltyDTO();
          
            SavePenaltyCommand = new SavePenaltyCommand(this);

            SearchPenaltyCommand = new SearchPenaltyCommand(this);

            UpdatePenaltyCommand = new UpdatePenaltyCommand(this);

            DeletePenaltyCommand = new DeletePenaltyCommand(this);

            loadPenaltyCommand = new RelayCommand(LoadPenaltyData);

            listPunishableReservationsCommand = new RelayCommand(LoadReservationsToBePenalized);

            NavigateMainCommand = new NavigateToAdminMainCommand(navigationStore);

            NavigatePenaltyInterfaceCommand = new NavigateToPenaltyInterfaceCommand(navigationStore);

        }

        public ICommand NavigatePenaltyInterfaceCommand { get; }

        public ICommand NavigateMainCommand { get; set; }


        #region Display_Operation

        private List<PenaltyDTO> penalties;

        public List<PenaltyDTO> Penalties
        {
            get { return penalties; }
            set { penalties = value; OnPropertyChanged("Penalties"); }
        }

        private List<ReservationDTO> reservations;

        public List<ReservationDTO> Reservations
        {
            get { return reservations; }
            set { reservations = value; OnPropertyChanged("Reservations"); }
        }


        private RelayCommand loadPenaltyCommand;

        public RelayCommand LoadPenaltyCommand
        {
            get { return loadPenaltyCommand; }
        }


        private void LoadPenaltyData()
        {
            Penalties = new List<PenaltyDTO>(service.GetAll());
        }


        private RelayCommand listPunishableReservationsCommand;

        public RelayCommand ListPunishableReservationsCommand
        {
            get { return listPunishableReservationsCommand; }
        }


        public void LoadReservationsToBePenalized()
        {
            Reservations = new List<ReservationDTO>(reservationService.GetReservationsToBePenalized());
        }

        #endregion


        private int selectedPolicyt;

        public int SelectedPolicy
        {
            get { return selectedPolicyt; }
            set { selectedPolicyt = value; OnPropertyChanged(nameof(SelectedPolicy)); }
        }



        private PenaltyPoliciesViewModel penaltyPoliciesViewModel;

        public PenaltyPoliciesViewModel PenaltyPoliciesViewModel
        {
            get { return penaltyPoliciesViewModel; }
            set { penaltyPoliciesViewModel = value; OnPropertyChanged("PenaltyPoliciesViewModel"); }
        }

        //private ManageReservationViewModel manageReservationViewModel;

        //public ManageReservationViewModel ManageReservationViewModel
        //{
        //    get { return manageReservationViewModel; }
        //    set { manageReservationViewModel = value; OnPropertyChanged("ManageReservationViewModel"); }
        //}


        private ReservationDTO currentReservationToBePunished;

        public ReservationDTO CurrentReservationToBePunished
        {
            get { return currentReservationToBePunished; }
            set { currentReservationToBePunished = value; OnPropertyChanged("CurrentReservationToBePunished"); }
        }

        private ReservationDTO reservationCurrentListRecord;

        public ReservationDTO ReservationCurrentListRecord
        {
            get { return reservationCurrentListRecord; }
            set { reservationCurrentListRecord = value; OnPropertyChanged(nameof(ReservationCurrentListRecord)); }
        }



        private PenaltyDTO currentRecord;

        public PenaltyDTO CurrentRecord
        {
            get { return currentRecord; }
            set { currentRecord = value; OnPropertyChanged("CurrentRecord"); }
        }

        private PenaltyDTO currentListRecord;

        public PenaltyDTO CurrentListRecord
        {
            get { return currentListRecord; }
            set { currentListRecord = value; OnPropertyChanged(nameof(CurrentListRecord)); }
        }



        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged("Message"); }
        }

        #region SaveOperation

        public ICommand SavePenaltyCommand { get; set; }

        #endregion

        #region SearchOperation

        public ICommand SearchPenaltyCommand { get; set; }

        #endregion

        #region UpdateOperation

        public ICommand UpdatePenaltyCommand { get; set; }

        #endregion

        #region DeleteOperation

        public ICommand DeletePenaltyCommand { get; set; }

        #endregion

    }
}
