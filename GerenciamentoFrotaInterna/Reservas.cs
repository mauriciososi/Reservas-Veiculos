using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.InteropServices.WindowsRuntime;

namespace GerenciamentoFrotaInterna
{
    internal class Reservas
    {
        public int r_codigo_reserva;
        public int r_matricula;
        public string r_placa;
        public int r_odometro_inicial;
        public int r_odometro_final; 
        public string r_origem;
        public string r_destino;
        public DateTime r_inicio_reserva;          //Data início reserva
        public TimeSpan r_hora_inicio_reserva;     //Hora inicio reserva prevista
        public DateTime r_fim_reserva;             //Data fim reserva prevista
        public TimeSpan r_hora_fim_reserva;        //Hora fim reserva prevista
        public DateTime r_devolucao;               //Data que realmente foi a devolução veículo
        public TimeSpan r_hora_dev_reserva;        //Hora inicio reserva prevista
        public DateTime r_registro;                //Data em que foi criado registro na tabela
        public string r_user_registro;             //Usuário que criou registro na tabela
        public DateTime r_data_atualizacao;        //Data em que atualizou registro na tabela
        public string r_user_atualizacao;          //Usuário que atualizou registro na tabela


        public static int GetNumeroReserva(int nr)
        {

            var vcon = Banco.ConexaoBanco();
            var cmd = vcon.CreateCommand();
            SqlCommand cmd5 = new SqlCommand("SELECT MAX(numr_codigo_reserva)+1 AS ID FROM   tbl_numeroreservas", vcon);
            Int32 next = (Int32)cmd5.ExecuteScalar();
            vcon.Close();

            vcon.Open();
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();

            cmd.CommandText =
            "UPDATE tbl_numeroreservas SET numr_codigo_reserva =" + next + " where numr_codigo_reserva>0";

            da = new SqlDataAdapter(cmd.CommandText, vcon);
            cmd.ExecuteNonQuery();
            vcon.Close();
            return next;

        }

        public void CheckReservasDates()
        {
            F_Reserva wreserva = new F_Reserva();

            if (DateTime.Today > (Convert.ToDateTime(r_inicio_reserva)))
            {
                MessageBox.Show("Data INÍCIO informada, é inferior a data de hoje, verifique");

                return;
            }
            


            if (DateTime.Today > (Convert.ToDateTime(r_inicio_reserva)))
            {
                MessageBox.Show("Data FIM informada, é inferior a data de hoje, verifique");

                return;
            }



            if ((Convert.ToDateTime(r_inicio_reserva)) > (Convert.ToDateTime(r_fim_reserva)))
            {
                MessageBox.Show("Data fim reserva menor que data inicio, verifique");

                return;
            }


            if (r_hora_inicio_reserva > (r_hora_fim_reserva))
            {
                MessageBox.Show("Hora INÍCIO informada, é superior a hora FINAL da reserva, verifique");

                return;
            }


            if (DateTime.Today > (Convert.ToDateTime(r_hora_fim_reserva)))
            {
                MessageBox.Show("Hora informada, é superior a hora FINAL da reserva, verifique");

                return;
            }

        }


        public static DataTable ObterDadosReserva(int reserva)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = Banco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT *  FROM tbl_reservas WHERE res_codigo_reserva=" +reserva;
                da = new SqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        public void ConsultarReservas(string placa)
        {
            Consulta consulta = new Consulta(placa);
            string vQuery = @"SELECT  res_codigo_reserva as 'Nr_RESERVA', 
                                      res_placa AS 'PLACA',
                                      res_matricula AS 'MATRICULA',
                                      res_inicio_reserva AS  'INÍCIO',
                                      res_hora_inicio_reserva AS HORA,
                                      res_fim_reserva AS FIM,
                                      res_hora_fim_reserva AS HORA,
                                      res_destino 'AS DESTINO' 
                            FROM tbl_reservas
                            WHERE res_placa like '%" + placa + "%'";

            consulta.dgv_consulta.DataSource = Banco.consulta(vQuery);
            //dgv_consulta.Columns[0].Width = 300;
            

            foreach (DataGridViewColumn column in consulta.dgv_consulta.Columns)
            {
                //if (column.DataPropertyName == "res_codigo_reserva")
                //    column.Width = 10; 
                //else if (column.DataPropertyName == "res_placa")
                //    column.Width = 10; 
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
           // consulta.ShowDialog();
        }




    }
}
