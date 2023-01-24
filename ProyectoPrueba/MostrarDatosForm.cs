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

namespace ProyectoPrueba
{
    public partial class MostrarDatosForm : Form
    {
        public MostrarDatosForm()
        {
            InitializeComponent();
            //Chart....

            chart1.Series["Precio 2"].ChartType = SeriesChartType.Line;
            chart1.Series["Precio 2"].Color = Color.Red;
            
        }

        private void botonPrueba_Click(object sender, EventArgs e)
        {


            int nro = int.Parse(cajaPrueba.Text);


            if (nro <= 100)
            {
                cajaPrueba.Text = "";
                labelPorcentaje1.Text = nro.ToString() + "%";
                switch (nro)
                {
                    case 0:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\100.png");
                        break;
                    case 1:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\3.png");
                        break;
                    case 2:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\3.png");
                        break;
                    case 3:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\3.png");
                        break;
                    case 4:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\5.png");
                        break;
                    case 5:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\5.png");
                        break;
                    case 6:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\5.png");
                        break;
                    case 7:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\8.png");
                        break;
                    case 8:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\8.png");
                        break;
                    case 9:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\10.png");
                        break;
                    case 10:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\10.png");
                        break;
                    case 11:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\10.png");
                        break;
                    case 12:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\13.png");
                        break;
                    case 13:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\13.png");
                        break;
                    case 14:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\15.png");
                        break;
                    case 15:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\15.png");
                        break;
                    case 16:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\15.png");
                        break;
                    case 17:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\15.png");
                        break;
                    case 18:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\20.png");
                        break;
                    case 19:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\20.png");
                        break;
                    case 20:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\20.png");
                        break;
                    case 21:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\20.png");
                        break;
                    case 22:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\23.png");
                        break;
                    case 23:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\23.png");
                        break;
                    case 24:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\23.png");
                        break;
                    case 25:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\25.png");
                        break;
                    case 26:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\25.png");
                        break;
                    case 27:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\27.png");
                        break;
                    case 28:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\27.png");
                        break;
                    case 29:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\30.png");
                        break;
                    case 30:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\30.png");
                        break;
                    case 31:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\30.png");
                        break;
                    case 32:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\33.png");
                        break;
                    case 33:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\33.png");
                        break;
                    case 34:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\35.png");
                        break;
                    case 35:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\35.png");
                        break;
                    case 36:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\35.png");
                        break;
                    case 37:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\40.png");
                        break;
                    case 38:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\40.png");
                        break;
                    case 39:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\40.png");
                        break;
                    case 40:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\40.png");
                        break;
                    case 41:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\40.png");
                        break;
                    case 42:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\43.png");
                        break;
                    case 43:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\43.png");
                        break;
                    case 44:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\43.png");
                        break;
                    case 45:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\45.png");
                        break;
                    case 46:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\45.png");
                        break;
                    case 47:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\47.png");
                        break;
                    case 48:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\49.png");
                        break;
                    case 49:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\49.png");
                        break;
                    case 50:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\50.png");
                        break;
                    case 51:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\50.png");
                        break;
                    case 52:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\53.png");
                        break;
                    case 53:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\53.png");
                        break;
                    case 54:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\53.png");
                        break;
                    case 55:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\55.png");
                        break;
                    case 56:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\55.png");
                        break;
                    case 57:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\57.png");
                        break;
                    case 58:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\57.png");
                        break;
                    case 59:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\60.png");
                        break;
                    case 60:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\60.png");
                        break;
                    case 61:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\60.png");
                        break;
                    case 62:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\63.png");
                        break;
                    case 63:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\63.png");
                        break;
                    case 64:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\63.png");
                        break;
                    case 65:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\66.png");
                        break;
                    case 66:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\66.png");
                        break;
                    case 67:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\66.png");
                        break;
                    case 68:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\66.png");
                        break;
                    case 69:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\70.png");
                        break;
                    case 70:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\70.png");
                        break;
                    case 71:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\70.png");
                        break;
                    case 72:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\73.png");
                        break;
                    case 73:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\73.png");
                        break;
                    case 74:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\73.png");
                        break;
                    case 75:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\75.png");
                        break;
                    case 76:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\75.png");
                        break;
                    case 77:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\78.png");
                        break;
                    case 78:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\78.png");
                        break;
                    case 79:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\78.png");
                        break;
                    case 80:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\80.png");
                        break;
                    case 81:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\80.png");
                        break;
                    case 82:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\83.png");
                        break;
                    case 83:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\83.png");
                        break;
                    case 84:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\83.png");
                        break;
                    case 85:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\85.png");
                        break;
                    case 86:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\85.png");
                        break;
                    case 87:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\88.png");
                        break;
                    case 88:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\88.png");
                        break;
                    case 89:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\88.png");
                        break;
                    case 90:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\90.png");
                        break;
                    case 91:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\90.png");
                        break;
                    case 92:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\92.png");
                        break;
                    case 93:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\94.png");
                        break;
                    case 94:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\94.png");
                        break;
                    case 95:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\95.png");
                        break;
                    case 96:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\96.png");
                        break;
                    case 97:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\97.png");
                        break;
                    case 98:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\98.png");
                        break;
                    case 99:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\99.png");
                        break;
                    case 100:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\0.png");
                        break;
                    default:
                        break;




                }

            }
            else
            {
                labelNumeroAlto.Text = "X El numero debe ser menor o igual a 100";
            }



            //Charting

            //string[] series = { "Eduardo", "Jose", "Fernando" };
            //int[] point = { 24, 14, 78 };
            //chart1.Palette = ChartColorPalette.SeaGreen;
            //chart1.Titles.Add("Edades");

            //for(int i = 0; i < series.Length; i++)
            //{
            //    Series serie = chart1.Series.Add(series[i]);
            //    serie.Label = point[i].ToString();
            //    serie.Points.Add(point[i]);
            //}
            DateTime fecha = dateTimePicker1.Value;
            string day = fecha.Day.ToString();
            string month = fecha.Month.ToString();
            string year = fecha.Year.ToString();
            int numero = int.Parse(cajaNumero.Text);

            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add(day + "-" + month + "-" + year, numero);


            if (chart1.Series["Series1"].Points.Count == 10)
            {
                chart1.Series["Precio 2"].Points.Clear();
                chart1.Series["Series1"].Points.Clear();


            }
            chart1.Series["Series1"].ChartType = SeriesChartType.Line; // Tipo de grafica: Bar, Column
            chart1.Series["Series1"].BorderWidth = 1; // Borde de la grafica
            chart1.Series["Series1"].Color = Color.SeaGreen; // Color de la grafica
            chart1.Series["Series1"].LegendText = "Precio"; // Label o etiqueta
            chart1.Series["Series1"].LabelForeColor = Color.SeaGreen;

            foreach (KeyValuePair<string, int> d in dic)
            {
                chart1.Series["Series1"].Points.AddXY(d.Key, d.Value);
            }
            int numero2 = int.Parse(cajaNumero2.Text);
            Dictionary<string, int> dic2 = new Dictionary<string, int>();
            dic2.Add(day + "--" + month + "-" + year, numero2);

            foreach (KeyValuePair<string, int> d in dic2)
            {
                chart1.Series["Precio 2"].Points.AddXY(d.Key, d.Value);
            }





        }

