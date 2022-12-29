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
    public partial class F_GestaoDeCadastros : Form
    {
        public F_GestaoDeCadastros()
        {
            InitializeComponent();
        }

        private void F_GestaoDeCadastros_Load(object sender, EventArgs e)
        {
            dgv_usuarios.DataSource = Banco.ObterUsuarioIdNome();
            dgv_usuarios.Columns[0].Width= 80;
            dgv_usuarios.Columns[1].Width = 120;
        }

        private void dgv_usuarios_SelectionChanged(object sender, EventArgs e)
        {
            //Esse bloquinho abaixo é pq GridView passa várias vezes antes de carregar
            //para evitar que entre sem necessidade
            // só quando tiver linhas selecionas ou seja maior do que zero
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                //irá carregar cada linha selecionad
                dt=Banco.ObterDadosUsuario(vid); //retorna dados do usuário que possui o ID especifico do parametro para "dt"
                //Field<Int64>("usr_id_usuario").ToString();
                txb_id.Text = dt.Rows[0].Field<Int32>("usr_id_usuario").ToString();
                cb_empresa.Text = dt.Rows[0].Field<Int32>("usr_cod_empresa").ToString();
               
                Usuario desc = new Usuario();
                txb_descEmpresa.Text = desc.DescricaoEmpresa(this.cb_empresa, this.txb_descEmpresa);

                txb_nome.Text = dt.Rows[0].Field<string>("usr_nome").ToString();
                txb_sobreNome.Text = dt.Rows[0].Field<string>("usr_sobre_nome").ToString();
                txb_matricula.Text = dt.Rows[0].Field<Int32>("usr_matricula").ToString();
                txb_departamento.Text= dt.Rows[0].Field<string>("usr_departamento").ToString();
                txb_cnh.Text = dt.Rows[0].Field<string>("usr_cnh").ToString();
                dtP_Data_CNH.Text = dt.Rows[0].Field<DateTime>("usr_data_vencimento_cnh").ToString();
                nr_numeroNivel.Value = dt.Rows[0].Field<Int32>("usr_Nivel_usuario");
                txb_usuario.Text = dt.Rows[0].Field<string>("usr_usuario").ToString();
                txb_senha.Text = dt.Rows[0].Field<string>("usr_senha").ToString();

               

            }
                
        }

        private void cb_empresa_SelectedIndexChanged(object sender, EventArgs e)
        {

            Usuario desc = new Usuario();
            txb_descEmpresa.Text = desc.DescricaoEmpresa(this.cb_empresa, this.txb_descEmpresa);


            
        }

        private void btn_GravarNovo_Click(object sender, EventArgs e)
        {
            frm_novousuario frm_Novousuario= new frm_novousuario();
            frm_Novousuario.ShowDialog();
            dgv_usuarios.DataSource = Banco.ObterUsuarioIdNome();
        }

        private void btn_SalvarAlteracao_Click(object sender, EventArgs e)
        {
            //Esse procedimento abaixo é para quando o registro sofrer alteração, o cursor ficar na própria linha
            int linha = dgv_usuarios.SelectedRows[0].Index;  //Guarda a linha que foi selecionada

            //Prefixo o_ para identificar a instância criada do "objeto usuario" da classe "Usuario"  
            Usuario o_usuario = new Usuario();

            o_usuario.w_usuario = txb_usuario.Text;
            o_usuario.w_senha = txb_senha.Text;
            o_usuario.w_empresa = Convert.ToInt32(cb_empresa.Text.ToString());
            o_usuario.w_matricula = Convert.ToInt32(txb_matricula.Text);
            o_usuario.w_departamento = txb_departamento.Text;
            o_usuario.w_nome = txb_nome.Text;
            o_usuario.w_sobrenome = txb_sobreNome.Text;
            o_usuario.w_cnh = txb_cnh.Text;
            o_usuario.w_data_cnh = Convert.ToDateTime(dtP_Data_CNH.Value.Date);
            o_usuario.w_nivel_acesso = Convert.ToInt32(Math.Round(nr_numeroNivel.Value));
            o_usuario.w_data_registro = DateTime.Now;
            o_usuario.w_user_registro = Globais.useracesso;
            
            //Chama método "AtualizarUsuario" da classe "Banco"
            Usuario.AtualizarUsuario(o_usuario);
            dgv_usuarios.DataSource = Banco.ObterUsuarioIdNome();
            dgv_usuarios.CurrentCell = dgv_usuarios[0, linha]; //Indica qual linha deve estar selecionada, no caso a que foi guardada

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("                Confirma exclusão?    ","                        Excluir?     ",MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                Usuario.ExcluirUsuario(txb_id.Text);
                //Após deletar através do método, remove a linha do DataGridView
                //ao invés de chamar o método para carregar novamente o DataGridView
                dgv_usuarios.Rows.Remove(dgv_usuarios.CurrentRow);
            }

        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
