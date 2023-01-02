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
                                      res_hora_inicio_reserva AS 'HORA',
                                      res_fim_reserva AS 'FIM',
                                      res_hora_fim_reserva AS 'HORA',
                                      res_destino AS 'DESTINO' 
                            FROM tbl_reservas 
                           WHERE res_placa like '%" + txb_placa.Text + "%'";


            dgv_consulta.DataSource = Banco.consulta(vQuery);
            //dgv_consulta.Columns[0].Width = 300;
            //dgv_consulta.Columns[0].Width = 100;
            //dgv_consulta.Columns[0].Width = 100;
            //dgv_consulta.Columns[0].Width = 100;
            //dgv_consulta.Columns[0].Width = 100;
            //dgv_consulta.Columns[0].Width = 100;
            //dgv_consulta.Columns[0].Width = 100;
            //dgv_consulta.Columns[0].Width = 100;

            foreach (DataGridViewColumn column in dgv_consulta.Columns)
            {
                //if (column.DataPropertyName == "res_codigo_reserva")
                //    column.Width = 10;
                //else if (column.DataPropertyName == "res_placa")
                //    column.Width = 10;
               column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }


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
