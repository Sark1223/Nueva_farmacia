using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_FARMACIA.PL
{
    public partial class frmMenuAdmin : Form
    {
        public frmMenuAdmin()
        {
            InitializeComponent();
        }

        private void pbSeemore_Click(object sender, EventArgs e)
        {

            //AbrirForm(new frmMasMenu());
            lblSalir.Text = "Sirvoooo";
        }

        public void AbrirForm(object mas)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }

            Form admin = mas as Form;
            admin.TopLevel = false;
            admin.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(admin);
            this.PanelContenedor.Tag = admin;

            admin.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbCiudad_Click(object sender, EventArgs e)
        {
            frmCiudad ciudad = new frmCiudad();
            ciudad.Show();
        }

        private void pbPropi_Click(object sender, EventArgs e)
        {
            frmPropietarios propietarios = new frmPropietarios();
            propietarios.Show();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdciudad_MouseHover(object sender, EventArgs e)
        {

            cmdciudad.BackColor=  7, 200, 216;
        }
    }
}
