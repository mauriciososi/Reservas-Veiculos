using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GerenciamentoFrotaInterna
{
    public partial class frm_novousuario : Form
    {
        public frm_novousuario()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(cb_empresa.Text);
            if (valor == 1 ) 
            {
                txb_descEmpresa.Text = "MATRIZ/SP CORPORATE";
            }
            else if (valor == 04)
            {
                txb_descEmpresa.Text = "YOSHIDA BRASIL";
            }
            else if(valor == 10)
            {
                txb_descEmpresa.Text = "FÁBRICA/SOROCABA";
            }
            else if(valor == 13)
            {
                txb_descEmpresa.Text = "FÁBRICA/YOSHIDA NORDESTE";
            }
        }

        private void frm_novousuario_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Salvar_Click(object sender, EventArgs e) // ESSE BOTÃO DEIXOU DE SER USADO. FOI SÓ NA 1A FASE
        {

            //Verificar se os todos os campos foram preenchidos na tela 

            foreach (Control item in this.Controls)
            {

                if (item is System.Windows.Forms.TextBox && String.IsNullOrWhiteSpace(item.Text))
                {
                    MessageBox.Show("O campo >>>: " + item.Name + "<<< é de preenchimento obrigatório!");
                    item.Focus();
                    return;
                }
            }

            // outra opção para varrer a tela e ver se tem algum campo sem preencher
            //foreach (Control X in this.Controls)
            //{
            //    System.Windows.Forms.TextBox tb = X as System.Windows.Forms.TextBox;
            //    if (tb != null)
            //    {
            //        string text = tb.Text;
            //        // Do something to text...
            //        MessageBox.Show("teste");
            //        tb.Text = string.Empty; // Clears it out...
            //    }
            //}

            //Prefixo o_ para identificar a instância criada do "objeto usuario" da classe "Usuario"  
            Usuario o_usuario = new Usuario();

            o_usuario.w_usuario = txb_usuario.Text;
            o_usuario.w_senha = txb_senha.Text;
            //o_usuario.w_empresa = Convert.ToInt32(cb_empresa.SelectedValue);
            o_usuario.w_empresa = Convert.ToInt32(cb_empresa.Text.ToString());
            o_usuario.w_matricula = Convert.ToInt32(txb_matricula.Text);
            o_usuario.w_departamento = txb_departamento.Text;
            o_usuario.w_nome = txb_nome.Text;
            o_usuario.w_sobrenome = txb_sobreNome.Text;
            o_usuario.w_cnh = txb_cnh.Text;
            o_usuario.w_data_cnh = dtP_Data_CNH.Value.Date;
            o_usuario.w_nivel_acesso = Convert.ToInt32 (Math.Round(nr_numeroNivel.Value));
            o_usuario.w_data_registro = DateTime.Now;
            o_usuario.w_user_registro = Globais.useracesso;

            //Chama método "NovoUsuario" da classe "Banco" passando parâmetro "o_usuario"
            Banco.NovoUsuario(o_usuario);



        }
       
        
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
