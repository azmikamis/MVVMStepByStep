using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMStepByStepLevel4
{
    public class ButtonCommand : ICommand
    {
        private Action WhattoExecute;
        public ButtonCommand(Action What) // Point 2
        {
            WhattoExecute = What;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public bool CanExecute(object parameter)
        {
            return true; // Point 3
        }
        public void Execute(object parameter)
        {
            WhattoExecute(); // Point 4
        }
        
    }
}
