
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace kolokwium
{
    public partial class Form1 : Form
    {
     
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

            int ile = 0;
            if (!rosn.Checked && !zmiejszenie.Checked && !Losowo.Checked)
            {
                MessageBox.Show("Jaki ciąg wybierasz?");
                return;
            }
            if (!sorBubbles.Checked && !wybory.Checked && !wstawienie.Checked && !Szybkie.Checked && !Scalenie.Checked)
            {
                MessageBox.Show("Jaki algorytm wybierasz?");
                return;
            }

            if (!int.TryParse(textBox1.Text, out ile))
            {
                MessageBox.Show("Ile liczb potrzebujesz?");
                return;
            }
            else
            {
                ile = Convert.ToInt32(textBox1.Text);
            }

            int[] losy = new int[ile];
            int[] up = new int[ile];
            int[] down = new int[ile];

           

            chart1.ChartAreas.First().AxisY.LabelStyle.Format = "0ms";
            

            if (this.rosn.Checked)
            {
                for (int i = 1; i < ile; i++)
                {
                    up[i] = i;
                }
            }
            if (this.zmiejszenie.Checked)
            {
                for (int i = ile - 1; i > 0; i--)
                {
                    down[i] = i;
                }
            }
            if (Losowo.Checked)
            {
                Random rnd = new Random();

                int strt = 0;
                int end = ile + 1;
                for (int i = 0; i < ile - 1; i++)
                {

                    losy[i] = rnd.Next(strt, end);

                }
            }
            void WykonajSortowanieBabelkowe(string nazwaSerii, Action<Bubble> metodaSortowania)
            {
                Bubble b = new Bubble();
                metodaSortowania(b);

                Series seria = new Series(nazwaSerii);
                seria.Points.Add(b.Zhonyi);
                chart1.Series.Clear(); 
                chart1.Series.Add(seria);
            }

            if (Losowo.Checked)
            {
                WykonajSortowanieBabelkowe("Babelkowe Losowe", b => b.srtBubble(losy));
            }
            else if (rosn.Checked)
            {
                WykonajSortowanieBabelkowe("Babelkowe Rosnace", b => b.srtBubble(up));
            }
            else if (zmiejszenie.Checked)
            {
                WykonajSortowanieBabelkowe("Babelkowe Malejace", b => b.srtBubble(down));
            }




            void WykonajSortowaniePrzezWstawianie(string nazwaSerii, Action<PrzezWstawianie> metodaSortowania)
            {
                PrzezWstawianie w = new PrzezWstawianie();
                metodaSortowania(w);

                Series seria = new Series(nazwaSerii);
                seria.Points.Add(w.Zhonyi);
                chart1.Series.Clear();
                chart1.Series.Add(seria);
            }

            if (wstawienie.Checked)
            {
                if (rosn.Checked)
                {
                    WykonajSortowaniePrzezWstawianie("PrzezWstawienie Rosnacy", w => w.srtWstawianie(up));
                }
                else if (zmiejszenie.Checked)
                {
                    WykonajSortowaniePrzezWstawianie("PrzezWstawienie Malejace", w => w.srtWstawianie(down));
                }
                else if (Losowo.Checked)
                {
                    WykonajSortowaniePrzezWstawianie("PrzezWstawienie Losowe", w => w.srtWstawianie(losy));
                }
            }

            void WykonajSortowaniePrzezWybieranie(string nazwaSerii, Action<PrzezWybory> metodaSortowania)
            {
                PrzezWybory pw = new PrzezWybory();
                metodaSortowania(pw);

                Series seria = new Series(nazwaSerii);
                seria.Points.Add(pw.Zhonyi);
                chart1.Series.Clear();
                chart1.Series.Add(seria);
            }

            if (wybory.Checked)
            {
                if (rosn.Checked)
                {
                    WykonajSortowaniePrzezWybieranie("PrzezWybor Rosnacy", w => w.srtwybory(up));
                }
                else if (zmiejszenie.Checked)
                {
                    WykonajSortowaniePrzezWybieranie("PrzezWybor Malejace", w => w.srtwybory(down));
                }
                else if (Losowo.Checked)
                {
                    WykonajSortowaniePrzezWybieranie("PrzezWybor Losowe", w => w.srtwybory(losy));
                }
            }

            void WykonajSortowanieSzybkie(string nazwaSerii, Action<srtszybki> metodaSortowania)
            {
                srtszybki s = new srtszybki();
                metodaSortowania(s);

                Series seria = new Series(nazwaSerii);
                seria.Points.Add(s.Zhonyi);
                chart1.Series.Clear();
                chart1.Series.Add(seria);
            }

            if (Szybkie.Checked)
            {
                if (rosn.Checked)
                {
                    WykonajSortowanieSzybkie("Szybkie Rosnace", s => s.qckSort(up, 0, ile - 1));
                }
                else if (zmiejszenie.Checked)
                {
                    WykonajSortowanieSzybkie("Szybkie Malejace", s => s.qckSort(down, 0, ile - 1));
                }
                else if (Losowo.Checked)
                {
                    WykonajSortowanieSzybkie("Szybkie Losowe", s => s.qckSort(losy, 0, ile - 1));
                }
            }

            void WykonajSortowanieScalanie(string nazwaSerii, Action<marge> metodaSortowania)
            {
                marge c = new marge();
                metodaSortowania(c);

                Series seria = new Series(nazwaSerii);
                seria.Points.Add(c.Zhonyi);
                chart1.Series.Clear();
                chart1.Series.Add(seria);
            }

            if (Scalenie.Checked)
            {
                if (rosn.Checked)
                {
                    WykonajSortowanieScalanie("PrzezScalenie Rosnące", c => c.srtmarge(up, 0, ile - 1));
                }
                else if (zmiejszenie.Checked)
                {
                    WykonajSortowanieScalanie("PrzezScalenie Malejace", c => c.srtmarge(down, 0, ile - 1));
                }
                else if (Losowo.Checked)
                {
                    WykonajSortowanieScalanie("PrzezScalenie Losowe", c => c.srtmarge(losy, 0, ile - 1));
                }
            }



        }
    }
        }
    


