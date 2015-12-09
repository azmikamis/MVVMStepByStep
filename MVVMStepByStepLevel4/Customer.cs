using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMStepByStepLevel4
{
    public class Customer
    {
        public string Name;
        public double Amount;
        public string Married;
        public double Tax;

        public Customer()
        {

        }

        public Customer(string name, int amount, string married)
        {
            Name = name;
            Amount = amount;
            Married = married;
        }

        public void CalculateTax()
        {
            if (Amount > 2000)
            {
                Tax = 20;
            }
            else if (Amount > 1000)
            {
                Tax = 10;
            }
            else
            {
                Tax = 5;
            }
        }
    }
}
