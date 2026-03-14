using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complejidad_con_Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ejeriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistro registro = new FormRegistro();
            registro.MdiParent = this;
            registro.Show();
        }

        private void conversorDeDivisasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form hijo in this.MdiChildren)
            {
                if (hijo is FormDivisas)
                {
                    hijo.Focus();
                    return;
                }
            }

            FormDivisas ventanaDivisas = new FormDivisas();
            ventanaDivisas.MdiParent = this;
            ventanaDivisas.Show();
        }

        private void serieFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFibonacci ventanaFibo = new FormFibonacci();
            ventanaFibo.MdiParent = this; 
            ventanaFibo.Show();
        }
    }
}

