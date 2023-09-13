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
    /// Interaction logic for WriterControlView.xaml
    /// </summary>
    public partial class WriterControlView : UserControl
    {
        public WriterControlView()
        {
            InitializeComponent();
        }




        public WriterDTO WriterDp
        {
            get { return (WriterDTO)GetValue(WriterDpProperty); }
            set { SetValue(WriterDpProperty, value); }
        }

        // Using a DependencyProperty as the backing store for WriterDp.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WriterDpProperty =
            DependencyProperty.Register("WriterDp", typeof(WriterDTO), typeof(WriterControlView), new PropertyMetadata(null));




        public WriterDTO WriterTxtDp
        {
            get { return (WriterDTO)GetValue(WriterTxtDpProperty); }
            set { SetValue(WriterTxtDpProperty, value); }
        }

        // Using a DependencyProperty as the backing store for WriterTxtDp.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WriterTxtDpProperty =
            DependencyProperty.Register("WriterTxtDp", typeof(WriterDTO), typeof(WriterControlView), new PropertyMetadata(null));

        private void txtWriterId_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtWriterId.Text != "")
            {
                WriterTxtDp.Writer_id = int.Parse(txtWriterId.Text);
            }
        }

        private void txtWriterNameSurname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtWriterNameSurname.Text != "")
            {
                WriterTxtDp.Writer_name_surname = txtWriterNameSurname.Text;
            }
        }

        private void lvWriters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            WriterDp = lvWriters.SelectedValue as WriterDTO;
            if (WriterDp != null)
            {

                txtWriterId.Text = WriterDp.Writer_id.ToString();
                txtWriterNameSurname.Text = WriterDp.Writer_name_surname.ToString();

            }
        }
    }
}
