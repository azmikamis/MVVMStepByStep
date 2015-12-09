using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMStepByStepLevel4
{
    public class CustomerViewModel : INotifyPropertyChanged // Point 1
    {
        private ButtonCommand objCommand;
        private Customer obj = new Customer("Test", 2000, "Married");

        public CustomerViewModel()
        {
            objCommand = new ButtonCommand(Calculate); // Point 2
        }

        public ICommand btnClick // Point 3
        {
            get
            {
                return objCommand;
            }
        }

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

        public string TxtTax
        {
            get { return Convert.ToString(obj.Tax); }
            set { obj.Tax = Convert.ToDouble(value); }
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
            set 
            { 
                if (value)
                {
                    obj.Married = "Married";
                }
                else
                {
                    obj.Married = "Not Married";
                }
            }
        }

        public void Calculate()
        {
            obj.CalculateTax();
            if (PropertyChanged != null) // Point 2
            {
                PropertyChanged(this,new PropertyChangedEventArgs("TxtTax"));
            // Point 3
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
