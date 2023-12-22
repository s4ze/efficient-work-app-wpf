using System.Windows;
using Pomodoro;
using Water;
using Warmup;
using Food;

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
        public void btnClickPomodoroPage(object sender, RoutedEventArgs e)
        {
            Main.Content = pomodoroPage;
        }
        public void btnClickWaterPage(object sender, RoutedEventArgs e)
        {
            Main.Content = waterPage;
        }
        public void btnClickWarmupPage(object sender, RoutedEventArgs e)
        {
            Main.Content = warmupPage;
        }
        public void btnClickFoodPage(object sender, RoutedEventArgs e)
        {
            Main.Content = foodPage;
        }
    }
}

