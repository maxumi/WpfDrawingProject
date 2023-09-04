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

        private ICommand _eraserCommand;
        public ICommand EraserCommand => _eraserCommand;

        private ICommand _drawCommand;
        public ICommand DrawCommand => _drawCommand;

        public ToolbarViewModel() 
        {
            _drawCommand = new RelayCommand(DrawClick);
            _eraserCommand = new RelayCommand(EraserClick);

        }

        private void DrawClick()
        {
            DrawButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        private void EraserClick()
        {
            EraserButtonClicked?.Invoke(this, EventArgs.Empty);
        }

    }
}
