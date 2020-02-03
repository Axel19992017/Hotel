using SistemaEjemplo.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEjemplo.Presentación
{
    public partial class frmDisponibilidadHabitaciones : Form
    {
        public frmDisponibilidadHabitaciones()
        {
            InitializeComponent();
        }
        private void getIdHabit()
        {
            cbNumHabitación.DisplayMember = "no_habitacion";
            cbNumHabitación.ValueMember = "no_habitacion";
            cbNumHabitación.DataSource = NOperaciones.GetIdHabitaciones();

        }
        private void frmDisponibilidadHabitaciones_Load(object sender, EventArgs e)
        {
            getIdHabit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbHabit_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string fechaEntrada, fechaSalida;
            fechaEntrada = dtpFechaEntrada.Value.ToShortDateString();
            fechaSalida = dtpFechaSalida.Value.ToShortDateString();

            if (cbxNoHabitacion.Checked == false)
            {
                int idHabit = int.Parse(cbNumHabitación.SelectedValue.ToString());
                
                dvResultado.DataSource = NOperaciones.DisponibilidadHabitConid(idHabit, fechaEntrada, fechaSalida);
            }
            else
            {
                dvResultado.DataSource = NOperaciones.DisponibilidadHabit(fechaEntrada, fechaSalida);
            }

        }

        private void cbIdHabitación_CheckStateChanged(object sender, EventArgs e)
        {
            if(cbxNoHabitacion.Checked == true)
            {
                cbNumHabitación.Enabled = false;
            }
            else
            {
                cbNumHabitación.Enabled = true;
            }
        }
    }
}
