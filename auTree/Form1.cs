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
        int selfNum = 0;

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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            centralPersonBuild(); //Помещаем персону из ячейки 0;0

            relationsBuild(); //Помещаем персоны из ячеек 0;j
        }

        private void relationsOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelationsOptions RO = new RelationsOptions();
            RO.Show();
        }
    }
}
