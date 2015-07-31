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
        //Ветвь от прапрапрадеда
        void GGGGFLine(int depth, double kit)
        {
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
