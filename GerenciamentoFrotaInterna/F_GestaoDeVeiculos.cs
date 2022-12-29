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
    public partial class F_GestaoDeVeiculos : Form
    {
        public F_GestaoDeVeiculos()
        {
            InitializeComponent();
        }
        
        private void cb_empresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Revisar esse código para não necessitar repetir como foi abaixo
            int valor = Convert.ToInt32(cb_empresa.Text);
            if (valor == 1)
            {
                txb_descEmpresa.Text = "MATRIZ/SP CORPORATE";
            }
            else if (valor == 04)
            {
                txb_descEmpresa.Text = "YOSHIDA BRASIL";
            }
            else if (valor == 10)
            {
                txb_descEmpresa.Text = "FÁBRICA/SOROCABA";
            }
            else if (valor == 13)
            {
                txb_descEmpresa.Text = "FÁBRICA/YOSHIDA NORDESTE";
            }
        }

        private void btn_GravarNovo_Click(object sender, EventArgs e)
        {
            frm_AdicionarVeiculos frm_AdicionarVeiculos = new frm_AdicionarVeiculos();
            frm_AdicionarVeiculos.ShowDialog();
            dgv_veiculos.DataSource = Veiculos.ObterVeiculoIdPlaca();
        }

        private void F_GestaoDeVeiculos_Load(object sender, EventArgs e)
        {
            dgv_veiculos.DataSource = Veiculos.ObterVeiculoIdPlaca();
            dgv_veiculos.Columns[0].Width = 80;
            dgv_veiculos.Columns[1].Width = 120;
             
        }

        private void dgv_veiculos_SelectionChanged(object sender, EventArgs e)
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
                dt = Veiculos.ObterDadosVeiculo(vid); //retorna dados do usuário que possui o ID especifico do parametro para "dt"
                //Field<Int64>("usr_id_usuario").ToString();
                
                cb_empresa.Text = dt.Rows[0].Field<Int32>("car_empresa").ToString();
                txb_ano.Text    = dt.Rows[0].Field<Int32>("car_ano").ToString();
                txb_modelo.Text = dt.Rows[0].Field<string>("car_modelo").ToString();
                txb_placa.Text  = dt.Rows[0].Field<string>("car_placa").ToString();
                cb_marca.Text   = dt.Rows[0].Field<string>("car_marca").ToString();
                txb_cor.Text    = dt.Rows[0].Field<string>("car_cor").ToString();
                //Foto preciso confirmar como levar para tela...
                pb_FotoCarro.ImageLocation = dt.Rows[0].Field<string>("car_foto");
                cb_combustivel.Text = dt.Rows[0].Field<string>("car_combustivel").ToString();
                txb_chassi.Text = dt.Rows[0].Field<string>("car_chassi").ToString();
                txb_hodometro.Text = dt.Rows[0].Field<Int32>("car_hodometro").ToString();
                txb_qtdportas.Text = dt.Rows[0].Field<Int32>("car_portas").ToString();
                cb_tipo.Text = dt.Rows[0].Field<string>("car_tipo").ToString();
                cb_situacao.Text = dt.Rows[0].Field<string>("car_situacao").ToString();

                //Rotina abaixo provisória...preciso converter para algo global
                int valor = Convert.ToInt32(cb_empresa.Text);
                if (valor == 1)
                {
                    txb_descEmpresa.Text = "MATRIZ/SP CORPORATE";
                }
                else if (valor == 04)
                {
                    txb_descEmpresa.Text = "YOSHIDA BRASIL";
                }
                else if (valor == 10)
                {
                    txb_descEmpresa.Text = "FÁBRICA/SOROCABA";
                }
                else if (valor == 13)
                {
                    txb_descEmpresa.Text = "FÁBRICA/YOSHIDA NORDESTE";
                }

            }
        }

        private void btn_SalvarAlteracao_Click(object sender, EventArgs e)
        {


            //Esse procedimento abaixo é para quando o registro sofrer alteração, o cursor ficar na própria linha
            int linha = dgv_veiculos.SelectedRows[0].Index;  //Guarda a linha que foi selecionada

            //Prefixo o_ para identificar a instância criada do "objeto usuario" da classe "Usuario"  
            Veiculos o_veiculo = new Veiculos();
        

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

            o_veiculo.v_empresa = Convert.ToInt32(cb_empresa.Text.ToString());
            o_veiculo.v_ano = Convert.ToInt32(txb_ano.Text.ToString());
            o_veiculo.v_modelo = txb_modelo.Text;
            o_veiculo.v_placa = txb_placa.Text;
            o_veiculo.v_marca = cb_marca.Text;
            o_veiculo.v_cor = txb_cor.Text;
            // o_veiculo.v_foto = destinoCompleto;
            o_veiculo.v_foto = pb_FotoCarro.ImageLocation.ToString();
            o_veiculo.v_combustivel = cb_combustivel.Text;
            o_veiculo.v_chassi = txb_chassi.Text;
            o_veiculo.v_hodometro = Convert.ToInt32(txb_hodometro.Text.ToString());
            o_veiculo.v_portas = Convert.ToInt32(txb_qtdportas.Text.ToString());
            o_veiculo.v_tipo = cb_tipo.Text;
            o_veiculo.v_situacao = cb_situacao.Text;
            o_veiculo.v_fornecedor = " ";   //por enquanto
            o_veiculo.v_data_registro = DateTime.Now;
            o_veiculo.v_user_registro = Globais.useracesso;


            //Chama método "AtualizarUsuario" da classe "Banco"
            Veiculos.AtualizarVeiculo(o_veiculo);
            dgv_veiculos.DataSource = Veiculos.ObterVeiculoIdPlaca();
            dgv_veiculos.CurrentCell = dgv_veiculos[0, linha]; //Indica qual linha deve estar selecionada, no caso a que foi guardada



        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("                Confirma exclusão?    ", "                        Excluir?     ", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Veiculos.ExcluirVeiculo(txb_placa.Text);
                //Após deletar através do método, remove a linha do DataGridView
                //ao invés de chamar o método para carregar novamente o DataGridView
                dgv_veiculos.Rows.Remove(dgv_veiculos.CurrentRow);
            }

        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
