﻿#pragma checksum "..\..\Account.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "015D4BC6DB9C27063F82B0FB60327969CC34D163651E7604F7EF9292E6110605"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
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
using WPFCLEAN;


namespace WPFCLEAN {
    
    
    /// <summary>
    /// Account
    /// </summary>
    public partial class Account : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 48 "..\..\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button dodajacc;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button izmeniacc;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button izbrisiacc;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgAcc;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFCLEAN;component/account.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Account.xaml"
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
            this.dodajacc = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\Account.xaml"
            this.dodajacc.Click += new System.Windows.RoutedEventHandler(this.dodajacc_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.izmeniacc = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\Account.xaml"
            this.izmeniacc.Click += new System.Windows.RoutedEventHandler(this.izmeniacc_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.izbrisiacc = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\Account.xaml"
            this.izbrisiacc.Click += new System.Windows.RoutedEventHandler(this.izbrisiacc_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dgAcc = ((System.Windows.Controls.DataGrid)(target));
            
            #line 79 "..\..\Account.xaml"
            this.dgAcc.AddHandler(System.Windows.Input.Mouse.PreviewMouseDownEvent, new System.Windows.Input.MouseButtonEventHandler(this.dgAcc_PreviewMouseDown));
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

