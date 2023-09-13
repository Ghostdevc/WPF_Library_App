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
    /// Interaction logic for CategoryControlView.xaml
    /// </summary>
    public partial class CategoryControlView : UserControl
    {
        public CategoryControlView()
        {
            InitializeComponent();
        }





        public CategoryDTO CategoryDp
        {
            get { return (CategoryDTO)GetValue(CategoryDpProperty); }
            set { SetValue(CategoryDpProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CategoryDp.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CategoryDpProperty =
            DependencyProperty.Register("CategoryDp", typeof(CategoryDTO), typeof(CategoryControlView), new PropertyMetadata(null));




        public CategoryDTO CategoryTxtDp
        {
            get { return (CategoryDTO)GetValue(CategoryTxtDpProperty); }
            set { SetValue(CategoryTxtDpProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CategoryTxtDp.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CategoryTxtDpProperty =
            DependencyProperty.Register("CategoryTxtDp", typeof(CategoryDTO), typeof(CategoryControlView), new PropertyMetadata(null));




        private void lvCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            CategoryDp = lvCategories.SelectedValue as CategoryDTO;

            if (CategoryDp != null)
            {
                txtCategoryId.Text = CategoryDp.Category_id.ToString();
                txtCategoryName.Text = CategoryDp.Category_name.ToString();
            }
            
        }

        private void txtCategoryId_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtCategoryId.Text != "")
            {
                CategoryTxtDp.Category_id = int.Parse(txtCategoryId.Text);
            }
            
        }

        private void txtCategoryName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txtCategoryName.Text != "")
            {
                CategoryTxtDp.Category_name = txtCategoryName.Text;
            }
        }
    }
}
