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
