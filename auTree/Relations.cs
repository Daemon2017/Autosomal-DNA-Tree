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
        int[] kitNumb = new int[30];

        void relationsBuild()
        {
            //Загрузка номеров китов
            string[] kitLines = File.ReadAllLines("KitsNumbers.txt");

            for (int i = 0; i < kitLines.Length; i++)
            {
                if (Int32.TryParse(kitLines[i], out kitNumb[i])) ;
            }

            //Загрузка матрицы родовых расстояний
            string[] genLines = File.ReadAllLines("GeneticDistances.txt");
            double[,] genDist = new double[genLines.Length, genLines[0].Split(';').Length];

            for (int i = 0; i < genLines.Length; i++)
            {
                string[] genTemp = genLines[i].Split(';');

                for (int j = 0; j < genTemp.Length; j++)
                {
                    if (Double.TryParse(genTemp[j], out genDist[i, j])) ;
                }
            }

            //Загрузка нижних и верхних границ интервалов для каждого возможного родства
            string[] lines = File.ReadAllLines("RelationsOptions.cfg");
            double[,] num = new double[lines.Length, lines[0].Split(';').Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(';');

                for (int j = 0; j < temp.Length; j++)
                {
                    if (Double.TryParse(temp[j], out num[i, j])) ;
                }
            }

            drawSelf(kitNumb[0]);

            for (int j = 0; j < genDist.GetLength(0); j++)
            {
                //Поколение 0
                if (genDist[selfNum, j] >= num[0, 0] && genDist[selfNum, j] <= num[0, 1])
                {

                }

                if (genDist[selfNum, j] >= num[1, 0] && genDist[selfNum, j] <= num[1, 1])
                {

                }

                if (genDist[selfNum, j] >= num[2, 0] && genDist[selfNum, j] <= num[2, 1])
                {

                }

                if (genDist[selfNum, j] >= num[3, 0] && genDist[selfNum, j] <= num[3, 1])
                {
                    GGGFLine(4, kitNumb[j]);
                }

                if (genDist[selfNum, j] >= num[4, 0] && genDist[selfNum, j] <= num[4, 1])
                {

                }

                //Поколение -1
                if (genDist[selfNum, j] >= num[5, 0] && genDist[selfNum, j] <= num[5, 1])
                {
                    ChildOrParent(j, genDist);
                }

                if (genDist[selfNum, j] >= num[6, 0] && genDist[selfNum, j] <= num[6, 1])
                {
                    GFLine(1, kitNumb[j]);
                }

                if (genDist[selfNum, j] >= num[7, 0] && genDist[selfNum, j] <= num[7, 1])
                {

                }

                if (genDist[selfNum, j] >= num[8, 0] && genDist[selfNum, j] <= num[8, 1])
                {
                    GGGFLine(3, kitNumb[j]);
                }

                if (genDist[selfNum, j] >= num[9, 0] && genDist[selfNum, j] <= num[9, 1])
                {

                }

                //Поколение -2
                if (genDist[selfNum, j] >= num[10, 0] && genDist[selfNum, j] <= num[10, 1])
                {
                    drawFather(0);
                    drawGrandfather(kitNumb[j]);
                }

                if (genDist[selfNum, j] >= num[11, 0] && genDist[selfNum, j] <= num[11, 1])
                {
                    GGFLine(1, kitNumb[j]);
                }

                if (genDist[selfNum, j] == 3.1)
                {
                    GGGFLine(2, kitNumb[j]);
                }

                if (genDist[selfNum, j] >= num[13, 0] && genDist[selfNum, j] <= num[13, 1])
                {

                }

                //Поколение -3
                if (genDist[selfNum, j] >= num[14, 0] && genDist[selfNum, j] <= num[14, 1])
                {

                }

                if (genDist[selfNum, j] >= num[15, 0] && genDist[selfNum, j] <= num[15, 1])
                {

                }

                if (genDist[selfNum, j] >= num[16, 0] && genDist[selfNum, j] <= num[16, 1])
                {

                }

                //Поколение -4
                if (genDist[selfNum, j] >= num[17, 0] && genDist[selfNum, j] <= num[17, 1])
                {

                }

                if (genDist[selfNum, j] >= num[18, 0] && genDist[selfNum, j] <= num[18, 1])
                {

                }

                //Поколение -5
                if (genDist[selfNum, j] >= num[19, 0] && genDist[selfNum, j] <= num[19, 1])
                {

                }
            }
        }
    }
}
