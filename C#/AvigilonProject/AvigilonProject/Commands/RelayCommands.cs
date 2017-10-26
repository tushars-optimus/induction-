using System;
using System.Windows.Input;

namespace AvigilonProject.UI.Commands
{
    /// <summary>
    /// To bind button to different action
    /// </summary>
    public class RelayCommand:ICommand
    {
        Action<object> executeMethod1;
        Func<object, bool> canexecutemethod1;
        public RelayCommand(Action<object> executeMethod, Func<object, bool> canexecutemethod)
        {
            this.executeMethod1 = executeMethod;
            this.canexecutemethod1 = canexecutemethod;
        }
        public bool CanExecute(object parameter)
        {
            return canexecutemethod1(parameter);
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
