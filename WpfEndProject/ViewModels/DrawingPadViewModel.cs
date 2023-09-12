using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Ink;
using System.Windows.Media;

namespace WpfEndProject.ViewModels
{
    internal class DrawingPadViewModel : ViewModelBase
    {

        public DrawingPadViewModel()
        {
            _myDrawingAttributes = new() { Color = Colors.Red };
        }

        private DrawingAttributes _myDrawingAttributes;
        public DrawingAttributes MyDrawingAttributes
        {
            get { return _myDrawingAttributes; }
            set
            {
                if (_myDrawingAttributes != value)
                {
                    _myDrawingAttributes = value;
                    OnPropertyChanged(nameof(MyDrawingAttributes));
                }
            }
        }

        private StrokeCollection inkCanvasStrokes = new StrokeCollection();

        public StrokeCollection InkCanvasStrokes
        {
            get { return inkCanvasStrokes; }
            set
            {
                inkCanvasStrokes = value;
                OnPropertyChanged(nameof(InkCanvasStrokes));
            }
        }


        private string _type = "Ink";

        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }
    }
}
