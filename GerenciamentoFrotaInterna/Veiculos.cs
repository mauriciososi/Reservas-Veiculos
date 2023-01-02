using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoFrotaInterna
{
    internal class Veiculos
    {
        public int v_empresa;
        public string v_placa;
        public int v_ano;
        public string v_marca;
        public string v_modelo;
        public int v_portas;  //Nr de portas
        public string v_cor;
        public string v_foto;
        public string v_chassi;
        public string v_combustivel;
        public string v_tipo;  //Executivo/Operacional/Sales force etc..
        public int v_hodometro;
        public string v_situacao;   //Veículo próprio/Alugado/etc
        public string v_fornecedor;    //Concessionária Ford/GM/multimarcas etc
        public DateTime v_data_registro;     //Data em que foi criado registro na tabela
        public string v_user_registro;       //Usuário que criou registro na tabela
        public DateTime v_data_atualizacao;  //Data em que atualizou registro na tabela
        public string v_user_atualizacao;    //Usuário que atualizou registro na tabela


        public static DataTable ObterVeiculoIdPlaca()
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = Banco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT car_id as ID, car_placa as PLACA, car_marca as MARCA, car_modelo as MODELO  FROM tbl_veiculos order by car_id ";
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
        public static DataTable ObterVeiculoByPlaca(string placa)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = Banco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT *  FROM tbl_veiculos WHERE car_placa='"+ placa+"' ";
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

        public static DataTable ObterDadosVeiculo(string id)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = Banco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT *  FROM tbl_veiculos WHERE car_id=" + id;
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

        public static void AtualizarVeiculo(Veiculos v)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = Banco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tbl_veiculos SET car_placa='" + v.v_placa + "',car_ano=" + v.v_ano + ",car_marca='" + v.v_marca + "',car_modelo='" + v.v_modelo + "',car_portas=" + v.v_portas + ",car_cor='" + v.v_cor + "',car_foto='" + v.v_foto + "',car_chassi='" + v.v_chassi + "',car_combustivel='" + v.v_combustivel + "',car_tipo='" + v.v_tipo + "',car_hodometro=" + v.v_hodometro + ",car_situacao='" + v.v_situacao + "',car_usuario_atualizacao='" + Globais.useracesso + "' WHERE car_placa= '" + v.v_placa + "'";
                da = new SqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void ExcluirVeiculo(string placa)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = Banco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tbl_veiculos WHERE car_placa= '" + placa + "'";
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
