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
            this.btn_consultar = new System.Windows.Forms.Button();
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
            this.mtb_horario_inicio = new System.Windows.Forms.MaskedTextBox();
            this.mtb_horario_fim = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_veiculos_reserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FotoCarro)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_consultar);
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.btn_GravarNovo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 612);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 32);
            this.panel1.TabIndex = 94;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(121, 3);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(115, 26);
            this.btn_consultar.TabIndex = 1;
            this.btn_consultar.Text = "Consultar reservas";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fechar.Location = new System.Drawing.Point(899, 4);
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
            this.btn_GravarNovo.Click += new System.EventHandler(this.btn_GravarNovo_Click);
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
            this.dgv_veiculos_reserva.Location = new System.Drawing.Point(15, 28);
            this.dgv_veiculos_reserva.MultiSelect = false;
            this.dgv_veiculos_reserva.Name = "dgv_veiculos_reserva";
            this.dgv_veiculos_reserva.ReadOnly = true;
            this.dgv_veiculos_reserva.RowHeadersVisible = false;
            this.dgv_veiculos_reserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_veiculos_reserva.Size = new System.Drawing.Size(555, 215);
            this.dgv_veiculos_reserva.TabIndex = 93;
            this.dgv_veiculos_reserva.SelectionChanged += new System.EventHandler(this.dgv_veiculos_reserva_SelectionChanged);
            // 
            // txb_descEmpresa
            // 
            this.txb_descEmpresa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txb_descEmpresa.Enabled = false;
            this.txb_descEmpresa.Location = new System.Drawing.Point(64, 305);
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
            this.cb_marca.Location = new System.Drawing.Point(541, 304);
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
            this.cb_combustivel.Location = new System.Drawing.Point(697, 355);
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
            this.cb_empresa.Location = new System.Drawing.Point(16, 305);
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
            this.txb_cor.Location = new System.Drawing.Point(791, 305);
            this.txb_cor.Name = "txb_cor";
            this.txb_cor.Size = new System.Drawing.Size(109, 20);
            this.txb_cor.TabIndex = 71;
            // 
            // txb_ano
            // 
            this.txb_ano.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_ano.Enabled = false;
            this.txb_ano.Location = new System.Drawing.Point(721, 303);
            this.txb_ano.Name = "txb_ano";
            this.txb_ano.Size = new System.Drawing.Size(44, 20);
            this.txb_ano.TabIndex = 70;
            // 
            // txb_placa
            // 
            this.txb_placa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_placa.Enabled = false;
            this.txb_placa.Location = new System.Drawing.Point(541, 356);
            this.txb_placa.Name = "txb_placa";
            this.txb_placa.Size = new System.Drawing.Size(70, 20);
            this.txb_placa.TabIndex = 68;
            // 
            // txb_modelo
            // 
            this.txb_modelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_modelo.Enabled = false;
            this.txb_modelo.Location = new System.Drawing.Point(541, 331);
            this.txb_modelo.Name = "txb_modelo";
            this.txb_modelo.Size = new System.Drawing.Size(223, 20);
            this.txb_modelo.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(625, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 85;
            this.label7.Text = "Combustível";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(769, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 83;
            this.label4.Text = "Cor";
            // 
            // lb_Placa
            // 
            this.lb_Placa.AutoSize = true;
            this.lb_Placa.Location = new System.Drawing.Point(495, 363);
            this.lb_Placa.Name = "lb_Placa";
            this.lb_Placa.Size = new System.Drawing.Size(34, 13);
            this.lb_Placa.TabIndex = 80;
            this.lb_Placa.Text = "Placa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(694, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 87;
            this.label6.Text = "Ano";
            // 
            // lb_marca
            // 
            this.lb_marca.AutoSize = true;
            this.lb_marca.Location = new System.Drawing.Point(494, 311);
            this.lb_marca.Name = "lb_marca";
            this.lb_marca.Size = new System.Drawing.Size(37, 13);
            this.lb_marca.TabIndex = 86;
            this.lb_marca.Text = "Marca";
            // 
            // lb_Modelo
            // 
            this.lb_Modelo.AutoSize = true;
            this.lb_Modelo.Location = new System.Drawing.Point(494, 338);
            this.lb_Modelo.Name = "lb_Modelo";
            this.lb_Modelo.Size = new System.Drawing.Size(42, 13);
            this.lb_Modelo.TabIndex = 88;
            this.lb_Modelo.Text = "Modelo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 96;
            this.label11.Text = "Nome";
            // 
            // txb_nome_completo
            // 
            this.txb_nome_completo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_nome_completo.Enabled = false;
            this.txb_nome_completo.Location = new System.Drawing.Point(63, 330);
            this.txb_nome_completo.Name = "txb_nome_completo";
            this.txb_nome_completo.Size = new System.Drawing.Size(260, 20);
            this.txb_nome_completo.TabIndex = 97;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 363);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 98;
            this.label12.Text = "Matrícula";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 363);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 98;
            this.label13.Text = "Matrícula";
            // 
            // txb_matricula
            // 
            this.txb_matricula.Enabled = false;
            this.txb_matricula.Location = new System.Drawing.Point(74, 356);
            this.txb_matricula.Name = "txb_matricula";
            this.txb_matricula.Size = new System.Drawing.Size(100, 20);
            this.txb_matricula.TabIndex = 97;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(492, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(247, 20);
            this.label14.TabIndex = 99;
            this.label14.Text = "Dados do veículo selecionado";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(11, 277);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(150, 20);
            this.label15.TabIndex = 99;
            this.label15.Text = "Dados do usuário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(379, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 99;
            this.label5.Text = "Dados da reserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 102;
            this.label2.Text = "Data fim";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 104;
            this.label3.Text = "Destino";
            // 
            // txb_destino_reserva
            // 
            this.txb_destino_reserva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_destino_reserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_destino_reserva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txb_destino_reserva.Location = new System.Drawing.Point(84, 70);
            this.txb_destino_reserva.Name = "txb_destino_reserva";
            this.txb_destino_reserva.Size = new System.Drawing.Size(350, 20);
            this.txb_destino_reserva.TabIndex = 105;
            this.txb_destino_reserva.Text = "[DIGITE ONDE SERÁ CHEGADA]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 104;
            this.label9.Text = "Origem";
            // 
            // txb_origem_reserva
            // 
            this.txb_origem_reserva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_origem_reserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_origem_reserva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txb_origem_reserva.Location = new System.Drawing.Point(81, 70);
            this.txb_origem_reserva.Name = "txb_origem_reserva";
            this.txb_origem_reserva.Size = new System.Drawing.Size(342, 20);
            this.txb_origem_reserva.TabIndex = 105;
            this.txb_origem_reserva.Text = "[DIGITE O PONTO DE PARTIDA]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(495, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 106;
            this.label10.Text = "Hodômetro atual";
            // 
            // txb_hodometro_inicial_reserva
            // 
            this.txb_hodometro_inicial_reserva.Enabled = false;
            this.txb_hodometro_inicial_reserva.Location = new System.Drawing.Point(586, 382);
            this.txb_hodometro_inicial_reserva.Name = "txb_hodometro_inicial_reserva";
            this.txb_hodometro_inicial_reserva.Size = new System.Drawing.Size(100, 20);
            this.txb_hodometro_inicial_reserva.TabIndex = 107;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(11, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(220, 20);
            this.label16.TabIndex = 99;
            this.label16.Text = "Selecione um carro abaixo";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(323, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 22);
            this.button1.TabIndex = 108;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pb_FotoCarro
            // 
            this.pb_FotoCarro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_FotoCarro.Location = new System.Drawing.Point(614, 28);
            this.pb_FotoCarro.Name = "pb_FotoCarro";
            this.pb_FotoCarro.Size = new System.Drawing.Size(333, 215);
            this.pb_FotoCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_FotoCarro.TabIndex = 91;
            this.pb_FotoCarro.TabStop = false;
            // 
            // mtb_horario_inicio
            // 
            this.mtb_horario_inicio.Location = new System.Drawing.Point(384, 43);
            this.mtb_horario_inicio.Mask = "00:00";
            this.mtb_horario_inicio.Name = "mtb_horario_inicio";
            this.mtb_horario_inicio.Size = new System.Drawing.Size(39, 20);
            this.mtb_horario_inicio.TabIndex = 109;
            this.mtb_horario_inicio.Text = "0000";
            this.mtb_horario_inicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtb_horario_inicio.ValidatingType = typeof(System.DateTime);
            // 
            // mtb_horario_fim
            // 
            this.mtb_horario_fim.Location = new System.Drawing.Point(394, 45);
            this.mtb_horario_fim.Mask = "00:00";
            this.mtb_horario_fim.Name = "mtb_horario_fim";
            this.mtb_horario_fim.Size = new System.Drawing.Size(40, 20);
            this.mtb_horario_fim.TabIndex = 109;
            this.mtb_horario_fim.Text = "0000";
            this.mtb_horario_fim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtb_horario_fim.ValidatingType = typeof(System.DateTime);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/YYYY";
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 20);
            this.dateTimePicker1.TabIndex = 110;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/YYYY";
            this.dateTimePicker2.Location = new System.Drawing.Point(84, 45);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(264, 20);
            this.dateTimePicker2.TabIndex = 111;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(329, 472);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 112;
            this.label17.Text = "label17";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txb_origem_reserva);
            this.groupBox1.Controls.Add(this.mtb_horario_inicio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 439);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 141);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Início reserva";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(349, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 111;
            this.label18.Text = "Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 111;
            this.label1.Text = "Data início";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txb_destino_reserva);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.mtb_horario_fim);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(552, 439);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 132);
            this.groupBox2.TabIndex = 113;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fim reserva";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(356, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 13);
            this.label19.TabIndex = 111;
            this.label19.Text = "Hora";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(708, 386);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(151, 13);
            this.label20.TabIndex = 114;
            this.label20.Text = "Reservas ativas da placa";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(857, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 20);
            this.button2.TabIndex = 115;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // F_Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 644);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txb_hodometro_inicial_reserva);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(5, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Reserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHECKIN Veiculos";
            this.Load += new System.EventHandler(this.F_Reserva_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_veiculos_reserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FotoCarro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_destino_reserva;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_origem_reserva;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb_hodometro_inicial_reserva;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.MaskedTextBox mtb_horario_inicio;
        public System.Windows.Forms.MaskedTextBox mtb_horario_fim;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_consultar;
    }
}