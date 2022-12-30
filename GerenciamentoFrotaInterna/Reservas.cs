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


        public static int getNumeroReserva(int nr)
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



    }
}
