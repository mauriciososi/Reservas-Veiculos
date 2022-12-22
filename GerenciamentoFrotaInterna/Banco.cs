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

        private static SqlConnection ConexaoBanco()
        {
            conexao = new SqlConnection(@"Data Source=N20393\SQLEXPRESS; Initial Catalog=db_frotaYKK;Integrated security=True");
            conexao.Open();
            return conexao;
        }

        public static DataTable ObterTodosFuncionarios()
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tbl_usuarios";
                    da = new SqlDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }

        }
        public static DataTable consulta(string sql)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SqlDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
               // ConexaoBanco().Close();
                throw ex;
            }
        }
        // INÍCIO-Funções do FORM F_GestaoDeUsuarios
        public static DataTable ObterUsuarioIdNome()
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT usr_id_usuario as ID, usr_nome as NOME, usr_sobre_nome as SOBRE_NOME  FROM tbl_usuarios";
                    da = new SqlDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }

        }
        public static DataTable ObterDadosUsuario(string id)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT *  FROM tbl_usuarios WHERE usr_id_usuario=" + id;
                    da = new SqlDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }

        }

        public static void AtualizarUsuario(Usuario u)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "UPDATE tbl_usuarios SET usr_usuario='" + u.w_usuario + "', usr_senha='" + u.w_senha + "'," + "usr_cod_empresa=" + u.w_empresa + ", usr_matricula =" + u.w_matricula + "," + "usr_departamento ='" + u.w_departamento + "',usr_nome ='" + u.w_nome + "'," + "usr_sobre_nome ='" + u.w_sobrenome + "',usr_cnh =" + u.w_cnh +"," +
                                                               "usr_Nivel_usuario ="+u.w_nivel_acesso+"," +
                                                      //       "usr_data_atualizacao="+DateTime.Now+"," +
                                                               "usr_usuario_atualizacao = '" + Globais.useracesso + "' WHERE usr_matricula =" +u.w_matricula;

                    da = new SqlDataAdapter(cmd.CommandText, ConexaoBanco());
                    cmd.ExecuteNonQuery();
                    ConexaoBanco().Close();
                    
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }

        }

        public static void ExcluirUsuario(string id)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM tbl_usuarios WHERE usr_id_usuario=" + id;

                    da = new SqlDataAdapter(cmd.CommandText, ConexaoBanco());
                    cmd.ExecuteNonQuery();
                    ConexaoBanco().Close();

                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }

        }



        // FIM-Funções do FORM F_GestaoDeUsuarios

        // INÍCIO-Funções do FORM frm_novousuario (Form2.cs[Design] "Novo usuário"
        public static void NovoUsuario(Usuario u) {

            if (existeUsername(u))
            {
                MessageBox.Show("Usuário informado já existe, verifique");
                return;
            }
            //try
           // {
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
           // }
           // catch (Exception ex)
           // {
           //     MessageBox.Show("Erro ao gravar novo usuário, verifique!");
                //throw;
           // }
            

        }
        // FIM-Funções do Form "Novo usuário"

        // INICIO-ROTINAS GERAIS
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
        // FIM-ROTINAS GERAIS

        

    }
}
