﻿using System;
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

        //Поколение +1
        void drawChild(double kit)
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(personX, personY + (25 + shiftW));
            relative[relativeNum].Name = "Child";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "Child \n" + kit.ToString(); ;
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);

            FrontOrBack(kit);
        }

        //Поколение 0
        void drawSelf(double kit)
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(personX, personY);
            relative[relativeNum].Name = "Self";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "Self \n" + kitNumb[selfNum].ToString();
            relative[relativeNum].BackColor = Color.White;
            relative[relativeNum].Visible = true;
            this.Controls.Add(relative[relativeNum]);
        }

        void drawBrother(double kit)
        {
            drawLines(0, 0, "FtoB");

            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(personX + (25 + shiftH), personY);
            relative[relativeNum].Name = "Brother";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "Brother \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);

            FrontOrBack(kit);
        }

        void draw1stCousin(double kit)
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(personX + 2 * (25 + shiftH), personY);
            relative[relativeNum].Name = "1stCousin";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "1st Cousin \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);

            FrontOrBack(kit);
        }

        void draw2ndCousin(double kit)
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(personX + 3 * (25 + shiftH), personY);
            relative[relativeNum].Name = "2ndCousin";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "2nd Cousin \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);

            FrontOrBack(kit);
        }

        void draw3rdCousin(double kit)
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(personX + 4 * (25 + shiftH), personY);
            relative[relativeNum].Name = "3rdCousin";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "3rd Cousin \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);

            FrontOrBack(kit);
        }

        void draw4thCousin(double kit)
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(personX + 5 * (25 + shiftH), personY);
            relative[relativeNum].Name = "4thCousin";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "4th Cousin \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);

            FrontOrBack(kit);
        }

        //Поколение -1
        void drawFather(double kit)
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(personX, personY - (25 + shiftW));
            relative[relativeNum].Name = "Father";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "Father \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);

            drawLines(relative[relativeNum].Location.X, relative[relativeNum].Location.Y, "Line");

            FrontOrBack(kit);
        }

        void drawUncle(double kit)
        {
            drawLines(0, 0, "GFtoU");

            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(personX + 2 * (25 + shiftH), personY - (25 + shiftW));
            relative[relativeNum].Name = "Uncle";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "Uncle \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);

            drawLines(relative[relativeNum].Location.X, relative[relativeNum].Location.Y, "Line");

            FrontOrBack(kit);
        }

        void draw1stCousin1R(double kit)
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(personX + 3 * (25 + shiftH), personY - (25 + shiftW));
            relative[relativeNum].Name = "1stCousin1R";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "1st Cousin 1R \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);

            drawLines(relative[relativeNum].Location.X, relative[relativeNum].Location.Y, "Line");

            FrontOrBack(kit);
        }

        void draw2ndCousin1R(double kit)
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(personX + 4 * (25 + shiftH), personY - (25 + shiftW));
            relative[relativeNum].Name = "2ndCousin1R";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "2nd Cousin 1R \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);

            drawLines(relative[relativeNum].Location.X, relative[relativeNum].Location.Y, "Line");

            FrontOrBack(kit);
        }

        void draw3rdCousin1R(double kit)
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(personX + 5 * (25 + shiftH), personY - (25 + shiftW));
            relative[relativeNum].Name = "3rdCousin1R";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "3rd Cousin 1R \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);

            drawLines(relative[relativeNum].Location.X, relative[relativeNum].Location.Y, "Line");

            FrontOrBack(kit);
        }

        //Поколение -2
        void drawGrandfather(double kit)
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(personX, personY - 2 * (25 + shiftW));
            relative[relativeNum].Name = "Grandfather";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "Grandfather" + "\n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);

            drawLines(relative[relativeNum].Location.X, relative[relativeNum].Location.Y, "Line");

            FrontOrBack(kit);
        }

        void drawGranduncle(double kit)
        {
            drawLines(0, 0, "GGFtoGU");

            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(personX + 3 * (25 + shiftH), personY - 2 * (25 + shiftW));
            relative[relativeNum].Name = "Granduncle";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "Grand-uncle \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);

            drawLines(relative[relativeNum].Location.X, relative[relativeNum].Location.Y, "Line");

            FrontOrBack(kit);
        }

        void draw1stCousin2R(double kit)
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(personX + 4 * (25 + shiftH), personY - 2 * (25 + shiftW));
            relative[relativeNum].Name = "1stCousin2R";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "1st Cousin 2R \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);

            drawLines(relative[relativeNum].Location.X, relative[relativeNum].Location.Y, "Line");

            FrontOrBack(kit);
        }

        void draw2ndCousin2R(double kit)
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(personX + 5 * (25 + shiftH), personY - 2 * (25 + shiftW));
            relative[relativeNum].Name = "2ndCousin2R";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "2nd Cousin 2R \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);

            drawLines(relative[relativeNum].Location.X, relative[relativeNum].Location.Y, "Line");

            FrontOrBack(kit);
        }

        //Поколение -3
        void drawGreatgrandfather(double kit)
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(personX, personY - 3 * (25 + shiftW));
            relative[relativeNum].Name = "Greatgrandfather";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "Great-grandfather \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);

            drawLines(relative[relativeNum].Location.X, relative[relativeNum].Location.Y, "Line");

            FrontOrBack(kit);
        }

        void drawGreatgranduncle(double kit)
        {
            drawLines(0, 0, "GGGFtoGGU");

            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(personX + 4 * (25 + shiftH), personY - 3 * (25 + shiftW));
            relative[relativeNum].Name = "Greatgranduncle";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "Great-grand-uncle " + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);

            drawLines(relative[relativeNum].Location.X, relative[relativeNum].Location.Y, "Line");

            FrontOrBack(kit);
        }

        void draw1stCousin3R(double kit)
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(personX + 5 * (25 + shiftH), personY - 3 * (25 + shiftW));
            relative[relativeNum].Name = "1stCousin3R";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "1st Cousin 3R \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);

            drawLines(relative[relativeNum].Location.X, relative[relativeNum].Location.Y, "Line");

            FrontOrBack(kit);
        }

        //Поколение -4
        void drawGreatgreatgrandfather(double kit)
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(personX, personY - 4 * (25 + shiftW));
            relative[relativeNum].Name = "Greatgreatgrandfather";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "Great-great-grandfather \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);

            drawLines(relative[relativeNum].Location.X, relative[relativeNum].Location.Y, "Line");

            FrontOrBack(kit);
        }

        void drawGreatgreatgranduncle(double kit)
        {
            drawLines(0, 0, "GGGGFtoGGGU");

            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(personX + 5 * (25 + shiftH), personY - 4 * (25 + shiftW));
            relative[relativeNum].Name = "Greatgreatgranduncle";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "Great-great-grand-uncle \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);

            drawLines(relative[relativeNum].Location.X, relative[relativeNum].Location.Y, "Line");

            FrontOrBack(kit);
        }

        //Поколение -5
        void drawGreatgreatgreatgrandfather(double kit)
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(personX, personY - 5 * (25 + shiftW));
            relative[relativeNum].Name = "Greatgreatgreatgrandfather";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "Great-great-great-grandfather \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);

            drawLines(relative[relativeNum].Location.X, relative[relativeNum].Location.Y, "Line");

            FrontOrBack(kit);
        }

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
