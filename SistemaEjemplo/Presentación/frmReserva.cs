using SistemaEjemplo.Datos;
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
    public partial class frmReserva : Form
    {
        public frmReserva()
        {
            InitializeComponent();
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
           
            dgvReserva.DataSource = NReserva.Mostrar();
            cbHabitDisp.DataSource = NOperaciones.DisponibilidadHabitReserva(dtpFechaEntrada.Value.ToShortDateString(), dtpFechaSalida.Value.ToShortDateString());
            cbHabitDisp.ValueMember = "IdHabitacion";
            cbHabitDisp.DisplayMember = "IdHabitacion";
            cbHabitDisp.SelectedIndex = 0;
            
        }

        private void dgvReserva_DoubleClick(object sender, EventArgs e)
        {
            int idReserva = Convert.ToInt16(this.dgvReserva.CurrentRow.Cells["IdReserva"].Value);
            dgvHabitaciones.DataSource = NHabitacionReserva.MostrarHabitaciones(idReserva);
            dgvServicios.DataSource = null;
            lblidHabitRes.Text = "<IdHabitRes>";
            lblIdReserva.Text = Convert.ToString(idReserva);
        }

        private void dgvHabitaciones_DoubleClick(object sender, EventArgs e)
        {
            int idHabitReser = Convert.ToInt16(this.dgvHabitaciones.CurrentRow.Cells["Código"].Value);
            Console.WriteLine(idHabitReser);
            dgvServicios.DataSource = NHabitacionServicioReserva.MostrarServiciosHabitacion(idHabitReser);
            lblidHabitRes.Text = Convert.ToString(idHabitReser);
            int idHabitRes = Convert.ToInt16(lblidHabitRes.Text);
            cbServicio.DataSource = NHabitacionServicioReserva.MostrarServicHabitReserDispon(idHabitRes);
            cbServicio.ValueMember = "id_servicio";
            cbServicio.DisplayMember = "id_servicio";
            cbServicio.SelectedIndex = 0;

        }

        private void lblHabRes_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void cbHabitDisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idHabit = Convert.ToInt32(cbHabitDisp.GetItemText(cbHabitDisp.SelectedItem));
                lblPrecio.Text = NHabitacion.MostrarPrecioHabitacion(idHabit).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnActHabDisp_Click(object sender, EventArgs e)
        {
            cbHabitDisp.DataSource = NOperaciones.DisponibilidadHabitReserva(dtpFechaEntrada.Value.ToShortDateString(), dtpFechaSalida.Value.ToShortDateString());
            cbHabitDisp.ValueMember = "IdHabitacion";
            cbHabitDisp.DisplayMember = "IdHabitacion";
        }

        private void btnAddHabit_Click(object sender, EventArgs e)
        {
            int idHabit = Convert.ToInt32(cbHabitDisp.GetItemText(cbHabitDisp.SelectedItem));
            int idReserva = Convert.ToInt32(lblIdReserva.Text);
            double precio = Convert.ToDouble(lblPrecio.Text);
            string fechaEntrada = dtpFechaEntrada.Value.ToShortDateString();
            string fechaSalida = dtpFechaSalida.Value.ToShortDateString();
            string res = NHabitacionReserva.Agregar(new DHabitacionReserva(idHabit, idReserva, fechaEntrada, fechaSalida, precio));
            if(res == "Listo")
            {
                dgvHabitaciones.DataSource = NHabitacionReserva.MostrarHabitaciones(idReserva);
                cbHabitDisp.DataSource = NOperaciones.DisponibilidadHabitReserva(dtpFechaEntrada.Value.ToShortDateString(), dtpFechaSalida.Value.ToShortDateString());
                cbHabitDisp.ValueMember = "IdHabitacion";
                cbHabitDisp.DisplayMember = "IdHabitacion";
            }
            else
            {
                Console.WriteLine(res);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idServicio = Convert.ToInt16(cbServicio.GetItemText(cbServicio.SelectedItem));
                lblPrecioServicio.Text = Convert.ToString(NServicios.MostrarPrecio(idServicio));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idHabitRes = Convert.ToInt16(lblidHabitRes.Text);
            int idServicio = Convert.ToInt16(cbServicio.GetItemText(cbServicio.SelectedItem));
            string res = NHabitacionServicioReserva.Agregar(new DHabitacionServicioReserva(idHabitRes,idServicio));
            
            if(res == "Listo")
            {
                dgvServicios.DataSource = NHabitacionServicioReserva.MostrarServiciosHabitacion(idHabitRes);

                cbServicio.DataSource = NHabitacionServicioReserva.MostrarServicHabitReserDispon(idHabitRes);
                cbServicio.ValueMember = "id_servicio";
                cbServicio.DisplayMember = "id_servicio";
                cbServicio.SelectedIndex = 0;
            }
            else
            {
                Console.WriteLine(res);
            }
        }
    }
}
