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

namespace MVVMStepByStepLevel0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Customer obj = new Customer("Test", 2000, "Married");

            lblName.Content = obj.Name; // mapping code
            lblAmount.Content = obj.Amount; // mapping code

            if (obj.Married == "Married") // transformation code
            {
                chkMarried.IsChecked = true;
            }
            else
            {
                chkMarried.IsChecked = false;
            }
        }
    }

    public class Customer
    {
        public string Name;
        public double Amount;
        public string Married;

        public Customer(string name, double amount, string married)
        {
            Name = name;
            Amount = amount;
            Married = married;
        }
    }
}
