using System.Windows;
using Pomodoro;
using Water;
using Warmup;
using Food;
using System.Windows.Media;

namespace EfficientWorkApp 
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Main.Content = pomodoroPage;
            pomodoroPage.StatusChanged += changeBackgroundColor;
            Window.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#BA4949"));
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
        public void changeBackgroundColor(bool workStatus)
        {
            if (workStatus) 
            {
                Window.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#BA4949"));
            }
            else
            {
                Window.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#38858A"));
            }
        }
    }
}

