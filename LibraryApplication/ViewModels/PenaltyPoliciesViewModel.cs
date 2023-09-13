using LibraryApplication.Commands;
using LibraryApplication.Commands.NavigationCommands;
using LibraryApplication.Commands.PenaltyPolicyCommands;
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
    public class PenaltyPoliciesViewModel : ViewModelBase
    {

        PenaltyService service;
        PenalPolicyService policyService;

        public PenaltyPoliciesViewModel(Stores.NavigationStore navigationStore)
        {
            policyService = new PenalPolicyService();
            

            LoadPolicyData();
            
            
            currentPolicy = new PenalPolicyDTO();

            
            SavePolicyCommand = new SavePolicyCommand(this);            
            
            SearchPolicyCommand = new SearchPolicyCommand(this);           
            
            UpdatePolicyCommand = new UpdatePolicyCommand(this);           
            
            DeletePolicyCommand = new DeletePolicyCommand(this);
       
            loadPolicyCommand = new RelayCommand(LoadPolicyData);

            NavigateMainCommand = new NavigateToAdminMainCommand(navigationStore);

            NavigatePenaltyInterfaceCommand = new NavigateToPenaltyInterfaceCommand(navigationStore);

        }

        public ICommand NavigatePenaltyInterfaceCommand { get; }

        public ICommand NavigateMainCommand { get; }


        #region Display_Operation

        private List<PenalPolicyDTO> penaltyPolicies;

        public List<PenalPolicyDTO> PenaltyPolicies
        {
            get { return penaltyPolicies; }
            set { penaltyPolicies = value; OnPropertyChanged("PenaltyPolicies"); }
        }


        private RelayCommand loadPolicyCommand;

        public RelayCommand LoadPolicyCommand
        {
            get { return loadPolicyCommand; }
        }

        private void LoadPolicyData()
        {
            PenaltyPolicies = new List<PenalPolicyDTO>(policyService.GetAll());
        }

        #endregion

        private PenalPolicyDTO currentListRecord;

        public PenalPolicyDTO CurrentListRecord
        {
            get { return currentListRecord; }
            set { currentListRecord = value; OnPropertyChanged(nameof(CurrentListRecord)); }
        }


        private PenalPolicyDTO currentPolicy;

        public PenalPolicyDTO CurrentPolicy
        {
            get { return currentPolicy; }
            set { currentPolicy = value; OnPropertyChanged("CurrentPolicy"); }
        }


        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged("Message"); }
        }


        #region SaveOperation

        public ICommand SavePolicyCommand { get; set; }

        #endregion

        #region SearchOperation

        public ICommand SearchPolicyCommand { get; set; }

        #endregion

        #region UpdateOperation

        public ICommand UpdatePolicyCommand { get; set; }

        #endregion

        #region DeleteOperation

        public ICommand DeletePolicyCommand { get; set; }

        #endregion

    }
}
