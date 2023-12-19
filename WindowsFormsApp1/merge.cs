using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kolokwium;

namespace kolokwium
{
    internal class marge : czas
    {
        public void srtmarge(int[] liczby, int left, int right)
        {
            int[] dos = new int[liczby.Length];
            for (int k = 0; k < liczby.Length; k++)
            {
                dos[k] = liczby[k];
            }
            odlicz();
            scalanie2(dos, left, right);
            stop();
        }
        public void scal(int[] dos, int left, int mid, int right)
        {
            int i = left, j = mid + 1;

            int[] pom = new int[dos.Length];

            for (int m = left; m < dos.Length; m++)
            {
                pom[m] = dos[m];
            }

            for (int k = left; k <= right; k++)
                if (i <= mid)
                {
                    if (j <= right)
                    {
                        if (pom[j] < pom[i])
                        {
                            dos[k] = pom[j++];
                        }
                        else
                        {
                            dos[k] = pom[i++];
                        }
                    }
                    else
                    {
                        dos[k] = pom[i++];
                    }
                }
                else
                {
                    dos[k] = pom[j++];
                }
        }
        public void scalanie2(int[] dos, int left, int right)
        {

            if (right <= left)
            {
                return;
            }

            int srodek = (right + left) / 2;


            scalanie2(dos, left, srodek);
            scalanie2(dos, srodek + 1, right);


            scal(dos, left, srodek, right);
        }

    }
}