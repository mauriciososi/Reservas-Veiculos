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
    public partial class F_Login : Form
    {
        Form1 form1;
        DataTable dt=new DataTable();
        public F_Login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void F_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Logar_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string senha = tb_senha.Text;
            Globais.useracesso = tb_username.Text;


            if (username =="" ||senha =="")
            {
                MessageBox.Show("Usuário e ou Senha invalidos");
                tb_username.Focus();
                return;
            }
            string sql = "SELECT * FROM TBL_USUARIOS WHERE usr_usuario='" + username+ "' AND usr_senha='" + senha+"'";
            dt= Banco.consulta(sql);
            if (dt.Rows.Count ==1)
            {
                form1.lb_acesso.Text = dt.Rows[0].ItemArray[10].ToString();
                //outra maneira de acessar informações do DataTable
                form1.lb_nomeUsuario.Text = dt.Rows[0].Field<string>("usr_nome");
                form1.lb_LedLogado.Image = Properties.Resources.led_verde;
                //Globais.nivel = int.Parse(dt.Rows[1].Field<Int64>("Nivel_usuario").ToString());
                Globais.nivel = int.Parse(dt.Rows[0].ItemArray[10].ToString());
                Globais.logado = true; 
                this.Close();
            }else
            {

                MessageBox.Show("Usuário não encontrado");
            }

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void tb_senha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
