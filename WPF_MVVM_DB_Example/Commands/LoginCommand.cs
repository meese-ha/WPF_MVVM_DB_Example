using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_MVVM_DB_Example.ViewModels;

namespace WPF_MVVM_DB_Example.Commands
{
    public class LoginCommand : ICommand
    {

        Action<object> _action;
        Func<object, bool> _func;

        public event EventHandler? CanExecuteChanged;

        public LoginCommand(Action<object> action, Func<object, bool> func)
        {
            this._action = action;
            this._func = func;
        }


        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _action(parameter);
        }


    }
}
