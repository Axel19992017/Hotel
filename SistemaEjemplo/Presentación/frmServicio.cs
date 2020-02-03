using SistemaEjemplo.Negocio;
using System;
using System.Windows.Forms;

namespace SistemaEjemplo.Presentación
{
    public partial class frmServicio : Form
    {

        public frmServicio()
        {
            InitializeComponent();
        }

        private void frmServicio_Load(object sender, EventArgs e)
        {

            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            tbDescripción.Enabled = false;
            tbPrecio.Enabled = false;
            dgvServicio.DataSource = NServicios.Mostrar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            stateNuevo();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TbDescripción_TextChanged(object sender, EventArgs e)
        {

        }
        private void stateIniciar()
        {
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            tbDescripción.Enabled = false;
            tbPrecio.Enabled = false;
        }
        private void stateNuevo()
        {
            tbPrecio.Enabled = true;
            tbDescripción.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;

        }
        private void stateGuardar()
        {
            tbPrecio.Text = "";
            tbDescripción.Text = "";
            stateIniciar();
        }
        private void stateCancelar()
        {
            stateGuardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            stateCancelar();
        }
        //private void 

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if(tbDescripción.Text == "" || tbPrecio.Text == "")
            {
                MessageBox.Show("Datos no ingresados");

            }
            else
            {
                if (isEditar)
                {
                    string res = NServicios.Editar(new Datos.DServicio(idServicio, tbDescripción.Text, double.Parse(tbPrecio.Text)));
                    if(res == "Edición Completa y Exitosa")
                    {
                        stateGuardar();
                        mostrar();
                    }
                    else
                    {
                        MessageBox.Show(res);

                    }
                }
                else
                {
                    string res = NServicios.Insertar(new Datos.DServicio(tbDescripción.Text, double.Parse(tbPrecio.Text)));
                    System.Console.WriteLine(res);
                    if (res == "Servicio Agregado")
                    {
                        stateGuardar();
                        mostrar();
                    }
                    else
                    {
                        MessageBox.Show(res);
                    }
                }
            }
        }
        private void mostrar()
        {
            dgvServicio.DataSource = NServicios.Mostrar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvServicio_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void tbBusqAvanzada_TextChanged(object sender, EventArgs e)
        {
            dgvServicio.DataSource = NServicios.Buscar(tbBusqAvanzada.Text);
        }

        private void dgvServicio_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvServicio_DoubleClick(object sender, EventArgs e)
        {
            tbDescripción.Text = Convert.ToString(dgvServicio.CurrentRow.Cells["Descripción"].Value);
            tbPrecio.Text = Convert.ToString(dgvServicio.CurrentRow.Cells["Precio"].Value);
            idServicio = Convert.ToInt16(dgvServicio.CurrentRow.Cells["Código del Servicio"].Value);
            Console.WriteLine("Id Servicio: "+idServicio);
            btnEditar.Enabled = true;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tbDescripción.Enabled = true;
            tbPrecio.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            isEditar = true;
        }
        bool isEditar = false;
        int idServicio;
    }
}
