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
    public partial class frmASucursal : Form
    {
        public frmASucursal()
        {
            InitializeComponent();
        }

        public void ObtenerValoresSucursal()
        {
            OpropiBLL.ID = int.Parse(txtIdPro.Text);
            OpropiBLL.A_paterno = txtPaterno.Text;
            OpropiBLL.A_materno = txtMaterno.Text;
            OpropiBLL.Nombre_s = txtNombres.Text;
            OpropiBLL.Calle = txtCalle.Text;
            OpropiBLL.No_exterior = int.Parse(txtIdPro.Text);
            OpropiBLL.No_interior = txtInterios.Text;
            OpropiBLL.Colonia = txtcolonia.Text;
            OpropiBLL.CP = int.Parse(txtIdPro.Text);
            OpropiBLL.telefono = long.Parse(txtTelefono.Text);
            OpropiBLL.correo_e = txtCorreo.Text + "@GMAIL.COM";
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
