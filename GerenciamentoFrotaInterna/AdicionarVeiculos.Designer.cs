namespace GerenciamentoFrotaInterna
{
    partial class frm_AdicionarVeiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AdicionarVeiculos));
            this.txb_descEmpresa = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.cb_empresa = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_chassi = new System.Windows.Forms.TextBox();
            this.txb_cor = new System.Windows.Forms.TextBox();
            this.txb_placa = new System.Windows.Forms.TextBox();
            this.txb_modelo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_Placa = new System.Windows.Forms.Label();
            this.lb_marca = new System.Windows.Forms.Label();
            this.lb_Modelo = new System.Windows.Forms.Label();
            this.pb_FotoCarro = new System.Windows.Forms.PictureBox();
            this.cb_combustivel = new System.Windows.Forms.ComboBox();
            this.btn_CarregarFoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_hodometro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.cb_situacao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_ano = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_qtdportas = new System.Windows.Forms.TextBox();
            this.cb_marca = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FotoCarro)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_descEmpresa
            // 
            this.txb_descEmpresa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txb_descEmpresa.Enabled = false;
            this.txb_descEmpresa.Location = new System.Drawing.Point(205, 15);
            this.txb_descEmpresa.Name = "txb_descEmpresa";
            this.txb_descEmpresa.ReadOnly = true;
            this.txb_descEmpresa.Size = new System.Drawing.Size(172, 20);
            this.txb_descEmpresa.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Salvar);
            this.panel1.Controls.Add(this.btn_Sair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 32);
            this.panel1.TabIndex = 29;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(3, 3);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(70, 26);
            this.btn_Salvar.TabIndex = 5;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(738, 3);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(70, 26);
            this.btn_Sair.TabIndex = 5;
            this.btn_Sair.Text = "Fechar";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // cb_empresa
            // 
            this.cb_empresa.FormattingEnabled = true;
            this.cb_empresa.Items.AddRange(new object[] {
            "01",
            "10",
            "04",
            "13"});
            this.cb_empresa.Location = new System.Drawing.Point(153, 15);
            this.cb_empresa.Name = "cb_empresa";
            this.cb_empresa.Size = new System.Drawing.Size(44, 21);
            this.cb_empresa.TabIndex = 1;
            this.cb_empresa.SelectedIndexChanged += new System.EventHandler(this.cb_empresa_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Empresa";
            // 
            // txb_chassi
            // 
            this.txb_chassi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_chassi.Location = new System.Drawing.Point(153, 166);
            this.txb_chassi.Name = "txb_chassi";
            this.txb_chassi.Size = new System.Drawing.Size(223, 20);
            this.txb_chassi.TabIndex = 11;
            // 
            // txb_cor
            // 
            this.txb_cor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_cor.Location = new System.Drawing.Point(247, 138);
            this.txb_cor.Name = "txb_cor";
            this.txb_cor.Size = new System.Drawing.Size(129, 20);
            this.txb_cor.TabIndex = 10;
            // 
            // txb_placa
            // 
            this.txb_placa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_placa.Location = new System.Drawing.Point(154, 47);
            this.txb_placa.Name = "txb_placa";
            this.txb_placa.Size = new System.Drawing.Size(102, 20);
            this.txb_placa.TabIndex = 2;
            // 
            // txb_modelo
            // 
            this.txb_modelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_modelo.Location = new System.Drawing.Point(155, 73);
            this.txb_modelo.Name = "txb_modelo";
            this.txb_modelo.Size = new System.Drawing.Size(223, 20);
            this.txb_modelo.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Combustível";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Chassi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cor";
            // 
            // lb_Placa
            // 
            this.lb_Placa.AutoSize = true;
            this.lb_Placa.Location = new System.Drawing.Point(48, 50);
            this.lb_Placa.Name = "lb_Placa";
            this.lb_Placa.Size = new System.Drawing.Size(34, 13);
            this.lb_Placa.TabIndex = 12;
            this.lb_Placa.Text = "Placa";
            // 
            // lb_marca
            // 
            this.lb_marca.AutoSize = true;
            this.lb_marca.Location = new System.Drawing.Point(50, 111);
            this.lb_marca.Name = "lb_marca";
            this.lb_marca.Size = new System.Drawing.Size(37, 13);
            this.lb_marca.TabIndex = 18;
            this.lb_marca.Text = "Marca";
            // 
            // lb_Modelo
            // 
            this.lb_Modelo.AutoSize = true;
            this.lb_Modelo.Location = new System.Drawing.Point(50, 78);
            this.lb_Modelo.Name = "lb_Modelo";
            this.lb_Modelo.Size = new System.Drawing.Size(42, 13);
            this.lb_Modelo.TabIndex = 19;
            this.lb_Modelo.Text = "Modelo";
            // 
            // pb_FotoCarro
            // 
            this.pb_FotoCarro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_FotoCarro.Location = new System.Drawing.Point(385, 15);
            this.pb_FotoCarro.Name = "pb_FotoCarro";
            this.pb_FotoCarro.Size = new System.Drawing.Size(411, 275);
            this.pb_FotoCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_FotoCarro.TabIndex = 34;
            this.pb_FotoCarro.TabStop = false;
            // 
            // cb_combustivel
            // 
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
            this.cb_combustivel.Location = new System.Drawing.Point(154, 196);
            this.cb_combustivel.Name = "cb_combustivel";
            this.cb_combustivel.Size = new System.Drawing.Size(223, 21);
            this.cb_combustivel.TabIndex = 12;
            // 
            // btn_CarregarFoto
            // 
            this.btn_CarregarFoto.Location = new System.Drawing.Point(417, 306);
            this.btn_CarregarFoto.Name = "btn_CarregarFoto";
            this.btn_CarregarFoto.Size = new System.Drawing.Size(110, 23);
            this.btn_CarregarFoto.TabIndex = 35;
            this.btn_CarregarFoto.Text = "Carregar foto";
            this.btn_CarregarFoto.UseVisualStyleBackColor = true;
            this.btn_CarregarFoto.Click += new System.EventHandler(this.btn_CarregarFoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"JPEG (*.jpeg)|*.jpg|PNG (*.png)|*.png\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hodômetro atual";
            // 
            // txb_hodometro
            // 
            this.txb_hodometro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_hodometro.Location = new System.Drawing.Point(153, 233);
            this.txb_hodometro.Name = "txb_hodometro";
            this.txb_hodometro.Size = new System.Drawing.Size(47, 20);
            this.txb_hodometro.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tipo veículo";
            // 
            // cb_tipo
            // 
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "OPERACIONAL",
            "EXECUTIVO",
            "FORÇA DE VENDAS"});
            this.cb_tipo.Location = new System.Drawing.Point(153, 269);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(223, 21);
            this.cb_tipo.TabIndex = 15;
            // 
            // cb_situacao
            // 
            this.cb_situacao.FormattingEnabled = true;
            this.cb_situacao.Items.AddRange(new object[] {
            "PRÓPRIO",
            "ALUGADO",
            "LEASING"});
            this.cb_situacao.Location = new System.Drawing.Point(155, 310);
            this.cb_situacao.Name = "cb_situacao";
            this.cb_situacao.Size = new System.Drawing.Size(137, 21);
            this.cb_situacao.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Situação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ano";
            // 
            // txb_ano
            // 
            this.txb_ano.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_ano.Location = new System.Drawing.Point(156, 134);
            this.txb_ano.Name = "txb_ano";
            this.txb_ano.Size = new System.Drawing.Size(44, 20);
            this.txb_ano.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(207, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Qtd portas";
            // 
            // txb_qtdportas
            // 
            this.txb_qtdportas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_qtdportas.Location = new System.Drawing.Point(269, 233);
            this.txb_qtdportas.Name = "txb_qtdportas";
            this.txb_qtdportas.Size = new System.Drawing.Size(47, 20);
            this.txb_qtdportas.TabIndex = 14;
            // 
            // cb_marca
            // 
            this.cb_marca.FormattingEnabled = true;
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
            this.cb_marca.Location = new System.Drawing.Point(156, 103);
            this.cb_marca.Name = "cb_marca";
            this.cb_marca.Size = new System.Drawing.Size(223, 21);
            this.cb_marca.TabIndex = 8;
            // 
            // frm_AdicionarVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 412);
            this.Controls.Add(this.cb_situacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_CarregarFoto);
            this.Controls.Add(this.pb_FotoCarro);
            this.Controls.Add(this.txb_descEmpresa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_tipo);
            this.Controls.Add(this.cb_marca);
            this.Controls.Add(this.cb_combustivel);
            this.Controls.Add(this.cb_empresa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txb_chassi);
            this.Controls.Add(this.txb_cor);
            this.Controls.Add(this.txb_qtdportas);
            this.Controls.Add(this.txb_hodometro);
            this.Controls.Add(this.txb_ano);
            this.Controls.Add(this.txb_placa);
            this.Controls.Add(this.txb_modelo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_Placa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_marca);
            this.Controls.Add(this.lb_Modelo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AdicionarVeiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarVeiculos";
            this.Load += new System.EventHandler(this.frm_AdicionarVeiculos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_FotoCarro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txb_descEmpresa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.ComboBox cb_empresa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_chassi;
        private System.Windows.Forms.TextBox txb_cor;
        private System.Windows.Forms.TextBox txb_placa;
        private System.Windows.Forms.TextBox txb_modelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_Placa;
        private System.Windows.Forms.Label lb_marca;
        private System.Windows.Forms.Label lb_Modelo;
        private System.Windows.Forms.PictureBox pb_FotoCarro;
        private System.Windows.Forms.ComboBox cb_combustivel;
        private System.Windows.Forms.Button btn_CarregarFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_hodometro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.ComboBox cb_situacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_ano;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_qtdportas;
        private System.Windows.Forms.ComboBox cb_marca;
    }
}