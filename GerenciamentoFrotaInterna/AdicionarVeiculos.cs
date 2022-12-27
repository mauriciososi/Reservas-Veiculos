using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GerenciamentoFrotaInterna
{
    public partial class frm_AdicionarVeiculos : Form
    {
        string origemCompleto = " ";
        string foto = " ";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = " ";

        public frm_AdicionarVeiculos()
        {
            InitializeComponent();
        }

        private void btn_CarregarFoto_Click(object sender, EventArgs e)
        {
            origemCompleto = " ";
            foto = " ";
            pastaDestino = Globais.caminhoFotos;
            destinoCompleto = " ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName;
                foto = openFileDialog1.SafeFileName;
                destinoCompleto = pastaDestino + foto;

            }
            if (File.Exists(destinoCompleto))
            {
                if (MessageBox.Show("Arquivo já existe, deseja substituir?", "Substituir", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                
            }
            //System.IO.File.Copy(origemCompleto, destinoCompleto, true);
            //if (File.Exists(destinoCompleto))
            //{
            //    pb_FotoCarro.ImageLocation = destinoCompleto;
            //}
            //else
            //{
            //    MessageBox.Show("Arquivo não copiado");
            //}
            pb_FotoCarro.ImageLocation = origemCompleto;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if(destinoCompleto== " ")
            {
                if(MessageBox.Show("Sem foto selecionada, deseja continuar?", "ERRO!", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            if (destinoCompleto != " ")
            {
                System.IO.File.Copy(origemCompleto, destinoCompleto, true);
                if (File.Exists(destinoCompleto))
                {
                    pb_FotoCarro.ImageLocation = destinoCompleto;
                }
                else
                {
                   if( MessageBox.Show("Erro ao localizar foto, deseja continuar?", "ERRO!", MessageBoxButtons.YesNo) == DialogResult.No)
                   {
                      return;
                   }
                }
            }

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

           
            Veiculos o_veiculo = new Veiculos();

            
            o_veiculo.v_empresa = Convert.ToInt32(cb_empresa.Text.ToString());
            o_veiculo.v_ano = Convert.ToInt32(txb_ano.Text.ToString());
            o_veiculo.v_modelo = txb_modelo.Text;
            o_veiculo.v_placa = txb_placa.Text;
            o_veiculo.v_marca = cb_marca.Text;
            o_veiculo.v_cor = txb_cor.Text;
            o_veiculo.v_foto = destinoCompleto;
            o_veiculo.v_combustivel = cb_combustivel.Text;
            o_veiculo.v_chassi = txb_chassi.Text;
            o_veiculo.v_hodometro = Convert.ToInt32(txb_hodometro.Text.ToString());
            o_veiculo.v_portas = Convert.ToInt32(txb_qtdportas.Text.ToString());
            o_veiculo.v_tipo = cb_tipo.Text;
            o_veiculo.v_situacao = cb_situacao.Text;
            o_veiculo.v_fornecedor  = " ";   //por enquanto
            o_veiculo.v_data_registro = DateTime.Now;
            o_veiculo.v_user_registro = Globais.useracesso;

            //Chama método "NovoVeiculo" da classe "Banco" passando parâmetro "o_veiculo"
            Banco.NovoVeiculo(o_veiculo);

            // teste
            // cb_empresa.Enabled= false;

            //Limpa todo os campos
            foreach (var control in this.Controls)
            {
                TextBox tb = control as TextBox;
                if (tb != null)
                {
                    tb.Text = string.Empty;
                }
                ComboBox cb = control as ComboBox;
                if (cb != null)
                {
                    cb.Text = string.Empty;
                }
                PictureBox pbx = control as PictureBox;
                if (pbx != null)
                {
                   pbx.Image = null;
                }
                
            }
        }

        private void cb_empresa_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

