using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace zalek
{
    public partial class Form1 : Form
    {
        //private int[] rnd;
        //private int[] array;
        public Form1()
        {
            InitializeComponent();
            chart1.Series.Clear();
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
            chart1.Series.Clear();

            int wielkosc = 1000;
            int[] wylosowane = new int[wielkosc];
            int[] rosnaco = new int[wielkosc];
            int[] malejace = new int[wielkosc];
            chart1.ChartAreas.First().AxisY.LabelStyle.Format = "0ms";

            if (this.rosnaco.Checked)
            {
                for (int i = 1; i < wielkosc; i++)
                {
                    rosnaco[i] = i;
                }
            }
            if (this.zmiejszenie.Checked)
            {
                for (int i = wielkosc - 1; i > 0; i--)
                {
                    malejace[i] = i;
                }
            }
            if (Losowo.Checked)
            {
                Random rnd = new Random();

                int poczatek = 0;
                int koniec = wielkosc + 1;
                for (int i = 0; i < wielkosc - 1; i++)
                {

                    wylosowane[i] = rnd.Next(poczatek, koniec);

                }
            }
            if (sorBubbles.Checked)
            {
                Bubble b = new Bubble();
                if (this.rosnaco.Checked)
                {
                    b.BubbleSort(rosnaco);
                    Series br = new Series("babelkowe-rosnace");
                    br.Points.Add(b.Duration);
                    chart1.Series.Add(br);
                }
                if (this.zmiejszenie.Checked)
                {
                    b.BubbleSort(malejace);
                    Series bm = new Series("babelkowe-malejace");
                    bm.Points.Add(b.Duration);
                    chart1.Series.Add(bm);
                }
                if (Losowo.Checked)
                {
                    b.BubbleSort(wylosowane);
                    Series bs = new Series("babelkowe-wylosowane");
                    bs.Points.Add(b.Duration);
                    chart1.Series.Add(bs);
                }
            }
            if (wstawka.Checked)
            {
                PrzezWstawianie w = new PrzezWstawianie();
                if (this.rosnaco.Checked)
                {
                    w.InsertionSort(rosnaco);
                    Series wr = new Series("WSTAWIANIE-rosnancy");
                    wr.Points.Add(w.Duration);
                    chart1.Series.Add(wr);
                }
                if (this.zmiejszenie.Checked)
                {
                    w.InsertionSort(malejace);
                    Series wm = new Series("WSTAWIANIE-malejace");
                    wm.Points.Add(w.Duration);
                    chart1.Series.Add(wm);
                }
                if (Losowo.Checked)
                {
                    w.InsertionSort(wylosowane);
                    Series ws = new Series("WSTAWIANIE-wylosowane");
                    ws.Points.Add(w.Duration);
                    chart1.Series.Add(ws);
                }
            }
            if (wybory.Checked)
            {
                wybsy pw = new wybsy();
                if (this.rosnaco.Checked)
                {
                    wybsy.BySelection(rosnaco);
                    Series pwr = new Series("MojeWybory-rosnancy");
                    pwr.Points.Add(pw.Duration);
                    chart1.Series.Add(pwr);
                }
                if (this.zmiejszenie.Checked)
                {
                    wybsy.BySelection(malejace);
                    Series wm = new Series("MojeWybory-malejace");
                    wm.Points.Add(pw.Duration);
                    chart1.Series.Add(wm);
                }
                if (Losowo.Checked)
                {
                    wybsy.BySelection(wylosowane);
                    Series ws = new Series("MojeWybory-wylosowane");
                    ws.Points.Add(pw.Duration);
                    chart1.Series.Add(ws);
                }
                if (Szybkie.Checked)
                {
                    sortszybki s = new sortszybki();
                    if (this.rosnaco.Checked)
                    {
                        s.QuickSort(rosnaco, 0, wielkosc - 1);
                        Series sr = new Series("szybkie-rosnace");
                        sr.Points.Add(s.Duration);
                        chart1.Series.Add(sr);
                    }
                    if (this.zmiejszenie.Checked)
                    {
                        s.QuickSort(malejace, 0, wielkosc - 1);
                        Series sm = new Series("szybkie-malejace");
                        sm.Points.Add(s.Duration);
                        chart1.Series.Add(sm);
                    }
                    if (Losowo.Checked)
                    {
                        s.QuickSort(wylosowane, 0, wielkosc - 1);
                        Series ss = new Series("szybkie-losowe");
                        ss.Points.Add(s.Duration);
                        chart1.Series.Add(ss);
                    }
                    if (scalenie.Checked)
                    {
                        merge m = new merge();
                        if (this.rosnaco.Checked)
                        {
                            merge.MergeSort(rosnaco);
                            Series pwr = new Series("MojeWybory-rosnancy");
                            pwr.Points.Add(m.Duration);
                            chart1.Series.Add(pwr);
                        }
                        if (this.zmiejszenie.Checked)
                        {
                            merge.MergeSort(malejace);
                            Series wm = new Series("MojeWybory-malejace");
                            wm.Points.Add(pw.Duration);
                            chart1.Series.Add(wm);
                        }
                        if (Losowo.Checked)
                        {
                            wybsy.BySelection(wylosowane);
                            Series ws = new Series("MojeWybory-wylosowane");
                            ws.Points.Add(pw.Duration);
                            chart1.Series.Add(ws);
                        }
                    }
                //MessageBox.
            }
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
        
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
           /* array = new int[100];
            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                this.array[i] = rnd.Next(1000);
            } */
        }//Losowe

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //ciagMalejacy.Generuj(10, 2, 5);
        }//Malejace

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //CiągRosnacy.Generuj(1, 2, 5);
        }//Rosnace

    private void chart1_Click(object sender, EventArgs e)
        {
           /* 
            chart1.Series.Clear();
            chart1.Series.Add("Losowe Liczby");

            for (int i = 0; i < array.Length; i++)
            {
                chart1.Series["Losowe Liczby"].Points.AddY(array[i]);
            }

            chart1.ChartAreas[0].AxisX.Title = "Indeks";
            chart1.ChartAreas[0].AxisY.Title = "Wartość"; 
           */
        }
    }
}
