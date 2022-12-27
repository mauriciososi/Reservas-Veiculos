namespace GerenciamentoFrotaInterna
{
    partial class F_GestaoDeCadastros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_GestaoDeCadastros));
            this.label9 = new System.Windows.Forms.Label();
            this.txb_descEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_senha = new System.Windows.Forms.TextBox();
            this.nr_numeroNivel = new System.Windows.Forms.NumericUpDown();
            this.txb_usuario = new System.Windows.Forms.TextBox();
            this.cb_empresa = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtP_Data_CNH = new System.Windows.Forms.DateTimePicker();
            this.txb_cnh = new System.Windows.Forms.TextBox();
            this.txb_departamento = new System.Windows.Forms.TextBox();
            this.txb_matricula = new System.Windows.Forms.TextBox();
            this.txb_sobreNome = new System.Windows.Forms.TextBox();
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Alterar = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txb_id = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_SalvarAlteracao = new System.Windows.Forms.Button();
            this.btn_GravarNovo = new System.Windows.Forms.Button();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nr_numeroNivel)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Senha";
            // 
            // txb_descEmpresa
            // 
            this.txb_descEmpresa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txb_descEmpresa.Enabled = false;
            this.txb_descEmpresa.Location = new System.Drawing.Point(152, 32);
            this.txb_descEmpresa.Name = "txb_descEmpresa";
            this.txb_descEmpresa.ReadOnly = true;
            this.txb_descEmpresa.Size = new System.Drawing.Size(223, 20);
            this.txb_descEmpresa.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Usuário";
            // 
            // txb_senha
            // 
            this.txb_senha.Location = new System.Drawing.Point(80, 318);
            this.txb_senha.Name = "txb_senha";
            this.txb_senha.PasswordChar = '*';
            this.txb_senha.Size = new System.Drawing.Size(223, 20);
            this.txb_senha.TabIndex = 30;
            // 
            // nr_numeroNivel
            // 
            this.nr_numeroNivel.Location = new System.Drawing.Point(152, 224);
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
            this.nr_numeroNivel.TabIndex = 28;
            this.nr_numeroNivel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txb_usuario
            // 
            this.txb_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_usuario.Location = new System.Drawing.Point(80, 280);
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.Size = new System.Drawing.Size(223, 20);
            this.txb_usuario.TabIndex = 29;
            // 
            // cb_empresa
            // 
            this.cb_empresa.FormattingEnabled = true;
            this.cb_empresa.Items.AddRange(new object[] {
            "01",
            "10",
            "04",
            "13"});
            this.cb_empresa.Location = new System.Drawing.Point(82, 31);
            this.cb_empresa.Name = "cb_empresa";
            this.cb_empresa.Size = new System.Drawing.Size(44, 21);
            this.cb_empresa.TabIndex = 32;
            this.cb_empresa.SelectedIndexChanged += new System.EventHandler(this.cb_empresa_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Empresa";
            // 
            // dtP_Data_CNH
            // 
            this.dtP_Data_CNH.CustomFormat = "";
            this.dtP_Data_CNH.Location = new System.Drawing.Point(152, 197);
            this.dtP_Data_CNH.Name = "dtP_Data_CNH";
            this.dtP_Data_CNH.Size = new System.Drawing.Size(223, 20);
            this.dtP_Data_CNH.TabIndex = 27;
            // 
            // txb_cnh
            // 
            this.txb_cnh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_cnh.Location = new System.Drawing.Point(152, 167);
            this.txb_cnh.Name = "txb_cnh";
            this.txb_cnh.Size = new System.Drawing.Size(223, 20);
            this.txb_cnh.TabIndex = 26;
            // 
            // txb_departamento
            // 
            this.txb_departamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_departamento.Location = new System.Drawing.Point(152, 139);
            this.txb_departamento.Name = "txb_departamento";
            this.txb_departamento.Size = new System.Drawing.Size(223, 20);
            this.txb_departamento.TabIndex = 25;
            // 
            // txb_matricula
            // 
            this.txb_matricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_matricula.Location = new System.Drawing.Point(152, 111);
            this.txb_matricula.Name = "txb_matricula";
            this.txb_matricula.Size = new System.Drawing.Size(223, 20);
            this.txb_matricula.TabIndex = 24;
            // 
            // txb_sobreNome
            // 
            this.txb_sobreNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_sobreNome.Location = new System.Drawing.Point(152, 84);
            this.txb_sobreNome.Name = "txb_sobreNome";
            this.txb_sobreNome.Size = new System.Drawing.Size(223, 20);
            this.txb_sobreNome.TabIndex = 22;
            // 
            // txb_nome
            // 
            this.txb_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_nome.Location = new System.Drawing.Point(152, 58);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(223, 20);
            this.txb_nome.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Dados de Login";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nível acesso ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Data vencimento CNH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "CNH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Matrícula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sobre nome";
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.AutoSize = true;
            this.btn_Alterar.Location = new System.Drawing.Point(13, 65);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(35, 13);
            this.btn_Alterar.TabIndex = 19;
            this.btn_Alterar.Text = "Nome";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "ID";
            // 
            // txb_id
            // 
            this.txb_id.Location = new System.Drawing.Point(42, 6);
            this.txb_id.Name = "txb_id";
            this.txb_id.ReadOnly = true;
            this.txb_id.Size = new System.Drawing.Size(84, 20);
            this.txb_id.TabIndex = 34;
            this.txb_id.TabStop = false;
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
            this.panel1.TabIndex = 35;
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
            // dgv_usuarios
            // 
            this.dgv_usuarios.AllowUserToAddRows = false;
            this.dgv_usuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.EnableHeadersVisualStyles = false;
            this.dgv_usuarios.Location = new System.Drawing.Point(397, 32);
            this.dgv_usuarios.MultiSelect = false;
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.RowHeadersVisible = false;
            this.dgv_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_usuarios.Size = new System.Drawing.Size(391, 306);
            this.dgv_usuarios.TabIndex = 36;
            this.dgv_usuarios.SelectionChanged += new System.EventHandler(this.dgv_usuarios_SelectionChanged);
            // 
            // F_GestaoDeCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_usuarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txb_id);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txb_descEmpresa);
            this.Controls.Add(this.label1);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoDeCadastros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestao de Usuários";
            this.Load += new System.EventHandler(this.F_GestaoDeCadastros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nr_numeroNivel)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_descEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_senha;
        private System.Windows.Forms.NumericUpDown nr_numeroNivel;
        private System.Windows.Forms.TextBox txb_usuario;
        private System.Windows.Forms.ComboBox cb_empresa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtP_Data_CNH;
        private System.Windows.Forms.TextBox txb_cnh;
        private System.Windows.Forms.TextBox txb_departamento;
        private System.Windows.Forms.TextBox txb_matricula;
        private System.Windows.Forms.TextBox txb_sobreNome;
        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btn_Alterar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txb_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_SalvarAlteracao;
        private System.Windows.Forms.Button btn_GravarNovo;
    }
}