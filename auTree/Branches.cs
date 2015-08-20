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
        int FL1 = 0; //Количество ветвей, идущих от отца
        int GFL2 = 0; //Количество ветвей, идущих от деда
        int GGFL3 = 0; //Количество ветвей, идущих от прадеда
        int GGGFL4 = 0; //Количество ветвей, идущих от прапрадеда
        int GGGGFL5 = 0; //Количество ветвей, идущих от прапрапрадеда
        int SummOfLines = 0; //Общее количество ветвей на текущую итерацию

        //Подсчет общего количества ветвей на текущую итерацию
        void SummOfLinesCalc()
        {
            SummOfLines = FL1 + GFL2 + GGFL3 + GGGFL4 + GGGGFL5;
        }

        //Ветвь от прапрапрадеда
        void GGGGFLine(int depth, double kit)
        {
            GGGGFL5++;

            double currentKit = kit;

            drawGen(0, "Father");
            drawGen(0, "Grandfather");
            drawGen(0, "Greatgrandfather");
            drawGen(0, "Greatgreatgrandfather");

            if (depth >= 0)
            {
                if (depth != 0)
                {
                    currentKit = 0;
                }

                drawGen(currentKit, "Greatgreatgreatgrandfather");
                currentKit = kit;
            }

            if (depth >= 1)
            {
                if (depth != 1)
                {
                    currentKit = 0;
                }

                drawGen(currentKit, "Greatgreatgranduncle");
                currentKit = kit;
            }

            if (depth >= 2)
            {
                if (depth != 2)
                {
                    currentKit = 0;
                }

                drawGen(currentKit, "1stCousin3R");
                currentKit = kit;
            }

            if (depth >= 3)
            {
                if (depth != 3)
                {
                    currentKit = 0;
                }

                drawGen(currentKit, "2ndCousin2R");
                currentKit = kit;
            }

            if (depth >= 4)
            {
                if (depth != 4)
                {
                    currentKit = 0;
                }

                drawGen(currentKit, "3rdCousin1R");
                currentKit = kit;
            }

            if (depth >= 5)
            {
                if (depth != 5)
                {
                    currentKit = 0;
                }

                drawGen(currentKit, "4thCousin");
                currentKit = kit;
            }
        }

        //Ветвь от прапрадеда
        void GGGFLine(int depth, double kit)
        {
            GGGFL4++;

            double currentKit = kit;

            drawGen(0, "Father");
            drawGen(0, "Grandfather");
            drawGen(0, "Greatgrandfather");

            if (depth >= 0)
            {
                if (depth != 0)
                {
                    currentKit = 0;
                }

                drawGen(currentKit, "Greatgreatgrandfather");
                currentKit = kit;
            }

            if (depth >= 1)
            {
                if (depth != 1)
                {
                    currentKit = 0;
                }

                drawGen(currentKit, "Greatgranduncle");
                currentKit = kit;
            }

            if (depth >= 2)
            {
                if (depth != 2)
                {
                    currentKit = 0;
                }

                drawGen(currentKit, "1stCousin2R");
                currentKit = kit;
            }

            if (depth >= 3)
            {
                if (depth != 3)
                {
                    currentKit = 0;
                }

                drawGen(currentKit, "2ndCousin1R");
                currentKit = kit;
            }

            if (depth >= 4)
            {
                if (depth != 4)
                {
                    currentKit = 0;
                }

                drawGen(currentKit, "3rdCousin");
                currentKit = kit;
            }
        }

        //Ветвь от прадеда
        void GGFLine(int depth, double kit)
        {
            GGFL3++;

            double currentKit = kit;

            drawGen(0, "Father");
            drawGen(0, "Grandfather");

            if (depth >= 0)
            {
                if (depth != 0)
                {
                    currentKit = 0;
                }

                drawGen(currentKit, "Greatgrandfather");
                currentKit = kit;
            }

            if (depth >= 1)
            {
                if (depth != 1)
                {
                    currentKit = 0;
                }

                drawGen(currentKit, "Granduncle");
                currentKit = kit;
            }

            if (depth >= 2)
            {
                if (depth != 2)
                {
                    currentKit = 0;
                }

                drawGen(currentKit, "1stCousin1R");
                currentKit = kit;
            }

            if (depth >= 3)
            {
                if (depth != 3)
                {
                    currentKit = 0;
                }

                drawGen(currentKit, "2ndCousin");
                currentKit = kit;
            }
        }

        //Ветвь от деда
        void GFLine(int depth, double kit)
        {
            GFL2++;

            double currentKit = kit;

            drawGen(0, "Father");

            if (depth >= 0)
            {
                if (depth != 0)
                {
                    currentKit = 0;
                }

                drawGen(currentKit, "Grandfather");
                currentKit = kit;
            }

            if (depth >= 1)
            {
                if (depth != 1)
                {
                    currentKit = 0;
                }

                drawGen(currentKit, "Uncle");
                currentKit = kit;
            }

            if (depth >= 2)
            {
                if (depth != 2)
                {
                    currentKit = 0;
                }

                drawGen(currentKit, "1stCousin");
                currentKit = kit;
            }
        }

        //Ветвь от отца
        void FLine(int depth, double kit)
        {
            FL1++;

            double currentKit = kit;

            if (depth >= 0)
            {
                if (depth != 0)
                {
                    currentKit = 0;
                }

                drawGen(currentKit, "Father");
                currentKit = kit;
            }

            if (depth >= 1)
            {
                if (depth != 1)
                {
                    currentKit = 0;
                }
                                
                drawGen(currentKit, "Brother");
                currentKit = kit;
            }
        }
    }
}
