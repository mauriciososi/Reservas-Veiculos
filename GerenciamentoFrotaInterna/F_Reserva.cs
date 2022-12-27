using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GerenciamentoFrotaInterna
{
    public partial class F_Reserva : Form
    {
        public F_Reserva()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgv_veiculos_reserva_SelectionChanged(object sender, EventArgs e)
        {
            //Esse bloquinho abaixo é pq GridView passa várias vezes antes de carregar
            //para evitar que entre sem necessidade
            // só quando tiver linhas selecionadas ou seja, maior do que zero
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                //irá carregar cada linha selecionad
                dt = Banco.ObterDadosVeiculo(vid); //retorna dados do veículo que possui o ID especifico do parametro para "dt"
                                                   //Field<Int64>("usr_id_usuario").ToString();

                //cb_empresa.Text = dt.Rows[0].Field<Int32>("car_empresa").ToString();
                txb_ano.Text = dt.Rows[0].Field<Int32>("car_ano").ToString();
                txb_modelo.Text = dt.Rows[0].Field<string>("car_modelo").ToString();
                txb_placa.Text = dt.Rows[0].Field<string>("car_placa").ToString();
                cb_marca.Text = dt.Rows[0].Field<string>("car_marca").ToString();
                txb_cor.Text = dt.Rows[0].Field<string>("car_cor").ToString();
                //Foto preciso confirmar como levar para tela...
                pb_FotoCarro.ImageLocation = dt.Rows[0].Field<string>("car_foto");
                cb_combustivel.Text = dt.Rows[0].Field<string>("car_combustivel").ToString();
                // txb_chassi.Text = dt.Rows[0].Field<string>("car_chassi").ToString();
                txb_hodometro_inicial_reserva.Text = dt.Rows[0].Field<Int32>("car_hodometro").ToString();
               // txb_qtdportas.Text = dt.Rows[0].Field<Int32>("car_portas").ToString();
               // cb_tipo.Text = dt.Rows[0].Field<string>("car_tipo").ToString();
               // cb_situacao.Text = dt.Rows[0].Field<string>("car_situacao").ToString();

               

            }
        }

        private void F_Reserva_Load(object sender, EventArgs e)
        {
            dgv_veiculos_reserva.DataSource = Banco.ObterVeiculoIdPlaca();
            dgv_veiculos_reserva.Columns[0].Width = 80;
            dgv_veiculos_reserva.Columns[1].Width = 120;
            DataTable dtusr = new DataTable();
            dtusr = Usuario.ObterDadosUsuarioUserAcesso(Globais.useracesso);
            cb_empresa.Text = dtusr.Rows[0].Field<Int32>("usr_cod_empresa").ToString();
            txb_nome_completo.Text = dtusr.Rows[0].Field<string>("usr_nome").ToString() + " " +
               dtusr.Rows[0].Field<string>("usr_sobre_nome").ToString();
            txb_matricula.Text = dtusr.Rows[0].Field<Int32>("usr_matricula").ToString();
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
            //Calendar calendarWithBlackoutDates = new Calendar();

            //datePickerWithBlackoutDates.DisplayDateStart = new DateTime(2009, 8, 1);
            //datePickerWithBlackoutDates.DisplayDateEnd = new DateTime(2009, 8, 31);
            //datePickerWithBlackoutDates.SelectedDate = new DateTime(2009, 8, 10);

        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
