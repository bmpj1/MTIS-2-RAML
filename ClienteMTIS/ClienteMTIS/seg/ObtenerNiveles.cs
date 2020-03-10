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
    public partial class ObtenerNiveles : Form
    {
        private string restkey = "";
        public ObtenerNiveles(string restkey)
        {
            InitializeComponent();
            this.restkey = restkey;
            textBox2.Enabled = false;
            button2.Enabled = false;
        }

        /**
         * TextBox DNI
         * */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /**
         * Boton para obtener niveles
         * */
        private async void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            textBox2.Enabled = false;
            button2.Enabled = false;
            SeguridadClient cliente = new SeguridadClient("https://localhost:44358/");
            GetSeguridadObtenerNivelesQuery query = new GetSeguridadObtenerNivelesQuery();
            query.RestKey = restkey;
            query.DNI = textBox1.Text;
            var response = await cliente.SeguridadObtenerNiveles.Get(query);

            using (var contentStream = await response.RawContent.ReadAsStreamAsync())
            {
                contentStream.Seek(0, SeekOrigin.Begin);
                using (var sr = new StreamReader(contentStream))
                {
                    var res = JsonConvert.DeserializeObject<MultipleSeguridadObtenerNivelesGet>(sr.ReadToEnd());
                    var lista = res.Ipstring.ToArray<string>();
                    for (int i = 0; i < lista.Length; i++)
                    {
                        richTextBox1.Text += "Sala[" + i + "]: " + lista[i] + "\n";
                    }
                    if (lista.Length > 0)
                    {
                        textBox2.Enabled = true;
                        button2.Enabled = true;
                    }
                    MessageBox.Show(res.Error.Message);
                }
            }
        }

        /**
         * TextBox sala
         * */
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        /**
         * Boton eliminar permisos
         * */
        private async void button2_Click(object sender, EventArgs e)
        {
            SeguridadClient cliente = new SeguridadClient("https://localhost:44358/");
            DeleteSeguridadEliminarPermisosQuery query = new DeleteSeguridadEliminarPermisosQuery();
                query.RestKey = restkey;
                query.DNI = textBox1.Text;
                query.Sala = textBox2.Text;
            var response = await cliente.SeguridadEliminarPermisos.Delete(query);

            using (var contentStream = await response.RawContent.ReadAsStreamAsync())
            {
                contentStream.Seek(0, SeekOrigin.Begin);
                using (var sr = new StreamReader(contentStream))
                {
                    var res = JsonConvert.DeserializeObject<MultipleSeguridadEliminarPermisosDelete>(sr.ReadToEnd());
                    if(res.Ipbool.Value)
                        MessageBox.Show(res.Error.Message + "\n Actualice para comprobar si se ha borrado");
                    else
                        MessageBox.Show(res.Error.Message);
                }
            }
            /*
            Utilidades.Utilidades aux = new Utilidades.Utilidades();
            string errors = "", errorSala = "";
            if (aux.validarNIF(textBox1.Text, this.restkey, out errors))
            {
                Seguridad.Seguridad salas = new Seguridad.Seguridad();
                try
                {
                    if (salas.eliminarPermiso(textBox1.Text, textBox2.Text, this.restkey, out errorSala)) {
                        errors += "\n Actualize para comprobar si se ha borrado";
                    }
                    else
                    {
                        errors += " \n Ha ocurrido algún error";
                    }

                }
                catch (Exception ext)
                {
                    errors += " No existe la sala";
                }
            }
            MessageBox.Show(errors);
            */
        }

        /**
         * Cancelar // Vuelve al formulario principal
         * */
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main form = new Main(restkey);
            form.ShowDialog();
            this.Close();
        }
    }
}
