using LibraryApplication.Commands;
using LibraryApplication.Models;
using LibraryApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibraryApplication.Views
{
    /// <summary>
    /// Interaction logic for ManageReservationsView.xaml
    /// </summary>
    public partial class ManageReservationsView : UserControl
    {
        public ManageReservationsView()
        {
            
            InitializeComponent();

            
        }

        //private void dgBooks_Selected(object sender, RoutedEventArgs e)
        //{
        //    (DataContext as ManageReservationViewModel).BooksViewModel.CurrentBook = dgBooks.SelectedValue as BookDTO;
        //}

        //private void dgBooks_CurrentCellChanged(object sender, EventArgs e)
        //{
        //    (DataContext as ManageReservationViewModel).BooksViewModel.CurrentBook = dgBooks.SelectedValue as BookDTO;
        //}

        //private void dgUsers_CurrentCellChanged(object sender, EventArgs e)
        //{
        //    (DataContext as ManageReservationViewModel).UsersViewModel.CurrentUser = dgUsers.SelectedValue as UserDTO;
        //}

        //private void dgReservations_CurrentCellChanged(object sender, EventArgs e)
        //{
        //    (DataContext as ManageReservationViewModel).CurrentRecord = dgReservations.SelectedValue as ReservationDTO;
        //}

        //private void dgReservations_CellClick(object sender, EventArgs e)
        //{
        //    (DataContext as ManageReservationViewModel).CurrentRecord = dgReservations.SelectedValue as ReservationDTO;
        //}

        //private void dgReservations_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    (DataContext as ManageReservationViewModel).CurrentRecord = dgReservations.SelectedValue as ReservationDTO;
        //}

        private void dgReservations_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            (DataContext as ManageReservationViewModel).CurrentRecord = dgReservations.SelectedValue as ReservationDTO;
        }

        private void dgUsers_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            //UserDTO user = new UserDTO();
            //user = dgUsers.SelectedValue as UserDTO;
            //(DataContext as ManageReservationViewModel).CurrentRecord.Reserved_to_user_id = user.User_id;
            if (dgUsers.SelectedItem != null && string.IsNullOrEmpty(txtUser_id.Text) != true)
            {
                (DataContext as ManageReservationViewModel).UsersViewModel.CurrentUser = dgUsers.SelectedItem as UserDTO;
                //(DataContext as ManageReservationViewModel).CurrentRecord.Reserved_to_user_id = int.Parse(txtUser_id.Text);
            }
            else return;
        }

        private void dgBooks_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            //BookDTO book = new BookDTO();
            //book = dgBooks.SelectedValue as BookDTO;
            //(DataContext as ManageReservationViewModel).CurrentRecord.Reserved_book_id = book.Book_id;

            if (dgBooks.SelectedItem != null)
            {
                (DataContext as ManageReservationViewModel).BooksViewModel.CurrentBook = dgBooks.SelectedItem as BookDTO;
                //(DataContext as ManageReservationViewModel).CurrentRecord.Reserved_book_id = int.Parse(txtBook_id.Text);
            }
            else return;
            
        }

        //public RelayCommand LoadBoxesCommand
        //{
        //    get {return }
        //    set { }
        //}



        //public ICommand CurrentCellChangedCommand;
        //{
        //    get { return (ICommand)GetValue(CurrentCellChangedCommand;Property); }
        //    set { SetValue(CurrentCellChangedCommand;Property, value); }
        //}

        // Using a DependencyProperty as the backing store for CurrentCellChangedCommand;.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty CurrentCellChangedCommand;Property =
        //    DependencyProperty.Register("CurrentCellChangedCommand;", typeof(ICommand), typeof(ownerclass), new PropertyMetadata(0));









        //private void dgUsers_Selected(object sender, RoutedEventArgs e)
        //{
        //    (DataContext as ManageReservationViewModel).UsersViewModel.CurrentUser = dgUsers.SelectedValue as UserDTO;
        //}
    }
}
