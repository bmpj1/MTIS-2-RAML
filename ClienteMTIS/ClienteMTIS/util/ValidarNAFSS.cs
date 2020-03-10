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
    public partial class ValidarNAFSS : Form
    {
        private string restkey = "";
        public ValidarNAFSS(string restkey)
        {
            InitializeComponent();
            this.restkey = restkey;
        }

        /**
         * Validar NAFSS
         * */
        private async void button1_Click(object sender, EventArgs e)
        {
            UtilidadesClient cliente = new UtilidadesClient("https://localhost:44358/");
            GetUtilidadesValidarNAFSSQuery query = new GetUtilidadesValidarNAFSSQuery();
                query.RestKey = this.restkey;
                query.NAFSS = textBox1.Text;
            var response = await cliente.UtilidadesValidarNAFSS.Get(query);

            using (var contentStream = await response.RawContent.ReadAsStreamAsync())
            {
                contentStream.Seek(0, SeekOrigin.Begin);
                using (var sr = new StreamReader(contentStream))
                {
                    var res = JsonConvert.DeserializeObject<MultipleUtilidadesValidarNAFSSGet>(sr.ReadToEnd());
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
