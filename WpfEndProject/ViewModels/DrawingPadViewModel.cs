using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfEndProject.ViewModels
{
    internal class DrawingPadViewModel : ViewModelBase
    {
        public InkCanvas inkCanvas { get; set; }

        public DrawingPadViewModel()
        {
            inkCanvas = new InkCanvas();
        }

        private string _type = "Ink";

        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
                SetEditingModeFromType();
                OnPropertyChanged(nameof(Type));


            }
        }

        private void SetEditingModeFromType()
        {
            switch (_type)
            {
                case "Ink":
                    inkCanvas.EditingMode = InkCanvasEditingMode.Ink;
                    break;
                case "Select":
                    inkCanvas.EditingMode = InkCanvasEditingMode.Select;
                    break;
                case "EraseByStroke":
                    inkCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
                    break;
                case "EraseByPoint":
                    inkCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
                    break;
                case "GestureOnly":
                    inkCanvas.EditingMode = InkCanvasEditingMode.GestureOnly;
                    break;
                case "InkAndGesture":
                    inkCanvas.EditingMode = InkCanvasEditingMode.InkAndGesture;
                    break;
                case "ClearStroke":
                    //WIP
                    break;
                default:
                    // Handle unsupported input or set a default mode
                    break;
            }
        }


    }
}
