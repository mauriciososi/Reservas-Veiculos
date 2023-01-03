//-----------------------------------------------------------------------------------
// Autor: Mauricio Silva
// Sistema de reserva de veículos frota interna YKK
// 22/12/2022
//-----------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoFrotaInterna
{
    public partial class CheckOut2 : Form
    {
        public CheckOut2()
        {
            InitializeComponent();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_GravarNovo_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Reservas r_reserva = new Reservas();
            try
            {
                
                if (TimeSpan.Parse(mtb_horario_fim.Text) == r_reserva.r_hora_fim_reserva)    //nesse momento variável zerada
                { MessageBox.Show("A hora final deve ser informada"); }
                else if(txb_hodometro_final.Text == "")
                { MessageBox.Show("Hodômetro final deve ser informado"); }
                else
                {
                  
                    //Teste
                    r_reserva.r_codigo_reserva = Convert.ToInt32(txb_codigo_reserva.Text.ToString());
                    dt = Veiculos.ObterVeiculoByPlaca(txb_placa.Text);
                    //O hodômetro inicial será sempre o valor corrente do Master de Veículos
                    r_reserva.r_placa = dt.Rows[0].Field<String>("car_placa");
                    r_reserva.r_odometro_inicial = dt.Rows[0].Field<Int32>("car_hodometro");
                    r_reserva.r_odometro_final = Convert.ToInt32(txb_hodometro_final.Text.ToString());
                    
                    r_reserva.r_devolucao = dateTimePicker2.Value.Date;
                    
                    r_reserva.r_hora_dev_reserva = TimeSpan.Parse(mtb_horario_fim.Text);
                    r_reserva.r_ocorrencias = txb_ocorrencias.Text;
                    r_reserva.r_data_atualizacao =  DateTime.Now;
                    r_reserva.r_user_atualizacao = Globais.useracesso;

                    //Chama método "CheckOutReserva" da classe "Reservas" passando parâmetro "r_reserva"
                    Reservas.CheckOutReserva(r_reserva);
                    
                    //teste
                    //string vQuery = @"UPDATE tbl_veiculos set car_hodometro ="+ r_reserva.r_odometro_final+
                    //                  "WHERE car_placa = '" + txb_placa.Text ;
                    //Banco.consulta(vQuery); //Executa query update



                    //Limpa todo os campos (criar método para procedimento abaixo)


                    foreach (var control in this.Controls)
                    {
                        TextBox tb = control as TextBox;
                        if (tb != null)
                        {
                            tb.Text = string.Empty;
                        }
                        ComboBox cb = control as ComboBox;
                        if (cb != null)
                        {
                            cb.Text = string.Empty;
                        }
                        PictureBox pbx = control as PictureBox;
                        if (pbx != null)
                        {
                            pbx.Image = null;
                        }
                    }
                    Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu o seguinte erro ao gravar a reserva: " + erro.ToString());
            }
        }

        private void CheckOut2_Load(object sender, EventArgs e)
        {

        }
    }
}
