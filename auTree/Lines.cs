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
        //Соединительные линии
        void drawLines(int x, int y, string selectLine)
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics Form1 = this.CreateGraphics();

            switch (selectLine)
            {
                case "GGGGFtoGGGU":
                    Form1.DrawLine(myPen, personX + 50, personY - 5 * (25 + shiftW) + 50, personX + 5 * (25 + shiftH) + 50, personY - 4 * (25 + shiftW));
                    break;

                case "GGGFtoGGU":
                    Form1.DrawLine(myPen, personX + 50, personY - 4 * (25 + shiftW) + 50, personX + 4 * (25 + shiftH) + 50, personY - 3 * (25 + shiftW));
                    break;

                case "GGFtoGU":
                    Form1.DrawLine(myPen, personX + 50, personY - 3 * (25 + shiftW) + 50, personX + 3 * (25 + shiftH) + 50, personY - 2 * (25 + shiftW));
                    break;

                case "GFtoU":
                    Form1.DrawLine(myPen, personX + 50, personY - 2 * (25 + shiftW) + 50, personX + 2 * (25 + shiftH) + 50, personY - 1 * (25 + shiftW));
                    break;

                case "FtoB":
                    Form1.DrawLine(myPen, personX + 50, personY - 1 * (25 + shiftW) + 50, personX + 1 * (25 + shiftH) + 50, personY - 0 * (25 + shiftW));
                    break;

                case "Line":
                    Form1.DrawLine(myPen, x + 50, y + 50, x + 50, y + 75);
                    break;
            }
        }
    }
}
