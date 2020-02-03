using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEjemplo.Presentación;

namespace SistemaEjemplo
{
    public partial class frmPrincipal : Form
    {
        Inicio inicio;
        string userEmpleado;
        public frmPrincipal(string user,string rol, Inicio inicio)
        {
            InitializeComponent();
            this.inicio = inicio;
            if (rol == "Administrador")
            {
                userEmpleado = user;
                usuarioToolStripMenuItem.Enabled = false;
                empleadoToolStripMenuItem.Enabled = false;
            }
            else if (rol == "Empleado")
            {
                habitacionesToolStripMenuItem.Enabled = false;
                usuarioToolStripMenuItem.Enabled = false;
                serviciosToolStripMenuItem.Enabled = false;
                recaudacionesToolStripMenuItem.Enabled = false;
                userEmpleado = user;
            }else if(rol == "AdminMaestro")
            {
                userEmpleado = user;
                Console.WriteLine("Bienvenido profesor :D");
            }
            else
            {
                Console.WriteLine("Ya valistes D:");
            }

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente  fc = new frmCliente();
            fc.MdiParent = this;
            fc.Show();

        }

        private void habitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHabitacion frm = new frmHabitacion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServicio frmServicio = new frmServicio();
            frmServicio.MdiParent = this;
            frmServicio.Show();
        }

        private void disponibilidadHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisponibilidadHabitaciones dispHabitaciones = new frmDisponibilidadHabitaciones();
            dispHabitaciones.MdiParent = this;
            dispHabitaciones.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecaudaciones frmRecaudaciones = new frmRecaudaciones();
            frmRecaudaciones.MdiParent = this;
            frmRecaudaciones.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReserva reserva = new frmReserva();
            reserva.MdiParent = this;
            reserva.Show();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            inicio.Dispose();
        }

        private void agregarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddReserva addReserva = new frmAddReserva(userEmpleado);
            addReserva.MdiParent = this;
            addReserva.Show();
            
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleado empleado = new frmEmpleado();
            empleado.MdiParent = this;
            empleado.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario usuario = new frmUsuario();
            usuario.MdiParent = this;
            usuario.Show();
        }
    }
}
