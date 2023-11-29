using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Losowo
    {
        public Losowo() {

            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int dlugoscCiagu = rnd.Next(0, 21);
                Console.Write("ciąg: " + (i + 1) + ": ");
                for (int j = 0; j < dlugoscCiagu; j++)
                {
                    int losowaLiczba = Random.Next(0, 21);
                    Console.Write(losowaLiczba + " ");
                }
                Console.WriteLine();
            }
        }
    }

