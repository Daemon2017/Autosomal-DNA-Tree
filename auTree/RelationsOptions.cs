using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Подключаем пространство имен для работы с файлами

namespace auTree
{
    public partial class RelationsOptions : Form
    {
        public TextBox[] min0 = new TextBox[5];
        public TextBox[] max0 = new TextBox[5];
        public TextBox[] minM1 = new TextBox[5];
        public TextBox[] maxM1 = new TextBox[5];
        public TextBox[] minM2 = new TextBox[4];
        public TextBox[] maxM2 = new TextBox[4];
        public TextBox[] minM3 = new TextBox[3];
        public TextBox[] maxM3 = new TextBox[3];
        public TextBox[] minM4 = new TextBox[2];
        public TextBox[] maxM4 = new TextBox[2];
        public TextBox[] minM5 = new TextBox[1];
        public TextBox[] maxM5 = new TextBox[1];
        public TextBox[] minP1 = new TextBox[1];
        public TextBox[] maxP1 = new TextBox[1];

        public string[,] mass = new String[127, 127];

        int i;

        public RelationsOptions()
        {
            InitializeComponent();
        }

        private void RelationsOptions_Load(object sender, EventArgs e)
        {
            //Поколение 0
            for (i = 0; i < 5; i++)
            {
                min0[i] = new TextBox();
                min0[i].Location = new Point(99, 29 + i * 26);
                min0[i].Size = new System.Drawing.Size(24, 20);
                this.Controls.Add(min0[i]);
            }

            for (i = 0; i < 5; i++)
            {
                max0[i] = new TextBox();
                max0[i].Location = new Point(99 + 33, 29 + i * 26);
                max0[i].Size = new System.Drawing.Size(24, 20);
                this.Controls.Add(max0[i]);
            }

            //Поколение -1
            for (i = 0; i < 5; i++)
            {
                minM1[i] = new TextBox();
                minM1[i].Location = new Point(252, 29 + i * 26);
                minM1[i].Size = new System.Drawing.Size(24, 20);
                this.Controls.Add(minM1[i]);
            }

            for (i = 0; i < 5; i++)
            {
                maxM1[i] = new TextBox();
                maxM1[i].Location = new Point(252 + 33, 29 + i * 26);
                maxM1[i].Size = new System.Drawing.Size(24, 20);
                this.Controls.Add(maxM1[i]);
            }

            //Поколение -2
            for (i = 0; i < 4; i++)
            {
                minM2[i] = new TextBox();
                minM2[i].Location = new Point(408, 29 + i * 26);
                minM2[i].Size = new System.Drawing.Size(24, 20);
                this.Controls.Add(minM2[i]);
            }

            for (i = 0; i < 4; i++)
            {
                maxM2[i] = new TextBox();
                maxM2[i].Location = new Point(408 + 33, 29 + i * 26);
                maxM2[i].Size = new System.Drawing.Size(24, 20);
                this.Controls.Add(maxM2[i]);
            }

            //Поколение -3
            for (i = 0; i < 3; i++)
            {
                minM3[i] = new TextBox();
                minM3[i].Location = new Point(569, 29 + i * 26);
                minM3[i].Size = new System.Drawing.Size(24, 20);
                this.Controls.Add(minM3[i]);
            }

            for (i = 0; i < 3; i++)
            {
                maxM3[i] = new TextBox();
                maxM3[i].Location = new Point(569 + 33, 29 + i * 26);
                maxM3[i].Size = new System.Drawing.Size(24, 20);
                this.Controls.Add(maxM3[i]);
            }

            //Поколение -4
            for (i = 0; i < 2; i++)
            {
                minM4[i] = new TextBox();
                minM4[i].Location = new Point(758, 29 + i * 26);
                minM4[i].Size = new System.Drawing.Size(24, 20);
                this.Controls.Add(minM4[i]);
            }

            for (i = 0; i < 2; i++)
            {
                maxM4[i] = new TextBox();
                maxM4[i].Location = new Point(758 + 33, 29 + i * 26);
                maxM4[i].Size = new System.Drawing.Size(24, 20);
                this.Controls.Add(maxM4[i]);
            }

            //Поколение -5
            for (i = 0; i < 1; i++)
            {
                minM5[i] = new TextBox();
                minM5[i].Location = new Point(974, 29 + i * 26);
                minM5[i].Size = new System.Drawing.Size(24, 20);
                this.Controls.Add(minM5[i]);
            }

            for (i = 0; i < 1; i++)
            {
                maxM5[i] = new TextBox();
                maxM5[i].Location = new Point(974 + 33, 29 + i * 26);
                maxM5[i].Size = new System.Drawing.Size(24, 20);
                this.Controls.Add(maxM5[i]);
            }

            //Поколение +1
            for (i = 0; i < 1; i++)
            {
                minP1[i] = new TextBox();
                minP1[i].Location = new Point(252, 179 + i * 26);
                minP1[i].Size = new System.Drawing.Size(24, 20);
                this.Controls.Add(minP1[i]);
            }

            for (i = 0; i < 1; i++)
            {
                maxP1[i] = new TextBox();
                maxP1[i].Location = new Point(252 + 33, 179 + i * 26);
                maxP1[i].Size = new System.Drawing.Size(24, 20);
                this.Controls.Add(maxP1[i]);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 5; j++)
            {
                mass[j, 0] = min0[j].Text;
                mass[j, 1] = max0[j].Text;
            }

            for (int j = 5; j < 10; j++)
            {
                mass[j, 0] = minM1[j-5].Text;
                mass[j, 1] = maxM1[j-5].Text;
            }

            for (int j = 10; j < 14; j++)
            {
                mass[j, 0] = minM2[j - 10].Text;
                mass[j, 1] = maxM2[j - 10].Text;
            }

            for (int j = 14; j < 17; j++)
            {
                mass[j, 0] = minM3[j - 14].Text;
                mass[j, 1] = maxM3[j - 14].Text;
            }

            for (int j = 17; j < 19; j++)
            {
                mass[j, 0] = minM4[j - 17].Text;
                mass[j, 1] = maxM4[j - 17].Text;
            }

            for (int j = 19; j < 20; j++)
            {
                mass[j, 0] = minM5[j - 19].Text;
                mass[j, 1] = maxM5[j - 19].Text;
            }

            for (int j = 20; j < 21; j++)
            {
                mass[j, 0] = minP1[j - 20].Text;
                mass[j, 1] = maxP1[j - 20].Text;
            }

            using (StreamWriter gg = new StreamWriter(@"RelationsOptions.txt"))
            {
                for (int i = 0; i < 21; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        gg.Write(mass[i, j] + ",");
                    }
                    gg.Write("\r\n");
                }
                gg.Close();
            }
        }
    }
}
