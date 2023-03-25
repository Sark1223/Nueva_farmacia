using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_FARMACIA.PL
{
    public partial class frmCiudad : Form
    {
        public frmCiudad()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //SqlConnection conexion = new SqlConnection(@"Server=localhost\SQLEXPRESS; Initial Catalog = biblioteca; Trusted_Connection=True;");
            frmAciudad agregar = new frmAciudad();
            agregar.ShowDialog();
        }
    }
}
