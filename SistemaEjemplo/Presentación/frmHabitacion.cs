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
   
    public partial class frmHabitacion : Form
    {
        private bool isNuevo = false;
        private bool isEditar = false;

        public frmHabitacion()
        {
            InitializeComponent();
        }

        private void frmHabitacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hotelDataSet5.ListaTipoHabitacion' Puede moverla o quitarla según sea necesario.
            this.listaTipoHabitacionTableAdapter.Fill(this.hotelDataSet5.ListaTipoHabitacion);
            // TODO: esta línea de código carga datos en la tabla 'hotel2DataSet2.listaIDhabitaciones' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'hotel2DataSet1.ListaTipoHabitacion' Puede moverla o quitarla según sea necesario.
            this.LimpiarCampos();
            this.MostrarTabla();

        }

        private void BTNnuevo_Click(object sender, EventArgs e)
        {
            this.BTNeliminar.Enabled=false;
            this.BTNguardar.Enabled = true;
            this.BTNcancelar.Enabled = true;
            this.BTNeditar.Enabled = false;
            this.isNuevo = true;
            this.HabilitarCampos(true);
            this.BTNnuevo.Enabled = false;
        }

        public void MostrarTabla()
        {
            this.TABLEdatos.DataSource = NHabitacion.MostrarTablaHabitacion();

        }

        public void LimpiarCampos()
        {
            this.TXTdescripcion.Text = string.Empty;
            this.TXTnohabitacion.Text = string.Empty;
            this.COMBOtipohabitacion.SelectedIndex = 0;
            this.COMBOestado.SelectedIndex = 0;
            this.NUMcapacidad.Value = 1;
        }

        public void HabilitarCampos(bool valor)
        {
            this.COMBOtipohabitacion.Enabled = valor;
            this.TXTdescripcion.Enabled = valor;
            this.NUMcapacidad.Enabled = valor;
            this.COMBOestado.Enabled = valor;
            this.TXTnohabitacion.Enabled = valor;
        }

        private void TABLEdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(!this.isNuevo)
            {
                this.BTNeditar.Enabled = true;
                if (!this.isEditar)
                {
                    this.BTNeliminar.Enabled = true;
                }
            }
            
        }

        private void BTNeditar_Click(object sender, EventArgs e)
        {
            this.isEditar = true;
            this.BTNguardar.Enabled = true;
            this.BTNcancelar.Enabled = true;
            this.HabilitarCampos(true);
            this.BTNnuevo.Enabled = false;
            this.BTNeditar.Enabled = false;
            this.BTNeliminar.Enabled = false;
            this.TXTnohabitacion.ReadOnly = true;
            try
            {
                this.COMBOtipohabitacion.SelectedValue=Convert.ToString(this.TABLEdatos.CurrentRow.Cells["Código de tipo"].Value);
                this.TXTdescripcion.Text = Convert.ToString(this.TABLEdatos.CurrentRow.Cells["Descripción"].Value);
                this.NUMcapacidad.Value = decimal.Parse(this.TABLEdatos.CurrentRow.Cells["Capacidad"].Value.ToString());
                this.COMBOestado.SelectedItem = Convert.ToString(this.TABLEdatos.CurrentRow.Cells["Estado"].Value);
                this.TXTnohabitacion.Text = Convert.ToString(this.TABLEdatos.CurrentRow.Cells["No. de habitación"].Value);
                   
            }
            catch(Exception ex)
            {
                MessageBox.Show( ex.ToString(), "ERROR AL PASAR LOS DATOS DE TABLA A CAMPOS");
            }
        }

        private void BTNcancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
            this.HabilitarCampos(false);
            this.isEditar = false;
            this.isNuevo = false;
            this.BTNguardar.Enabled = false;
            this.BTNeditar.Enabled = false;
            this.BTNcancelar.Enabled = false;
            this.BTNnuevo.Enabled = true;
            this.TXTnohabitacion.ReadOnly = false;
        }

         private void BTNguardar_Click(object sender, EventArgs e)
           {
               try
               {
                   string rpta = "";

                   if (this.isNuevo)
                   {
                       rpta = NHabitacion.InsertarHabitacion(
                           int.Parse(this.TXTnohabitacion.Text),
                           int.Parse(this.COMBOtipohabitacion.SelectedValue.ToString()),
                           this.TXTdescripcion.Text,int.Parse(this.NUMcapacidad.Value.ToString()),
                           this.COMBOestado.SelectedItem.ToString());

                   }
                   else
                   {
                       rpta = NHabitacion.EditarHabitacion(
                           Convert.ToInt32(this.TABLEdatos.CurrentRow.Cells["No. de habitación"].Value),
                           Convert.ToInt32(this.COMBOtipohabitacion.SelectedValue.ToString()), 
                           this.TXTdescripcion.Text, 
                           Convert.ToInt32(this.NUMcapacidad.Value.ToString()),
                           this.COMBOestado.SelectedItem.ToString());

                       this.TXTnohabitacion.ReadOnly = false;
        
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

                this.BTNcancelar.Enabled = false;
                this.BTNnuevo.Enabled = true;
                this.BTNguardar.Enabled = false;
                this.BTNeditar.Enabled = false;
                

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
                        rpta = NHabitacion.EliminarHabitacion(Convert.ToInt32(this.TABLEdatos.CurrentRow.Cells["No. de habitación"].Value));
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
                        this.MensajeError(rpta);
                    }

                    this.MostrarTabla();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                
            }
        }

        private void TXTbuscar_TextChanged(object sender, EventArgs e)
        {
            this.TABLEdatos.DataSource = NHabitacion.BuscarHabitacion(this.TXTbuscar.Text.Trim());
        }
    }
    
}
