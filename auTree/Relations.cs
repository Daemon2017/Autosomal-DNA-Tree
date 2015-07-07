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
    }
}
