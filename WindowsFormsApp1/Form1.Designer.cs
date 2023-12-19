using System;

namespace zalek
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Losowo = new System.Windows.Forms.CheckBox();
            this.zmiejszenie = new System.Windows.Forms.CheckBox();
            this.rosnaco = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Scalenie = new System.Windows.Forms.CheckBox();
            this.Szybkie = new System.Windows.Forms.CheckBox();
            this.wstawka = new System.Windows.Forms.CheckBox();
            this.wybory = new System.Windows.Forms.CheckBox();
            this.sorBubbles = new System.Windows.Forms.CheckBox();
            this.Start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(242, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(546, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
//            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Losowo);
            this.groupBox1.Controls.Add(this.zmiejszenie);
            this.groupBox1.Controls.Add(this.rosnaco);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rodzaj ciagu";
//            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Losowo
            // 
            this.Losowo.AutoSize = true;
            this.Losowo.Location = new System.Drawing.Point(7, 68);
            this.Losowo.Name = "Losowo";
            this.Losowo.Size = new System.Drawing.Size(63, 17);
            this.Losowo.TabIndex = 2;
            this.Losowo.Text = "Losowe";
            this.Losowo.UseVisualStyleBackColor = true;
//            this.Losowo.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // zmiejszenie
            // 
            this.zmiejszenie.AutoSize = true;
            this.zmiejszenie.Location = new System.Drawing.Point(6, 43);
            this.zmiejszenie.Name = "zmiejszenie";
            this.zmiejszenie.Size = new System.Drawing.Size(69, 17);
            this.zmiejszenie.TabIndex = 1;
            this.zmiejszenie.Text = "Malejące";
            this.zmiejszenie.UseVisualStyleBackColor = true;
//            this.zmiejszenie.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // rosnaco
            // 
            this.rosnaco.AutoSize = true;
            this.rosnaco.Location = new System.Drawing.Point(7, 20);
            this.rosnaco.Name = "rosnaco";
            this.rosnaco.Size = new System.Drawing.Size(69, 17);
            this.rosnaco.TabIndex = 0;
            this.rosnaco.Text = "Rosnące";
            this.rosnaco.UseVisualStyleBackColor = true;
//            this.rosnaco.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Scalenie);
            this.groupBox2.Controls.Add(this.Szybkie);
            this.groupBox2.Controls.Add(this.wstawka);
            this.groupBox2.Controls.Add(this.wybory);
            this.groupBox2.Controls.Add(this.sorBubbles);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 159);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rodzaj Sortowania";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Scalenie
            // 
            this.Scalenie.AutoSize = true;
            this.Scalenie.Location = new System.Drawing.Point(7, 130);
            this.Scalenie.Name = "Scalenie";
            this.Scalenie.Size = new System.Drawing.Size(94, 17);
            this.Scalenie.TabIndex = 4;
            this.Scalenie.Text = "Przez scalanie";
            this.Scalenie.UseVisualStyleBackColor = true;
            // 
            // Szybkie
            // 
            this.Szybkie.AutoSize = true;
            this.Szybkie.Location = new System.Drawing.Point(7, 106);
            this.Szybkie.Name = "Szybkie";
            this.Szybkie.Size = new System.Drawing.Size(63, 17);
            this.Szybkie.TabIndex = 3;
            this.Szybkie.Text = "Szybkie";
            this.Szybkie.UseVisualStyleBackColor = true;
            // 
            // wstawka
            // 
            this.wstawka.AutoSize = true;
            this.wstawka.Location = new System.Drawing.Point(7, 82);
            this.wstawka.Name = "wstawka";
            this.wstawka.Size = new System.Drawing.Size(107, 17);
            this.wstawka.TabIndex = 2;
            this.wstawka.Text = "Przez wstawienie";
            this.wstawka.UseVisualStyleBackColor = true;
            // 
            // wybory
            // 
            this.wybory.AutoSize = true;
            this.wybory.Location = new System.Drawing.Point(7, 58);
            this.wybory.Name = "wybory";
            this.wybory.Size = new System.Drawing.Size(83, 17);
            this.wybory.TabIndex = 1;
            this.wybory.Text = "Przez wybor";
            this.wybory.UseVisualStyleBackColor = true;
            // 
            // sorBubbles
            // 
            this.sorBubbles.AutoSize = true;
            this.sorBubbles.Location = new System.Drawing.Point(7, 34);
            this.sorBubbles.Name = "sorBubbles";
            this.sorBubbles.Size = new System.Drawing.Size(59, 17);
            this.sorBubbles.TabIndex = 0;
            this.sorBubbles.Text = "Bubble";
            this.sorBubbles.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(76, 360);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }


       
        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox rosnaco;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Losowo;
        private System.Windows.Forms.CheckBox zmiejszenie;
        private System.Windows.Forms.CheckBox Scalenie;
        private System.Windows.Forms.CheckBox Szybkie;
        private System.Windows.Forms.CheckBox wstawka;
        private System.Windows.Forms.CheckBox wybory;
        private System.Windows.Forms.CheckBox sorBubbles;
        private System.Windows.Forms.Button Start;

    }
}

