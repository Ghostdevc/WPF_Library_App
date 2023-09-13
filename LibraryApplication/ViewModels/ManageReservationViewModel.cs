using LibraryApplication.Commands;
using LibraryApplication.Commands.ReservationCommands;
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
    public class ManageReservationViewModel : ViewModelBase
    {
        

        ReservationService service;
        ReservationStatusService reservationStatusService;
        BookService bookService;

        public ManageReservationViewModel(Stores.NavigationStore navigationStore)
        {

            
            reservationStatusService = new ReservationStatusService();
            service = new ReservationService();
            bookService = new BookService();


            booksViewModel = new BooksViewModel(navigationStore);
            usersViewModel = new UsersViewModel(navigationStore);

            LoadReservationStatusOptions();

            LoadData();
            currentRecord = new ReservationDTO();

            reservationToCreate = new ReservationDTO();

            MarkBookReturnedCommand = new MarkBookReturnedCommand(this);
            
            SaveReservationCommand = new SaveReservationCommand(this);

            SearchReservationCommand = new SearchReservationCommand(this);

            UpdateReservationCommand = new UpdateReservationCommand(this);

            DeleteReservationCommand = new DeleteReservationCommand(this);


            loadAllReservations = new RelayCommand(LoadData);


            loadActiveReservations = new RelayCommand(ListActiveReservations);

            loadReservationStatusOptionsRelayCommand = new RelayCommand(LoadReservationStatusOptions);

            loadSearchByBookIdDataRelayCommand = new RelayCommand(LoadSearchByBookIdData);

            loadSearchByUserIdDataRelayCommand = new RelayCommand(LoadSearchByUserIdData);

            NavigateMainCommand = new NavigateToAdminMainCommand(navigationStore);
        }

        public ICommand NavigateMainCommand { get; }


        #region Display_Operation
        private List<ReservationDTO> reservations;

        public List<ReservationDTO> Reservations
        {
            get { return reservations; }
            set { reservations = value; OnPropertyChanged("Reservations"); }
        }

        private List<ReservationStatusDTO> reservationStatuses;

        public List<ReservationStatusDTO> ReservationStatuses
        {
            get { return reservationStatuses; }
            set { reservationStatuses = value; OnPropertyChanged("ReservationStatuses"); }
        }

        private List<PenalPolicyDTO> penalPolicies;

        public List<PenalPolicyDTO> PenalPolicies
        {
            get { return penalPolicies; }
            set { penalPolicies = value; OnPropertyChanged("PenalPolicies"); }
        }


        private RelayCommand loadAllReservations;

        public RelayCommand LoadAllReservations
        {
            get { return loadAllReservations; }
        }


        private void LoadData()
        {
            if (Reservations != null && 0 < Reservations.Count)
            {
                Reservations.Clear();
            }
            Reservations = new List<ReservationDTO>(service.GetAll());
        }

        private RelayCommand loadActiveReservations;

        public RelayCommand LoadActiveReservations
        {
            get { return loadActiveReservations; }
        }

        public void ListActiveReservations()
        {
            Reservations = new List<ReservationDTO>(service.GetActiveReservations());
        }


        private RelayCommand loadReservationStatusOptionsRelayCommand;

        public RelayCommand LoadReservationStatusOptionsRelayCommand
        {
            get { return loadReservationStatusOptionsRelayCommand; }
        }

        public void LoadReservationStatusOptions()
        {
            ReservationStatuses = new List<ReservationStatusDTO>(reservationStatusService.GetAll());
        }

        
        private BooksViewModel booksViewModel;

        public BooksViewModel BooksViewModel
        {
            get { return booksViewModel; }
            set { booksViewModel = value; OnPropertyChanged("BooksViewModel"); CurrentRecord.Reserved_book_id = BooksViewModel.CurrentBook.Book_id; }
        }

        private UsersViewModel usersViewModel;

        public UsersViewModel UsersViewModel
        {
            get { return usersViewModel; }
            set { usersViewModel = value; OnPropertyChanged("UsersViewModel"); CurrentRecord.Reserved_to_user_id = UsersViewModel.CurrentUser.User_id; }
        }

        #endregion

        private ReservationDTO reservationToCreate;

        public ReservationDTO ReservationToCreate
        {
            get { return reservationToCreate; }
            set { reservationToCreate = value; OnPropertyChanged(nameof(ReservationToCreate)); }
        }


        private ReservationDTO currentRecord;

        public ReservationDTO CurrentRecord
        {
            get { return currentRecord; }
            set { currentRecord = value; OnPropertyChanged("CurrentRecord"); }
        }

        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged("Message"); }
        }

        private string reservationManagementMessage;

        public string ReservationManagementMessage
        {
            get { return reservationManagementMessage; }
            set { reservationManagementMessage = value; OnPropertyChanged(nameof(ReservationManagementMessage)); }
        }


        #region SaveOperation

        public ICommand SaveReservationCommand { get; set; }

        #endregion

        #region SearchOperation

        public ICommand SearchReservationCommand { get; set; }

        private int searchInput;

        public int SearchInput
        {
            get { return searchInput; }
            set { searchInput = value; OnPropertyChanged(nameof(SearchInput)); }
        }


        private bool isReservationIdChecked;

        public bool IsReservationIdChecked
        {
            get { return isReservationIdChecked; }
            set { isReservationIdChecked = value; OnPropertyChanged(nameof(IsReservationIdChecked)); }
        }

        private bool isUserIdChecked;

        public bool IsUserIdChecked
        {
            get { return isUserIdChecked; }
            set { isUserIdChecked = value; OnPropertyChanged(nameof(IsUserIdChecked)); }
        }

        private bool isBookIdChecked;

        public bool IsBookIdChecked
        {
            get { return isBookIdChecked; }
            set { isBookIdChecked = value; OnPropertyChanged(nameof(IsBookIdChecked)); }
        }


        private RelayCommand loadSearchByUserIdDataRelayCommand;

        public RelayCommand LoadSearchByUserIdDataRelayCommand
        {
            get { return loadSearchByUserIdDataRelayCommand; }
        }


        private void LoadSearchByUserIdData()
        {
            if (Reservations != null && 0 < Reservations.Count)
            {
                Reservations.Clear();
            }
            Reservations = new List<ReservationDTO>(service.SearchByUserId(SearchInput));
        }


        private RelayCommand loadSearchByBookIdDataRelayCommand;

        public RelayCommand LoadSearchByBookIdDataRelayCommand
        {
            get { return loadSearchByBookIdDataRelayCommand; }
        }

        private void LoadSearchByBookIdData()
        {
            if (Reservations != null && 0 < Reservations.Count)
            {
                Reservations.Clear();
            }
            Reservations = new List<ReservationDTO>(service.SearchByBookId(SearchInput));
        }



        #endregion

        #region UpdateOperation

        public ICommand MarkBookReturnedCommand { get; set; }

        public ICommand UpdateReservationCommand { get; set; }

        #endregion

        #region DeleteOperation

        public ICommand DeleteReservationCommand { get; set; }

        #endregion

    }
}
