using System;

namespace WindowsFormsApp1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Losowe = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Scalenie = new System.Windows.Forms.CheckBox();
            this.Szybkie = new System.Windows.Forms.CheckBox();
            this.Wstawienie = new System.Windows.Forms.CheckBox();
            this.PrzezWybor = new System.Windows.Forms.CheckBox();
            this.Bubble = new System.Windows.Forms.CheckBox();
            this.Start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(242, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(546, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Losowe);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rodzaj ciagu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Losowe
            // 
            this.Losowe.AutoSize = true;
            this.Losowe.Location = new System.Drawing.Point(7, 68);
            this.Losowe.Name = "Losowe";
            this.Losowe.Size = new System.Drawing.Size(63, 17);
            this.Losowe.TabIndex = 2;
            this.Losowe.Text = "Losowe";
            this.Losowe.UseVisualStyleBackColor = true;
            this.Losowe.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 43);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(69, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Malejące";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Rosnące";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Scalenie);
            this.groupBox2.Controls.Add(this.Szybkie);
            this.groupBox2.Controls.Add(this.Wstawienie);
            this.groupBox2.Controls.Add(this.PrzezWybor);
            this.groupBox2.Controls.Add(this.Bubble);
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
            this.Szybkie.CheckedChanged += new System.EventHandler(this.Szybkie_CheckedChanged);
            // 
            // Wstawienie
            // 
            this.Wstawienie.AutoSize = true;
            this.Wstawienie.Location = new System.Drawing.Point(7, 82);
            this.Wstawienie.Name = "Wstawienie";
            this.Wstawienie.Size = new System.Drawing.Size(107, 17);
            this.Wstawienie.TabIndex = 2;
            this.Wstawienie.Text = "Przez wstawienie";
            this.Wstawienie.UseVisualStyleBackColor = true;
            // 
            // PrzezWybor
            // 
            this.PrzezWybor.AutoSize = true;
            this.PrzezWybor.Location = new System.Drawing.Point(7, 58);
            this.PrzezWybor.Name = "PrzezWybor";
            this.PrzezWybor.Size = new System.Drawing.Size(83, 17);
            this.PrzezWybor.TabIndex = 1;
            this.PrzezWybor.Text = "Przez wybor";
            this.PrzezWybor.UseVisualStyleBackColor = true;
            // 
            // Bubble
            // 
            this.Bubble.AutoSize = true;
            this.Bubble.Location = new System.Drawing.Point(7, 34);
            this.Bubble.Name = "Bubble";
            this.Bubble.Size = new System.Drawing.Size(59, 17);
            this.Bubble.TabIndex = 0;
            this.Bubble.Text = "Bubble";
            this.Bubble.UseVisualStyleBackColor = true;
            this.Bubble.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
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

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Szybkie_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Losowe;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox Scalenie;
        private System.Windows.Forms.CheckBox Szybkie;
        private System.Windows.Forms.CheckBox Wstawienie;
        private System.Windows.Forms.CheckBox PrzezWybor;
        private System.Windows.Forms.CheckBox Bubble;
        private System.Windows.Forms.Button Start;
    }
}

