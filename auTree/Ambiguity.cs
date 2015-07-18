﻿using System;
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
        void ChildOrParent(int j, double[,] genDist)
        {
            double[] compare = new double[genDist.GetLength(0)];
            double result;

            for (int i = 0; i < genDist.GetLength(0); i++)
            {
                compare[i] = genDist[selfNum, i] - genDist[j, i];
            }

            result = compare.Average();

            if (result >= 0)
            {
                FLine(0, kitNumb[j]);
            }
            else
            {
                drawChild(kitNumb[j]);
            }
        }

        void UncleOrGF(int j, double[,] genDist)
        {
            double[] compare = new double[genDist.GetLength(0)];
            double result;

            for (int i = 0; i < genDist.GetLength(0); i++)
            {
                compare[i] = genDist[selfNum, i] - genDist[j, i];
            }

            result = compare.Average();

            if (Math.Abs(result) >= 0.45)
            {
                GFLine(0, kitNumb[j]);
            }
            else
            {
                GFLine(1, kitNumb[j]);
            }
        }

        void Amb1stC2ROr2ndC(int j, double[,] genDist)
        {
            double[] compare = new double[genDist.GetLength(0)];
            double result;

            for (int i = 0; i < genDist.GetLength(0); i++)
            {
                compare[i] = genDist[selfNum, i] - genDist[j, i];
            }

            result = compare.Average();

            if (Math.Abs(result) >= 0.45)
            {
                GGFLine(3, kitNumb[j]);
            }
            else
            {
                GGGFLine(2, kitNumb[j]);
            }
        }

        void Amb2ndC1ROr3rdC(int j, double[,] genDist)
        {
            double[] compare = new double[genDist.GetLength(0)];
            double result;

            for (int i = 0; i < genDist.GetLength(0); i++)
            {
                compare[i] = genDist[selfNum, i] - genDist[j, i];
            }

            result = compare.Average();

            if (Math.Abs(result) >= 0.17)
            {
                GGGFLine(4, kitNumb[j]);
            }
            else
            {
                GGGFLine(3, kitNumb[j]);
            }
        }
    }
}
