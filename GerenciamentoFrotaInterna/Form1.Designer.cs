namespace GerenciamentoFrotaInterna
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_nomeUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_acesso = new System.Windows.Forms.Label();
            this.Acesso = new System.Windows.Forms.Label();
            this.lb_LedLogado = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oficinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novaReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosDisponíveisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oficinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lb_LedLogado)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.lb_nomeUsuario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lb_acesso);
            this.panel1.Controls.Add(this.Acesso);
            this.panel1.Controls.Add(this.lb_LedLogado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 430);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 20);
            this.panel1.TabIndex = 0;
            // 
            // lb_nomeUsuario
            // 
            this.lb_nomeUsuario.AutoSize = true;
            this.lb_nomeUsuario.Location = new System.Drawing.Point(146, 4);
            this.lb_nomeUsuario.Name = "lb_nomeUsuario";
            this.lb_nomeUsuario.Size = new System.Drawing.Size(16, 13);
            this.lb_nomeUsuario.TabIndex = 3;
            this.lb_nomeUsuario.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuário:";
            // 
            // lb_acesso
            // 
            this.lb_acesso.AutoSize = true;
            this.lb_acesso.Location = new System.Drawing.Point(75, 4);
            this.lb_acesso.Name = "lb_acesso";
            this.lb_acesso.Size = new System.Drawing.Size(13, 13);
            this.lb_acesso.TabIndex = 1;
            this.lb_acesso.Text = "0";
            // 
            // Acesso
            // 
            this.Acesso.AutoSize = true;
            this.Acesso.Location = new System.Drawing.Point(27, 4);
            this.Acesso.Name = "Acesso";
            this.Acesso.Size = new System.Drawing.Size(42, 13);
            this.Acesso.TabIndex = 1;
            this.Acesso.Text = "Acesso";
            // 
            // lb_LedLogado
            // 
            this.lb_LedLogado.Image = global::GerenciamentoFrotaInterna.Properties.Resources.led_vermelho;
            this.lb_LedLogado.Location = new System.Drawing.Point(0, 0);
            this.lb_LedLogado.Name = "lb_LedLogado";
            this.lb_LedLogado.Size = new System.Drawing.Size(20, 20);
            this.lb_LedLogado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lb_LedLogado.TabIndex = 0;
            this.lb_LedLogado.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.cadastrosToolStripMenuItem,
            this.reservasToolStripMenuItem1,
            this.consultasToolStripMenuItem,
            this.executivaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logonToolStripMenuItem,
            this.logoffToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // logonToolStripMenuItem
            // 
            this.logonToolStripMenuItem.Name = "logonToolStripMenuItem";
            this.logonToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.logonToolStripMenuItem.Text = "Logon";
            this.logonToolStripMenuItem.Click += new System.EventHandler(this.logonToolStripMenuItem_Click);
            // 
            // logoffToolStripMenuItem
            // 
            this.logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
            this.logoffToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.logoffToolStripMenuItem.Text = "Logoff";
            this.logoffToolStripMenuItem.Click += new System.EventHandler(this.logoffToolStripMenuItem_Click);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veículosToolStripMenuItem,
            this.oficinasToolStripMenuItem,
            this.usuáriosToolStripMenuItem1});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // veículosToolStripMenuItem
            // 
            this.veículosToolStripMenuItem.Name = "veículosToolStripMenuItem";
            this.veículosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.veículosToolStripMenuItem.Text = "Veículos";
            this.veículosToolStripMenuItem.Click += new System.EventHandler(this.veículosToolStripMenuItem_Click);
            // 
            // oficinasToolStripMenuItem
            // 
            this.oficinasToolStripMenuItem.Name = "oficinasToolStripMenuItem";
            this.oficinasToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.oficinasToolStripMenuItem.Text = "Oficinas";
            this.oficinasToolStripMenuItem.Click += new System.EventHandler(this.oficinasToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem1
            // 
            this.usuáriosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestãoDeUsuáriosToolStripMenuItem});
            this.usuáriosToolStripMenuItem1.Name = "usuáriosToolStripMenuItem1";
            this.usuáriosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.usuáriosToolStripMenuItem1.Text = "Usuários";
            this.usuáriosToolStripMenuItem1.Click += new System.EventHandler(this.usuáriosToolStripMenuItem1_Click);
            // 
            // gestãoDeUsuáriosToolStripMenuItem
            // 
            this.gestãoDeUsuáriosToolStripMenuItem.Name = "gestãoDeUsuáriosToolStripMenuItem";
            this.gestãoDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gestãoDeUsuáriosToolStripMenuItem.Text = "Gestão de Usuários";
            this.gestãoDeUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeUsuáriosToolStripMenuItem_Click);
            // 
            // reservasToolStripMenuItem1
            // 
            this.reservasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaReservaToolStripMenuItem,
            this.alterarReservaToolStripMenuItem,
            this.devoluçãoToolStripMenuItem});
            this.reservasToolStripMenuItem1.Name = "reservasToolStripMenuItem1";
            this.reservasToolStripMenuItem1.Size = new System.Drawing.Size(64, 20);
            this.reservasToolStripMenuItem1.Text = "Reservas";
            // 
            // novaReservaToolStripMenuItem
            // 
            this.novaReservaToolStripMenuItem.Name = "novaReservaToolStripMenuItem";
            this.novaReservaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.novaReservaToolStripMenuItem.Text = "Nova Reserva";
            // 
            // alterarReservaToolStripMenuItem
            // 
            this.alterarReservaToolStripMenuItem.Name = "alterarReservaToolStripMenuItem";
            this.alterarReservaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alterarReservaToolStripMenuItem.Text = "Alterar Reserva";
            // 
            // devoluçãoToolStripMenuItem
            // 
            this.devoluçãoToolStripMenuItem.Name = "devoluçãoToolStripMenuItem";
            this.devoluçãoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.devoluçãoToolStripMenuItem.Text = "Devolução";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservasToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.veículosDisponíveisToolStripMenuItem,
            this.oficinaToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reservasToolStripMenuItem.Text = "Reservas";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // veículosDisponíveisToolStripMenuItem
            // 
            this.veículosDisponíveisToolStripMenuItem.Name = "veículosDisponíveisToolStripMenuItem";
            this.veículosDisponíveisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.veículosDisponíveisToolStripMenuItem.Text = "Veículos Disponíveis";
            // 
            // oficinaToolStripMenuItem
            // 
            this.oficinaToolStripMenuItem.Name = "oficinaToolStripMenuItem";
            this.oficinaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oficinaToolStripMenuItem.Text = "Oficina";
            // 
            // executivaToolStripMenuItem
            // 
            this.executivaToolStripMenuItem.Name = "executivaToolStripMenuItem";
            this.executivaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.executivaToolStripMenuItem.Text = "Executiva";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GerenciamentoFrotaInterna.Properties.Resources.YKK_Logo_1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frota Interna YKK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lb_LedLogado)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox lb_LedLogado;
        public System.Windows.Forms.Label lb_nomeUsuario;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lb_acesso;
        public System.Windows.Forms.Label Acesso;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novaReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devoluçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículosDisponíveisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oficinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executivaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oficinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeUsuáriosToolStripMenuItem;
    }
}

