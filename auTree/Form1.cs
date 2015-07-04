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
        public Label[] mainPerson;
        public Label[] secondaryPerson;
        int alone;
        double compare;
        double total = 9, halfTotal = 4.5, now, opinion;

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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainPersonBuild();
            secondaryPersonBuild();
        }

        void mainPersonBuild()
        {
            mainPerson = new Label[1];
            mainPerson[alone] = new Label();
            mainPerson[alone].Location = new Point(500, 250);
            mainPerson[alone].Name = "mainPerson";
            mainPerson[alone].Size = new System.Drawing.Size(50, 13);
            mainPerson[alone].Text = "Персона";
            mainPerson[alone].BackColor = Color.White;
            mainPerson[alone].Visible = true;
            this.Controls.Add(mainPerson[alone]);
        }

        void secondaryPersonBuild()
        {
            for (int i = 0; i < 9; i++)
            {
                if (genDist[1, i] < 2)
                {
                    if (genDist[1, i] == 1)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            compare = genDist[1, j] - genDist[2, j];

                            if (compare > 0)
                            {
                                now++;
                                if (now > halfTotal)
                                {
                                    opinion = 1;
                                }
                                else
                                {
                                    opinion = 0;
                                }
                            }
                        }

                        if (opinion == 0)
                        {
                            secondaryPerson = new Label[1];
                            secondaryPerson[alone] = new Label();
                            secondaryPerson[alone].Location = new Point(500, 300);
                            secondaryPerson[alone].Name = "secondaryPerson";
                            secondaryPerson[alone].Size = new System.Drawing.Size(50, 13);
                            secondaryPerson[alone].Text = "Ребёнок";
                            secondaryPerson[alone].BackColor = Color.White;
                            secondaryPerson[alone].Visible = true;
                            this.Controls.Add(secondaryPerson[alone]);
                        }
                        else
                        {
                            secondaryPerson = new Label[1];
                            secondaryPerson[alone] = new Label();
                            secondaryPerson[alone].Location = new Point(500, 200);
                            secondaryPerson[alone].Name = "secondaryPerson";
                            secondaryPerson[alone].Size = new System.Drawing.Size(50, 13);
                            secondaryPerson[alone].Text = "Родитель";
                            secondaryPerson[alone].BackColor = Color.White;
                            secondaryPerson[alone].Visible = true;
                            this.Controls.Add(secondaryPerson[alone]);
                        }
                    }

                    if (genDist[1, i] == 1.6)
                    {
                        secondaryPerson = new Label[1];
                        secondaryPerson[alone] = new Label();
                        secondaryPerson[alone].Location = new Point(550, 200);
                        secondaryPerson[alone].Name = "secondaryPerson";
                        secondaryPerson[alone].Size = new System.Drawing.Size(50, 13);
                        secondaryPerson[alone].Text = "Дядя";
                        secondaryPerson[alone].BackColor = Color.White;
                        secondaryPerson[alone].Visible = true;
                        this.Controls.Add(secondaryPerson[alone]);
                    }

                    if (genDist[1, i] != 1.6 && genDist[1, i] >= 1.3 && genDist[1, i] <= 1.7)
                    {

                    }
                }
            }
        }
    }
}
