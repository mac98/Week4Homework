/// Chapter No. 3		Exercise No. 1
/// File Name: Program.cs
/// @author: Marcus Moore
/// Date:  September 19, 2021
///
/// Problem Statement: Given the monthly payment and principle amount due, calculate how much is paid to interest and
///                    how much is paid off the principle amount of a mortgage.
/// 
/// Overall Plan:
/// 1) Google the formula for calculating mortgages and find several that involve math outside the scope of an intro
///    to C# class. Opt instead to blindly guess.
/// 2) Create two doubles to hold the monthly and principle payments entered into the text boxes. Parse both entries
///    into doubles.
/// 3) Create two more doubles to hold the interest payement and amount to deduct from the principle amount.
/// 4) Calculate the amount paid to interest by multiplying 6.39% against the monthly amount and store it in interest payment.
/// 5) Calculate the amount paid off of the principle by subtracting the amount paid to interest from the monthly payment.
/// 6) Display these, as well as the remaining balance.

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

namespace Project1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double m_payment = double.Parse(MonthlyPayment.Text);
            double p_payment = double.Parse(PrincipleAmount.Text);

            double int_pay = Math.Round(m_payment * 0.0639d, 2);
            double prn_pay = m_payment - int_pay;

            MessageBox.Show("You paid $" + int_pay + " in interest and $" + prn_pay + " off your principle amount. Your remaining principle amount is $" + (p_payment - prn_pay) + ".");
        }
    }
}
