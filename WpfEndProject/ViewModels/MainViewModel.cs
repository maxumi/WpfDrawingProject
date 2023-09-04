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
        private Brush _backgroundColor = Brushes.White; // Initial background color

        public Brush BackgroundColor
        {
            get => _backgroundColor;
            set
            {
                _backgroundColor = value;
                OnPropertyChanged(nameof(BackgroundColor));
            }
        }

        public ToolbarViewModel ToolBar { get; } = new ToolbarViewModel();
        public DrawingPadViewModel DrawingPad { get; } = new DrawingPadViewModel();

        public MainViewModel()
        {
            ToolBar.DrawButtonClicked += OnDrawButtonClicked;
            ToolBar.EraserButtonClicked += OnEraserButtonClicked;
        }
        private void OnEraserButtonClicked(object? sender, EventArgs e)
        {
            BackgroundColor = Brushes.Blue;
            // Handle the Eraser button click here
            // For example, change some properties related to erasing
        }

        private void OnDrawButtonClicked(object? sender, EventArgs e)
        {
            BackgroundColor = Brushes.Red;
            // Handle the Draw button click here
            // For example, change some properties related to drawing
        }


    }
}
