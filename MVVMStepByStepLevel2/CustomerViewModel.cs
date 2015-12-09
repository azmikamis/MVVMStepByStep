using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMStepByStepLevel2
{
    public class CustomerViewModel
    {
        private Customer obj = new Customer("Test", 2000, "Married");

        public string TxtCustomerName
        {
            get { return obj.Name; }
            set { obj.Name = value; }
        }

        public string TxtAmount
        {
            get { return Convert.ToString(obj.Amount); }
            set { obj.Amount = Convert.ToDouble(value); }
        }

        public bool IsMarried
        {
            get
            {
                if (obj.Married == "Married")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }
}
