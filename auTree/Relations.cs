﻿using System;
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
        //Массив с номерами тестовых наборов
        int[] kitNumb = new int[30];

        //Массив с граничными значениями неопределенностей
        double[] edge = new double[5]; 

        //Запуск загрузки информации и отрисовки персон
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

            //Загрузка граничных значений неопределенностей
            loadAmbiguityEdges();

            //Отрисовка собственной персоны
            drawGen(kitNumb[selfNum], "Self");

            //Отрисовка родственных персон
            for (int j = 0; j < genDist.GetLength(0); j++)
            {
                //Линия от отца
                LineFather(j, genDist, num);

                //Линия от деда
                LineGrandfather(j, genDist, num);

                //Линия от прадеда
                LineGreatgrandfather(j, genDist, num);

                //Линия от прапрадеда
                LineGreatgreatgrandfather(j, genDist, num);

                //Линия от прапрапрадеда
                LineGreatgreatgreatgrandfather(j, genDist, num);
            }
        }

        //Загрузка номеров китов
        void loadKitNumbers()
        {
            string[] kitLines = File.ReadAllLines("KitsNumbers.txt");
            for (int i = 0; i < kitLines.Length; i++)
            {
                if (Int32.TryParse(kitLines[i], out kitNumb[i])) ;
            }
        }

        //Загрузка граничных значений неопределенностей
        void loadAmbiguityEdges()
        {
            string[] ambiguityEdge = File.ReadAllLines("AmbiguityOptions.cfg");
            for (int i = 0; i < ambiguityEdge.Length; i++)
            {
                if (Double.TryParse(ambiguityEdge[i], out edge[i])) ;
            }
        }

        //Линия от отца
        void LineFather(int j, double[,] genDist, double[,] num)
        {
            if (genDist[selfNum, j] >= num[5, 0] && genDist[selfNum, j] <= num[5, 1])
            {
                if (useAmbiguitySolver == true)
                {
                    ambiguity(j, genDist, "ChildOrParent"); //Father
                }
                else
                {
                    FLine(0, kitNumb[j]);
                }
            }

            if (genDist[selfNum, j] >= num[0, 0] && genDist[selfNum, j] <= num[0, 1])
            {
                FLine(1, kitNumb[j]); //Brother
            }
        }

        //Линия от деда
        void LineGrandfather(int j, double[,] genDist, double[,] num)
        {
            if (genDist[selfNum, j] >= num[10, 0] && genDist[selfNum, j] <= num[10, 1])
            {
                if (useAmbiguitySolver == true)
                {
                    ambiguity(j, genDist, "UncleOrGF"); //Grand-father
                }
                else
                {
                    GFLine(0, kitNumb[j]);
                }
            }

            if (genDist[selfNum, j] >= num[6, 0] && genDist[selfNum, j] <= num[6, 1])
            {
                if (useAmbiguitySolver == true)
                {
                    ambiguity(j, genDist, "UncleOrGF"); //Uncle
                }
                else
                {
                    GFLine(1, kitNumb[j]);
                }
            }

            if (genDist[selfNum, j] >= num[1, 0] && genDist[selfNum, j] <= num[1, 1])
            {
                GFLine(2, kitNumb[j]); //1st Cousin
            }
        }

        //Линия от прадеда
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
                if (useAmbiguitySolver == true)
                {
                    ambiguity(j, genDist, "1stC2ROr2ndC"); //2nd Cousin
                }
                else
                {
                    GGFLine(3, kitNumb[j]);
                }
            }
        }

        //Линия от прапрадеда
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
                if (useAmbiguitySolver == true)
                {
                    ambiguity(j, genDist, "1stC2ROr2ndC"); //1st Cousin 2R
                }
                else
                {
                    GGGFLine(2, kitNumb[j]);
                }
            }

            if (genDist[selfNum, j] >= num[8, 0] && genDist[selfNum, j] <= num[8, 1])
            {
                if (useAmbiguitySolver == true)
                {
                    ambiguity(j, genDist, "2ndC1ROr3rdC"); //2nd Cousin 1R
                }
                else
                {
                    GGGFLine(3, kitNumb[j]);
                }
            }

            if (genDist[selfNum, j] >= num[3, 0] && genDist[selfNum, j] <= num[3, 1])
            {
                if (useAmbiguitySolver == true)
                {
                    ambiguity(j, genDist, "2ndC1ROr3rdC"); //3rd Cousin
                }
                else
                {
                    GGGFLine(4, kitNumb[j]);
                }
            }
        }

        //Линия от прапрапрадеда
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
