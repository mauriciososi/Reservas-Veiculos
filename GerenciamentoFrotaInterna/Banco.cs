using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GerenciamentoFrotaInterna
{
    internal class Banco
    {
        private static SqlConnection conexao;

        public static SqlConnection ConexaoBanco()
        {
            conexao = new SqlConnection(@"Data Source=N20393\SQLEXPRESS; Initial Catalog=db_frotaYKK;Integrated security=True");
            conexao.Open();
            return conexao;
        }
        public static DataTable consulta(string sql)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            //try
            //{
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close(); 
                return dt;
            //}
            //catch (Exception ex)
            //{
            //    // ConexaoBanco().Close();
            //    throw ex;
            //}
        }
        //--------------------------------------------------------------------------------------------//
        // INÍCIO-Funções do FORM F_GestaoDeUsuario (Fica na classe Banco devido uso do "DataTable")  //
        //--------------------------------------------------------------------------------------------//
        public static DataTable ObterUsuarioIdNome()
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT usr_id_usuario as ID, usr_nome as NOME, usr_sobre_nome as SOBRE_NOME  FROM tbl_usuarios";
                da = new SqlDataAdapter(cmd.CommandText, vcon );
                da.Fill(dt);
                vcon.Close();
                return dt;
                
            }
            catch (Exception ex)
            {
              throw ex;
            }

        }
        public static DataTable ObterDadosUsuario(string id)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT *  FROM tbl_usuarios WHERE usr_id_usuario=" + id;
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
        public static DataTable ObterDadosUsuarioUserAcesso(string useracesso)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT *  FROM tbl_usuarios WHERE usr_usuario= '"+useracesso+"' ";
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
        //-----------------------------------------------------------------------------//
        // FIM-Funções do FORM F_GestaoDeUsuarios                                      //
        //-----------------------------------------------------------------------------//

        //------------------------FUNÇÕES/METODOS USUARIOS-----------------------------//
        // INÍCIO-Funções do FORM frm_novousuario (Form2.cs[Design] "Novo usuário"     //
        //-----------------------------------------------------------------------------//
        // INICIO-ROTINAS GRAVAR NOVO USUARIO
        public static void NovoUsuario(Usuario u) {

            if (existeUsername(u))
            {
                MessageBox.Show("Usuário informado já existe, verifique");
                return;
            }
            try
           {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO tbl_usuarios (" +
                    "usr_usuario, " +
                    "usr_senha," +
                    "usr_cod_empresa," +
                    "usr_matricula," +
                    "usr_departamento," +
                    "usr_nome," +
                    "usr_sobre_nome, " +
                    "usr_cnh," +
                    "usr_data_vencimento_cnh," +
                    "usr_Nivel_usuario," +
                    "usr_data_cadastro," +
                    "usr_usuario_cadastro," +
                    "usr_data_atualizacao," +
                    "usr_usuario_atualizacao) " +
                    "VALUES (@usr_usuario," +
                    "@usr_senha," +
                    "@usr_cod_empresa, " +
                    "@usr_matricula," +
                    "@usr_departamento," +
                    "@usr_nome," +
                    "@usr_sobre_nome," +
                    "@usr_cnh," +
                    "@usr_data_vencimento_cnh," +
                    "@usr_Nivel_usuario," +
                    "@usr_data_cadastro," +
                    "@usr_usuario_cadastro," +
                    "@usr_data_atualizacao," +
                    "@usr_usuario_atualizacao)";
                cmd.Parameters.AddWithValue("@usr_usuario", u.w_usuario);
                cmd.Parameters.AddWithValue("@usr_senha", u.w_senha);
                cmd.Parameters.AddWithValue("@usr_cod_empresa", u.w_empresa);
                cmd.Parameters.AddWithValue("@usr_matricula", u.w_matricula);
                cmd.Parameters.AddWithValue("@usr_departamento", u.w_departamento);
                cmd.Parameters.AddWithValue("@usr_nome", u.w_nome);
                cmd.Parameters.AddWithValue("@usr_sobre_nome", u.w_sobrenome);
                cmd.Parameters.AddWithValue("@usr_cnh", u.w_cnh);
                cmd.Parameters.AddWithValue("@usr_data_vencimento_cnh", u.w_data_cnh);
                cmd.Parameters.AddWithValue("@usr_Nivel_usuario", u.w_nivel_acesso);
                cmd.Parameters.AddWithValue("@usr_data_cadastro", u.w_data_registro);
                cmd.Parameters.AddWithValue("@usr_usuario_cadastro", u.w_user_registro);
               //Nesse ponto não precisa gravar os campos de atualização... deixar por enquanto pra não dar erro
                cmd.Parameters.AddWithValue("@usr_data_atualizacao", DateTime.Now);
                cmd.Parameters.AddWithValue("@usr_usuario_atualizacao", "teste");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo usuário inserido com sucesso.");
                ConexaoBanco().Close();
           }
           catch (Exception ex)
           {
              MessageBox.Show("Erro ao gravar novo usuário, verifique!");
           throw;
           }
        }
        //------------------------FUNÇÕES/METODOS USUARIOS-----------------------------//
        // FIM-Funções do FORM frm_novousuario (Form2.cs[Design] "Novo usuário"        //
        //-----------------------------------------------------------------------------//


        //------------------------FUNÇÕES/METODOS VEICULOS-----------------------------//
        // INICIO-Funções do FORM  (AdicionarVeiculos.cs[Design] "Novo veiculo"        //
        //-----------------------------------------------------------------------------//
        // INICIO-ROTINAS GRAVAR VEÍCULOS 
        public static void NovoVeiculo(Veiculos v)
        {

            if (existePlaca(v))
            {
                MessageBox.Show("Veículo informado já existe, verifique");
                return;
            }
         try
         {
            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = "INSERT INTO tbl_veiculos (" +
                "car_empresa," +
                "car_placa," +
                "car_ano," +
                "car_marca," +
                "car_modelo," +
                "car_portas," +
                "car_cor," +
                "car_foto," +
                "car_chassi," +
                "car_combustivel," +
                "car_tipo," +
                "car_hodometro," +
                "car_situacao," +
                "car_data_cadastro," +
                "car_usuario_cadastro," +
                "car_data_atualizacao," +
                "car_usuario_atualizacao) " +
                "VALUES (@car_empresa," +
                "@car_placa," +
                "@car_ano," +
                "@car_marca," +
                "@car_modelo," +
                "@car_portas," +
                "@car_cor," +
                "@car_foto," +
                "@car_chassi," +
                "@car_combustivel," +
                "@car_tipo," +
                "@car_hodometro," +
                "@car_situacao," +
                "@car_data_cadastro," +
                "@car_usuario_cadastro," +
                "@car_data_atualizacao," +
                "@car_usuario_atualizacao)";
            cmd.Parameters.AddWithValue("@car_empresa", v.v_empresa);
            cmd.Parameters.AddWithValue("@car_placa", v.v_placa);
            cmd.Parameters.AddWithValue("@car_ano", v.v_ano);
            cmd.Parameters.AddWithValue("@car_marca", v.v_marca);
            cmd.Parameters.AddWithValue("@car_modelo", v.v_modelo);
            cmd.Parameters.AddWithValue("@car_portas", v.v_portas);
            cmd.Parameters.AddWithValue("@car_cor", v.v_cor);
            cmd.Parameters.AddWithValue("@car_foto", v.v_foto);
            cmd.Parameters.AddWithValue("@car_chassi", v.v_chassi);
            cmd.Parameters.AddWithValue("@car_combustivel", v.v_combustivel);
            cmd.Parameters.AddWithValue("@car_tipo", v.v_tipo);
            cmd.Parameters.AddWithValue("@car_hodometro", v.v_hodometro);
            cmd.Parameters.AddWithValue("@car_situacao", v.v_situacao);
            cmd.Parameters.AddWithValue("@car_data_cadastro", DateTime.Now);
            cmd.Parameters.AddWithValue("@car_usuario_cadastro", Globais.useracesso);
            //Nesse ponto não precisa gravar os campos de atualização... deixar por enquanto pra não dar erro
            cmd.Parameters.AddWithValue("@car_data_atualizacao", DateTime.Now);
            cmd.Parameters.AddWithValue("@car_usuario_atualizacao", Globais.useracesso);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Novo veículo inserido com sucesso.");
            ConexaoBanco().Close();
         }
         catch (Exception ex)
         {
               MessageBox.Show("Erro ao gravar novo usuário, verifique!");
               throw;
         }


        }
        // FIM-ROTINAS GRAVAR VEÍCULOS
        //------------------------FUNÇÕES/METODOS VEICULOS-----------------------------//
        // FIM-Funções do FORM  (AdicionarVeiculos.cs[Design] "Novo veiculo"           //
        //-----------------------------------------------------------------------------//


        //------------------------FUNÇÕES/METODOS RESERVAS-----------------------------//
        // INICIO-Funções do FORM  (F_Reserva.cs[Design] "Nova reserva"                //
        //-----------------------------------------------------------------------------//
        // INICIO-ROTINAS GRAVAR RESERVAS
        public static void NovaReserva(Reservas r)
        {
            //try
            //{
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO tbl_reservas (" +
                    "res_codigo_reserva,"   +
                    "res_matricula,"        +
                    "res_placa,"            +
                    "res_odometro_inicial," +
                    "res_origem,"           +
                    "res_destino,"          +
                    "res_inicio_reserva,"   +
                    "res_hora_inicio_reserva," +
                    "res_fim_reserva,"      +
                    "res_hora_fim_reserva," +
                    "res_data_cadastro,"    +
                    "res_usuario_cadastro)" +
                    "VALUES (@res_codigo_reserva," +
                    "@res_matricula,"        +
                    "@res_placa,"            +
                    "@res_odometro_inicial," +
                    "@res_origem,"           +
                    "@res_destino,"          +
                    "@res_inicio_reserva,"   +
                    "@res_hora_inicio_reserva," +
                    "@res_fim_reserva,"      +
                    "@res_hora_fim_reserva," +
                    "@res_data_cadastro,"    +
                    "@res_usuario_cadastro)";
                cmd.Parameters.AddWithValue("@res_codigo_reserva", r.r_codigo_reserva);
                cmd.Parameters.AddWithValue("@res_matricula", r.r_matricula);
                cmd.Parameters.AddWithValue("@res_placa", r.r_placa);
                cmd.Parameters.AddWithValue("@res_odometro_inicial", r.r_odometro_inicial);
                cmd.Parameters.AddWithValue("@res_origem", r.r_origem);
                cmd.Parameters.AddWithValue("@res_destino", r.r_destino);
                cmd.Parameters.AddWithValue("@res_inicio_reserva", r.r_inicio_reserva);
                cmd.Parameters.AddWithValue("@res_hora_inicio_reserva", r.r_hora_inicio_reserva);
                cmd.Parameters.AddWithValue("@res_fim_reserva", r.r_fim_reserva);
                cmd.Parameters.AddWithValue("@res_hora_fim_reserva", r.r_hora_fim_reserva);
                cmd.Parameters.AddWithValue("@res_data_cadastro", r.r_registro);
                cmd.Parameters.AddWithValue("@res_usuario_cadastro", r.r_user_registro);
                cmd.ExecuteNonQuery();
                MessageBox.Show("          Reserva Nr #" + r.r_codigo_reserva + " confirmada.", "           CONFIRMAÇÃO DA RESERVA", MessageBoxButtons.OK);

                 ConexaoBanco().Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Erro ao gravar novo usuário, verifique!");
            //    throw;
            //}


        }
        // FIM-ROTINAS GRAVAR RESERVAS
        //------------------------FUNÇÕES/METODOS RESERVAS-----------------------------//
        // FIM-Funções do FORM  (F_Reserva.cs[Design] "Nova reserva"           //
        //-----------------------------------------------------------------------------//


        //----------------------------INICIO-ROTINAS GERAIS----------------------------//
        //                    (USUARIO/VEICULOS/RESERVAS/OFICINAS)                     //
        //-----------------------------------------------------------------------------//
        //***SETOR USUARIO***
        public static bool existeUsername(Usuario u)
        {
            bool res;

            SqlDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT usr_usuario FROM tbl_usuarios" +
                "                       WHERE usr_usuario ='" + u.w_usuario + "'";
            da = new SqlDataAdapter(cmd.CommandText, ConexaoBanco());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;

        }
        //-----------------------------------------------------------------------------//
        //***SETOR VEICULOS***                                                         //
        //-----------------------------------------------------------------------------//
        public static bool existePlaca(Veiculos v)
        {
            bool res;

            SqlDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT car_placa FROM tbl_veiculos" +
                "                       WHERE car_placa ='" + v.v_placa + "'";
            da = new SqlDataAdapter(cmd.CommandText, ConexaoBanco());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }





        //----------------------------FIM-ROTINAS GERAIS-------------------------------//
        //                    (USUARIO/VEICULOS/RESERVAS/OFICINAS)                     //
        //-----------------------------------------------------------------------------//



    }
}
