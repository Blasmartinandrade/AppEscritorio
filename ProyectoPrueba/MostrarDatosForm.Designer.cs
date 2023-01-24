using System;

namespace ProyectoPrueba
{
    partial class MostrarDatosForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.botonPrueba = new System.Windows.Forms.Button();
            this.cajaPrueba = new System.Windows.Forms.TextBox();
            this.labelPorcentaje1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNumeroAlto = new System.Windows.Forms.Label();
            this.cajaNumero = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelTbPorcentaje = new System.Windows.Forms.Label();
            this.labelTbPrecio = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPrecio2 = new System.Windows.Forms.Label();
            this.cajaNumero2 = new System.Windows.Forms.TextBox();
            this.labelNumeroMinimo = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelNumeroMaximo = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonPrueba
            // 
            this.botonPrueba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.botonPrueba.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.botonPrueba.ForeColor = System.Drawing.SystemColors.Control;
            this.botonPrueba.Location = new System.Drawing.Point(68, 202);
            this.botonPrueba.Name = "botonPrueba";
            this.botonPrueba.Size = new System.Drawing.Size(69, 25);
            this.botonPrueba.TabIndex = 1;
            this.botonPrueba.Text = "Ver";
            this.botonPrueba.UseVisualStyleBackColor = false;
            this.botonPrueba.Click += new System.EventHandler(this.botonPrueba_Click);
            // 
            // cajaPrueba
            // 
            this.cajaPrueba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.cajaPrueba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cajaPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cajaPrueba.ForeColor = System.Drawing.SystemColors.Menu;
            this.cajaPrueba.Location = new System.Drawing.Point(45, 49);
            this.cajaPrueba.Name = "cajaPrueba";
            this.cajaPrueba.Size = new System.Drawing.Size(117, 24);
            this.cajaPrueba.TabIndex = 2;
            this.cajaPrueba.Click += new System.EventHandler(this.cajaPrueba_Click);
            // 
            // labelPorcentaje1
            // 
            this.labelPorcentaje1.AutoSize = true;
            this.labelPorcentaje1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelPorcentaje1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.labelPorcentaje1.Location = new System.Drawing.Point(430, 76);
            this.labelPorcentaje1.Name = "labelPorcentaje1";
            this.labelPorcentaje1.Size = new System.Drawing.Size(41, 25);
            this.labelPorcentaje1.TabIndex = 4;
            this.labelPorcentaje1.Text = "0%";
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(35)))));
            this.chart1.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chart1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            this.chart1.BackSecondaryColor = System.Drawing.Color.Gainsboro;
            this.chart1.CausesValidation = false;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.None;
            chartArea1.Area3DStyle.Rotation = 1;
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.DarkOrange;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsMarksNextToAxis = false;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 5;
            chartArea1.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DarkOrange;
            chartArea1.AxisX.LabelStyle.Interval = 0D;
            chartArea1.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea1.AxisX.LineColor = System.Drawing.Color.DarkOrange;
            chartArea1.AxisX.MaximumAutoSize = 10F;
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(28)))), ((int)(((byte)(0)))));
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            chartArea1.AxisX.ScrollBar.Size = 10D;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Orange;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.DarkOrange;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.DarkOrange;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Aquamarine;
            chartArea1.AxisY.MaximumAutoSize = 10F;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.OldLace;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Orange;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.DarkOrange;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(35)))));
            chartArea1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Percent80;
            chartArea1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(35)))));
            chartArea1.BorderColor = System.Drawing.Color.Olive;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(35)))));
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(140)))));
            legend1.HeaderSeparatorColor = System.Drawing.Color.Transparent;
            legend1.IsDockedInsideChartArea = false;
            legend1.IsTextAutoFit = false;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 233);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BorderColor = System.Drawing.Color.White;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.CustomProperties = "LabelStyle=Left, IsXAxisQuantitative=False";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F);
            series1.LabelForeColor = System.Drawing.Color.Goldenrod;
            series1.Legend = "Legend1";
            series1.LegendText = "Precio";
            series1.MarkerBorderColor = System.Drawing.Color.FloralWhite;
            series1.MarkerColor = System.Drawing.Color.Aqua;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.MarkerColor = System.Drawing.Color.DeepPink;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Precio 2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(541, 216);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(386, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelNumeroAlto
            // 
            this.labelNumeroAlto.AutoSize = true;
            this.labelNumeroAlto.Font = new System.Drawing.Font("Verdana", 7F);
            this.labelNumeroAlto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.labelNumeroAlto.Location = new System.Drawing.Point(44, 76);
            this.labelNumeroAlto.Name = "labelNumeroAlto";
            this.labelNumeroAlto.Size = new System.Drawing.Size(19, 12);
            this.labelNumeroAlto.TabIndex = 6;
            this.labelNumeroAlto.Text = "24";
            // 
            // cajaNumero
            // 
            this.cajaNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.cajaNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cajaNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cajaNumero.ForeColor = System.Drawing.Color.White;
            this.cajaNumero.Location = new System.Drawing.Point(46, 113);
            this.cajaNumero.Name = "cajaNumero";
            this.cajaNumero.Size = new System.Drawing.Size(116, 24);
            this.cajaNumero.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.DarkOrange;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePicker1.Location = new System.Drawing.Point(45, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 24);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // labelTbPorcentaje
            // 
            this.labelTbPorcentaje.AutoSize = true;
            this.labelTbPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTbPorcentaje.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelTbPorcentaje.Location = new System.Drawing.Point(43, 26);
            this.labelTbPorcentaje.Name = "labelTbPorcentaje";
            this.labelTbPorcentaje.Size = new System.Drawing.Size(76, 17);
            this.labelTbPorcentaje.TabIndex = 15;
            this.labelTbPorcentaje.Text = "Porcentaje";
            // 
            // labelTbPrecio
            // 
            this.labelTbPrecio.AutoSize = true;
            this.labelTbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTbPrecio.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelTbPrecio.Location = new System.Drawing.Point(42, 93);
            this.labelTbPrecio.Name = "labelTbPrecio";
            this.labelTbPrecio.Size = new System.Drawing.Size(48, 17);
            this.labelTbPrecio.TabIndex = 16;
            this.labelTbPrecio.Text = "Precio";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(467, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 25);
            this.button1.TabIndex = 17;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPrecio2
            // 
            this.labelPrecio2.AutoSize = true;
            this.labelPrecio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPrecio2.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelPrecio2.Location = new System.Drawing.Point(180, 26);
            this.labelPrecio2.Name = "labelPrecio2";
            this.labelPrecio2.Size = new System.Drawing.Size(60, 17);
            this.labelPrecio2.TabIndex = 18;
            this.labelPrecio2.Text = "Precio 2";
            // 
            // cajaNumero2
            // 
            this.cajaNumero2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.cajaNumero2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cajaNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cajaNumero2.ForeColor = System.Drawing.Color.White;
            this.cajaNumero2.Location = new System.Drawing.Point(183, 49);
            this.cajaNumero2.Name = "cajaNumero2";
            this.cajaNumero2.Size = new System.Drawing.Size(116, 24);
            this.cajaNumero2.TabIndex = 19;
            // 
            // labelNumeroMinimo
            // 
            this.labelNumeroMinimo.AutoSize = true;
            this.labelNumeroMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNumeroMinimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.labelNumeroMinimo.Location = new System.Drawing.Point(35, 21);
            this.labelNumeroMinimo.Name = "labelNumeroMinimo";
            this.labelNumeroMinimo.Size = new System.Drawing.Size(16, 17);
            this.labelNumeroMinimo.TabIndex = 14;
            this.labelNumeroMinimo.Text = "2";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMin.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelMin.Location = new System.Drawing.Point(-2, 21);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(38, 17);
            this.labelMin.TabIndex = 12;
            this.labelMin.Text = "Min.:";
            // 
            // labelNumeroMaximo
            // 
            this.labelNumeroMaximo.AutoSize = true;
            this.labelNumeroMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelNumeroMaximo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(250)))), ((int)(((byte)(200)))));
            this.labelNumeroMaximo.Location = new System.Drawing.Point(35, 2);
            this.labelNumeroMaximo.Name = "labelNumeroMaximo";
            this.labelNumeroMaximo.Size = new System.Drawing.Size(21, 15);
            this.labelNumeroMaximo.TabIndex = 13;
            this.labelNumeroMaximo.Text = "13";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMax.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelMax.Location = new System.Drawing.Point(-2, 0);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(41, 17);
            this.labelMax.TabIndex = 11;
            this.labelMax.Text = "Max.:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelMax);
            this.panel1.Controls.Add(this.labelNumeroMaximo);
            this.panel1.Controls.Add(this.labelMin);
            this.panel1.Controls.Add(this.labelNumeroMinimo);
            this.panel1.Location = new System.Drawing.Point(386, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 76);
            this.panel1.TabIndex = 20;
            // 
            // MostrarDatosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(575, 451);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cajaNumero2);
            this.Controls.Add(this.labelPrecio2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTbPrecio);
            this.Controls.Add(this.labelTbPorcentaje);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cajaNumero);
            this.Controls.Add(this.labelNumeroAlto);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labelPorcentaje1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cajaPrueba);
            this.Controls.Add(this.botonPrueba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MostrarDatosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MostrarDatosForm";
            this.Load += new System.EventHandler(this.MostrarDatosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonPrueba;
        private System.Windows.Forms.TextBox cajaPrueba;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPorcentaje1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelNumeroAlto;
        private System.Windows.Forms.TextBox cajaNumero;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelTbPorcentaje;
        private System.Windows.Forms.Label labelTbPrecio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPrecio2;
        private System.Windows.Forms.TextBox cajaNumero2;
        private System.Windows.Forms.Label labelNumeroMinimo;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelNumeroMaximo;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Panel panel1;
    }
}