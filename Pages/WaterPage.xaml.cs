using System;
using System.Windows;
using System.Windows.Controls;

namespace water
{
    public partial class WaterPage : Page
    {
        private int totalWater = 0;
        public WaterPage()
        {
            InitializeComponent();
            DataContext = this;
        }

        public int WaterAmount
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

        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int amount = int.Parse(button.Tag.ToString());
            WaterAmount += amount;
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            WaterAmount = 0;
            waterDisplay.Text = WaterAmount.ToString();
        }

        private void CustomVolume_Click(object sender, RoutedEventArgs e)
        {
            customVolumeTextBox.Visibility = Visibility.Visible;
        }

        private void AddCustomVolume_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(customVolumeTextBox.Text, out int customVolume))
            {
                WaterAmount += customVolume;
            }
            waterDisplay.Text = WaterAmount.ToString();
            customVolumeTextBox.Visibility = Visibility.Collapsed;
            customVolumeTextBox.Text = "";
        }
    }
}
