namespace GerenciamentoFrotaInterna
{
    partial class frm_novousuario
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
            this.btn_Alterar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.txb_sobreNome = new System.Windows.Forms.TextBox();
            this.txb_matricula = new System.Windows.Forms.TextBox();
            this.txb_departamento = new System.Windows.Forms.TextBox();
            this.txb_cnh = new System.Windows.Forms.TextBox();
            this.dtP_Data_CNH = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_empresa = new System.Windows.Forms.ComboBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.nr_numeroNivel = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txb_descEmpresa = new System.Windows.Forms.TextBox();
            this.txb_usuario = new System.Windows.Forms.TextBox();
            this.txb_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nr_numeroNivel)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.AutoSize = true;
            this.btn_Alterar.Location = new System.Drawing.Point(34, 31);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(35, 13);
            this.btn_Alterar.TabIndex = 0;
            this.btn_Alterar.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sobre nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Matrícula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Departamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "CNH";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Data vencimento CNH";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nível acesso ";
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // txb_nome
            // 
            this.txb_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_nome.Location = new System.Drawing.Point(173, 31);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(223, 20);
            this.txb_nome.TabIndex = 1;
            // 
            // txb_sobreNome
            // 
            this.txb_sobreNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_sobreNome.Location = new System.Drawing.Point(173, 57);
            this.txb_sobreNome.Name = "txb_sobreNome";
            this.txb_sobreNome.Size = new System.Drawing.Size(223, 20);
            this.txb_sobreNome.TabIndex = 2;
            // 
            // txb_matricula
            // 
            this.txb_matricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_matricula.Location = new System.Drawing.Point(173, 84);
            this.txb_matricula.Name = "txb_matricula";
            this.txb_matricula.Size = new System.Drawing.Size(223, 20);
            this.txb_matricula.TabIndex = 3;
            // 
            // txb_departamento
            // 
            this.txb_departamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_departamento.Location = new System.Drawing.Point(173, 106);
            this.txb_departamento.Name = "txb_departamento";
            this.txb_departamento.Size = new System.Drawing.Size(223, 20);
            this.txb_departamento.TabIndex = 4;
            // 
            // txb_cnh
            // 
            this.txb_cnh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_cnh.Location = new System.Drawing.Point(173, 128);
            this.txb_cnh.Name = "txb_cnh";
            this.txb_cnh.Size = new System.Drawing.Size(223, 20);
            this.txb_cnh.TabIndex = 5;
            this.txb_cnh.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // dtP_Data_CNH
            // 
            this.dtP_Data_CNH.Location = new System.Drawing.Point(173, 154);
            this.dtP_Data_CNH.Name = "dtP_Data_CNH";
            this.dtP_Data_CNH.Size = new System.Drawing.Size(223, 20);
            this.dtP_Data_CNH.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(424, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Empresa";
            // 
            // cb_empresa
            // 
            this.cb_empresa.FormattingEnabled = true;
            this.cb_empresa.Items.AddRange(new object[] {
            "01",
            "10",
            "04",
            "13"});
            this.cb_empresa.Location = new System.Drawing.Point(487, 28);
            this.cb_empresa.Name = "cb_empresa";
            this.cb_empresa.Size = new System.Drawing.Size(44, 21);
            this.cb_empresa.TabIndex = 10;
            this.cb_empresa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(110, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Dados de Login";
            this.label10.Click += new System.EventHandler(this.label5_Click);
            // 
            // nr_numeroNivel
            // 
            this.nr_numeroNivel.Location = new System.Drawing.Point(175, 183);
            this.nr_numeroNivel.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nr_numeroNivel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nr_numeroNivel.Name = "nr_numeroNivel";
            this.nr_numeroNivel.Size = new System.Drawing.Size(100, 20);
            this.nr_numeroNivel.TabIndex = 7;
            this.nr_numeroNivel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Salvar);
            this.panel1.Controls.Add(this.btn_Sair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 372);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 32);
            this.panel1.TabIndex = 8;
            // 
            // txb_descEmpresa
            // 
            this.txb_descEmpresa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txb_descEmpresa.Enabled = false;
            this.txb_descEmpresa.Location = new System.Drawing.Point(537, 29);
            this.txb_descEmpresa.Name = "txb_descEmpresa";
            this.txb_descEmpresa.ReadOnly = true;
            this.txb_descEmpresa.Size = new System.Drawing.Size(172, 20);
            this.txb_descEmpresa.TabIndex = 9;
            // 
            // txb_usuario
            // 
            this.txb_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_usuario.Location = new System.Drawing.Point(173, 244);
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.Size = new System.Drawing.Size(223, 20);
            this.txb_usuario.TabIndex = 9;
            this.txb_usuario.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txb_senha
            // 
            this.txb_senha.Location = new System.Drawing.Point(173, 282);
            this.txb_senha.Name = "txb_senha";
            this.txb_senha.Size = new System.Drawing.Size(223, 20);
            this.txb_senha.TabIndex = 9;
            this.txb_senha.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Senha";
            // 
            // frm_novousuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 404);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txb_descEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txb_senha);
            this.Controls.Add(this.nr_numeroNivel);
            this.Controls.Add(this.txb_usuario);
            this.Controls.Add(this.cb_empresa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtP_Data_CNH);
            this.Controls.Add(this.txb_cnh);
            this.Controls.Add(this.txb_departamento);
            this.Controls.Add(this.txb_matricula);
            this.Controls.Add(this.txb_sobreNome);
            this.Controls.Add(this.txb_nome);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Alterar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_novousuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo usuário";
            this.Load += new System.EventHandler(this.frm_novousuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nr_numeroNivel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btn_Alterar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.TextBox txb_sobreNome;
        private System.Windows.Forms.TextBox txb_matricula;
        private System.Windows.Forms.TextBox txb_departamento;
        private System.Windows.Forms.TextBox txb_cnh;
        private System.Windows.Forms.DateTimePicker dtP_Data_CNH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_empresa;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nr_numeroNivel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txb_descEmpresa;
        private System.Windows.Forms.TextBox txb_usuario;
        private System.Windows.Forms.TextBox txb_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
    }
}