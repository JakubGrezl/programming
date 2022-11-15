using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace VykresleniSpiraly
{
    internal class Spirala
    {
        
        float odstup;
        float stredX;
        float stredY;
        int smer;
        float temp;

        public Spirala(float odstup, float stredX, float stredY)
        {
            this.odstup = odstup;
            this.stredX = stredX;
            this.stredY = stredY;
            this.smer = 0;
            this.temp = 0;

        }

        public void Vykresli(Graphics g)
        {
            for (int i = 0; i < 2000; i++)
            {
                if (smer == 4)
                    smer = 0;

                switch (smer)
                {
                    case 0: //zleva doprava
                        g.DrawLine(Pens.Black, stredX, stredY, stredX + temp, stredY);
                        stredX += temp;
                        temp += odstup * i;
                        break;

                    case 1: //zespod nahoru
                        g.DrawLine(Pens.Black, stredX, stredY, stredX, stredY + temp);
                        stredY += temp;
                        temp += odstup * i;
                        break;

                    case 2: //zprava doleva
                        g.DrawLine(Pens.Black, stredX, stredY, stredX - temp, stredY);
                        stredX -= temp;
                        temp += odstup * i;
                        break;

                    case 3: //zhora dolu
                        g.DrawLine(Pens.Black, stredX, stredY, stredX, stredY - temp);
                        stredY -= temp;
                        temp += odstup * i;
                        break;
                    default:
                        break;
                }
                smer++;
            }
        }

        internal void Rotation()
        {
            smer++;
        }
    }
}
