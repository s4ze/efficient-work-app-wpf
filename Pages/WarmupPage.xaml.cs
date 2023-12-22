using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace warmup
{
    public partial class WarmupPage : Page
    {
        public WarmupPage()
        {
            InitializeComponent();
            DataContext = this;
        }
        private ObservableCollection<string> tasks;
    }
}
