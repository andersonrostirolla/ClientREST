using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Http;
using System.Web.Script.Serialization;
using MongoDB.Bson;
using System.Net.Http.Headers;
using System.IO;
using Newtonsoft.Json;
using System.Text;

namespace ClientREST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

                /*client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

                var resposta = await client.PostAsync(tbRequest.Text,config);*/

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //StringContent content = new StringContent(JsonConvert.SerializeObject(config));
                StringContent content = new StringContent(JsonConvert.SerializeObject(config), Encoding.UTF8, "application/json");

                // HTTP POST
                HttpResponseMessage response = await client.PostAsync("", content);
                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    config = JsonConvert.DeserializeObject<ConfigSensor>(data);
                }

                /*
                 using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:99999/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    StringContent content = new StringContent(JsonConvert.SerializeObject(product));
                    // HTTP POST
                    HttpResponseMessage response = await client.PostAsync("api/products/save", content);
                    if (response.IsSuccessStatusCode)
                    {
                        string data = await response.Content.ReadAsStringAsync();
                        product = JsonConvert.DeserializeObject<Product>(data);
                    }
                } 
                */

            }
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
    }
}
