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
        public Form1()
        {
            InitializeComponent();

            relative = new Label[127];
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Relations.cs - содержит интервалы, указывающие на то, какого уровня родство отрисовывать
            relationsBuild();
        }

        private void relationsOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //RelationsOptions.cs - конфигурирование интервалов родства
            RelationsOptions RO = new RelationsOptions();
            RO.Show();
        }

        private void ambiguityOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AmbiguityOptions.cs - конфигурирование границ неопределенностей
            AmbiguityOptions AO = new AmbiguityOptions();
            AO.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 About = new AboutBox1();
            About.Show();            
        }
    }
}
