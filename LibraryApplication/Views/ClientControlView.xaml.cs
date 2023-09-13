using LibraryApplication.Models;
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
    /// Interaction logic for ClientControlView.xaml
    /// </summary>
    public partial class ClientControlView : UserControl
    {
        public ClientControlView()
        {
            InitializeComponent();
        }




        public UserDTO UserTxtDp
        {
            get { return (UserDTO)GetValue(UserTxtDpProperty); }
            set { SetValue(UserTxtDpProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UserTxtDp.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UserTxtDpProperty =
            DependencyProperty.Register("UserTxtDp", typeof(UserDTO), typeof(ClientControlView), new PropertyMetadata(null));




        public UserDTO UserDp
        {
            get { return (UserDTO)GetValue(UserDpProperty); }
            set { SetValue(UserDpProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UserDp.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UserDpProperty =
            DependencyProperty.Register("UserDp", typeof(UserDTO), typeof(ClientControlView), new PropertyMetadata(null));

        private void txtId_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtId.Text != "")
            {
                UserTxtDp.User_id = int.Parse(txtId.Text);
            }
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtName.Text != "")
            {
                UserTxtDp.User_name = txtName.Text;
            }
        }

        private void txtSurname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtSurname.Text != "")
            {
                UserTxtDp.User_surname = txtSurname.Text;
            }
        }

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtUsername.Text != "")
            {
                UserTxtDp.User_nick = txtUsername.Text;
            }
        }

        private void txtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtPassword.Text != "")
            {
                UserTxtDp.User_password = txtPassword.Text;
            }
        }

        private void txtUserTypeID_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtUserTypeID.Text != "")
            {
                UserTxtDp.User_type_id = int.Parse(txtUserTypeID.Text);
            }
        }

        private void lvUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserDp = lvUsers.SelectedValue as UserDTO;
            if (UserDp != null)
            {
                txtId.Text = UserDp.User_id.ToString();
                txtName.Text = UserDp.User_name.ToString();
                txtSurname.Text = UserDp.User_surname.ToString();
                txtUsername.Text = UserDp.User_nick.ToString();
                txtPassword.Text = UserDp.User_password.ToString();
                txtUserTypeID.Text = UserDp.User_type_id.ToString();
            }
        }
    }
}
