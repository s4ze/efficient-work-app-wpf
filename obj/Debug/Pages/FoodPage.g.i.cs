﻿#pragma checksum "..\..\..\Pages\FoodPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D3AA5A61D65F62C896CAB958C7504B5D803613B403E01F403740B6CA12AA32F1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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


namespace Food {
    
    
    /// <summary>
    /// FoodPage
    /// </summary>
    public partial class FoodPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\Pages\FoodPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Food.FoodPage Page;
        
        #line default
        #line hidden
        
        
        #line 6 "..\..\..\Pages\FoodPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle bg_Rectangle;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Pages\FoodPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock foodDisplay;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\FoodPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox customQuantityTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/efficient-work-app;component/pages/foodpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\FoodPage.xaml"
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
            this.Page = ((Food.FoodPage)(target));
            return;
            case 2:
            this.bg_Rectangle = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 3:
            this.foodDisplay = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            
            #line 17 "..\..\..\Pages\FoodPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.addFoodClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 18 "..\..\..\Pages\FoodPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.resetClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 19 "..\..\..\Pages\FoodPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.customQuantityClick);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 22 "..\..\..\Pages\FoodPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.addFoodClick);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 23 "..\..\..\Pages\FoodPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.addFoodClick);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 24 "..\..\..\Pages\FoodPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.addFoodClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.customQuantityTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 27 "..\..\..\Pages\FoodPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.addCustomQuantityClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

