﻿#pragma checksum "..\..\..\..\Simulation\SetToINITstate.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FBAE29BA3D11F75103370F979F48CC10F8447FA7"
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
using WpfTopologyRenderer.Simulation;


namespace WpfTopologyRenderer.Simulation {
    
    
    /// <summary>
    /// SetToINITstate
    /// </summary>
    public partial class SetToINITstate : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\Simulation\SetToINITstate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stPanel;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Simulation\SetToINITstate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button tbSetToInitState;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Simulation\SetToINITstate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbSymbol;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfTopologyRenderer;component/simulation/settoinitstate.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Simulation\SetToINITstate.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\..\Simulation\SetToINITstate.xaml"
            ((WpfTopologyRenderer.Simulation.SetToINITstate)(target)).DataContextChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.UserControl_DataContextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.stPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.tbSetToInitState = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\..\Simulation\SetToINITstate.xaml"
            this.tbSetToInitState.Click += new System.Windows.RoutedEventHandler(this.SetToINITState_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbSymbol = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

