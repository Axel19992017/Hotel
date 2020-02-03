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
    public partial class frmRecaudaciones : Form
    {
        public frmRecaudaciones()
        {
            InitializeComponent();
        }

        private void frmRecaudaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hotelDataSet3.listYear' Puede moverla o quitarla según sea necesario.
            this.listYearTableAdapter.Fill(this.hotelDataSet3.listYear);
            // TODO: esta línea de código carga datos en la tabla 'hotelDataSet2.listMes' Puede moverla o quitarla según sea necesario.
            this.listMesTableAdapter.Fill(this.hotelDataSet2.listMes);

        }

        private void lblRecServCant_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            lblRecHabitCant.Text = NOperaciones.Recaudaciones(Convert.ToInt16(cbMes.SelectedValue), Convert.ToInt16(cbYear.SelectedValue)).Rows[0][0].ToString();
            lblRecServCant.Text = NOperaciones.Recaudaciones(Convert.ToInt16(cbMes.SelectedValue), Convert.ToInt16(cbYear.SelectedValue)).Rows[0][1].ToString();
            lblRecTotCant.Text = NOperaciones.Recaudaciones(Convert.ToInt16(cbMes.SelectedValue), Convert.ToInt16(cbYear.SelectedValue)).Rows[0][2].ToString();
            lblComisionesCant.Text = NOperaciones.Recaudaciones(Convert.ToInt16(cbMes.SelectedValue), Convert.ToInt16(cbYear.SelectedValue)).Rows[0][3].ToString();


        }
    }
}
