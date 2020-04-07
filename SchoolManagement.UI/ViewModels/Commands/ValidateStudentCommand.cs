using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.UI.ViewModels.Commands
{
    class ValidateStudentCommand
    {
        public event EventHandler CanExecuteChanged;

        Action<Student> _execute;

        public ValidateStudentCommand(Action<Student> action)
        {
            _execute = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter as Student);
        }
    }
}
