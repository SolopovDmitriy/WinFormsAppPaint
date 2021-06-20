using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppPaint.Figures
{
    public interface IFigure
    {
        public Color Color { get; set; }

        Point StartPoint { get; set; } //имя свойства пишется с большой буквы

        Point EndPoint { get; set; }//имя свойства пишется с большой буквы

        public int Thickness { get; set; }

        void Draw(Graphics g); // имя метода пишется с большой буквы

    }
}// провести упорядочивание кода!!!
