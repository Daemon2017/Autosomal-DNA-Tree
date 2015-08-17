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
        RelationsOptions RO = new RelationsOptions();
        AmbiguityOptions AO = new AmbiguityOptions();
        AboutBox1 About = new AboutBox1();

        //Переменная, разрешающая/запрещающая пытаться решить неопределенности
        bool useAmbiguitySolver;

        public Form1()
        {
            InitializeComponent();

            relative = new Label[127];
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Запуск загрузки информации и отрисовки персон
            relationsBuild();
        }

        private void relationsOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RO.Show();
        }

        private void ambiguityOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Загрузка значения, позволяющего/запрещающего пытаться решить неопределенности
            AO.button1.Click += (senderSlave, eSlave) =>
            {
                this.useAmbiguitySolver = AO.useAmbiguitySolver;
            };
            AO.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About.Show();            
        }
    }
}
