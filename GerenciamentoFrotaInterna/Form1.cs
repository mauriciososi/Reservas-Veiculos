using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoFrotaInterna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lb_nomeUsuario.Text = "...";
            lb_LedLogado.Image = Properties.Resources.led_vermelho;
            Globais.nivel = 0;
            Globais.logado = false;

        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    //procedimento da janela


                }
                else
                {
                    MessageBox.Show("É necessário ter autoridade para acessar essa opção.");
                }

            }
            else
            {
                MessageBox.Show("É necessário ter usuário logado.");
            }
        }

        private void oficinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    //procedimento da janela


                }
                else
                {
                    MessageBox.Show("É necessário ter autoridade para acessar essa opção.");
                }

            }
            else
            {
                MessageBox.Show("É necessário ter usuário logado.");
            }
        }

        private void usuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    //procedimento da janela


                }
                else
                {
                    MessageBox.Show("É necessário ter autoridade para acessar essa opção.");
                }

            }
            else
            {
                MessageBox.Show("É necessário ter usuário logado.");
            }
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_novousuario
            frm_novousuario f_novoUsuario = new frm_novousuario();
            f_novoUsuario.ShowDialog();
            if (Globais.nivel >= 2)
            {
                //procedimento da janela


            }
            else
            {
                MessageBox.Show("É necessário ter autoridade para acessar essa opção.");
            }


        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    //Procedimentos de Gestão
                    F_GestaoDeCadastros f_GestaoDeCadastros = new F_GestaoDeCadastros();
                    f_GestaoDeCadastros.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }

            }
            else
            {
                MessageBox.Show("É necessário ter usuário logado.");
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gestãoDeVeículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    //Procedimentos de Gestão
                    F_GestaoDeVeiculos f_GestaoDeVeiculos = new F_GestaoDeVeiculos();
                    f_GestaoDeVeiculos.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }

            }
            else
            {
                MessageBox.Show("É necessário ter usuário logado.");
            }
        }

        private void adicionarVeículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    //Procedimentos de Gestão veículos
                    frm_AdicionarVeiculos frm_AdicionarVeiculos = new frm_AdicionarVeiculos();
                    frm_AdicionarVeiculos.ShowDialog();


                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }

            }
            else
            {
                MessageBox.Show("É necessário ter usuário logado.");
            }
        }

        private void novaReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Reserva f_reserva = new F_Reserva();
            f_reserva.ShowDialog();


        }
    }  
}

