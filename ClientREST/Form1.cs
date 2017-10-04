using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace ClientREST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region UI Event Handlers
        private void btConectar_Click(object sender, EventArgs e)
        {
            //metodo get
            /*RestClient rClient = new RestClient();
            rClient.endPoint = tbRequest.Text;
            string strResponse = string.Empty;
            strResponse = rClient.makeRequest();

            debugOutput(strResponse);*/

            //metodo post
            SubmitData();
        }
        #endregion

        private void SubmitData()
        {
            try
            {
                int idSensor = Convert.ToInt32(tbIdSensor.Text);
                double valor = Convert.ToDouble(tbValor.Text);
                double max = Convert.ToDouble(tbMax.Text);
                double min = Convert.ToDouble(tbMin.Text);
                int vizinhos = Convert.ToInt32(cbNumViz.SelectedItem.ToString());
                bool tratamentoTempoReal = (ckTrataTempoReal.Checked) ? true : false;
                bool popularBaseTeste = (ckPopularBase.Checked) ? true : false;

                ASCIIEncoding encoding = new ASCIIEncoding();
                string postData = "?idSensor=" + idSensor + "&valor=" + valor + "&min=" + min + "&max=" + max + "&redeSensor=" + tratamentoTempoReal + "&vizinhos=" + vizinhos;

                byte[] data = encoding.GetBytes(postData);

                WebRequest request = WebRequest.Create(tbRequest.Text);
                request.Method = "POST";
                request.ContentType = "application/form-data";
                request.ContentLength = data.Length;

                Stream stream = request.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Close();

                WebResponse response = request.GetResponse();
                stream = response.GetResponseStream();

                StreamReader sr = new StreamReader(stream);

                MessageBox.Show(sr.ReadToEnd() + "Deu boa");

                sr.Close();
                stream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                tbResposta.Text = tbResposta.Text + strDebugText + Environment.NewLine;
                tbResposta.SelectionStart = tbResposta.TextLength;
                tbResposta.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
    }
}
