using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  
       internal class ciagMalejacy
        {
            public static void Generuj(int poczatkowaWartosc, int krok, int iloscLiczb)
            {
                for (int i = 0; i < iloscLiczb; i++)
                {

                    int aktualnaWartosc = poczatkowaWartosc - i * krok;

                    Console.WriteLine(aktualnaWartosc);

                }

            }

       }

}
