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
    public partial class Form1
    {
        void centralPersonBuild()
        {
            drawSelf(kitNumb[0]);
        }

        void relationsBuild()
        {
            string[] lines = File.ReadAllLines("RelationsOptions.cfg");
            double[,] num = new double[lines.Length, lines[0].Split(' ').Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(' ');

                for (int j = 0; j < temp.Length; j++)
                {
                    if (Double.TryParse(temp[j], out num[i, j])) ;
                }
            }

            for (int j = 0; j < genDist.GetLength(0); j++)
            {
                //Поколение 0
                if (genDist[selfNum, j] == 3.6)
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

                //Поколение -1
                if (genDist[selfNum, j] == num[6, 0] )
                {
                    ChildOrParent(j);
                }

                if (genDist[selfNum, j] == 1.6)
                {
                    drawFather(0);
                    drawGrandfather(0);
                    drawUncle(kitNumb[j]);
                }

                if (genDist[selfNum, j] == 3.8)
                {
                    drawFather(0);
                    drawGrandfather(0);
                    drawGreatgrandfather(0);
                    drawGreatgreatgrandfather(0);
                    drawGreatgranduncle(0);
                    draw1stCousin2R(0);
                    draw2ndCousin1R(kitNumb[j]);
                }

                //Поколение -2
                if ((genDist[selfNum, j] == 1.7) || (genDist[selfNum, j] == 1.5))
                {
                    drawFather(0);
                    drawGrandfather(kitNumb[j]);
                }

                if (genDist[selfNum, j] == 2.2)
                {
                    drawFather(0);
                    drawGrandfather(0);
                    drawGreatgrandfather(0);
                    drawGranduncle(kitNumb[j]);
                }


                if (genDist[selfNum, j] == 3.1)
                {
                    drawFather(0);
                    drawGrandfather(0);
                    drawGreatgrandfather(0);
                    drawGreatgreatgrandfather(0);
                    drawGreatgranduncle(0);
                    draw1stCousin2R(kitNumb[j]);
                }
            }
        }
    }
}
