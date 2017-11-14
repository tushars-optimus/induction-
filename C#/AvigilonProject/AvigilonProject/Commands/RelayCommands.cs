using System;
using System.Windows.Input;

namespace AvigilonProject.UI.Commands
{
    /// <summary>
    /// To bind button to different action
    /// </summary>
    public class RelayCommand : ICommand
    {
        Action<object> executeMethod1;
        Func<object, bool> canExecuteMethod1;
        public RelayCommand(Action<object> executeMethod, Func<object, bool> canExecuteMethod)
        {
            this.executeMethod1 = executeMethod;
            this.canExecuteMethod1 = canExecuteMethod;
        }
        public bool CanExecute(object parameter)
        {
            return canExecuteMethod1(parameter);
        }

        public event EventHandler CanExecuteChanged
    {
             add
            {
                CommandManager.RequerySuggested += value;

            }
            remove
            {
                CommandManager.RequerySuggested -= value;

            }
    }

        public void Execute(object parameter)
        {
            executeMethod1(parameter);
        }
    }
}
