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
    public partial class FormDivisas : Form
    {
        public FormDivisas()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            
            if (double.TryParse(txtMonto.Text, out double monto))
            {
                // Tasas de cambio (Ajustables según el mercado)
                double tasaUSD = 60.26;
                double tasaEUR = 71.23;
                double resultado = 0;

                // 1. Primero convertimos la moneda de origen a la moneda base (DOP)
                double montoEnDOP = 0;

                if (cmbOrigen.Text == "DOP") montoEnDOP = monto;
                else if (cmbOrigen.Text == "USD") montoEnDOP = monto * tasaUSD;
                else if (cmbOrigen.Text == "EUR") montoEnDOP = monto * tasaEUR;

                // 2. Ahora convertimos de la moneda base (DOP) a la moneda de destino
                if (cmbDestino.Text == "DOP") resultado = montoEnDOP;
                else if (cmbDestino.Text == "USD") resultado = montoEnDOP / tasaUSD;
                else if (cmbDestino.Text == "EUR") resultado = montoEnDOP / tasaEUR;

                // 3. Mostramos el resultado con dos decimales
                lblResultado.Text = "Resultado: " + resultado.ToString("N2") + " " + cmbDestino.Text;
            }
            else
            {
                MessageBox.Show("Por favor, introduce una cantidad numérica válida.", "Error de entrada");
            }
        }

        private void FormDivisas_Load(object sender, EventArgs e)
        {

        }
    }
 }

