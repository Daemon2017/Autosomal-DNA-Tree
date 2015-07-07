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
    public partial class Form1
    {
        //Неоднозначности
        void ChildOrParent(int j)
        {
            double father = 0;
            double halfTotal = genDist.GetLength(0) / 2;

            for (int i = 0; i < genDist.GetLength(0); i++)
            {
                double compare = genDist[selfNum, i] - genDist[j, i];

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
    }
}
