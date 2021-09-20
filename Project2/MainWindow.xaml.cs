/// Chapter No. 3		Exercise No. 2
/// File Name: Program.cs
/// @author: Marcus Moore
/// Date:  September 19, 2021
///
/// Problem Statement: Prompt the user for a price between 25 and 100 cents, given in intervals of 5, and display the
///                    change in coins the user would recieve after paying a dollar.
/// 
/// Overall Plan:
/// 1) Create an int to store the user's entered price.
/// 2) Check that the price is within 25 and 100 cents. If it is not, set it to the minimum or maximum as appropriate.
/// 3) Check if the price is an interval of 5 using the mod command.
/// 4) If the price is not an interval of 5, round it to the nearest one.
/// 5) Create three ints: one for quarters, one for dimes, and one for nickels.
/// 6) Subtract the price from 100 and store the difference in an integer called change.
/// 7) Divide change by 25 and store it in quarters.
/// 8) Subtract the amount of cents in quarters from the total change and store this back in change.
/// 9) Repeat twice more with dimes and nickels. The final change should always be 0.
/// 10) Display a message box explaing how much of each coin was paid out.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalcChange_Click(object sender, RoutedEventArgs e)
        {
            int price = int.Parse(PriceBox.Text);

            if (price < 25)
                price = 25;
            else if (price > 100)
                price = 100;
            else if (price % 5 != 0)
            {
                if (price % 5 > 2)
                {
                    price += 5 - (price % 5);
                }
                else
                {
                    price -= (price % 5);
                }
            }

            int change = 100 - price;
            int quarters, dimes, nickels;
            quarters = change / 25;
            change -= quarters * 25;
            dimes = change / 10;
            change -= dimes * 10;
            nickels = change / 5;
            change -= nickels * 5;
            if (change > 0)
            {
                MessageBox.Show("Error: Amount initially given not in an interval of 5!");
            }
            else
            {
                MessageBox.Show("The item cost " + price + " cents, meaning you will recieve " + quarters + " quarter(s), " + dimes + " dime(s), and " + nickels + " nickel(s).");
            }
        }
    }
}
