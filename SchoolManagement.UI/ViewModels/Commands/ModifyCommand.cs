using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SchoolManagement.UI.ViewModels.Commands
{
    public class ModifyCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        Action _execute;

        public ModifyCommand(Action action)
        {
            _execute = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute.Invoke();
        }
    }
}
