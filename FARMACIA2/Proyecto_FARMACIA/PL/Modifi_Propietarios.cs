using Proyecto_FARMACIA.DAL;
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
    public partial class Modifi_Propietarios : Form
    {
        public Modifi_Propietarios()
        {
            InitializeComponent();
        }

        Conexion conexion = new Conexion();

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (conexion.Eliminar("DELETE FROM PROPIETARIO WHERE id_propietario =" + txtIdPro.Text))
            {
                MessageBox.Show("El propietario " + txtPaterno.Text+" "+txtMaterno.Text+" "+txtNombres.Text + " de ID " + txtIdPro.Text + " ha sido eliminado", "REGISTRO ELIMINADO");

                Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error.", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
