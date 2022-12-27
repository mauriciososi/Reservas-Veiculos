namespace GerenciamentoFrotaInterna
{
    partial class F_Reserva
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Reserva));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_GravarNovo = new System.Windows.Forms.Button();
            this.dgv_veiculos_reserva = new System.Windows.Forms.DataGridView();
            this.txb_descEmpresa = new System.Windows.Forms.TextBox();
            this.cb_marca = new System.Windows.Forms.ComboBox();
            this.cb_combustivel = new System.Windows.Forms.ComboBox();
            this.cb_empresa = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_cor = new System.Windows.Forms.TextBox();
            this.txb_ano = new System.Windows.Forms.TextBox();
            this.txb_placa = new System.Windows.Forms.TextBox();
            this.txb_modelo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_Placa = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_marca = new System.Windows.Forms.Label();
            this.lb_Modelo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txb_nome_completo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txb_matricula = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_inicio_reserva = new System.Windows.Forms.DateTimePicker();
            this.dtp_fim_reserva = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_destino_reserva = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_origem_reserva = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txb_hodometro_inicial_reserva = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pb_FotoCarro = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_veiculos_reserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FotoCarro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.btn_GravarNovo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 32);
            this.panel1.TabIndex = 94;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fechar.Location = new System.Drawing.Point(695, 3);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(98, 23);
            this.btn_Fechar.TabIndex = 0;
            this.btn_Fechar.Text = "Fechar janela";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // btn_GravarNovo
            // 
            this.btn_GravarNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GravarNovo.Location = new System.Drawing.Point(7, 3);
            this.btn_GravarNovo.Name = "btn_GravarNovo";
            this.btn_GravarNovo.Size = new System.Drawing.Size(104, 23);
            this.btn_GravarNovo.TabIndex = 0;
            this.btn_GravarNovo.Text = "Gravar Reserva";
            this.btn_GravarNovo.UseVisualStyleBackColor = true;
            // 
            // dgv_veiculos_reserva
            // 
            this.dgv_veiculos_reserva.AllowUserToAddRows = false;
            this.dgv_veiculos_reserva.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_veiculos_reserva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_veiculos_reserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_veiculos_reserva.EnableHeadersVisualStyles = false;
            this.dgv_veiculos_reserva.Location = new System.Drawing.Point(8, 28);
            this.dgv_veiculos_reserva.MultiSelect = false;
            this.dgv_veiculos_reserva.Name = "dgv_veiculos_reserva";
            this.dgv_veiculos_reserva.ReadOnly = true;
            this.dgv_veiculos_reserva.RowHeadersVisible = false;
            this.dgv_veiculos_reserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_veiculos_reserva.Size = new System.Drawing.Size(451, 129);
            this.dgv_veiculos_reserva.TabIndex = 93;
            this.dgv_veiculos_reserva.SelectionChanged += new System.EventHandler(this.dgv_veiculos_reserva_SelectionChanged);
            // 
            // txb_descEmpresa
            // 
            this.txb_descEmpresa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txb_descEmpresa.Enabled = false;
            this.txb_descEmpresa.Location = new System.Drawing.Point(58, 201);
            this.txb_descEmpresa.Name = "txb_descEmpresa";
            this.txb_descEmpresa.ReadOnly = true;
            this.txb_descEmpresa.Size = new System.Drawing.Size(172, 20);
            this.txb_descEmpresa.TabIndex = 90;
            // 
            // cb_marca
            // 
            this.cb_marca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_marca.Enabled = false;
            this.cb_marca.FormattingEnabled = true;
            this.cb_marca.ItemHeight = 13;
            this.cb_marca.Items.AddRange(new object[] {
            "CITROEN",
            "FORD",
            "FIAT",
            "GM",
            "HONDA",
            "JEEP",
            "NISSAN",
            "PEGEOUT",
            "RENAULT",
            "TOYOTA",
            "VW"});
            this.cb_marca.Location = new System.Drawing.Point(428, 186);
            this.cb_marca.Name = "cb_marca";
            this.cb_marca.Size = new System.Drawing.Size(145, 21);
            this.cb_marca.TabIndex = 78;
            // 
            // cb_combustivel
            // 
            this.cb_combustivel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_combustivel.Enabled = false;
            this.cb_combustivel.FormattingEnabled = true;
            this.cb_combustivel.Items.AddRange(new object[] {
            "ALCOOL",
            "DIESEL",
            "ELETRICIDADE",
            "FLEX",
            "GÁS",
            "GASOLINA",
            "",
            "",
            ""});
            this.cb_combustivel.Location = new System.Drawing.Point(584, 237);
            this.cb_combustivel.Name = "cb_combustivel";
            this.cb_combustivel.Size = new System.Drawing.Size(127, 21);
            this.cb_combustivel.TabIndex = 73;
            // 
            // cb_empresa
            // 
            this.cb_empresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_empresa.Enabled = false;
            this.cb_empresa.FormattingEnabled = true;
            this.cb_empresa.Items.AddRange(new object[] {
            "01",
            "10",
            "04",
            "13"});
            this.cb_empresa.Location = new System.Drawing.Point(10, 201);
            this.cb_empresa.Name = "cb_empresa";
            this.cb_empresa.Size = new System.Drawing.Size(35, 21);
            this.cb_empresa.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-100, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 89;
            this.label8.Text = "Empresa";
            // 
            // txb_cor
            // 
            this.txb_cor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_cor.Enabled = false;
            this.txb_cor.Location = new System.Drawing.Point(678, 187);
            this.txb_cor.Name = "txb_cor";
            this.txb_cor.Size = new System.Drawing.Size(109, 20);
            this.txb_cor.TabIndex = 71;
            // 
            // txb_ano
            // 
            this.txb_ano.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_ano.Enabled = false;
            this.txb_ano.Location = new System.Drawing.Point(608, 185);
            this.txb_ano.Name = "txb_ano";
            this.txb_ano.Size = new System.Drawing.Size(44, 20);
            this.txb_ano.TabIndex = 70;
            // 
            // txb_placa
            // 
            this.txb_placa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_placa.Enabled = false;
            this.txb_placa.Location = new System.Drawing.Point(428, 238);
            this.txb_placa.Name = "txb_placa";
            this.txb_placa.Size = new System.Drawing.Size(70, 20);
            this.txb_placa.TabIndex = 68;
            // 
            // txb_modelo
            // 
            this.txb_modelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_modelo.Enabled = false;
            this.txb_modelo.Location = new System.Drawing.Point(428, 213);
            this.txb_modelo.Name = "txb_modelo";
            this.txb_modelo.Size = new System.Drawing.Size(223, 20);
            this.txb_modelo.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 85;
            this.label7.Text = "Combustível";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(656, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 83;
            this.label4.Text = "Cor";
            // 
            // lb_Placa
            // 
            this.lb_Placa.AutoSize = true;
            this.lb_Placa.Location = new System.Drawing.Point(382, 245);
            this.lb_Placa.Name = "lb_Placa";
            this.lb_Placa.Size = new System.Drawing.Size(34, 13);
            this.lb_Placa.TabIndex = 80;
            this.lb_Placa.Text = "Placa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(581, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 87;
            this.label6.Text = "Ano";
            // 
            // lb_marca
            // 
            this.lb_marca.AutoSize = true;
            this.lb_marca.Location = new System.Drawing.Point(381, 193);
            this.lb_marca.Name = "lb_marca";
            this.lb_marca.Size = new System.Drawing.Size(37, 13);
            this.lb_marca.TabIndex = 86;
            this.lb_marca.Text = "Marca";
            // 
            // lb_Modelo
            // 
            this.lb_Modelo.AutoSize = true;
            this.lb_Modelo.Location = new System.Drawing.Point(381, 220);
            this.lb_Modelo.Name = "lb_Modelo";
            this.lb_Modelo.Size = new System.Drawing.Size(42, 13);
            this.lb_Modelo.TabIndex = 88;
            this.lb_Modelo.Text = "Modelo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 96;
            this.label11.Text = "Nome";
            // 
            // txb_nome_completo
            // 
            this.txb_nome_completo.Enabled = false;
            this.txb_nome_completo.Location = new System.Drawing.Point(57, 226);
            this.txb_nome_completo.Name = "txb_nome_completo";
            this.txb_nome_completo.Size = new System.Drawing.Size(260, 20);
            this.txb_nome_completo.TabIndex = 97;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 259);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 98;
            this.label12.Text = "Matrícula";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 259);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 98;
            this.label13.Text = "Matrícula";
            // 
            // txb_matricula
            // 
            this.txb_matricula.Enabled = false;
            this.txb_matricula.Location = new System.Drawing.Point(68, 252);
            this.txb_matricula.Name = "txb_matricula";
            this.txb_matricula.Size = new System.Drawing.Size(100, 20);
            this.txb_matricula.TabIndex = 97;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(379, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 13);
            this.label14.TabIndex = 99;
            this.label14.Text = "Dados do veículo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(5, 173);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 13);
            this.label15.TabIndex = 99;
            this.label15.Text = "Dados do usuário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 99;
            this.label5.Text = "Dados da reserva";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Data início ";
            // 
            // dtp_inicio_reserva
            // 
            this.dtp_inicio_reserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_inicio_reserva.Location = new System.Drawing.Point(74, 314);
            this.dtp_inicio_reserva.Name = "dtp_inicio_reserva";
            this.dtp_inicio_reserva.Size = new System.Drawing.Size(217, 20);
            this.dtp_inicio_reserva.TabIndex = 101;
            this.dtp_inicio_reserva.Value = new System.DateTime(2022, 12, 26, 22, 23, 0, 0);
            this.dtp_inicio_reserva.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtp_fim_reserva
            // 
            this.dtp_fim_reserva.Location = new System.Drawing.Point(382, 313);
            this.dtp_fim_reserva.Name = "dtp_fim_reserva";
            this.dtp_fim_reserva.Size = new System.Drawing.Size(217, 20);
            this.dtp_fim_reserva.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 102;
            this.label2.Text = "Data fim";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 104;
            this.label3.Text = "Destino";
            // 
            // txb_destino_reserva
            // 
            this.txb_destino_reserva.Location = new System.Drawing.Point(428, 340);
            this.txb_destino_reserva.Name = "txb_destino_reserva";
            this.txb_destino_reserva.Size = new System.Drawing.Size(335, 20);
            this.txb_destino_reserva.TabIndex = 105;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 104;
            this.label9.Text = "Origem";
            // 
            // txb_origem_reserva
            // 
            this.txb_origem_reserva.Location = new System.Drawing.Point(56, 341);
            this.txb_origem_reserva.Name = "txb_origem_reserva";
            this.txb_origem_reserva.Size = new System.Drawing.Size(304, 20);
            this.txb_origem_reserva.TabIndex = 105;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 106;
            this.label10.Text = "Hodômetro atual";
            // 
            // txb_hodometro_inicial_reserva
            // 
            this.txb_hodometro_inicial_reserva.Enabled = false;
            this.txb_hodometro_inicial_reserva.Location = new System.Drawing.Point(104, 371);
            this.txb_hodometro_inicial_reserva.Name = "txb_hodometro_inicial_reserva";
            this.txb_hodometro_inicial_reserva.Size = new System.Drawing.Size(100, 20);
            this.txb_hodometro_inicial_reserva.TabIndex = 107;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(5, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(157, 13);
            this.label16.TabIndex = 99;
            this.label16.Text = "Selecione um carro abaixo";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(317, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 22);
            this.button1.TabIndex = 108;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pb_FotoCarro
            // 
            this.pb_FotoCarro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_FotoCarro.Location = new System.Drawing.Point(497, 28);
            this.pb_FotoCarro.Name = "pb_FotoCarro";
            this.pb_FotoCarro.Size = new System.Drawing.Size(214, 138);
            this.pb_FotoCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_FotoCarro.TabIndex = 91;
            this.pb_FotoCarro.TabStop = false;
            // 
            // F_Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_hodometro_inicial_reserva);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txb_origem_reserva);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txb_destino_reserva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_fim_reserva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_inicio_reserva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txb_matricula);
            this.Controls.Add(this.txb_nome_completo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_veiculos_reserva);
            this.Controls.Add(this.pb_FotoCarro);
            this.Controls.Add(this.txb_descEmpresa);
            this.Controls.Add(this.cb_marca);
            this.Controls.Add(this.cb_combustivel);
            this.Controls.Add(this.cb_empresa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txb_cor);
            this.Controls.Add(this.txb_ano);
            this.Controls.Add(this.txb_placa);
            this.Controls.Add(this.txb_modelo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_Placa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_marca);
            this.Controls.Add(this.lb_Modelo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(5, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Reserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Reserva";
            this.Load += new System.EventHandler(this.F_Reserva_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_veiculos_reserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FotoCarro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_GravarNovo;
        private System.Windows.Forms.DataGridView dgv_veiculos_reserva;
        private System.Windows.Forms.PictureBox pb_FotoCarro;
        private System.Windows.Forms.TextBox txb_descEmpresa;
        private System.Windows.Forms.ComboBox cb_marca;
        private System.Windows.Forms.ComboBox cb_combustivel;
        private System.Windows.Forms.ComboBox cb_empresa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_cor;
        private System.Windows.Forms.TextBox txb_ano;
        private System.Windows.Forms.TextBox txb_placa;
        private System.Windows.Forms.TextBox txb_modelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_Placa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_marca;
        private System.Windows.Forms.Label lb_Modelo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txb_nome_completo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txb_matricula;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_inicio_reserva;
        private System.Windows.Forms.DateTimePicker dtp_fim_reserva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_destino_reserva;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_origem_reserva;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb_hodometro_inicial_reserva;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
    }
}