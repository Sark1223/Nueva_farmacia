using Proyecto_FARMACIA.BLL;
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
    public partial class frmASucursal : Form
    {
        public frmASucursal()
        {
            InitializeComponent();
        }

        //Objetos de Clase
        SucursalBLL objSucursal = new SucursalBLL();
        Conexion conexion = new Conexion();

        public void ObtenerValoresSucursal()
        {
            objSucursal.id_Ciudad_farm = int.Parse(txtIdFarmacia.Text);
            objSucursal.nombre_farm = txtNombre.Text;
            objSucursal.calle_farm = txtCalle.Text;
            objSucursal.no_exterior_farm = int.Parse(txtNo_exte.Text);
            objSucursal.no_interior_farm = txtCalle.Text;
            objSucursal.colonia_farm = txtcolonia.Text;
            objSucursal.CP_farm = int.Parse(txtCP.Text);
            //objSucursal.id_propi_farm = txtcolonia.Text;
            //objSucursal.id_Ciudad_farm = int.Parse(txtIdPro.Text);
        }

        //METODOS DE SUCURSALES
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            ObtenerValoresSucursal();

            if (conexion.AgregarSucursal(objSucursal))
            {
                MessageBox.Show("La sucursal " + txtNombre.Text + " de ID: " + txtIdFarmacia.Text + " se INGRESO correctamente", "REGISTRO AGREGADO", MessageBoxButtons.OK);
                Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error.", "ERROR", MessageBoxButtons.OK);
            }
        }


        //CERRAR FORMA 
        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
