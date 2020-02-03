using SistemaEjemplo.Negocio;
using System;
using System.Windows.Forms;

namespace SistemaEjemplo.Presentación
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string usuario = Convert.ToString(dgvUsuario.CurrentRow.Cells["Usuario"].Value);
            lblUsuario.Text = usuario;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(tbUser.Text != ""  && tbPass.Text != "")
            {
                string usuario = tbUser.Text;
                string pass = tbPass.Text;
                int idEmpleado = Convert.ToInt16(cbIdEmpleado.GetItemText(cbIdEmpleado.SelectedItem));
                string rol = cbRol.GetItemText(cbRol.SelectedItem);
                Console.WriteLine(idEmpleado);
                string res = NUsuario.Agregar(new Datos.DUsuario(usuario, pass, rol, idEmpleado));
                dgvUsuario.DataSource = NUsuario.Mostrar();
            }

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hotelDataSet6.getIdEmpleados' Puede moverla o quitarla según sea necesario.
            this.getIdEmpleadosTableAdapter.Fill(this.hotelDataSet6.getIdEmpleados);
            dgvUsuario.DataSource = NUsuario.Mostrar();
            cbIdEmpleado.SelectedIndex = 0;
            cbRol.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = lblUsuario.Text;
            string res = NUsuario.Borrar(usuario);
            if(res == "Usuario Eliminado")
            {
                dgvUsuario.DataSource = NUsuario.Mostrar();
            }
            else
            {
                Console.WriteLine(res);
            }
        }
    }
}
