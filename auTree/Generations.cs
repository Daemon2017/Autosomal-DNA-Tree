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
        int relativeNum = 0;
        int selfNum = 0;

        int shiftW = 50, shiftH = 100;
        int containerWidth = 100, containerHeight = 50;
        int personX = 12, personY = 500;

        public Label[] relative;

        //Отрисовка персоны
        void drawGen(double kit, string selectGen)
        {
            relative[relativeNum] = new Label();

            switch (selectGen)
            {
                case "Child":
                    SummOfLinesCalc();
                    relative[relativeNum].Location = new Point(personX, personY + 1 * (25 + shiftW));
                    break;

                case "Self":
                    relative[relativeNum].Location = new Point(personX, personY);
                    break;

                case "Brother":
                    SummOfLinesCalc();
                    drawLines(0, 0, "FtoB");
                    relative[relativeNum].Location = new Point(personX + SummOfLines * (25 + shiftH), personY);
                    break;

                case "1stCousin":
                    SummOfLinesCalc();
                    relative[relativeNum].Location = new Point(personX + SummOfLines * (25 + shiftH), personY);
                    break;

                case "2ndCousin":
                    SummOfLinesCalc();
                    relative[relativeNum].Location = new Point(personX + SummOfLines * (25 + shiftH), personY);
                    break;

                case "3rdCousin":
                    SummOfLinesCalc();
                    relative[relativeNum].Location = new Point(personX + SummOfLines * (25 + shiftH), personY);
                    break;

                case "4thCousin":
                    SummOfLinesCalc();
                    relative[relativeNum].Location = new Point(personX + SummOfLines * (25 + shiftH), personY);
                    break;

                case "Father":
                    relative[relativeNum].Location = new Point(personX, personY - 1 * (25 + shiftW));
                    break;

                case "Uncle":
                    SummOfLinesCalc();
                    drawLines(0, 0, "GFtoU");
                    relative[relativeNum].Location = new Point(personX + SummOfLines * (25 + shiftH), personY - 1 * (25 + shiftW));
                    break;

                case "1stCousin1R":
                    SummOfLinesCalc();
                    relative[relativeNum].Location = new Point(personX + SummOfLines * (25 + shiftH), personY - 1 * (25 + shiftW));
                    break;

                case "2ndCousin1R":
                    SummOfLinesCalc();
                    relative[relativeNum].Location = new Point(personX + SummOfLines * (25 + shiftH), personY - 1 * (25 + shiftW));
                    break;

                case "3rdCousin1R":
                    SummOfLinesCalc();
                    relative[relativeNum].Location = new Point(personX + SummOfLines * (25 + shiftH), personY - 1 * (25 + shiftW));
                    break;

                case "Grandfather":
                    relative[relativeNum].Location = new Point(personX, personY - 2 * (25 + shiftW));
                    break;

                case "Granduncle":
                    SummOfLinesCalc();
                    drawLines(0, 0, "GGFtoGU");
                    relative[relativeNum].Location = new Point(personX + SummOfLines * (25 + shiftH), personY - 2 * (25 + shiftW));
                    break;

                case "1stCousin2R":
                    SummOfLinesCalc();
                    relative[relativeNum].Location = new Point(personX + SummOfLines * (25 + shiftH), personY - 2 * (25 + shiftW));
                    break;

                case "2ndCousin2R":
                    SummOfLinesCalc();
                    relative[relativeNum].Location = new Point(personX + SummOfLines * (25 + shiftH), personY - 2 * (25 + shiftW));
                    break;

                case "Greatgrandfather":
                    relative[relativeNum].Location = new Point(personX, personY - 3 * (25 + shiftW));
                    break;

                case "Greatgranduncle":
                    SummOfLinesCalc();
                    drawLines(0, 0, "GGGFtoGGU");
                    relative[relativeNum].Location = new Point(personX + SummOfLines * (25 + shiftH), personY - 3 * (25 + shiftW));
                    break;

                case "1stCousin3R":
                    SummOfLinesCalc();
                    relative[relativeNum].Location = new Point(personX + SummOfLines * (25 + shiftH), personY - 3 * (25 + shiftW));
                    break;

                case "Greatgreatgrandfather":
                    relative[relativeNum].Location = new Point(personX, personY - 4 * (25 + shiftW));
                    break;

                case "Greatgreatgranduncle":
                    SummOfLinesCalc();
                    drawLines(0, 0, "GGGGFtoGGGU");
                    relative[relativeNum].Location = new Point(personX + SummOfLines * (25 + shiftH), personY - 4 * (25 + shiftW));
                    break;

                case "Greatgreatgreatgrandfather":
                    relative[relativeNum].Location = new Point(personX, personY - 5 * (25 + shiftW));
                    break;
            }

            relative[relativeNum].Name = selectGen;
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = selectGen + "\n" + kit.ToString(); ;
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);

            drawLines(relative[relativeNum].Location.X, relative[relativeNum].Location.Y, "Line");

            //Помещать ячейку с персоной на передний или задний план
            FrontOrBack(kit);
        }

        //Помещать ячейку с персоной на передний или задний план
        void FrontOrBack(double kit)
        {
            if (kit != 0)
            {
                relative[relativeNum].BringToFront();
            }
            else
            {
                relative[relativeNum].SendToBack();
            }
        }
    }
}
