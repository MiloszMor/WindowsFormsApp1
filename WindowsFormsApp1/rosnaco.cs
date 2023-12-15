using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CiągRosnacy
    {
        public static void Generuj(int poczatkowaWartosc, int krok, int iloscLiczb)
        {
            for (int i = 0; i < iloscLiczb; i++)
            {
                int aktualnaWartosc = poczatkowaWartosc + i * krok;
                Console.WriteLine(aktualnaWartosc);
            }
        }
    }
}
