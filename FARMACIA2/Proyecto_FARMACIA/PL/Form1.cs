using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_FARMACIA.PL
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmMenuAdmin menuAdmin = new frmMenuAdmin();
            menuAdmin.Show(new frmMenuAdmin());
        }

        //private void btnCerrar_Click(object sender, EventArgs e)
        //{
        //    Close();
        //}

        //public void AbrirForm(object mas)
        //{
        //    if (this.PanelContenedor.Controls.Count > 0)
        //    {
        //        this.PanelContenedor.Controls.RemoveAt(0);
        //    }

        //    Form admin = mas as Form;
        //    admin.TopLevel = false;
        //    admin.Dock = DockStyle.Fill;
        //    this.PanelContenedor.Controls.Add(admin);
        //    this.PanelContenedor.Tag = admin;

        //    admin.Show();
        //}

        //private void frmAdmin_Load(object sender, EventArgs e)
        //{
        //    AbrirForm(new frmMenuAdmin());
        //}

    }
}
