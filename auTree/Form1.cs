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

        int shiftV = 50;
        int shiftH = 100;

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

        public Form1()
        {
            InitializeComponent();
            relative = new Label[127];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            centralPersonBuild(); //Помещаем персону из ячейки 1;1
            relationsBuild(); //Помещаем персоны из ячеек 1;j
        }

        void centralPersonBuild()
        {
            drawSelf();
        }

        void relationsBuild()
        {
            for (int j = 0; j < 9; j++)
            {
                if (genDist[0, j] == 1)
                {
                    ChildOrParent();
                }

                if ((genDist[0, j] == 1.7) || (genDist[0, j] == 1.5))
                {
                    drawFather();
                    drawGrandfather();
                }

                if (genDist[0, j] == 1.6)
                {
                    drawFather();
                    drawGrandfather();
                    drawUncle();
                }

                if (genDist[0, j] == 2.2)
                {
                    drawFather();
                    drawGrandfather();
                    drawGreatgrandfather();
                    drawGranduncle();
                }

                if (genDist[0, j] == 3.1)
                {
                    drawFather();
                    drawGrandfather();
                    drawGreatgrandfather();
                    drawGreatgreatgrandfather();
                    drawGreatgranduncle();
                    draw1stCousin2R();
                }

                if (genDist[0, j] == 3.6)
                {
                    drawFather();
                    drawGrandfather();
                    drawGreatgrandfather();
                    drawGreatgreatgrandfather();
                    drawGreatgranduncle();
                    draw1stCousin2R();
                    draw2ndCousin1R();
                    draw3rdCousin();
                }

                if (genDist[0, j] == 3.8)
                {
                    drawFather();
                    drawGrandfather();
                    drawGreatgrandfather();
                    drawGreatgreatgrandfather();
                    drawGreatgranduncle();
                    draw1stCousin2R();
                    draw2ndCousin1R();
                }

                if (genDist[0, j] == 6.4)
                {

                }
            }
        }

        void ChildOrParent()
        {
            drawFather();
        }

        //Поколение =1
        void drawChild()
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X, person.Location.Y + 25 + shiftV);
            relative[relativeNum].Name = "Child";
            relative[relativeNum].Size = new System.Drawing.Size(100, 50);
            relative[relativeNum].Text = "Child";
            relative[relativeNum].BackColor = Color.White;
            relative[relativeNum].Visible = true;
            this.Controls.Add(relative[relativeNum]);
        }

        //Поколение 0

        void drawSelf()
        {
            person = new Label();
            person.Location = new Point(450, 400);
            person.Name = "Self";
            person.Size = new System.Drawing.Size(100, 50);
            person.Text = "Self";
            person.BackColor = Color.White;
            person.Visible = true;
            this.Controls.Add(person);
        }

        void drawBrother()
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X + 25 + shiftH, person.Location.Y);
            relative[relativeNum].Name = "Brother";
            relative[relativeNum].Size = new System.Drawing.Size(100, 50);
            relative[relativeNum].Text = "Brother";
            relative[relativeNum].BackColor = Color.White;
            relative[relativeNum].Visible = true;
            this.Controls.Add(relative[relativeNum]);
        }

        void draw1stCousin()
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X - 25 - shiftH, person.Location.Y);
            relative[relativeNum].Name = "1stCousin";
            relative[relativeNum].Size = new System.Drawing.Size(100, 50);
            relative[relativeNum].Text = "1st Cousin";
            relative[relativeNum].BackColor = Color.White;
            relative[relativeNum].Visible = true;
            this.Controls.Add(relative[relativeNum]);
        }

        void draw2ndCousin()
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X + 2 * (25 + shiftH), person.Location.Y);
            relative[relativeNum].Name = "2ndCousin";
            relative[relativeNum].Size = new System.Drawing.Size(100, 50);
            relative[relativeNum].Text = "2nd Cousin";
            relative[relativeNum].BackColor = Color.White;
            relative[relativeNum].Visible = true;
            this.Controls.Add(relative[relativeNum]);
        }

        void draw3rdCousin()
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X - 2 * (25 + shiftH), person.Location.Y);
            relative[relativeNum].Name = "3rdCousin";
            relative[relativeNum].Size = new System.Drawing.Size(100, 50);
            relative[relativeNum].Text = "3rd Cousin";
            relative[relativeNum].BackColor = Color.White;
            relative[relativeNum].Visible = true;
            this.Controls.Add(relative[relativeNum]);
        }

        void draw4thCousin()
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X + 3 * (25 + shiftH), person.Location.Y);
            relative[relativeNum].Name = "4thCousin";
            relative[relativeNum].Size = new System.Drawing.Size(100, 50);
            relative[relativeNum].Text = "4th Cousin";
            relative[relativeNum].BackColor = Color.White;
            relative[relativeNum].Visible = true;
            this.Controls.Add(relative[relativeNum]);
        }

        //Поколение -1
        void drawFather()
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X, person.Location.Y - 25 - shiftV);
            relative[relativeNum].Name = "Father";
            relative[relativeNum].Size = new System.Drawing.Size(100, 50);
            relative[relativeNum].Text = "Father";
            relative[relativeNum].BackColor = Color.White;
            relative[relativeNum].Visible = true;
            this.Controls.Add(relative[relativeNum]);
        }

        void drawUncle()
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X - 25 - shiftH, person.Location.Y - 25 - shiftV);
            relative[relativeNum].Name = "Uncle";
            relative[relativeNum].Size = new System.Drawing.Size(100, 50);
            relative[relativeNum].Text = "Uncle";
            relative[relativeNum].BackColor = Color.White;
            relative[relativeNum].Visible = true;
            this.Controls.Add(relative[relativeNum]);
        }

        void draw1stCousin1R()
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X + 2 * (25 + shiftH), person.Location.Y - 25 - shiftV);
            relative[relativeNum].Name = "1stCousin1R";
            relative[relativeNum].Size = new System.Drawing.Size(100, 50);
            relative[relativeNum].Text = "1st Cousin 1R";
            relative[relativeNum].BackColor = Color.White;
            relative[relativeNum].Visible = true;
            this.Controls.Add(relative[relativeNum]);
        }

        void draw2ndCousin1R()
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X - 2 * (25 + shiftH), person.Location.Y - 25 - shiftV);
            relative[relativeNum].Name = "2ndCousin1R";
            relative[relativeNum].Size = new System.Drawing.Size(100, 50);
            relative[relativeNum].Text = "2nd Cousin 1R";
            relative[relativeNum].BackColor = Color.White;
            relative[relativeNum].Visible = true;
            this.Controls.Add(relative[relativeNum]);
        }

        void draw3rdCousin1R()
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X + 3 * (25 + shiftH), person.Location.Y - 25 - shiftV);
            relative[relativeNum].Name = "3rdCousin1R";
            relative[relativeNum].Size = new System.Drawing.Size(100, 50);
            relative[relativeNum].Text = "3rd Cousin 1R";
            relative[relativeNum].BackColor = Color.White;
            relative[relativeNum].Visible = true;
            this.Controls.Add(relative[relativeNum]);
        }

        //Поколение -2
        void drawGrandfather()
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X, person.Location.Y - 2 * (25 + shiftV));
            relative[relativeNum].Name = "Grandfather";
            relative[relativeNum].Size = new System.Drawing.Size(100, 50);
            relative[relativeNum].Text = "Grandfather";
            relative[relativeNum].BackColor = Color.White;
            relative[relativeNum].Visible = true;
            this.Controls.Add(relative[relativeNum]);
        }

        void drawGranduncle()
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X + 2 * (25 + shiftH), person.Location.Y - 2 * (25 + shiftV));
            relative[relativeNum].Name = "Granduncle";
            relative[relativeNum].Size = new System.Drawing.Size(100, 50);
            relative[relativeNum].Text = "Grand uncle";
            relative[relativeNum].BackColor = Color.White;
            relative[relativeNum].Visible = true;
            this.Controls.Add(relative[relativeNum]);
        }

        void draw1stCousin2R()
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X - 2 * (25 + shiftH), person.Location.Y - 2 * (25 + shiftV));
            relative[relativeNum].Name = "1stCousin2R";
            relative[relativeNum].Size = new System.Drawing.Size(100, 50);
            relative[relativeNum].Text = "1st Cousin 2R";
            relative[relativeNum].BackColor = Color.White;
            relative[relativeNum].Visible = true;
            this.Controls.Add(relative[relativeNum]);
        }

        void draw2ndCousin2R()
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X + 3 * (25 + shiftH), person.Location.Y - 2 * (25 + shiftV));
            relative[relativeNum].Name = "2ndCousin2R";
            relative[relativeNum].Size = new System.Drawing.Size(100, 50);
            relative[relativeNum].Text = "2nd Cousin 2R";
            relative[relativeNum].BackColor = Color.White;
            relative[relativeNum].Visible = true;
            this.Controls.Add(relative[relativeNum]);
        }

        //Поколение -3
        void drawGreatgrandfather()
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X, person.Location.Y - 3 * (25 + shiftV));
            relative[relativeNum].Name = "Greatgrandfather";
            relative[relativeNum].Size = new System.Drawing.Size(100, 50);
            relative[relativeNum].Text = "Great grandfather";
            relative[relativeNum].BackColor = Color.White;
            relative[relativeNum].Visible = true;
            this.Controls.Add(relative[relativeNum]);
        }

        void drawGreatgranduncle()
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X - 2 * (25 + shiftH), person.Location.Y - 3 * (25 + shiftV));
            relative[relativeNum].Name = "Greatgranduncle";
            relative[relativeNum].Size = new System.Drawing.Size(100, 50);
            relative[relativeNum].Text = "Great grand uncle";
            relative[relativeNum].BackColor = Color.White;
            relative[relativeNum].Visible = true;
            this.Controls.Add(relative[relativeNum]);
        }

        void draw1stCousin3R()
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X + 3 * (25 + shiftH), person.Location.Y - 3 * (25 + shiftV));
            relative[relativeNum].Name = "1stCousin3R";
            relative[relativeNum].Size = new System.Drawing.Size(100, 50);
            relative[relativeNum].Text = "1st Cousin 3R";
            relative[relativeNum].BackColor = Color.White;
            relative[relativeNum].Visible = true;
            this.Controls.Add(relative[relativeNum]);
        }

        //Поколение -4
        void drawGreatgreatgrandfather()
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X, person.Location.Y - 4 * (25 + shiftV));
            relative[relativeNum].Name = "Greatgreatgrandfather";
            relative[relativeNum].Size = new System.Drawing.Size(100, 50);
            relative[relativeNum].Text = "Great-great-grandfather";
            relative[relativeNum].BackColor = Color.White;
            relative[relativeNum].Visible = true;
            this.Controls.Add(relative[relativeNum]);
        }

        void drawGreatgreatgranduncle()
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X + 3 * (25 + shiftH), person.Location.Y - 4 * (25 + shiftV));
            relative[relativeNum].Name = "Greatgreatgranduncle";
            relative[relativeNum].Size = new System.Drawing.Size(100, 50);
            relative[relativeNum].Text = "Great-great-grand-uncle";
            relative[relativeNum].BackColor = Color.White;
            relative[relativeNum].Visible = true;
            this.Controls.Add(relative[relativeNum]);
        }

        //Поколение -5
        void drawGreatgreatgreatgrandfather()
        {
            relative[relativeNum] = new Label();
            relative[relativeNum].Location = new Point(person.Location.X, person.Location.Y - 5 * (25 + shiftV));
            relative[relativeNum].Name = "Greatgreatgreatgrandfather";
            relative[relativeNum].Size = new System.Drawing.Size(100, 50);
            relative[relativeNum].Text = "Great-great-great-grandfather";
            relative[relativeNum].BackColor = Color.White;
            relative[relativeNum].Visible = true;
            this.Controls.Add(relative[relativeNum]);
        }
    }
}
