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
    /// Interaction logic for BooksView.xaml
    /// </summary>
    public partial class BooksView : UserControl
    {
        public BooksView()
        {
            InitializeComponent();
        }




        public BookDTO BookDp
        {
            get { return (BookDTO)GetValue(BookDpProperty); }
            set { SetValue(BookDpProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BookDp.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BookDpProperty =
            DependencyProperty.Register("BookDp", typeof(BookDTO), typeof(BooksView), new PropertyMetadata(null));




        public BookDTO BookTxtDp
        {
            get { return (BookDTO)GetValue(BookTxtDpProperty); }
            set { SetValue(BookTxtDpProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BookTxtDp.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BookTxtDpProperty =
            DependencyProperty.Register("BookTxtDp", typeof(BookDTO), typeof(BooksView), new PropertyMetadata(null));

        private void txtBookId_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtBookId.Text != "")
            {
                BookTxtDp.Book_id = int.Parse(txtBookId.Text);
            }
        }

        private void txtBookName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtBookName.Text != "")
            {
                BookTxtDp.Book_name = txtBookName.Text;
            }
        }

        private void txtStatus_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtStatus.Text != "")
            {
                BookTxtDp.Status_id = int.Parse(txtStatus.Text);
            }
        }

        private void txtWriter_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtWriter.Text != "")
            {
                BookTxtDp.Writer_id = int.Parse(txtWriter.Text);
            }
        }

        private void txtCategory_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtCategory.Text != "")
            {
                BookTxtDp.Category_id = int.Parse(txtCategory.Text);
            }
        }

        private void lvBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            BookDp = lvBooks.SelectedValue as BookDTO;

            if (BookDp != null)
            {
                txtBookId.Text = BookDp.Book_id.ToString();
                txtBookName.Text = BookDp.Book_name.ToString();
                txtStatus.Text = BookDp.Status_id.ToString();
                txtWriter.Text = BookDp.Writer_id.ToString();
                txtCategory.Text = BookDp.Category_id.ToString();
            }


        }
    }
}
