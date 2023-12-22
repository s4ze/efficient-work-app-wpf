using System.Windows;
using System.Windows.Controls;

namespace Water
{
    public partial class WaterPage : Page
    {
        private int totalWater = 0;
        public WaterPage()
        {
            InitializeComponent();
            DataContext = this;
        }

        public int waterAmount
        {
            get { return totalWater; }
            set
            {
                totalWater = value;
                if (totalWater > 2000)
                    totalWater = 2000;

                if (totalWater < 0)
                    totalWater = 0;
            }
        }

        private void addWaterClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int amount = int.Parse(button.Tag.ToString());
            waterAmount += amount;
        }

        private void resetClick(object sender, RoutedEventArgs e)
        {
            waterAmount = 0;
            waterDisplay.Text = waterAmount.ToString();
        }

        private void customVolumeClick(object sender, RoutedEventArgs e)
        {
            customVolumeTextBox.Visibility = Visibility.Visible;
        }

        private void addCustomVolumeClick(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(customVolumeTextBox.Text, out int customVolume))
            {
                waterAmount += customVolume;
            }
            waterDisplay.Text = waterAmount.ToString();
            customVolumeTextBox.Visibility = Visibility.Collapsed;
            customVolumeTextBox.Text = "";
        }
    }
}
