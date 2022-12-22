using System;
using System.Collections.Generic;
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
        public int w_empresa;
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

       

    }
}
