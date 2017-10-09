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
            this.btInserir = new System.Windows.Forms.Button();
            this.tbRequest = new System.Windows.Forms.TextBox();
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
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btBuscar = new System.Windows.Forms.Button();
            this.tbUnidadeMedida = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMetodo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(115, 254);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(75, 23);
            this.btInserir.TabIndex = 9;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // tbRequest
            // 
            this.tbRequest.Location = new System.Drawing.Point(115, 12);
            this.tbRequest.Name = "tbRequest";
            this.tbRequest.Size = new System.Drawing.Size(254, 20);
            this.tbRequest.TabIndex = 1;
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
            this.label2.Location = new System.Drawing.Point(19, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resposta da API:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 198);
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
            this.cbNumViz.Location = new System.Drawing.Point(115, 195);
            this.cbNumViz.Name = "cbNumViz";
            this.cbNumViz.Size = new System.Drawing.Size(39, 21);
            this.cbNumViz.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor minimo:";
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(115, 91);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(56, 20);
            this.tbMin.TabIndex = 5;
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(115, 117);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(56, 20);
            this.tbMax.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 120);
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
            this.ckTrataTempoReal.Location = new System.Drawing.Point(115, 231);
            this.ckTrataTempoReal.Name = "ckTrataTempoReal";
            this.ckTrataTempoReal.Size = new System.Drawing.Size(149, 17);
            this.ckTrataTempoReal.TabIndex = 7;
            this.ckTrataTempoReal.Text = "Tratamento em tempo real";
            this.ckTrataTempoReal.UseVisualStyleBackColor = true;
            // 
            // ckPopularBase
            // 
            this.ckPopularBase.AutoSize = true;
            this.ckPopularBase.Location = new System.Drawing.Point(270, 231);
            this.ckPopularBase.Name = "ckPopularBase";
            this.ckPopularBase.Size = new System.Drawing.Size(114, 17);
            this.ckPopularBase.TabIndex = 8;
            this.ckPopularBase.Text = "Popular base teste";
            this.ckPopularBase.UseVisualStyleBackColor = true;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(115, 64);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(56, 20);
            this.tbDescricao.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Descrição: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(115, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(393, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(420, 254);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 16;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_ClickAsync);
            // 
            // tbUnidadeMedida
            // 
            this.tbUnidadeMedida.Location = new System.Drawing.Point(115, 143);
            this.tbUnidadeMedida.Name = "tbUnidadeMedida";
            this.tbUnidadeMedida.Size = new System.Drawing.Size(56, 20);
            this.tbUnidadeMedida.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Unidade de Medida:";
            // 
            // tbMetodo
            // 
            this.tbMetodo.Location = new System.Drawing.Point(115, 169);
            this.tbMetodo.Name = "tbMetodo";
            this.tbMetodo.Size = new System.Drawing.Size(56, 20);
            this.tbMetodo.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Método:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 449);
            this.Controls.Add(this.tbMetodo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbUnidadeMedida);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbDescricao);
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
            this.Controls.Add(this.tbRequest);
            this.Controls.Add(this.btInserir);
            this.Name = "Form1";
            this.Text = "ClientREST";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.TextBox tbRequest;
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
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox tbUnidadeMedida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMetodo;
        private System.Windows.Forms.Label label9;
    }
}

