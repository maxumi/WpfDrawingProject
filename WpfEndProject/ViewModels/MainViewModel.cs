using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Ink;
using System.Windows.Media;
using WpfEndProject.EventArgsCustom;

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
            ToolBar.ChangeColorButtonClicked += OnColorChangeButtonClicked;
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
            DrawingPad.InkCanvasStrokes.Clear();

        }
        private void OnColorChangeButtonClicked(object? sender, EventArgs EventSomething)
        {
            ColorEventArgs ColorEventArg = (ColorEventArgs)EventSomething;

            
            MessageBox.Show($"{ColorEventArg.Color}");

            if (ColorConverter.ConvertFromString(ColorEventArg.Color) is Color newColor)
            {
                // Update the MyDrawingAttributes color
                DrawingAttributes draw = new DrawingAttributes();
                draw.Color = newColor;
                DrawingPad.MyDrawingAttributes = draw;
            }
            
        }

    }
}
