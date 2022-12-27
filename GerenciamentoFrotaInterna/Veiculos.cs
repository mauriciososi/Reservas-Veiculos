using System;
using System.Collections.Generic;
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
    }
}
