using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfEndProject.Commands
{
    internal class TestRelayCommand : ICommand
    {
        private Action<object?> methodToExecute;
        private Func<object?, bool> canExecuteEvaluator;

        public TestRelayCommand(Action<object?> methodToExecute, Func<object?, bool> canExecute)
        {
            this.methodToExecute = methodToExecute;
            this.canExecuteEvaluator = canExecute;
        }

        public TestRelayCommand(Action<object?> methodToExecute)
        {
            this.methodToExecute = methodToExecute;
            this.canExecuteEvaluator = _ => true;
        }

        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object? parameter) => canExecuteEvaluator?.Invoke(parameter) ?? true;

        public void Execute(object? parameter) => methodToExecute?.Invoke(parameter);
    }
}
