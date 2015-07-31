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
        double[] edge = new double[5];

        void relationsBuild()
        {
            //Загрузка номеров китов
            loadKitNumbers();

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

            //Загрузка граничного значения неопределенностей
            loadAmbiguityEdges();

            //Отрисовка собственной персоны
            drawGen(kitNumb[0], "Self");

            //Отрисовка родственных персон
            for (int j = 0; j < genDist.GetLength(0); j++)
            {
                //Line Father
                LineFather(j, genDist, num);

                //Line Grand-father
                LineGrandfather(j, genDist, num);

                //Line Great-grand-father
                LineGreatgrandfather(j, genDist, num);

                //Line Great-great-grand-father
                LineGreatgreatgrandfather(j, genDist, num);

                //Line Great-great-great-grand-father
                LineGreatgreatgreatgrandfather(j, genDist, num);
            }
        }

        void loadKitNumbers()
        {
            string[] kitLines = File.ReadAllLines("KitsNumbers.txt");
            for (int i = 0; i < kitLines.Length; i++)
            {
                if (Int32.TryParse(kitLines[i], out kitNumb[i])) ;
            }
        }

        void loadAmbiguityEdges()
        {
            string[] ambiguityEdge = File.ReadAllLines("AmbiguityOptions.cfg");
            for (int i = 0; i < ambiguityEdge.Length; i++)
            {
                if (Double.TryParse(ambiguityEdge[i], out edge[i])) ;
            }
        }

        void LineFather(int j, double[,] genDist, double[,] num)
        {
            if (genDist[selfNum, j] >= num[5, 0] && genDist[selfNum, j] <= num[5, 1])
            {
                ambiguity(j, genDist, "ChildOrParent"); //Father
            }
            if (genDist[selfNum, j] >= num[0, 0] && genDist[selfNum, j] <= num[0, 1])
            {
                FLine(1, kitNumb[j]); //Brother
            }
        }

        void LineGrandfather(int j, double[,] genDist, double[,] num)
        {
            if (genDist[selfNum, j] >= num[10, 0] && genDist[selfNum, j] <= num[10, 1])
            {
                ambiguity(j, genDist, "UncleOrGF"); //Grand-father
            }
            if (genDist[selfNum, j] >= num[6, 0] && genDist[selfNum, j] <= num[6, 1])
            {
                ambiguity(j, genDist, "UncleOrGF"); //Uncle
            }
            if (genDist[selfNum, j] >= num[1, 0] && genDist[selfNum, j] <= num[1, 1])
            {
                GFLine(2, kitNumb[j]); //1st Cousin
            }
        }

        void LineGreatgrandfather(int j, double[,] genDist, double[,] num)
        {
            if (genDist[selfNum, j] >= num[14, 0] && genDist[selfNum, j] <= num[14, 1])
            {
                GGFLine(0, kitNumb[j]); //Great-grand-father
            }
            if (genDist[selfNum, j] >= num[11, 0] && genDist[selfNum, j] <= num[11, 1])
            {
                GGFLine(1, kitNumb[j]); //Grand-uncle
            }
            if (genDist[selfNum, j] >= num[7, 0] && genDist[selfNum, j] <= num[7, 1])
            {
                GGFLine(2, kitNumb[j]); //1st Cousin 1R
            }
            if (genDist[selfNum, j] >= num[2, 0] && genDist[selfNum, j] <= num[2, 1])
            {
                ambiguity(j, genDist, "1stC2ROr2ndC"); //2nd Cousin
            }
        }

        void LineGreatgreatgrandfather(int j, double[,] genDist, double[,] num)
        {
            if (genDist[selfNum, j] >= num[17, 0] && genDist[selfNum, j] <= num[17, 1])
            {
                GGGFLine(0, kitNumb[j]); //Great-great-grand-father
            }
            if (genDist[selfNum, j] >= num[15, 0] && genDist[selfNum, j] <= num[15, 1])
            {
                GGGFLine(1, kitNumb[j]); //Great-grand-uncle
            }
            if (genDist[selfNum, j] >= num[12, 0] && genDist[selfNum, j] <= num[12, 1])
            {
                ambiguity(j, genDist, "1stC2ROr2ndC"); //1st Cousin 2R
            }
            if (genDist[selfNum, j] >= num[8, 0] && genDist[selfNum, j] <= num[8, 1])
            {
                ambiguity(j, genDist, "2ndC1ROr3rdC"); //2nd Cousin 1R
            }
            if (genDist[selfNum, j] >= num[3, 0] && genDist[selfNum, j] <= num[3, 1])
            {
                ambiguity(j, genDist, "2ndC1ROr3rdC"); //3rd Cousin
            }
        }

        void LineGreatgreatgreatgrandfather(int j, double[,] genDist, double[,] num)
        {
            if (genDist[selfNum, j] >= num[19, 0] && genDist[selfNum, j] <= num[19, 1])
            {
                GGGGFLine(0, kitNumb[j]); //Great-great-great-grand-father
            }
            if (genDist[selfNum, j] >= num[18, 0] && genDist[selfNum, j] <= num[18, 1])
            {
                GGGGFLine(1, kitNumb[j]); //Great-great-grand-uncle
            }
            if (genDist[selfNum, j] >= num[16, 0] && genDist[selfNum, j] <= num[16, 1])
            {
                GGGGFLine(2, kitNumb[j]); //1st Cousin 3R
            }
            if (genDist[selfNum, j] >= num[13, 0] && genDist[selfNum, j] <= num[13, 1])
            {
                GGGGFLine(3, kitNumb[j]); //2nd Cousin 2R
            }
            if (genDist[selfNum, j] >= num[9, 0] && genDist[selfNum, j] <= num[9, 1])
            {
                GGGGFLine(4, kitNumb[j]); //3rd Cousin 1R
            }
            if (genDist[selfNum, j] >= num[4, 0] && genDist[selfNum, j] <= num[4, 1])
            {
                GGGGFLine(5, kitNumb[j]); //4th Cousin
            }
        }
    }
}
