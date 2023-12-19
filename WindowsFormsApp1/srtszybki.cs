using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using kolokwium;

namespace kolokwium
{
    internal class srtszybki : czas
    {
        public void qckSort(int[] liczby, int left, int right)
        {
            int[] dos = new int[liczby.Length];
            for (int k = 0; k < liczby.Length; k++)
            {
                dos[k] = liczby[k];
            }
            odlicz();
            quickSort(dos, left, right);
            stop();
        }
        public void quickSort(int[] szybkieliczby, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = szybkieliczby[(left + right) / 2];
            while (i < j)
            {
                while (szybkieliczby[i] < pivot) i++;
                while (szybkieliczby[j] > pivot) j--;
                if (i <= j)
                {
                    int tmp = szybkieliczby[i];
                    szybkieliczby[i++] = szybkieliczby[j];
                    szybkieliczby[j--] = tmp;
                }
            }
            if (left < j) quickSort(szybkieliczby, left, j);
            if (i < right) quickSort(szybkieliczby, i, right);
        }
    }
}