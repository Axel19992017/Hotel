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
    public partial class frmAddReserva : Form
    {
        string userEmpleado;
        public frmAddReserva(string userEmpleado)
        {
            this.userEmpleado = userEmpleado;
            InitializeComponent();
            lblIdEmpleado.Text = NEmpleado.ObtenerIdEmpleado(userEmpleado).Rows[0][0].ToString();
        }

        private void frmAddReserva_Load(object sender, EventArgs e)
        {
            dgvCliente.DataSource = NCliente.MostrarCorto();
            lblIdReserva.Text = Convert.ToString(NReserva.GetIdReservaNueva());
        }


        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {
            string id = Convert.ToString(dgvCliente.CurrentRow.Cells["Código"].Value);
            lblIdCliente.Text = id;
        }

        private void btnActCliente_Click(object sender, EventArgs e)
        {
            dgvCliente.DataSource = NCliente.MostrarCorto();
        }

        private void btnPaso1_Click(object sender, EventArgs e)
        {
            try
            {
                DReserva reserva = new DReserva();
                reserva.Id_cliente = Convert.ToInt16(lblIdCliente.Text);
                reserva.Id_empleado = Convert.ToInt16(lblIdEmpleado.Text);
                reserva.Fecha_reserva = dtpFechaReserva.Value.ToShortDateString();
                reserva.Divisa = cbDivisaCordobas.Checked ? "C$" : "$";
                reserva.Forma_pago = cbMetodoTarjeta.Checked ? "TARJETA" : "CONTADO";
                reserva.Stat = cbEstadoPagado.Checked ? "PAGADO" : "RESERVADO";

                string res = NReserva.Agregar(reserva);
                if (res == "Listo")
                {
                    
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }

        private void cblDivisa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cblEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clbFormaPago_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnActHabDisp_Click(object sender, EventArgs e)
        {
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //aquí se cierra :D
        }



        private void cbDivisaDolares_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDivisaDolares.Checked)
            {
                cbDivisaCordobas.Checked = false;
            }
            else
            {
                cbDivisaCordobas.Checked = true;
            }
        }

        private void cbDivisaCordobas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDivisaCordobas.Checked)
            {
                cbDivisaDolares.Checked = false;
            }
            else
            {
                cbDivisaDolares.Checked = true;
            }
        }

        private void cbPagoContado_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbPagoContado.Checked)
            {
                cbMetodoTarjeta.Checked = false;
            }
            else
            {
                cbMetodoTarjeta.Checked = true;
            }
        }

        private void cbMetodoTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMetodoTarjeta.Checked)
            {
                cbPagoContado.Checked = false;
            }
            else
            {
                cbPagoContado.Checked = true;
            }
        }

        private void cbEstadoReservado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEstadoReservado.Checked)
            {
                cbEstadoPagado.Checked = false;
            }
            else
            {
                cbEstadoPagado.Checked = true;
            }
        }

        private void cbEstadoPagado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEstadoPagado.Checked)
            {
                cbEstadoReservado.Checked = false;
            }
            else
            {
                cbEstadoReservado.Checked = true;
            }
        }

        private void dgvHabDisp_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dgvHabReserva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvServDisp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
