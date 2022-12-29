using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoFrotaInterna
{
    internal class Usuario
    {
        public string w_usuario;
        public string w_senha;
        public int w_empresa ;
        public int w_matricula;
        public string w_departamento;
        public string w_nome;
        public string w_sobrenome;
        public string w_cnh;
        public DateTime w_data_cnh;          //Vencimento
        public int w_nivel_acesso;           //0=básico,1=médio,2=Administrador
        public DateTime w_data_registro;     //Data em que foi criado registro na tabela
        public string w_user_registro;       //Usuário que criou registro na tabela
        public DateTime w_data_atualizacao;  //Data em que atualizou registro na tabela
        public string w_user_atualizacao;    //Usuário que atualizou registro na tabela

        //Propriedade w_empresa
        //public string DescricaoEmpresa(TextBox tb_empresa, string desc_empresa)
        public string DescricaoEmpresa(ComboBox cb_empresa, TextBox desc_empresa)

        {
            int valor = Convert.ToInt32(cb_empresa.Text);
            if (valor == 1)
            {
                desc_empresa.Text = "MATRIZ/SP CORPORATE";
            }
            else if (valor == 04)
            {
                desc_empresa.Text = "YOSHIDA BRASIL";
            }
            else if (valor == 10)
            {
                desc_empresa.Text = "FÁBRICA/SOROCABA";
            }
            else if (valor == 13)
            {
                desc_empresa.Text = "FÁBRICA/YOSHIDA NORDESTE";
            }


            return desc_empresa.Text;
        }


        public static DataTable ObterTodosFuncionarios()
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = Banco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tbl_usuarios";
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
                var vcon = Banco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT *  FROM tbl_usuarios WHERE usr_usuario= '" + useracesso + "' ";
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

        public static void AtualizarUsuario(Usuario u)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = Banco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tbl_usuarios SET usr_usuario='" + u.w_usuario + "', usr_senha='" + u.w_senha + "'," + "usr_cod_empresa=" + u.w_empresa + ", usr_matricula =" + u.w_matricula + "," + "usr_departamento ='" + u.w_departamento + "',usr_nome ='" + u.w_nome + "'," + "usr_sobre_nome ='" + u.w_sobrenome + "',usr_cnh =" + u.w_cnh + "," +
                                                               "usr_Nivel_usuario =" + u.w_nivel_acesso + "," +
                                                               //   "usr_data_atualizacao="+ u.w_data_cnh + "," +
                                                               "usr_usuario_atualizacao = '" + Globais.useracesso + "' WHERE usr_matricula =" + u.w_matricula;

                da = new SqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void ExcluirUsuario(string id)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = Banco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tbl_usuarios WHERE usr_id_usuario=" + id;
                da = new SqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }







    }

}
