using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using pomodoro;
using water;
using warmup;
using food;

namespace EfficientWorkApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = pomodoroPage;
        }
        private readonly PomodoroAndToDoPage pomodoroPage = new PomodoroAndToDoPage();
        private readonly WaterPage waterPage = new WaterPage();
        private readonly WarmupPage warmupPage = new WarmupPage();
        private readonly FoodPage foodPage = new FoodPage();
        public void BtnClickPomodoroPage(object sender, RoutedEventArgs e)
        {
            Main.Content = pomodoroPage;
        }
        public void BtnClickWaterPage(object sender, RoutedEventArgs e)
        {
            Main.Content = waterPage;
        }
        public void BtnClickWarmupPage(object sender, RoutedEventArgs e)
        {
            Main.Content = warmupPage;
        }
        public void BtnClickFoodPage(object sender, RoutedEventArgs e)
        {
            Main.Content = foodPage;
        }
    }
}

