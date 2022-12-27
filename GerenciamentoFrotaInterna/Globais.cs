using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoFrotaInterna
{
      internal class Globais
    {
        public static string versao="1.0";
        public static Boolean logado=false;
        public static int nivel=0;
        public static string useracesso = " ";
        public static string caminhoFotos = @"C:\Curso C#\Frota Interna YKK\GerenciamentoFrotaInterna\Imagens\carros\";

        ////** Rotina de limpeza
        //public void ClearTextBoxes(Control control)
        //{
        //    foreach (Control c in control.Controls)
        //    {
        //        if (c is TextBox)
        //        {
        //            ((TextBox)c).Clear();
        //        }

        //        if (c.HasChildren)
        //        {
        //            ClearTextBoxes(c);
        //        }


        //        if (c is CheckBox)
        //        {

        //            ((CheckBox)c).Checked = false;
        //        }

        //        if (c is RadioButton)
        //        {
        //            ((RadioButton)c).Checked = false;
        //        }
        //    }
        //}


    }
}
