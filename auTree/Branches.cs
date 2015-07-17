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
        //Ветвление
        void GGGGFLine(int depth, double kit)
        {
            double currentKit = kit;

            drawFather(0);
            drawGrandfather(0);
            drawGreatgrandfather(0);
            drawGreatgreatgrandfather(0);

            if (depth >= 0)
            {
                if (depth != 0)
                {
                    currentKit = 0;
                }

                drawGreatgreatgreatgrandfather(currentKit);
                currentKit = kit;
            }

            if (depth >= 1)
            {
                if (depth != 1)
                {
                    currentKit = 0;
                }

                drawGreatgreatgranduncle(currentKit);
                currentKit = kit;
            }

            if (depth >= 2)
            {
                if (depth != 2)
                {
                    currentKit = 0;
                }

                draw1stCousin3R(currentKit);
                currentKit = kit;
            }

            if (depth >= 3)
            {
                if (depth != 3)
                {
                    currentKit = 0;
                }

                draw2ndCousin2R(currentKit);
                currentKit = kit;
            }

            if (depth >= 4)
            {
                if (depth != 4)
                {
                    currentKit = 0;
                }

                draw3rdCousin1R(currentKit);
                currentKit = kit;
            }

            if (depth >= 5)
            {
                if (depth != 5)
                {
                    currentKit = 0;
                }

                draw4thCousin(currentKit);
                currentKit = kit;
            }
        }

        void GGGFLine(int depth, double kit)
        {
            double currentKit = kit;

            drawFather(0);
            drawGrandfather(0);
            drawGreatgrandfather(0);

            if (depth >= 0)
            {
                if (depth != 0)
                {
                    currentKit = 0;
                }

                drawGreatgreatgrandfather(currentKit);
                currentKit = kit;
            }

            if (depth >= 1)
            {
                if (depth != 1)
                {
                    currentKit = 0;
                }

                drawGreatgranduncle(currentKit);
                currentKit = kit;
            }

            if (depth >= 2)
            {
                if (depth != 2)
                {
                    currentKit = 0;
                }

                draw1stCousin2R(currentKit);
                currentKit = kit;
            }

            if (depth >= 3)
            {
                if (depth != 3)
                {
                    currentKit = 0;
                }

                draw2ndCousin1R(currentKit);
                currentKit = kit;
            }

            if (depth >= 4)
            {
                if (depth != 4)
                {
                    currentKit = 0;
                }

                draw3rdCousin(currentKit);
                currentKit = kit;
            }
        }

        void GGFLine(int depth, double kit)
        {
            double currentKit = kit;

            drawFather(0);
            drawGrandfather(0);

            if (depth >= 0)
            {
                if (depth != 0)
                {
                    currentKit = 0;
                }

                drawGreatgrandfather(currentKit);
                currentKit = kit;
            }

            if (depth >= 1)
            {
                if (depth != 1)
                {
                    currentKit = 0;
                }

                drawGranduncle(currentKit);
                currentKit = kit;
            }

            if (depth >= 2)
            {
                if (depth != 2)
                {
                    currentKit = 0;
                }

                draw1stCousin1R(currentKit);
                currentKit = kit;
            }

            if (depth >= 3)
            {
                if (depth != 3)
                {
                    currentKit = 0;
                }

                draw2ndCousin(currentKit);
                currentKit = kit;
            }
        }

        void GFLine(int depth, double kit)
        {
            double currentKit = kit;

            drawFather(0);

            if (depth >= 0)
            {
                if (depth != 0)
                {
                    currentKit = 0;
                }

                drawGrandfather(currentKit);
                currentKit = kit;
            }

            if (depth >= 1)
            {
                if (depth != 1)
                {
                    currentKit = 0;
                }

                drawUncle(currentKit);
                currentKit = kit;
            }

            if (depth >= 2)
            {
                if (depth != 2)
                {
                    currentKit = 0;
                }

                draw1stCousin(currentKit);
                currentKit = kit;
            }
        }

        void FLine(int depth, double kit)
        {
            double currentKit = kit;

            if (depth >= 0)
            {
                if (depth != 0)
                {
                    currentKit = 0;
                }

                drawFather(currentKit);
                currentKit = kit;
            }

            if (depth >= 1)
            {
                if (depth != 1)
                {
                    currentKit = 0;
                }

                drawBrother(currentKit);
                currentKit = kit;
            }
        }
    }
}
