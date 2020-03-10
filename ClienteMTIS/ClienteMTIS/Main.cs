using ClienteMTIS.Utilidades;
using ClienteMTIS.Utilidades.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteMTIS
{
    public partial class Main : Form
    {
        private string restkey = "";
        public Main()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
        }

        public Main(string soapkey)
        {
            InitializeComponent();
            this.restkey = soapkey;
            textBox1.Text = soapkey;
        }

        /**
         * Guardar SoapKey
         * */
        private async void button1_Click(object sender, EventArgs e)
        {
            this.restkey = "";
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;

            UtilidadesClient cliente = new UtilidadesClient("https://localhost:44358/");
            GetUtilidadesValidarNIFQuery query = new GetUtilidadesValidarNIFQuery();
            query.RestKey = textBox1.Text;
            query.DNI = "comprobarRestKey";
            var response = await cliente.UtilidadesValidarNIF.Get(query);

            using (var contentStream = await response.RawContent.ReadAsStreamAsync())
            {
                contentStream.Seek(0, SeekOrigin.Begin);
                using (var sr = new StreamReader(contentStream))
                {
                    var res = JsonConvert.DeserializeObject<MultipleUtilidadesValidarNIFGet>(sr.ReadToEnd());
                    if (res.Error.Message.Equals("Error al validar la soapkey."))
                    {
                        MessageBox.Show("La soap key no es válida.");
                    }
                    else
                    {
                        this.restkey = textBox1.Text;
                        groupBox1.Enabled = true;
                        groupBox2.Enabled = true;
                        groupBox3.Enabled = true;
                    }
                }
            }
        }

        /**
         * Validar NIF
         * */
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            util.ValidarNIF form = new util.ValidarNIF(this.restkey);
            form.ShowDialog();
            this.Close();
        }

        /**
         * Validar IBAN
         * */
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            util.Validar_IBAN form = new util.Validar_IBAN(this.restkey);
            form.ShowDialog();
            this.Close();
        }

        /**
         * Validar NAFSS
         * */
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            util.ValidarNAFSS form = new util.ValidarNAFSS(this.restkey);
            form.ShowDialog();
            this.Close();
        }

        /**
         * Nuevo Empleado
         * */
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            emp.NuevoEmpleado form = new emp.NuevoEmpleado(this.restkey);
            form.ShowDialog();
            this.Close();
        }

        /**
         * Editar Empleado
         * */
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            emp.ModificarEmpleado form = new emp.ModificarEmpleado(this.restkey);
            form.ShowDialog();
            this.Close();
        }

        /**
         * Borrar Empleado
         * */
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            emp.BorrarEmpleado form = new emp.BorrarEmpleado(this.restkey);
            form.ShowDialog();
            this.Close();
        }

        /**
         * Asignar Permisos
         * */
        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            seg.AsignarPermisos form = new seg.AsignarPermisos(this.restkey);
            form.ShowDialog();
            this.Close();
        }

        /**
         * Obtener Niveles
         * */
        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            seg.ObtenerNiveles form = new seg.ObtenerNiveles(this.restkey);
            form.ShowDialog();
            this.Close();
        }

        /**
         * Validar Usuario/Empleado
         * */
        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            seg.ValidarUsuario form = new seg.ValidarUsuario(this.restkey);
            form.ShowDialog();
            this.Close();
        }
    }
}
