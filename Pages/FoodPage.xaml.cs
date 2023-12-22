using System.Windows;
using System.Windows.Controls;

namespace Food
{
    public partial class FoodPage : Page
    {
        private int totalFood = 0;
        public FoodPage()
        {
            InitializeComponent();
            DataContext = this;
        }

        public int foodAmount
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

        private void addFoodClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int amount = int.Parse(button.Tag.ToString());
            foodAmount += amount;
        }

        private void resetClick(object sender, RoutedEventArgs e)
        {
            foodAmount = 0;
            foodDisplay.Text = foodAmount.ToString();
        }

        private void customQuantityClick(object sender, RoutedEventArgs e)
        {
            customQuantityTextBox.Visibility = Visibility.Visible;
        }

        private void addCustomQuantityClick(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(customQuantityTextBox.Text, out int customQuantity))
            {
                foodAmount += customQuantity;
            }
            foodDisplay.Text = foodAmount.ToString();
            customQuantityTextBox.Visibility = Visibility.Collapsed;
            customQuantityTextBox.Text = "";
        }
    }
}
