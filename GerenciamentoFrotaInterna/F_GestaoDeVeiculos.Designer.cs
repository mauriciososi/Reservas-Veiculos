namespace GerenciamentoFrotaInterna
{
    partial class F_GestaoDeVeiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_GestaoDeVeiculos));
            this.cb_situacao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_descEmpresa = new System.Windows.Forms.TextBox();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.cb_marca = new System.Windows.Forms.ComboBox();
            this.cb_combustivel = new System.Windows.Forms.ComboBox();
            this.cb_empresa = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_chassi = new System.Windows.Forms.TextBox();
            this.txb_cor = new System.Windows.Forms.TextBox();
            this.txb_qtdportas = new System.Windows.Forms.TextBox();
            this.txb_hodometro = new System.Windows.Forms.TextBox();
            this.txb_ano = new System.Windows.Forms.TextBox();
            this.txb_placa = new System.Windows.Forms.TextBox();
            this.txb_modelo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Placa = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_marca = new System.Windows.Forms.Label();
            this.lb_Modelo = new System.Windows.Forms.Label();
            this.pb_FotoCarro = new System.Windows.Forms.PictureBox();
            this.dgv_veiculos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_SalvarAlteracao = new System.Windows.Forms.Button();
            this.btn_GravarNovo = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FotoCarro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_veiculos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_situacao
            // 
            this.cb_situacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_situacao.FormattingEnabled = true;
            this.cb_situacao.Items.AddRange(new object[] {
            "PRÓPRIO",
            "ALUGADO",
            "LEASING"});
            this.cb_situacao.Location = new System.Drawing.Point(123, 307);
            this.cb_situacao.Name = "cb_situacao";
            this.cb_situacao.Size = new System.Drawing.Size(137, 21);
            this.cb_situacao.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Situação";
            // 
            // txb_descEmpresa
            // 
            this.txb_descEmpresa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txb_descEmpresa.Enabled = false;
            this.txb_descEmpresa.Location = new System.Drawing.Point(173, 12);
            this.txb_descEmpresa.Name = "txb_descEmpresa";
            this.txb_descEmpresa.ReadOnly = true;
            this.txb_descEmpresa.Size = new System.Drawing.Size(172, 20);
            this.txb_descEmpresa.TabIndex = 60;
            // 
            // cb_tipo
            // 
            this.cb_tipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "OPERACIONAL",
            "EXECUTIVO",
            "FORÇA DE VENDAS"});
            this.cb_tipo.Location = new System.Drawing.Point(121, 266);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(223, 21);
            this.cb_tipo.TabIndex = 11;
            // 
            // cb_marca
            // 
            this.cb_marca.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.cb_marca.Location = new System.Drawing.Point(124, 100);
            this.cb_marca.Name = "cb_marca";
            this.cb_marca.Size = new System.Drawing.Size(223, 21);
            this.cb_marca.TabIndex = 40;
            // 
            // cb_combustivel
            // 
            this.cb_combustivel.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.cb_combustivel.Location = new System.Drawing.Point(122, 193);
            this.cb_combustivel.Name = "cb_combustivel";
            this.cb_combustivel.Size = new System.Drawing.Size(223, 21);
            this.cb_combustivel.TabIndex = 8;
            // 
            // cb_empresa
            // 
            this.cb_empresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_empresa.FormattingEnabled = true;
            this.cb_empresa.Items.AddRange(new object[] {
            "01",
            "10",
            "04",
            "13"});
            this.cb_empresa.Location = new System.Drawing.Point(121, 12);
            this.cb_empresa.Name = "cb_empresa";
            this.cb_empresa.Size = new System.Drawing.Size(44, 21);
            this.cb_empresa.TabIndex = 1;
            this.cb_empresa.SelectedIndexChanged += new System.EventHandler(this.cb_empresa_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Empresa";
            // 
            // txb_chassi
            // 
            this.txb_chassi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_chassi.Location = new System.Drawing.Point(121, 163);
            this.txb_chassi.Name = "txb_chassi";
            this.txb_chassi.Size = new System.Drawing.Size(223, 20);
            this.txb_chassi.TabIndex = 7;
            // 
            // txb_cor
            // 
            this.txb_cor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_cor.Location = new System.Drawing.Point(215, 135);
            this.txb_cor.Name = "txb_cor";
            this.txb_cor.Size = new System.Drawing.Size(129, 20);
            this.txb_cor.TabIndex = 6;
            // 
            // txb_qtdportas
            // 
            this.txb_qtdportas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_qtdportas.Location = new System.Drawing.Point(237, 230);
            this.txb_qtdportas.Name = "txb_qtdportas";
            this.txb_qtdportas.Size = new System.Drawing.Size(47, 20);
            this.txb_qtdportas.TabIndex = 10;
            // 
            // txb_hodometro
            // 
            this.txb_hodometro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_hodometro.Location = new System.Drawing.Point(121, 230);
            this.txb_hodometro.Name = "txb_hodometro";
            this.txb_hodometro.Size = new System.Drawing.Size(47, 20);
            this.txb_hodometro.TabIndex = 9;
            // 
            // txb_ano
            // 
            this.txb_ano.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_ano.Location = new System.Drawing.Point(124, 131);
            this.txb_ano.Name = "txb_ano";
            this.txb_ano.Size = new System.Drawing.Size(44, 20);
            this.txb_ano.TabIndex = 5;
            // 
            // txb_placa
            // 
            this.txb_placa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_placa.Location = new System.Drawing.Point(122, 44);
            this.txb_placa.Name = "txb_placa";
            this.txb_placa.Size = new System.Drawing.Size(102, 20);
            this.txb_placa.TabIndex = 2;
            // 
            // txb_modelo
            // 
            this.txb_modelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_modelo.Location = new System.Drawing.Point(123, 70);
            this.txb_modelo.Name = "txb_modelo";
            this.txb_modelo.Size = new System.Drawing.Size(223, 20);
            this.txb_modelo.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Combustível";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Chassi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Qtd portas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Hodômetro atual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Cor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Tipo veículo";
            // 
            // lb_Placa
            // 
            this.lb_Placa.AutoSize = true;
            this.lb_Placa.Location = new System.Drawing.Point(16, 47);
            this.lb_Placa.Name = "lb_Placa";
            this.lb_Placa.Size = new System.Drawing.Size(34, 13);
            this.lb_Placa.TabIndex = 46;
            this.lb_Placa.Text = "Placa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Ano";
            // 
            // lb_marca
            // 
            this.lb_marca.AutoSize = true;
            this.lb_marca.Location = new System.Drawing.Point(18, 108);
            this.lb_marca.Name = "lb_marca";
            this.lb_marca.Size = new System.Drawing.Size(37, 13);
            this.lb_marca.TabIndex = 56;
            this.lb_marca.Text = "Marca";
            // 
            // lb_Modelo
            // 
            this.lb_Modelo.AutoSize = true;
            this.lb_Modelo.Location = new System.Drawing.Point(18, 75);
            this.lb_Modelo.Name = "lb_Modelo";
            this.lb_Modelo.Size = new System.Drawing.Size(42, 13);
            this.lb_Modelo.TabIndex = 58;
            this.lb_Modelo.Text = "Modelo";
            // 
            // pb_FotoCarro
            // 
            this.pb_FotoCarro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_FotoCarro.Location = new System.Drawing.Point(360, 221);
            this.pb_FotoCarro.Name = "pb_FotoCarro";
            this.pb_FotoCarro.Size = new System.Drawing.Size(216, 145);
            this.pb_FotoCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_FotoCarro.TabIndex = 61;
            this.pb_FotoCarro.TabStop = false;
            // 
            // dgv_veiculos
            // 
            this.dgv_veiculos.AllowUserToAddRows = false;
            this.dgv_veiculos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_veiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_veiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_veiculos.EnableHeadersVisualStyles = false;
            this.dgv_veiculos.Location = new System.Drawing.Point(360, 12);
            this.dgv_veiculos.MultiSelect = false;
            this.dgv_veiculos.Name = "dgv_veiculos";
            this.dgv_veiculos.ReadOnly = true;
            this.dgv_veiculos.RowHeadersVisible = false;
            this.dgv_veiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_veiculos.Size = new System.Drawing.Size(428, 191);
            this.dgv_veiculos.TabIndex = 64;
            this.dgv_veiculos.SelectionChanged += new System.EventHandler(this.dgv_veiculos_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.btn_Excluir);
            this.panel1.Controls.Add(this.btn_SalvarAlteracao);
            this.panel1.Controls.Add(this.btn_GravarNovo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 32);
            this.panel1.TabIndex = 65;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fechar.Location = new System.Drawing.Point(340, 3);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(98, 23);
            this.btn_Fechar.TabIndex = 0;
            this.btn_Fechar.Text = "Fechar janela";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excluir.Location = new System.Drawing.Point(236, 3);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(98, 23);
            this.btn_Excluir.TabIndex = 0;
            this.btn_Excluir.Text = "Excluir usuário";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_SalvarAlteracao
            // 
            this.btn_SalvarAlteracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SalvarAlteracao.Location = new System.Drawing.Point(132, 3);
            this.btn_SalvarAlteracao.Name = "btn_SalvarAlteracao";
            this.btn_SalvarAlteracao.Size = new System.Drawing.Size(98, 23);
            this.btn_SalvarAlteracao.TabIndex = 0;
            this.btn_SalvarAlteracao.Text = "Salvar alterações";
            this.btn_SalvarAlteracao.UseVisualStyleBackColor = true;
            this.btn_SalvarAlteracao.Click += new System.EventHandler(this.btn_SalvarAlteracao_Click);
            // 
            // btn_GravarNovo
            // 
            this.btn_GravarNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GravarNovo.Location = new System.Drawing.Point(7, 3);
            this.btn_GravarNovo.Name = "btn_GravarNovo";
            this.btn_GravarNovo.Size = new System.Drawing.Size(119, 23);
            this.btn_GravarNovo.TabIndex = 0;
            this.btn_GravarNovo.Text = "Gravar novo usuário";
            this.btn_GravarNovo.UseVisualStyleBackColor = true;
            this.btn_GravarNovo.Click += new System.EventHandler(this.btn_GravarNovo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(357, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 13);
            this.label10.TabIndex = 66;
            this.label10.Text = "Clique duplo para alterar a foto";
            // 
            // F_GestaoDeVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_veiculos);
            this.Controls.Add(this.cb_situacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pb_FotoCarro);
            this.Controls.Add(this.txb_descEmpresa);
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
            this.Name = "F_GestaoDeVeiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Veículos - Frota YKK";
            this.Load += new System.EventHandler(this.F_GestaoDeVeiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_FotoCarro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_veiculos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_situacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_FotoCarro;
        private System.Windows.Forms.TextBox txb_descEmpresa;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.ComboBox cb_marca;
        private System.Windows.Forms.ComboBox cb_combustivel;
        private System.Windows.Forms.ComboBox cb_empresa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_chassi;
        private System.Windows.Forms.TextBox txb_cor;
        private System.Windows.Forms.TextBox txb_qtdportas;
        private System.Windows.Forms.TextBox txb_hodometro;
        private System.Windows.Forms.TextBox txb_ano;
        private System.Windows.Forms.TextBox txb_placa;
        private System.Windows.Forms.TextBox txb_modelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Placa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_marca;
        private System.Windows.Forms.Label lb_Modelo;
        private System.Windows.Forms.DataGridView dgv_veiculos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_SalvarAlteracao;
        private System.Windows.Forms.Button btn_GravarNovo;
        private System.Windows.Forms.Label label10;
    }
}