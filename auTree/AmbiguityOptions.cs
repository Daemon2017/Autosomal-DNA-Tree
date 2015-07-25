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
    public partial class AmbiguityOptions : Form
    {
        public TextBox[] dis = new TextBox[5];

        public AmbiguityOptions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AmbiguityOptions_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                dis[i] = new TextBox();
                dis[i].Location = new Point(148, 25 + i * 26);
                dis[i].Size = new System.Drawing.Size(24, 20);
                this.Controls.Add(dis[i]);
            }
        }
    }
}
