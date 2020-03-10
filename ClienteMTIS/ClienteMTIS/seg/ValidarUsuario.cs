using ClienteMTIS.Seguridad;
using ClienteMTIS.Seguridad.Models;
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

namespace ClienteMTIS.seg
{
    public partial class ValidarUsuario : Form
    {
        private string restkey = "";
        public ValidarUsuario(string key)
        {
            InitializeComponent();
            this.restkey = key;
        }

        /**
         * TextBox DNI
         * */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /**
         * TextBox Sala
         * */
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        /**
         * BtnValidar
         * */
        private async void button1_Click(object sender, EventArgs e)
        {
            SeguridadClient cliente = new SeguridadClient("https://localhost:44358/");
            GetSeguridadValidarUsuarioQuery query = new GetSeguridadValidarUsuarioQuery();
                query.RestKey = restkey;
                query.DNI = textBox1.Text;
                query.Sala = textBox2.Text;
            var response = await cliente.SeguridadValidarUsuario.Get(query);

            using (var contentStream = await response.RawContent.ReadAsStreamAsync())
            {
                contentStream.Seek(0, SeekOrigin.Begin);
                using (var sr = new StreamReader(contentStream))
                {
                    var res = JsonConvert.DeserializeObject<MultipleSeguridadValidarUsuarioGet>(sr.ReadToEnd());
                    MessageBox.Show(res.Error.Message);
                }
            }
            /*Utilidades.Utilidades aux = new Utilidades.Utilidades();
            string errors = "", errorSala="";
            if (aux.validarNIF(textBox1.Text, this.restkey, out errors))
            {
                Seguridad.Seguridad seguridad = new Seguridad.Seguridad();
                if (seguridad.validarUsuario(textBox1.Text, textBox2.Text, this.restkey, out errorSala))
                {
                    errors += "\n" + errorSala;
                } else {
                    errors += "\n Esa sala/empleado no existe";
                }
            }
            MessageBox.Show(errors);*/
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
