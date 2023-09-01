using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfEndProject.Commands;

namespace WpfEndProject.ViewModels
{
    internal class ToolbarViewModel : ViewModelBase
    {
        public ICommand SelectCommand { get; }
        public ICommand DrawLineCommand { get; }

        public ToolbarViewModel()
        {
            SelectCommand = new RelayCommand(ExecuteSelectCommand);
            DrawLineCommand = new RelayCommand(ExecuteDrawLineCommand);

        }

        private void ExecuteSelectCommand()
        {
            // Implement logic for the Select button
        }

        private void ExecuteDrawLineCommand()
        {
            // Implement logic for the Draw Line button
        }
    }
}
