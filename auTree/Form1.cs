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
    public partial class Form1 : Form
    {
        public Label person;

        public Label[] relative;
        int relativeNum = 0;

        int shiftW = 50;
        int shiftH = 100;

        int containerWidth = 100;
        int containerHeight = 50;

        double[,] genDist = 
        {
            {0,   1,   1.7, 1.6, 2.2, 3.1, 3.6, 3.8, 6.4},
            {1,   0,   1,   1.2, 1.6, 2.6, 3.2, 3.5, 5.8},
            {1.7, 1,   0,   1,   1.2, 2,   2.8, 2.4, 3.7},
            {1.6, 1.2, 1,   0,   1.6, 2.7, 3.4, 3,   6.2},
            {2.2, 1.6, 1.2, 1.6, 0,   1.9, 2.9, 2.5, 3.6},
            {3.1, 2.6, 2,   2.7, 1.9, 0,   1.5, 2.4, 3.9},
            {3.6, 3.2, 2.8, 3.4, 2.9, 1.5, 0,   3.3, 4.3},
            {3.8, 3.5, 2.4, 3,   2.5, 2.4, 3.3, 0,   4},
            {6.4, 5.8, 3.7, 6.2, 3.6, 3.9, 4.3, 4,   0}
        };

        double[] kitNumb = 
        {
            236530,
            253745,
            257060,
            236539,
            213524,
            261987,
            261985,
            260621,
            222811
        };

        public Form1()
        {
            InitializeComponent();
            relative = new Label[127];
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            centralPersonBuild(); //Помещаем персону из ячейки 1;1
            relationsBuild(); //Помещаем персоны из ячеек 1;j
        }

        void centralPersonBuild()
        {
            drawSelf(kitNumb[0]);
        }

        void relationsBuild()
        {
            for (int j = 0; j < genDist.GetLength(0); j++)
            {
                if (genDist[0, j] == 1)//Или отец, или сын
                {
                    ChildOrParent(j);
                }

                if ((genDist[0, j] == 1.7) || (genDist[0, j] == 1.5))//Дед
                {
                    drawFather(0);
                    drawGrandfather(kitNumb[j]);
                }

                if (genDist[0, j] == 1.6)//Дядя
                {
                    drawFather(0);
                    drawGrandfather(0);
                    drawUncle(kitNumb[j]);
                }

                if (genDist[0, j] == 2.2)//Брат деда
                {
                    drawFather(0);
                    drawGrandfather(0);
                    drawGreatgrandfather(0);
                    drawGranduncle(kitNumb[j]);
                }

                if (genDist[0, j] == 3.1)
                {
                    drawFather(0);
                    drawGrandfather(0);
                    drawGreatgrandfather(0);
                    drawGreatgreatgrandfather(0);
                    drawGreatgranduncle(0);
                    draw1stCousin2R(kitNumb[j]);
                }

                if (genDist[0, j] == 3.6)//Четырехъюродный брат
                {
                    drawFather(0);
                    drawGrandfather(0);
                    drawGreatgrandfather(0);
                    drawGreatgreatgrandfather(0);
                    drawGreatgranduncle(0);
                    draw1stCousin2R(0);
                    draw2ndCousin1R(0);
                    draw3rdCousin(kitNumb[j]);
                }

                if (genDist[0, j] == 3.8)
                {
                    drawFather(0);
                    drawGrandfather(0);
                    drawGreatgrandfather(0);
                    drawGreatgreatgrandfather(0);
                    drawGreatgranduncle(0);
                    draw1stCousin2R(0);
                    draw2ndCousin1R(kitNumb[j]);
                }

                if (genDist[0, j] == 6.4)
                {

                }
            }
        }

        //Неоднозначности
        void ChildOrParent(int j)
        {
            double father = 0;
            double halfTotal = genDist.GetLength(0) / 2;

            for (int i = 0; i < genDist.GetLength(0); i++)
            {

                double compare = genDist[0, i] - genDist[j, i];

                if (compare > 0)
                {
                    father++;
                }
            }

            if (father > halfTotal)
            {
                drawFather(kitNumb[j]);
            }
            else
            {
                drawChild(kitNumb[j]);
            }

        }

        //Поколение =1
        void drawChild(double kit)
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X, person.Location.Y + 25 + shiftW);
            relative[relativeNum].Name = "Child";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "Child \n" + kit.ToString(); ;
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);
        }

        //Поколение 0
        void drawSelf(double kit)
        {
            person = new Label();
            person.Location = new Point(550, 500);
            person.Name = "Self";
            person.Size = new System.Drawing.Size(containerWidth, containerHeight);
            person.Text = "Self \n" + kit.ToString();
            person.BackColor = Color.White;
            person.Visible = true;
            this.Controls.Add(person);
        }

        void drawBrother(double kit)
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X + 25 + shiftH, person.Location.Y);
            relative[relativeNum].Name = "Brother";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "Brother \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);
        }

        void draw1stCousin(double kit)
        {
            drawLineDown(-1, 0);

            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X - 25 - shiftH, person.Location.Y);
            relative[relativeNum].Name = "1stCousin";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "1st Cousin \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);
        }

        void draw2ndCousin(double kit)
        {
            drawLineDown(2, 0);

            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X + 2 * (25 + shiftH), person.Location.Y);
            relative[relativeNum].Name = "2ndCousin";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "2nd Cousin \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);
        }

        void draw3rdCousin(double kit)
        {
            drawLineDown(-2, 0);

            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X - 2 * (25 + shiftH), person.Location.Y);
            relative[relativeNum].Name = "3rdCousin";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "3rd Cousin \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);
        }

        void draw4thCousin(double kit)
        {
            drawLineDown(3, 0);

            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X + 3 * (25 + shiftH), person.Location.Y);
            relative[relativeNum].Name = "4thCousin";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "4th Cousin \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);
        }

        //Поколение -1
        void drawFather(double kit)
        {
            drawLineUp(0, -1);

            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X, person.Location.Y - 25 - shiftW);
            relative[relativeNum].Name = "Father";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "Father \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);
        }

        void drawUncle(double kit)
        {
            drawLineGFtoU();

            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X - 25 - shiftH, person.Location.Y - 25 - shiftW);
            relative[relativeNum].Name = "Uncle";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "Uncle \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);
        }

        void draw1stCousin1R(double kit)
        {
            drawLineDown(2, -1);

            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X + 2 * (25 + shiftH), person.Location.Y - 25 - shiftW);
            relative[relativeNum].Name = "1stCousin1R";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "1st Cousin 1R \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);
        }

        void draw2ndCousin1R(double kit)
        {
            drawLineDown(-2, -1);

            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X - 2 * (25 + shiftH), person.Location.Y - 25 - shiftW);
            relative[relativeNum].Name = "2ndCousin1R";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "2nd Cousin 1R \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);
        }

        void draw3rdCousin1R(double kit)
        {
            drawLineDown(3, -1);

            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X + 3 * (25 + shiftH), person.Location.Y - 25 - shiftW);
            relative[relativeNum].Name = "3rdCousin1R";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "3rd Cousin 1R \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);
        }

        //Поколение -2
        void drawGrandfather(double kit)
        {
            drawLineUp(0, -2);

            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X, person.Location.Y - 2 * (25 + shiftW));
            relative[relativeNum].Name = "Grandfather";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "Grandfather \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);
        }

        void drawGranduncle(double kit)
        {
            drawLineGGFtoGU();

            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X + 2 * (25 + shiftH), person.Location.Y - 2 * (25 + shiftW));
            relative[relativeNum].Name = "Granduncle";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "Grand uncle \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);
        }

        void draw1stCousin2R(double kit)
        {
            drawLineDown(-2, -2);

            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X - 2 * (25 + shiftH), person.Location.Y - 2 * (25 + shiftW));
            relative[relativeNum].Name = "1stCousin2R";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "1st Cousin 2R \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);
        }

        void draw2ndCousin2R(double kit)
        {
            drawLineDown(3, -2);

            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X + 3 * (25 + shiftH), person.Location.Y - 2 * (25 + shiftW));
            relative[relativeNum].Name = "2ndCousin2R";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "2nd Cousin 2R \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);
        }

        //Поколение -3
        void drawGreatgrandfather(double kit)
        {
            drawLineUp(0, -3);

            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X, person.Location.Y - 3 * (25 + shiftW));
            relative[relativeNum].Name = "Greatgrandfather";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "Great grandfather \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);
        }

        void drawGreatgranduncle(double kit)
        {
            drawLineGGGFtoGGU();

            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X - 2 * (25 + shiftH), person.Location.Y - 3 * (25 + shiftW));
            relative[relativeNum].Name = "Greatgranduncle";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "Great grand uncle " + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);
        }

        void draw1stCousin3R(double kit)
        {
            drawLineDown(3, -3);

            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X + 3 * (25 + shiftH), person.Location.Y - 3 * (25 + shiftW));
            relative[relativeNum].Name = "1stCousin3R";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "1st Cousin 3R \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);
        }

        //Поколение -4
        void drawGreatgreatgrandfather(double kit)
        {
            drawLineUp(0, -4);

            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X, person.Location.Y - 4 * (25 + shiftW));
            relative[relativeNum].Name = "Greatgreatgrandfather";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "Great-great-grandfather \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);
        }

        void drawGreatgreatgranduncle(double kit)
        {
            drawLineDown(3, -4);

            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X + 3 * (25 + shiftH), person.Location.Y - 4 * (25 + shiftW));
            relative[relativeNum].Name = "Greatgreatgranduncle";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "Great-great-grand-uncle \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);
        }

        //Поколение -5
        void drawGreatgreatgreatgrandfather(double kit)
        {
            drawLineUp(0, -5);

            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X, person.Location.Y - 5 * (25 + shiftW));
            relative[relativeNum].Name = "Greatgreatgreatgrandfather";
            relative[relativeNum].Size = new System.Drawing.Size(containerWidth, containerHeight);
            relative[relativeNum].Text = "Great-great-great-grandfather \n" + kit.ToString();
            relative[relativeNum].BackColor = Color.White;
            this.Controls.Add(relative[relativeNum]);
        }

        //Соединительные линии
        void drawLineGGGGFtoGGGU()
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics Form1 = this.CreateGraphics();
            Form1.DrawLine(myPen, person.Location.X + 50, person.Location.Y - 5 * (25 + shiftW) + 50, person.Location.X + 3 * (25 + shiftH) + 50, person.Location.Y - 4 * (25 + shiftW));
        }

        void drawLineGGGFtoGGU()
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics Form1 = this.CreateGraphics();
            Form1.DrawLine(myPen, person.Location.X + 50, person.Location.Y - 4 * (25 + shiftW) + 50, person.Location.X - 2 * (25 + shiftH) + 50, person.Location.Y - 3 * (25 + shiftW));
        }

        void drawLineGGFtoGU()
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics Form1 = this.CreateGraphics();
            Form1.DrawLine(myPen, person.Location.X + 50, person.Location.Y - 3 * (25 + shiftW) + 50, person.Location.X + 2 * (25 + shiftH) + 50, person.Location.Y - 2 * (25 + shiftW));
        }

        void drawLineGFtoU()
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics Form1 = this.CreateGraphics();
            Form1.DrawLine(myPen, person.Location.X + 50, person.Location.Y - 2 * (25 + shiftW) + 50, person.Location.X - 1 * (25 + shiftH) + 50, person.Location.Y - 1 * (25 + shiftW));
        }

        void drawLineFtoB()
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics Form1 = this.CreateGraphics();
            Form1.DrawLine(myPen, person.Location.X + 50, person.Location.Y - 1 * (25 + shiftW) + 50, person.Location.X + 1 * (25 + shiftH) + 50, person.Location.Y - 0 * (25 + shiftW));
        }

        void drawLineUp(int x, int y)
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics Form1 = this.CreateGraphics();
            Form1.DrawLine(myPen, person.Location.X + 50 + x * (25 + shiftH), person.Location.Y + y * (25 + shiftW), person.Location.X + 50 + x * (25 + shiftH), person.Location.Y + (y + 1) * (25 + shiftW));
        }

        void drawLineDown(int x, int y)
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics Form1 = this.CreateGraphics();
            Form1.DrawLine(myPen, person.Location.X + 50 + x * (25 + shiftH), person.Location.Y + y * (25 + shiftW), person.Location.X + 50 + x * (25 + shiftH), person.Location.Y + (y - 1) * (25 + shiftW));
        }
    }
}
