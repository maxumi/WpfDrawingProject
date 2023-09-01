using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfEndProject.Commands
{
    internal class RelayCommand : ICommand
    {
        private Action methodToExecute;
        private Func<bool> canExecuteEvaluator;

        public RelayCommand(Action methodToExecute, Func<bool> canExecute)
        {
            this.methodToExecute = methodToExecute;
            this.canExecuteEvaluator = canExecute;
        }

        public RelayCommand(Action methodToExecute)
        {
            this.methodToExecute = methodToExecute;
            this.canExecuteEvaluator = () => true;
        }

        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object? parameter) => canExecuteEvaluator?.Invoke() ?? true;

        public void Execute(object? parameter) => methodToExecute?.Invoke();
    }
}
