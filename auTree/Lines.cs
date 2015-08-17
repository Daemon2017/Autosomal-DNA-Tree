using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auTree
{
    public partial class Form1
    {
        //Отрисовка соединительных линий
        void drawLines(int x, int y, string selectLine)
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics Form1 = this.CreateGraphics();

            switch (selectLine)
            {
                //Линия от прапрапрадеда к двоюродному прапрадеду
                case "GGGGFtoGGGU":
                    Form1.DrawLine(myPen, personX + 50, personY - 5 * (25 + shiftW) + 50, personX + 5 * (25 + shiftH) + 50, personY - 4 * (25 + shiftW));
                    break;

                //Линия от прапрадеда к двоюродному прадеду
                case "GGGFtoGGU":
                    Form1.DrawLine(myPen, personX + 50, personY - 4 * (25 + shiftW) + 50, personX + 4 * (25 + shiftH) + 50, personY - 3 * (25 + shiftW));
                    break;

                //Линия от прадеда к двоюродному деду
                case "GGFtoGU":
                    Form1.DrawLine(myPen, personX + 50, personY - 3 * (25 + shiftW) + 50, personX + 3 * (25 + shiftH) + 50, personY - 2 * (25 + shiftW));
                    break;

                //Линия от деда к дяде
                case "GFtoU":
                    Form1.DrawLine(myPen, personX + 50, personY - 2 * (25 + shiftW) + 50, personX + 2 * (25 + shiftH) + 50, personY - 1 * (25 + shiftW));
                    break;

                //Линия от отца к брату
                case "FtoB":
                    Form1.DrawLine(myPen, personX + 50, personY - 1 * (25 + shiftW) + 50, personX + 1 * (25 + shiftH) + 50, personY - 0 * (25 + shiftW));
                    break;

                //Линия от персоны вниз
                case "Line":
                    Form1.DrawLine(myPen, x + 50, y + 50, x + 50, y + 75);
                    break;
            }
        }
    }
}
