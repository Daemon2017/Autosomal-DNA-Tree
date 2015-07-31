using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace auTree
{
    public partial class AmbiguityOptions : Form
    {
        TextBox[] ambiguityDistance = new TextBox[5];
        string[] masDis = new String[5];
        public bool useAmbiguitySolver;

        public AmbiguityOptions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 5; j++)
            {
                masDis[j] = ambiguityDistance[j].Text;
            }
            saveMatrix();
            useAmbiguitySolver = checkBox1.Checked;
            Close();
        }

        private void AmbiguityOptions_Load(object sender, EventArgs e)
        {
            drawTextBoxes();
            loadMatrix();
        }

        void drawTextBoxes()
        {
            for (int i = 0; i < 5; i++)
            {
                ambiguityDistance[i] = new TextBox();
                ambiguityDistance[i].Location = new Point(148, 25 + i * 26);
                ambiguityDistance[i].Size = new System.Drawing.Size(34, 20);
                this.Controls.Add(ambiguityDistance[i]);
            }
        }

        void loadMatrix()
        {
            string[] ambiguityEdge = File.ReadAllLines("AmbiguityOptions.cfg");
            double[] edge = new double[5];

            for (int i = 0; i < ambiguityEdge.Length; i++)
            {
                if (Double.TryParse(ambiguityEdge[i], out edge[i])) ;
                ambiguityDistance[i].Text = edge[i].ToString();
            }
        }

        void saveMatrix()
        {
            using (StreamWriter gg = new StreamWriter(@"AmbiguityOptions.cfg"))
            {
                for (int i = 0; i < 5; i++)
                {
                    gg.Write(masDis[i]);
                    gg.Write("\r\n");
                }
                gg.Close();
            }
        }
    }
}
