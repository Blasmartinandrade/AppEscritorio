using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrueba
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            Menu.Renderer = new MiRenderizador();
        }

        //SALIR
        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //MOVER FORM

        bool val = false;
        private void Arrastrar_MouseDown(object sender, MouseEventArgs e)
        {
            val = true;

        }

        private void Arrastrar_MouseMove(object sender, MouseEventArgs e)
        {
            if (val == true)
            {
                this.Location = Cursor.Position;
            }

        }

        private void Arrastrar_MouseUp(object sender, MouseEventArgs e)
        {
            val = false;


        }


        private class MiRenderizador : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                if (!e.Item.Selected) base.OnRenderMenuItemBackground(e);
                else
                {
                    Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                    e.Graphics.FillRectangle(Brushes.SeaGreen, rc); //Elige el color que desees
                    e.Graphics.DrawRectangle(Pens.Black, 1, 0, rc.Width - 2, rc.Height - 1);
                }
            }
        }

        private void menu_Mostrar_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void menu_Mostrar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimizar_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void btnCerrar_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            IngresarDatosForm ventana = new IngresarDatosForm();
            ventana.MdiParent = this;
            ventana.Show();
            cambiarADia.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\DIA.gif");
        }

        public virtual void cambiarADia_Click(object sender, EventArgs e)
        {
            

            



            if (menu_Ingresar.ForeColor == Color.White)
            {
                
                
                Form ActiveChild = this.ActiveMdiChild;
                if (ActiveChild.GetType() == typeof(IngresarDatosForm))
                {
                    
                }
                ActiveChild.BackColor = Color.White;
                this.BackColor = Color.White;
                Menu.BackColor = Color.White;
                menu_Ingresar.ForeColor = Color.Black;
                mostrarDatosToolStripMenuItem.ForeColor = Color.Black;
                Logo.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\ICONO.png");
                btnMinimizar.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\menos.png");
                btnCerrar.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\cruz.png");
                cambiarADia.BackColor = Color.White;
                menu_Ingresar.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\capas.png");
                mostrarDatosToolStripMenuItem.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\grafico-histograma.png");
                if (mostrarDatosToolStripMenuItem.BackColor == Color.FromArgb(0, 200, 130))
                {
                    mostrarDatosToolStripMenuItem.BackColor = Color.FromArgb(0, 200, 130);

                }
                else
                {
                    mostrarDatosToolStripMenuItem.BackColor = Color.White;
                }
                if (menu_Ingresar.BackColor == Color.FromArgb(0, 200, 130))
                {
                    menu_Ingresar.BackColor = Color.FromArgb(0, 200, 130);


                }
                else
                {
                    menu_Ingresar.BackColor = Color.White;
                }

                
            }
            else
            {
                Form ActiveChild = this.ActiveMdiChild;
                ActiveChild.BackColor = Color.FromArgb(10, 0, 35);
                mostrarDatosToolStripMenuItem.Image = global::ProyectoPrueba.Properties.Resources.chart_histogram;
                menu_Ingresar.Image = global::ProyectoPrueba.Properties.Resources.layers;
                Color menu_anterior = new Color();
                menu_anterior = Color.FromArgb(10, 0, 30);
                Color form_anterior = new Color();
                form_anterior = Color.FromArgb(10, 0, 35);
                Menu.BackColor = menu_anterior;
                this.BackColor = form_anterior;
                menu_Ingresar.ForeColor = Color.White;
                mostrarDatosToolStripMenuItem.ForeColor = Color.White;
                btnMinimizar.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\minus.png");
                Logo.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\iconDark.png");
                btnCerrar.Image = Image.FromFile("C:\\Users\\blasm\\OneDrive\\Escritorio\\Escritorio\\software\\c#nivel2\\ProyectoPrueba\\ProyectoPrueba\\IMG\\cross.png");
                cambiarADia.BackColor = menu_anterior;
                if (mostrarDatosToolStripMenuItem.BackColor == Color.FromArgb(0, 200, 130))
                {
                    mostrarDatosToolStripMenuItem.BackColor = Color.FromArgb(0, 200, 130);

                }
                else
                {
                    mostrarDatosToolStripMenuItem.BackColor = Color.FromArgb(10, 0, 30);
                }
                if (menu_Ingresar.BackColor == Color.FromArgb(0, 200, 130))
                {
                    menu_Ingresar.BackColor = Color.FromArgb(0, 200, 130);


                }
                else
                {
                    menu_Ingresar.BackColor = Color.FromArgb(10, 0, 30);
                }


            }
            
            
        }

        private void menu_Ingresar_Click(object sender, EventArgs e)
        {
            

            foreach(var item in Application.OpenForms)
            {
                if(item.GetType() == typeof(IngresarDatosForm))
                {
                    return;
                }
            }
            Form activeChild = this.ActiveMdiChild;
            activeChild.Close();
            IngresarDatosForm ventana = new IngresarDatosForm();
            
            ventana.MdiParent = this;
            ventana.Show();
            if (Menu.BackColor == Color.White)
            {
                ventana.BackColor = Color.White;
                mostrarDatosToolStripMenuItem.BackColor = Color.White;
                menu_Ingresar.BackColor = Color.FromArgb(0, 200, 130);
            }
            else
            {
                mostrarDatosToolStripMenuItem.BackColor = Color.FromArgb(10, 0, 30);
                menu_Ingresar.BackColor = Color.FromArgb(0, 200, 130);
                ventana.BackColor = Color.FromArgb(10, 0, 35);
            }

        }

        private void mostrarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(MostrarDatosForm))
                {
                    return;
                }
            }
            Form activeChild = this.ActiveMdiChild;
            activeChild.Close();
            MostrarDatosForm ventana = new MostrarDatosForm();
            
            ventana.MdiParent = this;
            ventana.Show();
            if (Menu.BackColor == Color.White)
            {
                ventana.BackColor = Color.White;
                menu_Ingresar.BackColor = Color.White;
                mostrarDatosToolStripMenuItem.BackColor = Color.FromArgb(0, 200, 130);
            }
            else
            {
                menu_Ingresar.BackColor = Color.FromArgb(10, 0, 30);
                mostrarDatosToolStripMenuItem.BackColor = Color.FromArgb(0, 200, 130);
                ventana.BackColor = Color.FromArgb(10, 0, 35);
            }

        }
    }
}
