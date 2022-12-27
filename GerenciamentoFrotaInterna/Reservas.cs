using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoFrotaInterna
{
    internal class Reservas
    {
        public int r_res_codigo_reserva;
        public int r_res_matricula;
        public int r_res_odometro_inicial;
        public int r_res_odometro_final; 
        public string r_res_origem;
        public string r_r_res_destino;
        public DateTime r_res_inicio_reserva;  //Data início reserva
        public DateTime r_res_fim_reserva;     //Data fim reserva
        public DateTime r_res_devolucao;       //Data que realmente foi a devolução veículo
        public DateTime r_data_registro;       //Data em que foi criado registro na tabela
        public string r_user_registro;         //Usuário que criou registro na tabela
        public DateTime r_data_atualizacao;    //Data em que atualizou registro na tabela
        public string r_user_atualizacao;      //Usuário que atualizou registro na tabela




    }
}
