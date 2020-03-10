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

namespace ClienteMTIS.util
{
    public partial class ValidarNIF : Form
    {
        private string restkey = "";
        public ValidarNIF(string restkey)
        {
            InitializeComponent();
            this.restkey = restkey;
        }

        /**
         * Validar DNI/NIF
         * */
        private async void button1_Click(object sender, EventArgs e)
        {
            UtilidadesClient cliente = new UtilidadesClient("https://localhost:44358/");
            GetUtilidadesValidarNIFQuery query = new GetUtilidadesValidarNIFQuery();
                query.RestKey = restkey;
                query.DNI = textBox1.Text;
            var response = await cliente.UtilidadesValidarNIF.Get(query);
            
            using (var contentStream = await response.RawContent.ReadAsStreamAsync())
            {
                contentStream.Seek(0, SeekOrigin.Begin);
                using (var sr = new StreamReader(contentStream))
                {
                    var res = JsonConvert.DeserializeObject<MultipleUtilidadesValidarNIFGet>(sr.ReadToEnd());
                    MessageBox.Show(res.Error.Message);
                }
            }
        }

        /**
         * Cancelar // Vuelve al formulario principal
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
