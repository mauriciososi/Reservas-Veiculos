using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace GerenciamentoFrotaInterna
{
    public partial class F_Reserva : Form
    {
        public F_Reserva()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgv_veiculos_reserva_SelectionChanged(object sender, EventArgs e)
        {
            //Esse bloquinho abaixo é pq GridView passa várias vezes antes de carregar
            //para evitar que entre sem necessidade
            // só quando tiver linhas selecionadas ou seja, maior do que zero
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                //irá carregar cada linha selecionad
                dt = Veiculos.ObterDadosVeiculo(vid); //retorna dados do veículo que possui o ID especifico do parametro para "dt"
                                                   //Field<Int64>("usr_id_usuario").ToString();

                //cb_empresa.Text = dt.Rows[0].Field<Int32>("car_empresa").ToString();
                txb_ano.Text = dt.Rows[0].Field<Int32>("car_ano").ToString();
                txb_modelo.Text = dt.Rows[0].Field<string>("car_modelo").ToString();
                txb_placa.Text = dt.Rows[0].Field<string>("car_placa").ToString();
                cb_marca.Text = dt.Rows[0].Field<string>("car_marca").ToString();
                txb_cor.Text = dt.Rows[0].Field<string>("car_cor").ToString();
                //Foto preciso confirmar como levar para tela...
                pb_FotoCarro.ImageLocation = dt.Rows[0].Field<string>("car_foto");
                cb_combustivel.Text = dt.Rows[0].Field<string>("car_combustivel").ToString();
                // txb_chassi.Text = dt.Rows[0].Field<string>("car_chassi").ToString();
                txb_hodometro_inicial_reserva.Text = dt.Rows[0].Field<Int32>("car_hodometro").ToString();
               // txb_qtdportas.Text = dt.Rows[0].Field<Int32>("car_portas").ToString();
               // cb_tipo.Text = dt.Rows[0].Field<string>("car_tipo").ToString();
               // cb_situacao.Text = dt.Rows[0].Field<string>("car_situacao").ToString();

               

            }
        }

        private void F_Reserva_Load(object sender, EventArgs e)
        {
            dgv_veiculos_reserva.DataSource = Veiculos.ObterVeiculoIdPlaca();
            dgv_veiculos_reserva.Columns[0].Width = 80;
            dgv_veiculos_reserva.Columns[1].Width = 120;
            DataTable dtusr = new DataTable();
            dtusr = Usuario.ObterDadosUsuarioUserAcesso(Globais.useracesso);
            cb_empresa.Text = dtusr.Rows[0].Field<Int32>("usr_cod_empresa").ToString();
            txb_nome_completo.Text = dtusr.Rows[0].Field<string>("usr_nome").ToString() + " " +
                                     dtusr.Rows[0].Field<string>("usr_sobre_nome").ToString();
            txb_matricula.Text = dtusr.Rows[0].Field<Int32>("usr_matricula").ToString();

            Usuario desc = new Usuario();
            txb_descEmpresa.Text = desc.DescricaoEmpresa(this.cb_empresa, this.txb_descEmpresa);
            
            //teste para desabilitar
            //dtp_inicio_reserva.Enabled = false;
            //dtp_fim_reserva.Enabled = false;

            //Inicia a tela com botão desabilitado, até serem preenchidos corretamente todos os campos
            btn_GravarNovo.Enabled = false;
            
            ////CreateMyDateTimePicker();
            //DateTimePicker dateTimePicker1 = new DateTimePicker();

            //dateTimePicker1.Format = DateTimePickerFormat.Custom;

            //// Set the MinDate and MaxDate.
            //dateTimePicker1.MinDate = new DateTime(2022, 12, 28);
            //dateTimePicker1.MaxDate = new DateTime(2022, 12, 28);
            //dateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd";
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;

        }

        // teste date 
        //public void CreateMyDateTimePicker()
        //{
        //    ////     Create a new DateTimePicker control and initialize it.
        //    //DateTimePicker dateTimePicker1 = new DateTimePicker();

        //    //dateTimePicker1.Format = DateTimePickerFormat.Custom;

        //    //// Set the MinDate and MaxDate.
        //    //dateTimePicker1.MinDate = new DateTime(2022, 12, 28);
        //    //dateTimePicker1.MaxDate = new DateTime(2022, 12, 28);

        //    // Set the CustomFormat string.
        //   // dateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd";
        //   // dateTimePicker1.Format = DateTimePickerFormat.Custom;

        //    // Show the CheckBox and display the control as an up-down control.
        //   // dateTimePicker1.ShowCheckBox = true;
        //   //dateTimePicker1.ShowUpDown = true;
        //    //  dtp_inicio_reserva = dateTimePicker1;

        //}


            private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //Reservas wReserva = new Reservas();
            //wReserva.CheckReservasDates();
            if (DateTime.Today > (Convert.ToDateTime(dtp_inicio_reserva)))
            {
                MessageBox.Show("Data INÍCIO informada, é inferior a data de hoje, verifique");

                return;
            }



            if (DateTime.Today > (Convert.ToDateTime(dtp_fim_reserva)))
            {
                MessageBox.Show("Data FIM informada, é inferior a data de hoje, verifique");

                return;
            }



            if ((Convert.ToDateTime(dtp_inicio_reserva)) > (Convert.ToDateTime(dtp_fim_reserva)))
            {
                MessageBox.Show("Data fim reserva menor que data inicio, verifique");

                return;
            }


            if (Convert.ToDateTime(mtb_horario_inicio) > (Convert.ToDateTime(mtb_horario_fim)))
            {
                MessageBox.Show("Hora INÍCIO informada, é superior a hora FINAL da reserva, verifique");

                return;
            }


            btn_GravarNovo.Enabled = true;

            //datepicker blockdates
            // verificar bloqueio de datas no calendário ....colocar aqui

        } 
        private void btn_GravarNovo_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {

                if (item is System.Windows.Forms.TextBox && String.IsNullOrWhiteSpace(item.Text))
                {
                    MessageBox.Show("O campo >>>: " + item.Name + "<<< é de preenchimento obrigatório!");
                    item.Focus();
                    return;
                }
            }



           


            //if (DateTime.Today.TimeOfDay) > (Convert.ToDateTime(mtb_horario_fim)))
            //{
            //    MessageBox.Show("Hora informada, é superior a hora FINAL da reserva, verifique");

            //    return;
            //}



            Reservas r_reserva = new Reservas();
            r_reserva.CheckReservasDates();
            



            r_reserva.r_placa = txb_placa.Text;          
            r_reserva.r_matricula = Convert.ToInt32(txb_matricula.Text.ToString());
            r_reserva.r_odometro_inicial = Convert.ToInt32(txb_hodometro_inicial_reserva.Text.ToString());
            r_reserva.r_odometro_final = 0; // por enquanto deixar zero...ver depois
            r_reserva.r_origem = txb_origem_reserva.Text;
            r_reserva.r_destino = txb_destino_reserva.Text;
           
            DateTime fromdate = Convert.ToDateTime(dtp_inicio_reserva.Text);
            r_reserva.r_inicio_reserva = fromdate;
            DateTime todate = Convert.ToDateTime(dtp_fim_reserva.Text);
            r_reserva.r_hora_inicio_reserva = Convert.ToDateTime(mtb_horario_inicio.Text);
            
            r_reserva.r_fim_reserva = todate;
            r_reserva.r_hora_fim_reserva = Convert.ToDateTime(mtb_horario_fim.Text);
            // r_reserva.r_devolucao    // por enquanto deixar zero...ver depois

            DateTime wDate = new DateTime();
            r_reserva.r_registro = DateTime.Now;
            r_reserva.r_user_registro = Globais.useracesso;

            int numero_reserva = Reservas.getNumeroReserva(0);
            r_reserva.r_codigo_reserva = Convert.ToInt32(numero_reserva);
                        

            //Chama método "NovaReserva" da classe "Banco" passando parâmetro "r_reserva"
            Banco.NovaReserva(r_reserva);


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
}
