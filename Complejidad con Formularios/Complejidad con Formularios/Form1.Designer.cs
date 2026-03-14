namespace Complejidad_con_Formularios
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejeriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversorDeDivisasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serieFibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejeriToolStripMenuItem,
            this.conversorDeDivisasToolStripMenuItem,
            this.serieFibonacciToolStripMenuItem,
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ejeriToolStripMenuItem
            // 
            this.ejeriToolStripMenuItem.Name = "ejeriToolStripMenuItem";
            this.ejeriToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.ejeriToolStripMenuItem.Text = "Registro de Personas";
            this.ejeriToolStripMenuItem.Click += new System.EventHandler(this.ejeriToolStripMenuItem_Click);
            // 
            // conversorDeDivisasToolStripMenuItem
            // 
            this.conversorDeDivisasToolStripMenuItem.Name = "conversorDeDivisasToolStripMenuItem";
            this.conversorDeDivisasToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.conversorDeDivisasToolStripMenuItem.Text = "Conversor de Divisas";
            this.conversorDeDivisasToolStripMenuItem.Click += new System.EventHandler(this.conversorDeDivisasToolStripMenuItem_Click);
            // 
            // serieFibonacciToolStripMenuItem
            // 
            this.serieFibonacciToolStripMenuItem.Name = "serieFibonacciToolStripMenuItem";
            this.serieFibonacciToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.serieFibonacciToolStripMenuItem.Text = "Serie Fibonacci";
            this.serieFibonacciToolStripMenuItem.Click += new System.EventHandler(this.serieFibonacciToolStripMenuItem_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Actividad Práctica 4 - [Jonard]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ejeriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversorDeDivisasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serieFibonacciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

