﻿#pragma checksum "..\..\..\MainMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "541F5F5495F86F8EF96154F20470C52247880326"
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
using Tanks_game;


namespace Tanks_game {
    
    
    /// <summary>
    /// MainMenu
    /// </summary>
    public partial class MainMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 57 "..\..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MenuGrid;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid EnterNamePanel;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SettingsPanel;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider PlayerTankSpeedSlider;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider PlayerBulletSpeedSlider;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider EnemyTankSpeedSlider;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider EnemyBulletSpeedSlider;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider EnemySpawnTimeSlider;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Tanks_game;V1.0.0.0;component/mainmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainMenu.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MenuGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            
            #line 61 "..\..\..\MainMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.StartButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 62 "..\..\..\MainMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SettingsButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 63 "..\..\..\MainMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ExitButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.EnterNamePanel = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.TextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 79 "..\..\..\MainMenu.xaml"
            this.TextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 81 "..\..\..\MainMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EnterName_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SettingsPanel = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.PlayerTankSpeedSlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 10:
            this.PlayerBulletSpeedSlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 11:
            this.EnemyTankSpeedSlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 12:
            this.EnemyBulletSpeedSlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 13:
            this.EnemySpawnTimeSlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 14:
            
            #line 125 "..\..\..\MainMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ApplyButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

