﻿#pragma checksum "..\..\..\UploadWindow.cs.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53DFD076300D7F415E3C81986C8D7CFCA6C80925"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NetBookLog;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace NetBookLog {
    
    
    /// <summary>
    /// UploadWindow
    /// </summary>
    public partial class UploadWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\UploadWindow.cs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonOpenFiles;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\UploadWindow.cs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBoxSelectedFiles;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\UploadWindow.cs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonAdd;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\UploadWindow.cs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonRemove;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/NetBookLog;V1.0;component/uploadwindow.cs.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UploadWindow.cs.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.buttonOpenFiles = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\UploadWindow.cs.xaml"
            this.buttonOpenFiles.Click += new System.Windows.RoutedEventHandler(this.ButtonOpenFiles_OnClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.listBoxSelectedFiles = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.buttonAdd = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\UploadWindow.cs.xaml"
            this.buttonAdd.Click += new System.Windows.RoutedEventHandler(this.ButtonAdd_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonRemove = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\UploadWindow.cs.xaml"
            this.buttonRemove.Click += new System.Windows.RoutedEventHandler(this.ButtonRemove_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

