﻿#pragma checksum "..\..\PomodoroAndToDoPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1A6FC241C26B511B00AE31F1D17B2FF8430F356DC68A3599F332637501D1929A"
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
using efficient_work_app;


namespace efficient_work_app {
    
    
    /// <summary>
    /// PomodoroAndToDoPage
    /// </summary>
    public partial class PomodoroAndToDoPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\PomodoroAndToDoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal efficient_work_app.PomodoroAndToDoPage Page;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\PomodoroAndToDoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle bg_Rectangle;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\PomodoroAndToDoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnWork;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\PomodoroAndToDoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRest;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\PomodoroAndToDoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock timerDisplay;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\PomodoroAndToDoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStartPause;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\PomodoroAndToDoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox taskTextBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\PomodoroAndToDoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox taskListBox;
        
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
            System.Uri resourceLocater = new System.Uri("/efficient-work-app;component/pomodoroandtodopage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PomodoroAndToDoPage.xaml"
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
            this.Page = ((efficient_work_app.PomodoroAndToDoPage)(target));
            return;
            case 2:
            this.bg_Rectangle = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 3:
            this.btnWork = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\PomodoroAndToDoPage.xaml"
            this.btnWork.Click += new System.Windows.RoutedEventHandler(this.BtnWork_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnRest = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\PomodoroAndToDoPage.xaml"
            this.btnRest.Click += new System.Windows.RoutedEventHandler(this.BtnRest_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.timerDisplay = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.btnStartPause = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\PomodoroAndToDoPage.xaml"
            this.btnStartPause.Click += new System.Windows.RoutedEventHandler(this.BtnStartPause_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.taskTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 35 "..\..\PomodoroAndToDoPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddTask_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 36 "..\..\PomodoroAndToDoPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditTask_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 37 "..\..\PomodoroAndToDoPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteTask_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.taskListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 42 "..\..\PomodoroAndToDoPage.xaml"
            this.taskListBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.TaskListBox_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

