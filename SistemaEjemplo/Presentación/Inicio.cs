using SistemaEjemplo.Negocio;
using SistemaEjemplo.Presentación;
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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                string res = Convert.ToString(NUsuario.ValidarPass(tbUser.Text, tbPass.Text).Rows[0][0]);
                lblestado.Text = res;
                if (res == "Acceso Exitoso")
                {
                    string rol = Convert.ToString(NUsuario.ValidarPass(tbUser.Text, tbPass.Text).Rows[0][1]);
                    this.Visible = false;
                    frmPrincipal principal = new frmPrincipal(tbUser.Text,rol,this);
                    principal.Show();
                    
                }

            }
        }

        private void lblestado_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
