using System;
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
    public partial class testeDate : Form
    {
        public testeDate()
        {
            InitializeComponent();
        }

        private void testeDate_Load(object sender, EventArgs e)
        {
            CreateMyDateTimePicker();

        }

        public void CreateMyDateTimePicker()
        {
            //     Create a new DateTimePicker control and initialize it.
            DateTimePicker dateTimePicker1 = new DateTimePicker();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            // Set the MinDate and MaxDate.
            dateTimePicker1.MinDate = new DateTime(2022, 12, 28);
            dateTimePicker1.MaxDate = new DateTime(2022, 12, 28);

            // Set the CustomFormat string.
            // dateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd";
            // dateTimePicker1.Format = DateTimePickerFormat.Custom;

            // Show the CheckBox and display the control as an up-down control.
            // dateTimePicker1.ShowCheckBox = true;
            //dateTimePicker1.ShowUpDown = true;
            //  dtp_inicio_reserva = dateTimePicker1;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
