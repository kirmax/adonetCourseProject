﻿#pragma checksum "..\..\Purchasecontrol.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "336248C582C4C29A594F59D1879A61398E2A44E1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using adonetCourseProject;


namespace adonetCourseProject {
    
    
    /// <summary>
    /// Purchasecontrol
    /// </summary>
    public partial class Purchasecontrol : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 26 "..\..\Purchasecontrol.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearch;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Purchasecontrol.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Purchasecontrol.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Purchasecontrol.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Purchasecontrol.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEdit;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Purchasecontrol.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvPurchases;
        
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
            System.Uri resourceLocater = new System.Uri("/adonetCourseProject;component/purchasecontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Purchasecontrol.xaml"
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
            this.tbSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\Purchasecontrol.xaml"
            this.tbSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnSearch = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\Purchasecontrol.xaml"
            this.btnSearch.Click += new System.Windows.RoutedEventHandler(this.btnSearch_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\Purchasecontrol.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\Purchasecontrol.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnEdit = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\Purchasecontrol.xaml"
            this.btnEdit.Click += new System.Windows.RoutedEventHandler(this.btnEdit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lvPurchases = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 7:
            
            #line 57 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Loaded += new System.Windows.RoutedEventHandler(this.tviProduct_Loaded);
            
            #line default
            #line hidden
            
            #line 57 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Expanded += new System.Windows.RoutedEventHandler(this.tvProduct_Expanded);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 62 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.TextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 62 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            break;
            case 9:
            
            #line 66 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.TextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 66 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            break;
            case 10:
            
            #line 70 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.TextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 70 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            break;
            case 11:
            
            #line 74 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.TextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 74 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            break;
            case 12:
            
            #line 89 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.TextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 89 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            break;
            case 13:
            
            #line 96 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.TextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 96 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            break;
            case 14:
            
            #line 119 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.TextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 119 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            break;
            case 15:
            
            #line 131 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Loaded += new System.Windows.RoutedEventHandler(this.tviProduct_Loaded);
            
            #line default
            #line hidden
            
            #line 131 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Expanded += new System.Windows.RoutedEventHandler(this.tvProduct_Expanded);
            
            #line default
            #line hidden
            break;
            case 16:
            
            #line 136 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.TextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 136 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            break;
            case 17:
            
            #line 140 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.TextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 140 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            break;
            case 18:
            
            #line 144 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.TextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 144 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            break;
            case 19:
            
            #line 148 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.TextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 148 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            break;
            case 20:
            
            #line 152 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.TextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 152 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            break;
            case 21:
            
            #line 157 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.TextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 157 "..\..\Purchasecontrol.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

