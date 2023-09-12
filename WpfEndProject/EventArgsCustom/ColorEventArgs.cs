using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEndProject.EventArgsCustom
{
    internal class ColorEventArgs : EventArgs
    {
        public string? Color { get; set; }
        public ColorEventArgs(object color)
        {
            this.Color = (string)color;
        }
    }
}