        private void MostrarDatosForm_Load(object sender, EventArgs e)
        {
            //Charting

            //string[] series = { "Eduardo", "Jose", "Fernando" };
            //int[] point = { 24, 14, 78 };
            //chart1.Palette = ChartColorPalette.SeaGreen;
            //chart1.Titles.Add("Edades");

            //for(int i = 0; i < series.Length; i++)
            //{
            //    Series serie = chart1.Series.Add(series[i]);
            //    serie.Label = point[i].ToString();
            //    serie.Points.Add(point[i]);
            //}
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("19-FEB-2017", 576);
            dic.Add("20-FEB-2017", 1087);
            dic.Add("21-FEB-2017", 1061);
            dic.Add("22-FEB-2017", 660);
            dic.Add("23-FEB-2017", 774);
            dic.Add("24-FEB-2017", 576);
            dic.Add("25-FEB-2017", 887);
            dic.Add("26-FEB-2017", 561);
            dic.Add("27-FEB-2017", 1060);
            dic.Add("28-FEB-2017", 274);

            if (chart1.Series["Series1"].Points.Count == dic.Count)
            {
               
                chart1.Series["Series1"].Points.Clear();
                chart1.Series["Precio 2"].Points.Clear();


            }
            chart1.Series["Series1"].ChartType = SeriesChartType.Line; // Tipo de grafica: Bar, Column
            chart1.Series["Series1"].BorderWidth = 1; // Borde de la grafica
            chart1.Series["Series1"].Color = Color.SeaGreen; // Color de la grafica
            chart1.Series["Series1"].LegendText = "Precio"; // Label o etiqueta
            chart1.Series["Series1"].LabelForeColor = Color.SeaGreen;
            labelNumeroAlto.Text = "";



            foreach (KeyValuePair<string, int> d in dic)
            {
                chart1.Series["Series1"].Points.AddXY(d.Key, d.Value);
            }
            
            pictureBox1.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\Graficos\\Circles\\100.png");


            chart1.Series["Precio 2"].ChartType = SeriesChartType.Line;

            foreach(KeyValuePair<string, int> d in dic)
            {
                chart1.Series["Precio 2"].Points.AddXY(d.Key, d.Value);
            }
        
        }

        private void cajaPrueba_Click(object sender, EventArgs e)
        {
            labelNumeroAlto.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Precio 2"].Points.Clear();
        }
    }
}
