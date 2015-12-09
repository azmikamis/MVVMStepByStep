using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMStepByStepLevel1
{
    public class Customer
    {
        public string Name;
        public double Amount;
        public string Married;

        public Customer()
        {

        }

        public Customer(string name, int amount, string married)
        {
            Name = name;
            Amount = amount;
            Married = married;
        }
    }
}
