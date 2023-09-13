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
    /// Interaction logic for ManagePenaltyPoliciesView.xaml
    /// </summary>
    public partial class ManagePenaltyPoliciesView : UserControl
    {
        public ManagePenaltyPoliciesView()
        {
            InitializeComponent();
        }




        public PenalPolicyDTO PolicyTxtDp
        {
            get { return (PenalPolicyDTO)GetValue(PolicyTxtDpProperty); }
            set { SetValue(PolicyTxtDpProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PolicyTxtDp.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PolicyTxtDpProperty =
            DependencyProperty.Register("PolicyTxtDp", typeof(PenalPolicyDTO), typeof(ManagePenaltyPoliciesView), new PropertyMetadata(null));



        public PenalPolicyDTO PolicyDp
        {
            get { return (PenalPolicyDTO)GetValue(PolicyDpProperty); }
            set { SetValue(PolicyDpProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PolicyDp.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PolicyDpProperty =
            DependencyProperty.Register("PolicyDp", typeof(PenalPolicyDTO), typeof(ManagePenaltyPoliciesView), new PropertyMetadata(null));




        //private void dgPenaltyPolicy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{

        //PolicyDp = dgPenaltyPolicy.SelectedValue as PenalPolicyDTO;
        //    if (PolicyDp != null)
        //    {
        //        txtPenaltyPolicyId.Text = PolicyDp.Penal_policy_id.ToString();
        //        txtPenaltyPolicyDaysCount.Text = PolicyDp.Penalty_days.ToString();
        //    }


    //}

    private void txtPenaltyPolicyId_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtPenaltyPolicyId.Text != "")
            {
                PolicyTxtDp.Penal_policy_id = int.Parse(txtPenaltyPolicyId.Text);
            }
            
        }

        private void txtPenaltyPolicyDaysCount_TextChanged(object sender, TextChangedEventArgs e)
        {

            if(txtPenaltyPolicyDaysCount.Text != "" && txtPenaltyPolicyDaysCount.Text != null)
            {
                PolicyTxtDp.Penalty_days = int.Parse(txtPenaltyPolicyDaysCount.Text);
            }

            
        }

        private void lvPolicies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PolicyDp = lvPolicies.SelectedValue as PenalPolicyDTO;
            if (PolicyDp != null)
            {
                txtPenaltyPolicyId.Text = PolicyDp.Penal_policy_id.ToString();
                txtPenaltyPolicyDaysCount.Text = PolicyDp.Penalty_days.ToString();
            }
        }
    }
}
