using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfEndProject.ViewModels
{
    internal class MainViewModel : ViewModelBase
    {

        public ToolbarViewModel ToolBar { get; } = new ToolbarViewModel();
        public DrawingPadViewModel DrawingPad { get; set; } = new DrawingPadViewModel();

        public MainViewModel()
        {
            ToolBar.DrawButtonClicked += OnDrawButtonClicked;
            ToolBar.EraserButtonClicked += OnEraserButtonClicked;
            ToolBar.RestartButtonClicked += OnRestartButtonClicked;
        }
        private void OnDrawButtonClicked(object? sender, EventArgs e)
        {
            DrawingPad.Type = "Ink";
        }
        private void OnEraserButtonClicked(object? sender, EventArgs e)
        {
            DrawingPad.Type = "EraseByPoint";
        }
        private void OnRestartButtonClicked(object? sender, EventArgs e)
        {
            //Clear drawing pad 
            DrawingPad.Type = "ClearStroke";
        }


    }
}
