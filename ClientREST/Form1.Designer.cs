namespace ClientREST
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btConectar = new System.Windows.Forms.Button();
            this.tbRequest = new System.Windows.Forms.TextBox();
            this.tbResposta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNumViz = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIdSensor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ckTrataTempoReal = new System.Windows.Forms.CheckBox();
            this.ckPopularBase = new System.Windows.Forms.CheckBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btConectar
            // 
            this.btConectar.Location = new System.Drawing.Point(115, 192);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(75, 23);
            this.btConectar.TabIndex = 9;
            this.btConectar.Text = "Ir";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click);
            // 
            // tbRequest
            // 
            this.tbRequest.Location = new System.Drawing.Point(115, 12);
            this.tbRequest.Name = "tbRequest";
            this.tbRequest.Size = new System.Drawing.Size(254, 20);
            this.tbRequest.TabIndex = 1;
            // 
            // tbResposta
            // 
            this.tbResposta.Location = new System.Drawing.Point(115, 224);
            this.tbResposta.Multiline = true;
            this.tbResposta.Name = "tbResposta";
            this.tbResposta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResposta.Size = new System.Drawing.Size(401, 115);
            this.tbResposta.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL da API:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resposta da API:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numero de vizinhos:";
            // 
            // cbNumViz
            // 
            this.cbNumViz.FormattingEnabled = true;
            this.cbNumViz.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbNumViz.Location = new System.Drawing.Point(115, 90);
            this.cbNumViz.Name = "cbNumViz";
            this.cbNumViz.Size = new System.Drawing.Size(39, 21);
            this.cbNumViz.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor minimo:";
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(115, 117);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(56, 20);
            this.tbMin.TabIndex = 5;
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(115, 143);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(56, 20);
            this.tbMax.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor maximo:";
            // 
            // tbIdSensor
            // 
            this.tbIdSensor.Location = new System.Drawing.Point(115, 38);
            this.tbIdSensor.Name = "tbIdSensor";
            this.tbIdSensor.Size = new System.Drawing.Size(56, 20);
            this.tbIdSensor.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Id do sensor:";
            // 
            // ckTrataTempoReal
            // 
            this.ckTrataTempoReal.AutoSize = true;
            this.ckTrataTempoReal.Location = new System.Drawing.Point(115, 169);
            this.ckTrataTempoReal.Name = "ckTrataTempoReal";
            this.ckTrataTempoReal.Size = new System.Drawing.Size(149, 17);
            this.ckTrataTempoReal.TabIndex = 7;
            this.ckTrataTempoReal.Text = "Tratamento em tempo real";
            this.ckTrataTempoReal.UseVisualStyleBackColor = true;
            // 
            // ckPopularBase
            // 
            this.ckPopularBase.AutoSize = true;
            this.ckPopularBase.Location = new System.Drawing.Point(270, 169);
            this.ckPopularBase.Name = "ckPopularBase";
            this.ckPopularBase.Size = new System.Drawing.Size(114, 17);
            this.ckPopularBase.TabIndex = 8;
            this.ckPopularBase.Text = "Popular base teste";
            this.ckPopularBase.UseVisualStyleBackColor = true;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(115, 64);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(56, 20);
            this.tbValor.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Valor:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 351);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ckPopularBase);
            this.Controls.Add(this.ckTrataTempoReal);
            this.Controls.Add(this.tbIdSensor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbNumViz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbResposta);
            this.Controls.Add(this.tbRequest);
            this.Controls.Add(this.btConectar);
            this.Name = "Form1";
            this.Text = "ClientREST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.TextBox tbRequest;
        private System.Windows.Forms.TextBox tbResposta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNumViz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIdSensor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckTrataTempoReal;
        private System.Windows.Forms.CheckBox ckPopularBase;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label label7;
    }
}

