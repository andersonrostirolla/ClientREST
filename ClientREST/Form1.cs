using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Http;
using System.Web.Script.Serialization;
using MongoDB.Bson;

namespace ClientREST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class ConfigSensor
        {
            public ObjectId _id { get; set; }
            public int IdSensor { get; set; }
            public string Descricao { get; set; }
            public double Min { get; set; }
            public double Max { get; set; }
            public string UnidadeMedida { get; set; }
            public string Metodo { get; set; }
            public int VizinhosPadrao { get; set; }
            public DateTime Data { get; set; }
        }

        private async void btBuscar_ClickAsync(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(tbRequest.Text);
                var resposta = await client.GetAsync("");

                string dados = await resposta.Content.ReadAsStringAsync();

                List<ConfigSensor> config = new JavaScriptSerializer().Deserialize<List<ConfigSensor>>(dados);

                dataGridView1.DataSource = config;
            }
        }

        private async void btInserir_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(tbRequest.Text);

                ConfigSensor config = new ConfigSensor();

                config.IdSensor = Convert.ToInt32(tbIdSensor.Text);
                config.Descricao = tbDescricao.Text;
                config.Min = 4.1;//Convert.ToDouble(tbMin.Text);
                config.Max = 15.2;//Convert.ToDouble(tbMax.Text);
                config.UnidadeMedida = tbUnidadeMedida.Text;
                config.Metodo = tbMetodo.Text;
                config.VizinhosPadrao = Convert.ToInt32(cbNumViz.SelectedItem.ToString());
                //config.Data = DateTime.Now;

                var resposta = await client.PostAsXmlAsync("",config);
            }
        }
    }
}
