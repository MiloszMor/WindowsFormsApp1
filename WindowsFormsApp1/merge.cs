using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace zalek
{
    internal class merge : czas
    {
        public void Sortowanie(int[] liczby);

        int[] dos = new int[liczby.Length];
            for (int k = 0; k<liczby.Length; k++)
            {
                dos[k] = liczby[k];
            }

    StartCount();
    public static void MergeSort(int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSort(left, mid);
                MergeSort(mid + 1, right);

                Sort(left, mid, right);
            }
        }
        private void Sort(int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            Array.Copy(tab, left, leftArray, 0, n1);
            Array.Copy(tab, mid + 1, rightArray, 0, n2);

            int i = 0, j = 0;
            int k = left;

            while (i < n1 && j < n2)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    tab[k] = leftArray[i];
                    i++;
                }
                else
                {
                    tab[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                tab[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                tab[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}
