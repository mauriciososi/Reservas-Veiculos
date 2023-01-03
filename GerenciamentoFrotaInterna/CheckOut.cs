using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoFrotaInterna
{
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            string vQuery = @"SELECT  res_codigo_reserva as 'Nr_RESERVA', 
                                      res_placa AS 'PLACA',
                                      res_matricula AS 'MATRICULA',
                                      usr_nome AS 'NOME', 
                                      res_inicio_reserva AS  'INÍCIO',
                                      res_hora_inicio_reserva AS 'HORA',
                                      res_fim_reserva AS 'FIM',
                                      res_hora_fim_reserva AS 'HORA',
                                      res_destino AS 'DESTINO' 
                            FROM tbl_reservas JOIN
                                 tbl_usuarios on (res_matricula = usr_matricula)
                           WHERE usr_usuario = '" + Globais.useracesso+ "' AND res_desc_historico is null"; 
                              // res_devolucao is null

            dgv_checkout.DataSource = Banco.consulta(vQuery);

            dgv_checkout.Columns[0].Width = 80;
            dgv_checkout.Columns[1].Width = 70;
            dgv_checkout.Columns[2].Width = 75;
            dgv_checkout.Columns[3].Width = 100;
            dgv_checkout.Columns[4].Width = 70;
            dgv_checkout.Columns[5].Width = 70;
            dgv_checkout.Columns[6].Width = 70;
            dgv_checkout.Columns[7].Width = 70;
            dgv_checkout.Columns[8].Width = 320;
            //foreach (DataGridViewColumn column in dgv_checkout.Columns)
            //{
            //    //if (column.DataPropertyName == "res_codigo_reserva")
            //    //    column.Width = 10;
            //    //else if (column.DataPropertyName == "res_placa")
            //    //    column.Width = 10;
            //    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //}



        }

        private void btn_fecharC_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_checkout_DoubleClick(object sender, EventArgs e)
        {
            CheckOut2 checkout2 = new CheckOut2();
            DataGridView dgv_checkout = (DataGridView)sender;

            int wReserva = 0;           
            checkout2.txb_codigo_reserva.Text = dgv_checkout.SelectedRows[0].Cells[0].Value.ToString();
            wReserva = Int32.Parse(dgv_checkout.SelectedRows[0].Cells[0].Value.ToString());
            DataTable dt = new DataTable();
            
                      
            dt = Banco.ObterDadosUsuarioUserAcesso(Globais.useracesso);
            checkout2.cb_empresa.Text = dt.Rows[0].Field<Int32>("usr_cod_empresa").ToString();
            Usuario desc = new Usuario();
            checkout2.txb_descEmpresa.Text = desc.DescricaoEmpresa(checkout2.cb_empresa, checkout2.txb_descEmpresa);
            checkout2.txb_nome_completo.Text = dgv_checkout.SelectedRows[0].Cells[3].Value.ToString();
            checkout2.txb_matricula.Text = dgv_checkout.SelectedRows[0].Cells[2].Value.ToString();

            dt = Veiculos.ObterVeiculoByPlaca(dgv_checkout.SelectedRows[0].Cells[1].Value.ToString());
            checkout2.cb_marca.Text = dt.Rows[0].Field<String>("car_marca");
            checkout2.txb_ano.Text = dt.Rows[0].Field<Int32>("car_ano").ToString();
            checkout2.txb_cor.Text = dt.Rows[0].Field<String>("car_cor");
            checkout2.txb_modelo.Text = dt.Rows[0].Field<String>("car_modelo");
            checkout2.txb_placa.Text = dgv_checkout.SelectedRows[0].Cells[1].Value.ToString();
            checkout2.cb_combustivel.Text = dt.Rows[0].Field<String>("car_combustivel");

            dt = Reservas.ObterDadosReserva(wReserva);
            checkout2.txb_hodometro_inicial_reserva.Text = dt.Rows[0].Field<Int32>("res_odometro_inicial").ToString();
            checkout2.txb_dest_reserva.Text = dt.Rows[0].Field<String>("res_destino");
            
            DateTime wfim = dt.Rows[0].Field<DateTime>("res_fim_reserva"); 
            checkout2.dateTimePicker1.Value = new DateTime(wfim.Year, wfim.Month, wfim.Day);
            checkout2.mtb_horario_inicio.Text = dt.Rows[0].Field<TimeSpan>("res_hora_fim_reserva").ToString();

            //Exemplo
            //dateTimePicker1.MaxDate = new DateTime(2022, 12, 28);
            //dateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd";
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;

            //Desabilita dias anteriores ao dia atual
            //checkout2.dateTimePicker2.MinDate = DateTime.Today;
            

            checkout2.ShowDialog();
        }
    }
}
