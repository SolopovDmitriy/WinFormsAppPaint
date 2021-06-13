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
        Point topLeftPoint { get; 
            set; } //имя свойства пишется с большой буквы
   Point bottomRightPoint { get; set; }//имя свойства пишется с большой буквы
        void            draw(Graphics g); // имя метода пишется с большой буквы
 }
                 }// провести упорядочивание кода!!!
