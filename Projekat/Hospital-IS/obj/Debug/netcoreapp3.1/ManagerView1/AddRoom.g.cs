﻿#pragma checksum "..\..\..\..\ManagerView1\AddRoom.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4184691F04E143E971B0EDDAA29C3E12F0FC8890"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Hospital_IS.ManagerViewModel;
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


namespace Hospital_IS.ManagerView1 {
    
    
    /// <summary>
    /// AddRoom
    /// </summary>
    public partial class AddRoom : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 159 "..\..\..\..\ManagerView1\AddRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\..\..\ManagerView1\AddRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RoomNumberBox;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\..\..\ManagerView1\AddRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RoomFloorBox;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\..\..\ManagerView1\AddRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SurfaceAreaBox;
        
        #line default
        #line hidden
        
        
        #line 194 "..\..\..\..\ManagerView1\AddRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BedNumberBox;
        
        #line default
        #line hidden
        
        
        #line 201 "..\..\..\..\ManagerView1\AddRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBox;
        
        #line default
        #line hidden
        
        
        #line 208 "..\..\..\..\ManagerView1\AddRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Submit;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Hospital-IS;component/managerview1/addroom.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ManagerView1\AddRoom.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Back = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.RoomNumberBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 174 "..\..\..\..\ManagerView1\AddRoom.xaml"
            this.RoomNumberBox.GotFocus += new System.Windows.RoutedEventHandler(this.RoomNumber_GotFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RoomFloorBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 181 "..\..\..\..\ManagerView1\AddRoom.xaml"
            this.RoomFloorBox.GotFocus += new System.Windows.RoutedEventHandler(this.RoomFloor_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SurfaceAreaBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 188 "..\..\..\..\ManagerView1\AddRoom.xaml"
            this.SurfaceAreaBox.GotFocus += new System.Windows.RoutedEventHandler(this.SurfaceArea_GotFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BedNumberBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 195 "..\..\..\..\ManagerView1\AddRoom.xaml"
            this.BedNumberBox.GotFocus += new System.Windows.RoutedEventHandler(this.BedNumber_GotFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.Submit = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

