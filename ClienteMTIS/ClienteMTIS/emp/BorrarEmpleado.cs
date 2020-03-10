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
    public partial class BorrarEmpleado : Form
    {
        private string restkey = "";
        public BorrarEmpleado(string restkey )
        {
            InitializeComponent();
            this.restkey = restkey;
        }

        /**
         * TextBox DNI
         * */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /**
         * BtnEliminar
         * */
        private async void button1_Click(object sender, EventArgs e)
        {
            EmpleadoClient cliente = new EmpleadoClient("https://localhost:44358/");
            DeleteEmpleadosBorrarQuery query = new DeleteEmpleadosBorrarQuery();
                query.RestKey = restkey;
                query.DNI = textBox1.Text;
            var response = await cliente.EmpleadosBorrar.Delete(query);

            using (var contentStream = await response.RawContent.ReadAsStreamAsync())
            {
                contentStream.Seek(0, SeekOrigin.Begin);
                using (var sr = new StreamReader(contentStream))
                {
                    var res = JsonConvert.DeserializeObject<MultipleEmpleadosBorrarDelete>(sr.ReadToEnd());
                    MessageBox.Show(res.Error.Message);
                }
            }
            /*Utilidades.Utilidades aux = new Utilidades.Utilidades();
             string errors = "";
             if(aux.validarNIF(textBox1.Text, this.soapkey, out errors))
             {   
                 Empleado.Empleado borrar = new Empleado.Empleado();
                 try
                 {
                     borrar.borrar(textBox1.Text, this.soapkey, out errors);
                 } catch (Exception exept)
                 {
                     errors += " y no está registrado en la BDD.";
                 }
             }
            MessageBox.Show(errors);
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
