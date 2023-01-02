﻿using System;
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
    public partial class Consultar_Usuario : Form
    {
        public Consultar_Usuario()
        {
            InitializeComponent();
        }

        private void Consultar_Usuario_Load(object sender, EventArgs e)
        {
            string vQuery = @"SELECT  usr_matricula AS 'Nr_MATRICULA', 
                                      usr_nome AS 'NOME',
                                      usr_sobre_nome AS 'SOBRE NOME',
                                      usr_usuario AS  'LOGIN',
                                      usr_departamento AS 'DEPARTAMENTO',
                                      usr_Nivel_usuario 'NÍVEL DE ACESSO',
                                      usr_cnh AS 'CNH',
                                      usr_data_vencimento_cnh AS 'DATA VENCIMENTO CNH' 
                            FROM tbl_usuarios";
            dgv_consulta_usuario.DataSource = Banco.consulta(vQuery);
            //dgv_consulta.Columns[0].Width = 300;
            //dgv_consulta.Columns[0].Width = 100;
            //dgv_consulta.Columns[0].Width = 100;
            //dgv_consulta.Columns[0].Width = 100;
            //dgv_consulta.Columns[0].Width = 100;
            //dgv_consulta.Columns[0].Width = 100;
            //dgv_consulta.Columns[0].Width = 100;
            //dgv_consulta.Columns[0].Width = 100;

            foreach (DataGridViewColumn column in dgv_consulta_usuario.Columns)
            {
                //if (column.DataPropertyName == "res_codigo_reserva")
                //    column.Width = 10;
                //else if (column.DataPropertyName == "res_placa")
                //    column.Width = 10;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btn_fecharC_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
