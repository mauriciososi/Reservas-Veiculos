//-----------------------------------------------------------------------------------
// Autor: Mauricio Silva
// Sistema de reserva de veículos frota interna YKK
// 22/12/2022
//-----------------------------------------------------------------------------------
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
    public partial class Consulta : Form
    {
        public Consulta(string placa)
        {
            InitializeComponent();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
           
            string vQuery = @"SELECT  res_codigo_reserva as 'Nr_RESERVA', 
                                      res_placa AS 'PLACA',
                                      res_matricula AS 'MATRICULA',
                                      res_inicio_reserva AS  'INÍCIO',
                                      res_hora_inicio_reserva AS 'HORA-INICIO',
                                      res_fim_reserva AS 'FIM',
                                      res_hora_fim_reserva AS 'HORA-FIM',
                                      res_destino AS 'DESTINO' 
                            FROM tbl_reservas 
                           WHERE res_placa like '%" + txb_placa.Text + "%' AND res_desc_historico is null";


            dgv_consulta.DataSource = Banco.consulta(vQuery);
            dgv_consulta.Columns[0].Width = 90;
            dgv_consulta.Columns[1].Width = 70;
            dgv_consulta.Columns[2].Width = 90;
            dgv_consulta.Columns[3].Width = 70;
            dgv_consulta.Columns[4].Width = 90;
            dgv_consulta.Columns[5].Width = 70;
            dgv_consulta.Columns[6].Width = 70;
            dgv_consulta.Columns[7].Width = 430;

            //foreach (DataGridViewColumn column in dgv_consulta.Columns)
            //{
            //    //if (column.DataPropertyName == "res_codigo_reserva")
            //    //    column.Width = 10;
            //    //else if (column.DataPropertyName == "res_placa")
            //    //    column.Width = 10;
            //   column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //}


        }

       

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

            string vQuery = @"SELECT  res_codigo_reserva as 'Nr_RESERVA', 
                                      res_placa AS 'PLACA',
                                      res_matricula AS 'MATRICULA',
                                      res_inicio_reserva AS  'INÍCIO',
                                      res_hora_inicio_reserva AS HORA,
                                      res_fim_reserva AS FIM,
                                      res_hora_fim_reserva AS HORA,
                                      res_destino 'AS DESTINO' 
                            FROM tbl_reservas
                            WHERE res_placa like '%" + txb_placa.Text + "%'";

            dgv_consulta.DataSource = Banco.consulta(vQuery);


            
            //a instrução abaixo nã recarrega form
            //Reservas reserva = new Reservas();
            //string placa = txb_placa.Text;

            //reserva.ConsultarReservas(placa);





        }
    }
}
