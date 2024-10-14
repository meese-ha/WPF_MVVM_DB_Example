using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_MVVM_DB_Example.ViewModels;

namespace WPF_MVVM_DB_Example.Commands
{
    public class Command : ICommand
    {
        private readonly MainViewModel mainviewmodel;

        public event EventHandler? CanExecuteChanged;
        Action<object> _execute;
        //Func<object, bool> _canexecuteMethod;


        public Command(Action<object> execute)
        {
            this._execute = execute;
        }
        
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _execute(parameter);

        }


    }
}
