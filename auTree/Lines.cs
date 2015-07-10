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
        void drawLineGGGGFtoGGGU()
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics Form1 = this.CreateGraphics();
            Form1.DrawLine(myPen, person.Location.X + 50, person.Location.Y - 5 * (25 + shiftW) + 50, person.Location.X + 5 * (25 + shiftH) + 50, person.Location.Y - 4 * (25 + shiftW));
        }

        void drawLineGGGFtoGGU()
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics Form1 = this.CreateGraphics();
            Form1.DrawLine(myPen, person.Location.X + 50, person.Location.Y - 4 * (25 + shiftW) + 50, person.Location.X + 4 * (25 + shiftH) + 50, person.Location.Y - 3 * (25 + shiftW));
        }

        void drawLineGGFtoGU()
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics Form1 = this.CreateGraphics();
            Form1.DrawLine(myPen, person.Location.X + 50, person.Location.Y - 3 * (25 + shiftW) + 50, person.Location.X + 3 * (25 + shiftH) + 50, person.Location.Y - 2 * (25 + shiftW));
        }

        void drawLineGFtoU()
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics Form1 = this.CreateGraphics();
            Form1.DrawLine(myPen, person.Location.X + 50, person.Location.Y - 2 * (25 + shiftW) + 50, person.Location.X + 2 * (25 + shiftH) + 50, person.Location.Y - 1 * (25 + shiftW));
        }

        void drawLineFtoB()
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics Form1 = this.CreateGraphics();
            Form1.DrawLine(myPen, person.Location.X + 50, person.Location.Y - 1 * (25 + shiftW) + 50, person.Location.X + 1 * (25 + shiftH) + 50, person.Location.Y - 0 * (25 + shiftW));
        }

        void drawLine(int x, int y)
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics Form1 = this.CreateGraphics();
            Form1.DrawLine(myPen, x + 50, y+50, x + 50, y + 75);
        }
    }
}
