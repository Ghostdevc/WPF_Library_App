﻿#pragma checksum "..\..\..\Views\ManagePenaltyPoliciesView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "35F7DFC118D3026019F54C8288B1F7E8EA0CC9CC9B87AE8CA8A7439FBC17FDFA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LibraryApplication.ViewModels;
using LibraryApplication.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace LibraryApplication.Views {
    
    
    /// <summary>
    /// ManagePenaltyPoliciesView
    /// </summary>
    public partial class ManagePenaltyPoliciesView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\..\Views\ManagePenaltyPoliciesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPenaltyPolicyId;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Views\ManagePenaltyPoliciesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPenaltyPolicyDaysCount;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Views\ManagePenaltyPoliciesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Views\ManagePenaltyPoliciesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Views\ManagePenaltyPoliciesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Views\ManagePenaltyPoliciesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Views\ManagePenaltyPoliciesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNavigatePenaltyInterface;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Views\ManagePenaltyPoliciesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNavigateMain;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Views\ManagePenaltyPoliciesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtBlockMessage;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Views\ManagePenaltyPoliciesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvPolicies;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LibraryApplication;component/views/managepenaltypoliciesview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ManagePenaltyPoliciesView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtPenaltyPolicyId = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\..\Views\ManagePenaltyPoliciesView.xaml"
            this.txtPenaltyPolicyId.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtPenaltyPolicyId_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtPenaltyPolicyDaysCount = ((System.Windows.Controls.TextBox)(target));
            
            #line 51 "..\..\..\Views\ManagePenaltyPoliciesView.xaml"
            this.txtPenaltyPolicyDaysCount.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtPenaltyPolicyDaysCount_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.btnSearch = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.btnNavigatePenaltyInterface = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.btnNavigateMain = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.txtBlockMessage = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.lvPolicies = ((System.Windows.Controls.ListView)(target));
            
            #line 73 "..\..\..\Views\ManagePenaltyPoliciesView.xaml"
            this.lvPolicies.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lvPolicies_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

