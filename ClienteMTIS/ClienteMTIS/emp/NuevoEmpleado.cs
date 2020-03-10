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
    public partial class NuevoEmpleado : Form
    {
        private string restkey = "";
        public NuevoEmpleado(string restkey)
        {
            InitializeComponent();
            this.restkey = restkey;
        }

        /**
         * TextBox Nombre
         * */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /**
         * TextBox Apellidos
         * */
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        /**
         * TextBox Email
         * */
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        /**
         * TextBox DNI
         * */
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        /**
         * TextBox Direccion
         * */
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        /**
         * TextBox Poblacion
         * */
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        /**
         * TextBox Telefono
         * */
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        /**
         * TextBox NSS
         * */
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }


        /**
         * TextBox IBAN
         * */
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        /**
         * dateTimePicker Nacimiento
         * */
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        /**
         * BtnAceptar
         * */
        private async void button1_Click(object sender, EventArgs e)
        {
            EmpleadoClient client = new EmpleadoClient("https://localhost:44358"); // Mirar en API References -> Empleado.cs para saber como instanciar el cliente XD
            PostEmpleadosNuevoQuery entrada = new PostEmpleadosNuevoQuery();
            Empleado.Models.Empleado emp= new Empleado.Models.Empleado();
            
            entrada.RestKey = this.restkey;
            emp.Nombre = textBox1.Text;
            emp.Apellidos = textBox2.Text;
            emp.Email = textBox3.Text;
            emp.DNI = textBox4.Text;
            emp.Direccion = textBox5.Text;
            emp.Poblacion = textBox6.Text;
            emp.Telefono = textBox7.Text;
            emp.IBAN = textBox8.Text;
            emp.NSS = textBox9.Text;
            emp.Nacimiento = dateTimePicker1.Value.Date.ToString();

            var result = await client.EmpleadosNuevo.Post(emp, entrada);
            
            using (var contentStream = await result.RawContent.ReadAsStreamAsync())
            {
                contentStream.Seek(0, SeekOrigin.Begin);
                using (var sr = new StreamReader(contentStream))
                {
                    var res = JsonConvert.DeserializeObject<MultipleEmpleadosNuevoPost>(sr.ReadToEnd());
                    MessageBox.Show(res.Error.Message);
                }
            }
                    /*Utilidades.Utilidades aux = new Utilidades.Utilidades();

                    string errors = "", errorNIF = "", errorIBAN = "", errorNAFSS = "";
                    Boolean ok1, ok2, ok3;
                    ok1 = aux.validarNIF(textBox4.Text, this.restkey, out errorNIF);
                    ok2 = aux.validarIBAN(textBox9.Text, this.restkey, out errorIBAN);
                    ok3 = aux.validarNAFSS(textBox8.Text, this.restkey, out errorNAFSS);

                    if(!ok1)
                        errors = errorNIF + "\n";
                    if(!ok2)
                        errors += errorIBAN + "\n";
                    if(!ok3)
                        errors += errorNAFSS;
                    if(!ok1 || !ok2 || !ok3)
                        MessageBox.Show(errors);
                    else
                    {
                        Empleado.Empleado nuevo = new Empleado.Empleado();
                        DateTime nacimiento = dateTimePicker1.Value.Date;
                        nuevo.nuevo(textBox4.Text, textBox1.Text, textBox2.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox3.Text, nacimiento, textBox8.Text, textBox9.Text, this.restkey, out errors);
                        MessageBox.Show(errors);
                    }
                    */
                }

        /**
         * BtnCancelar // Vuelve al formulario principal
         * */
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main form = new Main(restkey);
            form.ShowDialog();
            this.Close();
        }
    }
}
