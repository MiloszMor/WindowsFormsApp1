using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Losowo
    {
        public int[] generujLosowe(int rozmiar)
        {
            int[] liczby = new int[rozmiar];

            Random losoweLiczby = new Random();
            for (int i = 0; i < rozmiar; i++) {
                liczby[i] = losoweLiczby.Next(0, 99999)
            }
            return liczby;
        }
    }
}

