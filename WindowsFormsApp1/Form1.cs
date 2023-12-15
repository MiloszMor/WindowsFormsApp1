using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int[] rnd;
        private int[] array;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           //MessageBox.
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
        /* {
             for (int i = 0; i < nummerlista.Count; i++)
             {
                 output.AppendText(Convert.ToString(nummerlista[i]) + " ");
             }
             int t = 0;
             for (int v = 0; v < nummerlista.Count; v++)
             {
                 for (int c = 0; c < nummerlista.Count; c++)
                 {
                     if (nummerlista[v] < nummerlista[c])
                     {
                         t = nummerlista[v];

                         nummerlista[v] = nummerlista[c];

                         nummerlista[c] = t;
                     }
                 }
             }
             for (int i = 0; i < nummerlista.Count; i++)
             {
                 outputSorterad.AppendText(Convert.ToString(nummerlista[i]) + " ");
             }
         }*/
        a
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            array = new int[100];
            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                this.array[i] = rnd.Next(1000);
            }
        }//Losowe

        
        /*{
            public static void Sort(int[] arr, int left, int right)
            {
                if (left < right)
                {
                    int pivot = Partition(arr, left, right);

                    Sort(arr, left, pivot - 1);
                    Sort(arr, pivot + 1, right);
                }
            }

            private static int Partition(int[] arr, int left, int right)
            {
                int pivot = arr[right];
                int i = left - 1;

                for (int j = left; j < right; j++)
                {
                    if (arr[j] <= pivot)
                    {
                        i++;
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

                int temp1 = arr[i + 1];
                arr[i + 1] = arr[right];
                arr[right] = temp1;

                return i + 1;
            }

            static void Main()
            {
                int[] ints = { 8, 875, 7, 9, 764, 55 };

                Console.WriteLine("Original array:");
                foreach (int i in ints)
                {
                    Console.WriteLine(i);
                }


                Sort(ints, 0, 5);

                Console.WriteLine("Sorted array:");

                foreach (int i in ints)
                {
                    Console.WriteLine(i);
                }
            }
        }*/

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ciagMalejacy.Generuj(10, 2, 5);
        }//Malejace

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CiągRosnacy.Generuj(1, 2, 5);
        }//Rosnace

private void chart1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add("Losowe Liczby");

            for (int i = 0; i < array.Length; i++)
            {
                chart1.Series["Losowe Liczby"].Points.AddY(array[i]);
            }

            chart1.ChartAreas[0].AxisX.Title = "Indeks";
            chart1.ChartAreas[0].AxisY.Title = "Wartość";
        }
    }
}
