using ClienteMTIS.Empleado;
using ClienteMTIS.Empleado.Models;
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

namespace ClienteMTIS.emp
{
    public partial class ModificarEmpleado : Form
    {
        private string restkey = "";
        public ModificarEmpleado(string restkey)
        {
            InitializeComponent();
            this.restkey = restkey;

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            dateTimePicker1.Enabled = false;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main form = new Main(restkey);
            form.ShowDialog();
            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            EmpleadoClient cliente = new EmpleadoClient("https://localhost:44358/");
            PutEmpleadosModificarQuery query = new PutEmpleadosModificarQuery();
                query.RestKey = restkey;

            Empleado.Models.Empleado empleado = new Empleado.Models.Empleado();
                empleado.Nombre = textBox1.Text;
                empleado.Apellidos = textBox2.Text;
                empleado.Email = textBox3.Text;
                empleado.DNI = textBox4.Text;
                empleado.Direccion = textBox5.Text;
                empleado.Poblacion = textBox6.Text;
                empleado.Telefono = textBox7.Text;
                empleado.NSS = textBox8.Text;
                empleado.IBAN = textBox9.Text;
                empleado.Nacimiento= dateTimePicker1.Value.Date.ToString();

            var response = await cliente.EmpleadosModificar.Put(empleado, query);

            using (var contentStream = await response.RawContent.ReadAsStreamAsync())
            {
                contentStream.Seek(0, SeekOrigin.Begin);
                using (var sr = new StreamReader(contentStream))
                {
                    var res = JsonConvert.DeserializeObject<MultipleEmpleadosModificarPut>(sr.ReadToEnd());
                    MessageBox.Show(res.Error.Message);
                }
            }
            /*Utilidades.Utilidades aux = new Utilidades.Utilidades();
            string errors = "", errorNIF = "", errorIBAN = "", errorNAFSS = "";
            Boolean ok1, ok2, ok3;
            ok1 = aux.validarNIF(textBox4.Text, this.restkey, out errorNIF);
            ok2 = aux.validarIBAN(textBox9.Text, this.restkey, out errorIBAN);
            ok3 = aux.validarNAFSS(textBox8.Text, this.restkey, out errorNAFSS);

            if (!ok1)
                errors = errorNIF + "\n";
            if (!ok2)
                errors += errorIBAN + "\n";
            if (!ok3)
                errors += errorNAFSS;
            if (!ok1 || !ok2 || !ok3)
                MessageBox.Show(errors);
            else
            {
                Empleado.Empleado editado = new Empleado.Empleado();
                DateTime nacimiento = dateTimePicker1.Value.Date;
                editado.modificar(textBox4.Text, this.restkey, textBox1.Text, textBox2.Text, textBox5.Text, textBox6.Text, nacimiento, textBox7.Text, textBox3.Text, textBox8.Text, textBox9.Text, out errors);
                MessageBox.Show(errors);
            }*/
        }

        /**
         * TextBox DNI/NIF
         * */
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        /**
         * Boton Consultar
         * */
        private async void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Length == 9)
            {
                EmpleadoClient cliente = new EmpleadoClient("https://localhost:44358/");
                GetEmpleadosConsultarQuery query = new GetEmpleadosConsultarQuery();
                    query.RestKey = restkey;
                    query.DNI = textBox4.Text;
                var response = await cliente.EmpleadosConsultar.Get(query);

                using (var contentStream = await response.RawContent.ReadAsStreamAsync())
                {
                    contentStream.Seek(0, SeekOrigin.Begin);
                    using (var sr = new StreamReader(contentStream))
                    {
                        var res = JsonConvert.DeserializeObject<MultipleEmpleadosConsultarGet>(sr.ReadToEnd());
                        if(res.Empleado == null)
                            MessageBox.Show(res.Error.Message);
                        else
                        {
                            textBox1.Text = res.Empleado.Nombre;
                            textBox2.Text = res.Empleado.Apellidos;
                            textBox3.Text = res.Empleado.Email;
                            textBox4.Text = res.Empleado.DNI;
                            textBox5.Text = res.Empleado.Direccion;
                            textBox6.Text = res.Empleado.Poblacion;
                            textBox7.Text = res.Empleado.Telefono;
                            textBox8.Text = res.Empleado.NSS;
                            textBox9.Text = res.Empleado.IBAN;
                            dateTimePicker1.Text = res.Empleado.Nacimiento.ToString();

                            textBox1.Enabled = true;
                            textBox2.Enabled = true;
                            textBox3.Enabled = true;
                            textBox5.Enabled = true;
                            textBox6.Enabled = true;
                            textBox7.Enabled = true;
                            textBox8.Enabled = true;
                            textBox9.Enabled = true;
                            dateTimePicker1.Enabled = true;
                            button1.Enabled = true;
                            MessageBox.Show(res.Error.Message);
                        }
                    }
                }
            } else {
                MessageBox.Show("NIF no valido.");
            }
        }
    }
}
