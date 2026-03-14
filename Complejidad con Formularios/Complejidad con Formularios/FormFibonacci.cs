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
    public partial class FormFibonacci : Form
    {
        public FormFibonacci()
        {
            InitializeComponent();
        }

       private void btnGenerar_Click(object sender, EventArgs e)
{
    // Validamos que el usuario ingrese un número entero
    if (int.TryParse(txtLimite.Text, out int limite))
    {
        if (limite < 0)
        {
            MessageBox.Show("Por favor, ingrese un número positivo.");
            return;
        }

       
        int a = 0;
        int b = 1;
        int c = 0;
       
        string serie = "0, 1";

        if (limite == 0) { txtResultado.Text = "0"; return; }
        if (limite == 1) { txtResultado.Text = "0, 1"; return; }

        
        while (true)
        {
            c = a + b;
            if (c > limite) break; 
            
            serie += ", " + c;
            a = b;
            b = c;
        }

        txtResultado.Text = serie;
    }
    else
    {
        MessageBox.Show("Por favor, ingrese un número válido.");
    }
}

        private void FormFibonacci_Load(object sender, EventArgs e)
        {

        }
    }
}
