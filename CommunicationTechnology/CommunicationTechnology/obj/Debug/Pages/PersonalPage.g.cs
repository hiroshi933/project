﻿#pragma checksum "..\..\..\Pages\PersonalPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2149FB2CD2CC7573F6F2711469BCABC240C74FCE12C6DF3529C880200810C8F8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CommunicationTechnology.Pages;
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


namespace CommunicationTechnology.Pages {
    
    
    /// <summary>
    /// PersonalPage
    /// </summary>
    public partial class PersonalPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Pages\PersonalPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CostButton;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Pages\PersonalPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TariffButton;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Pages\PersonalPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ServicesButton;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Pages\PersonalPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SupportButton;
        
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
            System.Uri resourceLocater = new System.Uri("/CommunicationTechnology;component/pages/personalpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PersonalPage.xaml"
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
            this.CostButton = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\Pages\PersonalPage.xaml"
            this.CostButton.Click += new System.Windows.RoutedEventHandler(this.CostButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TariffButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Pages\PersonalPage.xaml"
            this.TariffButton.Click += new System.Windows.RoutedEventHandler(this.TariffButton_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ServicesButton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Pages\PersonalPage.xaml"
            this.ServicesButton.Click += new System.Windows.RoutedEventHandler(this.ServicesButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SupportButton = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Pages\PersonalPage.xaml"
            this.SupportButton.Click += new System.Windows.RoutedEventHandler(this.SupportButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

