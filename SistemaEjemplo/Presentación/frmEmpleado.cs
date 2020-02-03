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
    public partial class frmEmpleado : Form
    {
        private bool isNuevo = false;
        private bool isEditar = false;

        public void LimpiarCampos()
        {
            this.TXTpnombre.Text = string.Empty;
            this.TXTsnombre.Text = string.Empty;
            this.TXTpapellido.Text = string.Empty;
            this.TXTsapellido.Text = string.Empty;
            this.TXTdireccion.Text = string.Empty;
            this.TXTtelefono.Text = string.Empty;
            this.TXTcorreo.Text = string.Empty;
        }

        public void HabilitarCampos(bool valor)
        {
            this.TXTpnombre.Enabled = valor;
            this.TXTsnombre.Enabled = valor;
            this.TXTpapellido.Enabled = valor;
            this.TXTsapellido.Enabled = valor;
            this.TXTdireccion.Enabled = valor;
            this.TXTtelefono.Enabled = valor;
            this.TXTcorreo.Enabled = valor;
        }

        public void EstadoBotones(string estado)
        {
            if (estado.Equals("ORIGINAL"))
            {
                this.BTNnuevo.Enabled = true;//ESTADO ORIGINAL DE LOS BOTONES
                this.BTNguardar.Enabled = false;
                this.BTNcancelar.Enabled = false;
                this.BTNeditar.Enabled = false;
                this.BTNeliminar.Enabled = false;
            }
            if (estado.Equals("EDICION") || estado.Equals("NUEVO"))
            {
                this.BTNnuevo.Enabled = false;
                this.BTNguardar.Enabled = true;
                this.BTNcancelar.Enabled = true;
                this.BTNeditar.Enabled = false;
                this.BTNeliminar.Enabled = false;
            }
        }

        public frmEmpleado()
        {
            InitializeComponent();
        }

        public void MostrarTabla()
        {
            this.TABLEdatos.DataSource = NEmpleado.MostrarTablaEmpleado();

        }

        private void BTNnuevo_Click(object sender, EventArgs e)
        {
            this.isNuevo = true;
            this.HabilitarCampos(true);
            this.EstadoBotones("NUEVO");

        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            this.MostrarTabla();
        }

        private void BTNcancelar_Click(object sender, EventArgs e)
        {
            this.isEditar = false;
            this.isNuevo = false;
            this.EstadoBotones("ORIGINAL");
            this.LimpiarCampos();
            this.HabilitarCampos(false);

        }

        private void TABLEdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!this.isNuevo)
            {
                this.BTNeditar.Enabled = true;
                if (!this.isEditar)
                {
                    this.BTNeliminar.Enabled = true;
                }
            }
        }

        private void BTNguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";

                if (this.isNuevo)
                {
                    rpta = NEmpleado.InsertarEmpleado(
                        this.TXTpnombre.Text,
                        this.TXTsnombre.Text,
                        this.TXTpapellido.Text,
                        this.TXTsapellido.Text,
                        this.TXTdireccion.Text,
                        this.TXTtelefono.Text,
                        this.TXTcorreo.Text);

                }
                else
                {
                    rpta = NEmpleado.EditarEmpleado(
                        Convert.ToInt32(this.TABLEdatos.CurrentRow.Cells["ID de empleado"].Value),
                        this.TXTpnombre.Text,
                        this.TXTsnombre.Text,
                        this.TXTpapellido.Text,
                        this.TXTsapellido.Text,
                        this.TXTdireccion.Text,
                        this.TXTtelefono.Text,
                        this.TXTcorreo.Text);

                }

                if (rpta.Equals("OK"))
                {
                    if (this.isNuevo)
                    {
                        this.MensajeOk("Se Insertó de forma correcta el registro");
                    }
                    else
                    {
                        this.MensajeOk("Se Actualizó de forma correcta el registro");
                    }
                }
                else
                {
                    this.MensajeError(rpta);
                }

                this.isNuevo = false;
                this.isEditar = false;
                this.LimpiarCampos();
                this.HabilitarCampos(false);

                this.EstadoBotones("ORIGINAL");


                this.MostrarTabla();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BTNeditar_Click(object sender, EventArgs e)
        {
            this.isEditar = true;
            this.EstadoBotones("EDICION");
            this.HabilitarCampos(true);

            try
            {
                this.TXTpnombre.Text = Convert.ToString(this.TABLEdatos.CurrentRow.Cells["Primer nombre"].Value);
                this.TXTsnombre.Text = Convert.ToString(this.TABLEdatos.CurrentRow.Cells["Segundo nombre"].Value);
                this.TXTpapellido.Text = Convert.ToString(this.TABLEdatos.CurrentRow.Cells["Primer apellido"].Value);
                this.TXTsapellido.Text = Convert.ToString(this.TABLEdatos.CurrentRow.Cells["Segundo apellido"].Value);
                this.TXTdireccion.Text = Convert.ToString(this.TABLEdatos.CurrentRow.Cells["Dirección"].Value);
                this.TXTtelefono.Text = Convert.ToString(this.TABLEdatos.CurrentRow.Cells["Teléfono"].Value);
                this.TXTcorreo.Text = Convert.ToString(this.TABLEdatos.CurrentRow.Cells["Correo electrónico"].Value);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR AL PASAR LOS DATOS DE TABLA A CAMPOS");
            }
        }

        private void TXTbuscar_TextChanged(object sender, EventArgs e)
        {
            this.TABLEdatos.DataSource = NEmpleado.BuscarHabitacion(this.TXTbuscar.Text.Trim());
        }

        private void BTNeliminar_Click(object sender, EventArgs e)
        {
            DialogResult boton = MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Precaucion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (boton == DialogResult.OK)
            {
                try
                {
                    string rpta = "";

                    if (!this.isNuevo)
                    {
                        rpta = NEmpleado.EliminarEmpleado(Convert.ToInt32(this.TABLEdatos.CurrentRow.Cells["ID de empleado"].Value));
                    }
                    if (rpta.Equals("OK"))
                    {
                        if (!this.isNuevo)
                        {
                            this.MensajeOk("Se Eliminó de forma correcta el registro");
                        }

                    }
                    else
                    {
                        this.MensajeError(rpta + "\n\nEs posible que el empleado este registrado en una reserva.");
                    }

                    this.MostrarTabla();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void TXTcorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTtelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTsapellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTpapellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTsnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTpnombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
