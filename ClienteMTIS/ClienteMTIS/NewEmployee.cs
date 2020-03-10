using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteMTIS
{
    public partial class NewEmployee : Form
    {
        private string SoapKey = "";
        
        public NewEmployee(string SoapKey)
        {
            InitializeComponent();
            disableForm();
            this.SoapKey = SoapKey;
        }

        private void disableForm()
        {
            textBox1.Enabled = false;
            textBox1.Enabled = false;
            textBox1.Enabled = false;
            textBox1.Enabled = false;
            textBox1.Enabled = false;
            textBox1.Enabled = false;
            textBox1.Enabled = false;
            textBox1.Enabled = false;
            textBox1.Enabled = false;
            dateTimePicker1.Enabled = false;
        }

        private void enableForm()
        {

            textBox1.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Enabled = true;
            dateTimePicker1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /**
         * Agregar empleado.
         * */
        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text,
                apellidos = textBox2.Text,
                email = textBox3.Text,
                dni = textBox4.Text,
                direccion = textBox5.Text,
                poblacion = textBox6.Text,
                telefono = textBox7.Text,
                nss = textBox8.Text,
                iban = textBox9.Text, 
                errors;
            DateTime nacimiento = dateTimePicker1.Value.Date;
            Empleado.Empleado empleado = new Empleado.Empleado();
            if (empleado.nuevo(dni,nombre,apellidos,direccion,poblacion,telefono,email,nacimiento,nss,iban,SoapKey,out errors))
            {
                MessageBox.Show(errors);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
            }
            else
            {
                MessageBox.Show(errors);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        /**
         * Cancelar
         * */
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main cancelar = new Main();
            cancelar.ShowDialog();
            this.Close();
        }

        /**
         * Validar DNI
         * */
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Utilidades.Utilidades helper = new Utilidades.Utilidades();
            string DNI = textBox4.Text;
            if (true)
            {

            }
        }
    }
}
