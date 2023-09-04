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
        private bool isDrawing = false;

        public ICommand DrawCommand { get; }
        public ICommand EraseCommand { get; }

        public ToolbarViewModel()
        {
            DrawCommand = new RelayCommand(ExecuteDrawCommand);
            EraseCommand = new RelayCommand(ExecuteEraseCommand);
        }

        // Bind this property to the InkCanvas's EditingMode property in XAML.
        public InkCanvasEditingMode CurrentEditingMode
        {
            get { return isDrawing ? InkCanvasEditingMode.Ink : InkCanvasEditingMode.EraseByStroke; }
        }

        private void ExecuteDrawCommand()
        {
            isDrawing = true;
            OnPropertyChanged(nameof(CurrentEditingMode)); // Notify that the editing mode has changed.
        }

        private void ExecuteEraseCommand()
        {
            isDrawing = false;
            OnPropertyChanged(nameof(CurrentEditingMode)); // Notify that the editing mode has changed.
        }
    }
}
