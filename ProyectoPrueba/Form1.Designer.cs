namespace ProyectoPrueba
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.menu_Ingresar = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.line1 = new System.Windows.Forms.Panel();
            this.line2 = new System.Windows.Forms.Panel();
            this.line3 = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.cambiarADia = new System.Windows.Forms.PictureBox();
            this.Arrastrar = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cambiarADia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrastrar)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.Menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Ingresar,
            this.mostrarDatosToolStripMenuItem});
            this.Menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Margin = new System.Windows.Forms.Padding(0, 200, 0, 100);
            this.Menu.MinimumSize = new System.Drawing.Size(130, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(0, 27, 0, 0);
            this.Menu.Size = new System.Drawing.Size(164, 506);
            this.Menu.TabIndex = 0;
            // 
            // menu_Ingresar
            // 
            this.menu_Ingresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.25F);
            this.menu_Ingresar.ForeColor = System.Drawing.Color.White;
            this.menu_Ingresar.Image = global::ProyectoPrueba.Properties.Resources.layers;
            this.menu_Ingresar.Margin = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.menu_Ingresar.Name = "menu_Ingresar";
            this.menu_Ingresar.Padding = new System.Windows.Forms.Padding(4, 20, 4, 5);
            this.menu_Ingresar.Size = new System.Drawing.Size(163, 53);
            this.menu_Ingresar.Text = "Ingresar datos";
            this.menu_Ingresar.Click += new System.EventHandler(this.menu_Ingresar_Click);
            this.menu_Ingresar.MouseLeave += new System.EventHandler(this.menu_Mostrar_MouseLeave);
            this.menu_Ingresar.MouseHover += new System.EventHandler(this.menu_Mostrar_MouseHover);
            // 
            // mostrarDatosToolStripMenuItem
            // 
            this.mostrarDatosToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.25F);
            this.mostrarDatosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mostrarDatosToolStripMenuItem.Image = global::ProyectoPrueba.Properties.Resources.chart_histogram;
            this.mostrarDatosToolStripMenuItem.Name = "mostrarDatosToolStripMenuItem";
            this.mostrarDatosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 20, 4, 5);
            this.mostrarDatosToolStripMenuItem.Size = new System.Drawing.Size(163, 53);
            this.mostrarDatosToolStripMenuItem.Text = "Mostrar Datos";
            this.mostrarDatosToolStripMenuItem.Click += new System.EventHandler(this.mostrarDatosToolStripMenuItem_Click);
            this.mostrarDatosToolStripMenuItem.MouseLeave += new System.EventHandler(this.menu_Mostrar_MouseLeave);
            this.mostrarDatosToolStripMenuItem.MouseHover += new System.EventHandler(this.menu_Mostrar_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.panel1.Location = new System.Drawing.Point(158, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 503);
            this.panel1.TabIndex = 0;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.line1.Location = new System.Drawing.Point(0, 104);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(157, 2);
            this.line1.TabIndex = 0;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.line2.Location = new System.Drawing.Point(0, 156);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(157, 2);
            this.line2.TabIndex = 0;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.line3.Location = new System.Drawing.Point(0, 212);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(157, 2);
            this.line3.TabIndex = 8;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.panelBottom.Location = new System.Drawing.Point(158, 496);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(587, 10);
            this.panelBottom.TabIndex = 11;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.panelRight.Controls.Add(this.btnCerrar);
            this.panelRight.Location = new System.Drawing.Point(735, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(11, 503);
            this.panelRight.TabIndex = 12;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnCerrar.Image = global::ProyectoPrueba.Properties.Resources.cross1;
            this.btnCerrar.Location = new System.Drawing.Point(1, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(10, 10);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            this.btnCerrar.MouseHover += new System.EventHandler(this.btnCerrar_MouseHover);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnMinimizar.Image = global::ProyectoPrueba.Properties.Resources.minus1;
            this.btnMinimizar.Location = new System.Drawing.Point(724, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(13, 12);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            this.btnMinimizar.MouseLeave += new System.EventHandler(this.btnMinimizar_MouseLeave);
            this.btnMinimizar.MouseHover += new System.EventHandler(this.btnMinimizar_MouseHover);
            // 
            // Logo
            // 
            this.Logo.Image = global::ProyectoPrueba.Properties.Resources.IconDark;
            this.Logo.Location = new System.Drawing.Point(32, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(84, 70);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 7;
            this.Logo.TabStop = false;
            // 
            // cambiarADia
            // 
            this.cambiarADia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.cambiarADia.Location = new System.Drawing.Point(128, 471);
            this.cambiarADia.Name = "cambiarADia";
            this.cambiarADia.Size = new System.Drawing.Size(24, 23);
            this.cambiarADia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cambiarADia.TabIndex = 6;
            this.cambiarADia.TabStop = false;
            this.cambiarADia.Click += new System.EventHandler(this.cambiarADia_Click);
            this.cambiarADia.MouseLeave += new System.EventHandler(this.btnMinimizar_MouseLeave);
            this.cambiarADia.MouseHover += new System.EventHandler(this.btnMinimizar_MouseHover);
            // 
            // Arrastrar
            // 
            this.Arrastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.Arrastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Arrastrar.Location = new System.Drawing.Point(158, 0);
            this.Arrastrar.Name = "Arrastrar";
            this.Arrastrar.Size = new System.Drawing.Size(576, 12);
            this.Arrastrar.TabIndex = 2;
            this.Arrastrar.TabStop = false;
            this.Arrastrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastrar_MouseDown);
            this.Arrastrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Arrastrar_MouseMove);
            this.Arrastrar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Arrastrar_MouseUp);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(746, 506);
            this.ControlBox = false;
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cambiarADia);
            this.Controls.Add(this.Arrastrar);
            this.Controls.Add(this.Menu);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menu;
            this.Name = "frmPrincipal";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANALITYCS";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cambiarADia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrastrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Arrastrar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox cambiarADia;
        private System.Windows.Forms.ToolStripMenuItem mostrarDatosToolStripMenuItem;
        private new System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Panel line2;
        private System.Windows.Forms.Panel line3;
        private System.Windows.Forms.ToolStripMenuItem menu_Ingresar;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelRight;

        //AGREGADORS

        //Ingresar datos



    }
}

