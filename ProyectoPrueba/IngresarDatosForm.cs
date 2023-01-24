using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrueba
{
    public partial class IngresarDatosForm : Form
    {
        public IngresarDatosForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = labelIngresarProducto.Text;
            int precio = int.Parse(labelIngresarPrecio.Text);
            DateTime fecha = datetimeFecha.Value;
            int day = fecha.Day;
            int month = fecha.Month;
            int year = fecha.Year;
        }
    }
}
