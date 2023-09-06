using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using WpfEndProject.Commands;



namespace WpfEndProject.ViewModels
{
    internal class ToolbarViewModel : ViewModelBase
    {
        public event EventHandler? EraserButtonClicked;
        public event EventHandler? DrawButtonClicked;
        public event EventHandler? RestartButtonClicked;


        private ICommand _eraserCommand;
        public ICommand EraserCommand => _eraserCommand;

        private ICommand _drawCommand;
        public ICommand DrawCommand => _drawCommand;

        private ICommand _RestartCommand;
        public ICommand RestartCommand => _RestartCommand;

        public ToolbarViewModel() 
        {
            _drawCommand = new RelayCommand(() => DrawButtonClicked?.Invoke(this, EventArgs.Empty));
            _eraserCommand = new RelayCommand(() => EraserButtonClicked?.Invoke(this, EventArgs.Empty));
            _RestartCommand = new RelayCommand(() => RestartButtonClicked?.Invoke(this, EventArgs.Empty));

        }

    }
}
