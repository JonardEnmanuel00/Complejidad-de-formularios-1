using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Complejidad_con_Formularios
{
    public partial class FormRegistro : Form
    {
        // Lista para guardar los datos en memoria
        List<Persona> listaPersonas = new List<Persona>();

        public FormRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Creamos la persona con tus controles exactos
            Persona nuevaPersona = new Persona()
            {
                Nombre = textBox1.Text,
                Apellido = textBox2.Text,
                Cedula = maskedTextBox1.Text,
                Edad = numericUpDown1.Text,
                Sexo = comboBox1.Text,
                EstadoCivil = comboBox2.Text,
                Telefono = maskedTextBox2.Text,
                Correo = textBox3.Text,
                Direccion = textBox4.Text,
                Ciudad = textBox5.Text,
                Ocupación = textBox6.Text,
                FechaNacimiento = dateTimePicker1.Text
            };

            // Agregamos y actualizamos la tabla
            listaPersonas.Add(nuevaPersona);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaPersonas;

            MessageBox.Show("¡Registro guardado con éxito!");
        }


        public class Persona
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Cedula { get; set; }
            public string Edad { get; set; }
            public string Sexo { get; set; }
            public string EstadoCivil { get; set; }
            public string Telefono { get; set; }
            public string Correo { get; set; }
            public string Direccion { get; set; }
            public string Ciudad { get; set; }
            public string Ocupación { get; set; }
            public string FechaNacimiento { get; set; }
        }



        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {

            Persona nuevaPersona = new Persona()
            {
                Nombre = textBox1.Text,
                Apellido = textBox2.Text,
                Cedula = maskedTextBox1.Text,
                Edad = numericUpDown1.Value.ToString(),
                Sexo = comboBox1.Text,
                EstadoCivil = comboBox2.Text,
                Telefono = maskedTextBox2.Text,
                Correo = textBox3.Text,
                Direccion = textBox4.Text,
                Ciudad = textBox5.Text,
                Ocupación = textBox6.Text,
                FechaNacimiento = dateTimePicker1.Text
            };

            // Agregamos a la lista y actualizamos el DataGridView
            listaPersonas.Add(nuevaPersona);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaPersonas;

            // Llamamos a la función de limpiar
            LimpiarCampos();

            MessageBox.Show("¡Registro guardado con éxito!", "UFHEC");
        }

        // 3. Función para limpiar los controles
        private void LimpiarCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            numericUpDown1.Value = 0;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {

        }
    }

}


