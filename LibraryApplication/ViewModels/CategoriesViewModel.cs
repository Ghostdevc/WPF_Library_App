using LibraryApplication.Commands;
using LibraryApplication.Commands.CategoryCommands;
using LibraryApplication.Commands.NavigationCommands;
using LibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryApplication.ViewModels
{
    public class CategoriesViewModel : ViewModelBase
    {

        CategoryService service;

        public CategoriesViewModel(Stores.NavigationStore navigationStore)
        {
            service = new CategoryService();
            
            currentRecord = new CategoryDTO();

            SaveCategoryCommand = new SaveCategoryCommand(this);

            SearchCategoryCommand = new SearchCategoryCommand(this);

            UpdateCategoryCommand = new UpdateCategoryCommand(this);

            DeleteCategoryCommand = new DeleteCategoryCommand(this);


            loadCategoriesRelayCommand = new RelayCommand(LoadCategories);

            LoadCategories();

            NavigateMainCommand = new NavigateToAdminMainCommand(navigationStore);

            NavigateContentInterfaceCommand = new NavigateToContentInterfaceCommand(navigationStore);  

        }

        public ICommand NavigateContentInterfaceCommand { get; }

        public ICommand NavigateMainCommand { get; }


        private List<CategoryDTO> recordsList;

        public List<CategoryDTO> RecordsList
        {
            get { return recordsList; }
            set { recordsList = value; OnPropertyChanged("RecordsList"); }
        }


        #region Display_Operation

        private RelayCommand loadCategoriesRelayCommand;

        public RelayCommand LoadCategoriesRelayCommand
        {
            get { return loadCategoriesRelayCommand; }
        }


        public void LoadCategories()
        {
            RecordsList = new List<CategoryDTO>(service.GetAll());
        }

        public ICommand ClearBoxesCommand { get; set; }

        public ICommand LoadCategoriesCommand { get; set; }

        
        #endregion

        private CategoryDTO currentRecord;

        public CategoryDTO CurrentRecord
        {
            get { return currentRecord; }
            set { currentRecord = value; OnPropertyChanged("CurrentRecord"); }
        }


        private CategoryDTO currentListRecord;

        public CategoryDTO CurrentListRecord
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

        public ICommand SaveCategoryCommand { get; }

        #endregion

        #region SearchOperation

        public ICommand SearchCategoryCommand { get; }

        #endregion

        #region UpdateOperation

        public ICommand UpdateCategoryCommand { get; }

        #endregion

        #region DeleteOperation

        public ICommand DeleteCategoryCommand { get; }

        #endregion

    }
}
