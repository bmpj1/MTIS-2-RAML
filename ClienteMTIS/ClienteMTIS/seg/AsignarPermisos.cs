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
    public partial class AsignarPermisos : Form
    {
        private string restkey = "";
        public AsignarPermisos(string key)
        {
            InitializeComponent();
            this.restkey = key;
        }

        /**
         * Asignar sala
         * */
        private async void button1_Click(object sender, EventArgs e)
        {
            SeguridadClient cliente = new SeguridadClient("https://localhost:44358/");
            PostSeguridadAsignarPermisosQuery query = new PostSeguridadAsignarPermisosQuery();
                query.RestKey = restkey;
                query.DNI = textBox1.Text;
                query.Sala = textBox2.Text;
            var response = await cliente.SeguridadAsignarPermisos.Post("", query);

            using (var contentStream = await response.RawContent.ReadAsStreamAsync())
            {
                contentStream.Seek(0, SeekOrigin.Begin);
                using (var sr = new StreamReader(contentStream))
                {
                    var res = JsonConvert.DeserializeObject<MultipleSeguridadAsignarPermisosPost>(sr.ReadToEnd());
                    MessageBox.Show(res.Error.Message);
                }
            }
            /*Utilidades.Utilidades aux = new Utilidades.Utilidades();
            string errors = "", errorSala="";
            if (aux.validarNIF(textBox1.Text, this.soapkey, out errors))
            {
                Seguridad.Seguridad salas = new Seguridad.Seguridad();
                try
                {
                    salas.asignarPermiso(textBox1.Text, textBox2.Text, this.soapkey, out errorSala);
                    errors += "\n" + errorSala;
                }
                catch (Exception ext)
                {
                    errors += " y no está registrado en la BDD.";
                }
            }
            MessageBox.Show(errors);*/
        }

        /**
         * Cancelar // Vuelve al form principal.
         * */
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main form = new Main(restkey);
            form.ShowDialog();
            this.Close();
        }
        
        /**
         * TextBox para especificar el DNI.
         * */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /**
         * TextBox para asignar la sala
         * */
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
