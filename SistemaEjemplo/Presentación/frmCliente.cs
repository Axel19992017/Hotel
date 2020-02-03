using System;
using System.Windows.Forms;
using SistemaEjemplo.Negocio;

namespace SistemaEjemplo.Presentación
{
    public partial class frmCliente : Form
    {     private bool IsNuevo = false;
        private UInt16 idCliente;
        private bool IsEditar = false;
        public frmCliente()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
           this.dataCliente.DataSource = NCliente.Mostrar();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }

         private void Botones()
        {
            if (this.IsNuevo || this.IsEditar) //Alt + 124
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnModificar.Enabled = false;
                this.btnCancelar.Enabled = true;
                this.btnEstado.Enabled = false;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnModificar.Enabled = true;
                this.btnCancelar.Enabled = false;
                this.btnEstado.Enabled = false;
            }

        }
         private void Habilitar(bool valor)
        {
            this.txtPrimerNombre.ReadOnly = !valor;
           
            this.txtSegundoNombre.ReadOnly = !valor;
            this.txtPrimerApellido.ReadOnly = !valor;
            this.txtSegundoApellido.ReadOnly = !valor;
            this.txtDireccion.ReadOnly = !valor;
            this.txtCorreo.ReadOnly = !valor;
            this.txtTelefono.ReadOnly = !valor;



        }
           private void Limpiar()
        {
            //this.txtNombres.Text = string.Empty;
            this.txtPrimerNombre.Text = string.Empty;

            this.txtSegundoNombre.Text = string.Empty;
            this.txtPrimerApellido.Text = string.Empty;
            this.txtSegundoApellido.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtCorreo.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;

        }

         private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
              try
               {
                string rpta = "";
              
                    if (this.IsNuevo)
                    {
                    rpta = NCliente.Insertar(this.txtPrimerNombre.Text, this.txtSegundoNombre.Text, this.txtPrimerApellido.Text, this.txtSegundoApellido.Text, this.txtDireccion.Text, this.txtTelefono.Text, txtCorreo.Text);

                    }
                    else
                    {
                    rpta = NCliente.Editar(Convert.ToInt32(this.dataCliente.CurrentRow.Cells["Id_Cliente"].Value),
                        this.txtPrimerNombre.Text, this.txtSegundoNombre.Text, this.txtPrimerApellido.Text, 
                        this.txtSegundoApellido.Text, this.txtDireccion.Text, this.txtTelefono.Text, txtCorreo.Text);
                       
                            
                            //   this.txtNombreCompañia.Text.Trim(), this.txtApellidos.Text.Trim(), this.cmbTipoPersonal.SelectedItem.ToString(), this.cmbDelegacion.SelectedItem.ToString(), this.txtObservacion.Text.Trim());
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el registro");
                         //   errorIcono.Clear();
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

                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();


                }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtPrimerNombre.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!this.txtPrimerNombre.Text.Equals(" "))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el registro a Modificar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
           // errorIcono.Clear();
        }

        private void dataCliente_DoubleClick(object sender, EventArgs e)
        {

            this.txtPrimerNombre.Text = Convert.ToString(this.dataCliente.CurrentRow.Cells["Primer Nombre"].Value);
            this.txtSegundoNombre.Text = Convert.ToString(this.dataCliente.CurrentRow.Cells["Segundo Nombre"].Value);
            this.txtPrimerApellido.Text = Convert.ToString(this.dataCliente.CurrentRow.Cells["Primer Apellido"].Value);
            this.txtSegundoApellido.Text = Convert.ToString(this.dataCliente.CurrentRow.Cells["Segundo Apellido"].Value);
            this.txtDireccion.Text = Convert.ToString(this.dataCliente.CurrentRow.Cells["Dirección"].Value);
            this.txtCorreo.Text = Convert.ToString(this.dataCliente.CurrentRow.Cells["Correo"].Value);
            this.txtTelefono.Text = Convert.ToString(this.dataCliente.CurrentRow.Cells["Teléfono"].Value);
            setBtnEstado(Convert.ToString(this.dataCliente.CurrentRow.Cells["Estado"].Value));
            btnEstado.Enabled = true;
            idCliente = Convert.ToUInt16(dataCliente.CurrentRow.Cells["Id_Cliente"].Value);
            
        }

        private void setBtnEstado(String estado)
        {
            if(estado == "Habilitado")
            {
                btnEstado.Text = "Inhabilitar";
            }
            else
            {
                btnEstado.Text = "Habilitar";
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dataCliente.DataSource = NCliente.BuscarAsegurado(this.txtBuscar.Text.Trim());


        }

        private void dataCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEstado_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            String res = NCliente.CambiarEstado(idCliente);
            MessageBox.Show(res);
            Mostrar();
        }
    }
    }

