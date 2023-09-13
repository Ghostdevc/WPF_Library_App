using LibraryApplication.Commands;
using LibraryApplication.Commands.CategoryCommands;
using LibraryApplication.Commands.NavigationCommands;
using LibraryApplication.Commands.WriterCommands;
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
    public class WritersViewModel : ViewModelBase
    {
        

        WriterService service;

        public WritersViewModel(Stores.NavigationStore navigationStore)
        {
            service = new WriterService();
            LoadData();
            currentRecord = new WriterDTO();

            SaveWriterCommand = new SaveWriterCommand(this);

            SearchWriterCommand = new SearchWriterCommand(this);

            UpdateWriterCommand = new UpdateWriterCommand(this);

            DeleteWriterCommand = new DeleteWriterCommand(this);

            loadWritersRelayCommand = new RelayCommand(LoadData);

            NavigateMainCommand = new NavigateToAdminMainCommand(navigationStore);

            NavigateContentInterfaceCommand = new NavigateToContentInterfaceCommand(navigationStore);  
        }

        public ICommand NavigateContentInterfaceCommand { get; }

        public ICommand NavigateMainCommand { get; }

        #region Display_Operation
        private List<WriterDTO> writersList;

        public List<WriterDTO> WritersList
        {
            get { return writersList; }
            set { writersList = value; OnPropertyChanged("WritersList"); }
        }

        private RelayCommand loadWritersRelayCommand;

        public RelayCommand LoadWritersRelayCommand
        {
            get { return loadWritersRelayCommand; }
        }


        private void LoadData()
        {
            WritersList = new List<WriterDTO>(service.GetAll());
        }
        #endregion


        private WriterDTO currentListRecord;

        public WriterDTO CurrentListRecord
        {
            get { return currentListRecord; }
            set { currentListRecord = value; OnPropertyChanged(nameof(CurrentListRecord)); }
        }



        private WriterDTO currentRecord;

        public WriterDTO CurrentRecord
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

        #region SaveOperation

        public ICommand SaveWriterCommand { get; set; }

        #endregion

        #region SearchOperation

        public ICommand SearchWriterCommand { get; set; }

        #endregion

        #region UpdateOperation

        public ICommand UpdateWriterCommand { get; set; }

        #endregion

        #region DeleteOperation

        public ICommand DeleteWriterCommand { get; set; }

        #endregion

    }
}
