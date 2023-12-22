using System;
using System.Windows;
using System.Windows.Controls;

namespace food
{
    public partial class FoodPage : Page
    {
        private int totalFood = 0;
        public FoodPage()
        {
            InitializeComponent();
            DataContext = this;
        }

        public int FoodAmount
        {
            get { return totalFood; }
            set
            {
                totalFood = value;
                if (totalFood > 2000)
                    totalFood = 2000;

                if (totalFood < 0)
                    totalFood = 0;
            }
        }

        private void AddFood_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int amount = int.Parse(button.Tag.ToString());
            FoodAmount += amount;
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            FoodAmount = 0;
            foodDisplay.Text = FoodAmount.ToString();
        }

        private void CustomQuantity_Click(object sender, RoutedEventArgs e)
        {
            customQuantityTextBox.Visibility = Visibility.Visible;
        }

        private void AddCustomQuantity_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(customQuantityTextBox.Text, out int customQuantity))
            {
                FoodAmount += customQuantity;
            }
            foodDisplay.Text = FoodAmount.ToString();
            customQuantityTextBox.Visibility = Visibility.Collapsed;
            customQuantityTextBox.Text = "";
        }
    }
}
