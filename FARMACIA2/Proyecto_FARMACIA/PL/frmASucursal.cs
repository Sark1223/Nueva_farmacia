using Proyecto_FARMACIA.BLL;
using Proyecto_FARMACIA.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        ///Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //Objetos de Clase
        SucursalBLL objSucursal = new SucursalBLL();
        Conexion conexion = new Conexion();
        int ID_Actual;

        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmASucursal_Load(object sender, EventArgs e)
        {
            if (lblTitle.Text == "AÑADIR SUCURSAL")
            {
                conexion.RellenarCB_1(cbCiudad, "SELECT * FROM CIUDAD", "-- Selecione Ciudad --");
                conexion.RellenarCB_2Palabras(cbPropietario, "SELECT * FROM PROPIETARIO", "-- Selecione Propietario --");
            }

            if (txtIdFarmacia.Text != "")
            {
                ID_Actual = int.Parse(txtIdFarmacia.Text);
            }
        }




        //METODOS DE SUCURSALES
        public void ObtenerValoresSucursal()
        {
            objSucursal.id_farm = int.Parse(txtIdFarmacia.Text);
            objSucursal.nombre_farm = txtNombre.Text;
            objSucursal.calle_farm = txtCalle.Text;
            objSucursal.no_exterior_farm = int.Parse(txtNo_exte.Text);
            objSucursal.no_interior_farm = txtInterios.Text;
            objSucursal.colonia_farm = txtcolonia.Text;
            objSucursal.CP_farm = int.Parse(txtCP.Text);
            //objSucursal.id_propi_farm = txtcolonia.Text;
            //objSucursal.id_Ciudad_farm = int.Parse(txtIdPro.Text);
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            ObtenerValoresSucursal();
            conexion.AgregarSucursal(objSucursal);
            //if ()
            //{
                MessageBox.Show("La sucursal " + txtNombre.Text + " de ID: " + txtIdFarmacia.Text + " se INGRESO correctamente", "REGISTRO AGREGADO", MessageBoxButtons.OK);
            //    Close();
            //}
            //else
            //{
            //    MessageBox.Show("Ha ocurrido un error.", "ERROR", MessageBoxButtons.OK);
            //}
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (conexion.Eliminar("DELETE FROM SUCURSAL WHERE id_farmacia =" + txtIdFarmacia.Text))
            {
                MessageBox.Show("La farmacia: " + txtIdFarmacia.Text + " de nombre: " + txtNombre.Text + " ha sido eliminada", "REGISTRO ELIMINADO");

                Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error.", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            ObtenerValoresSucursal();

           string COMANDO = "update FARMACIA set id_farmacia = " + objSucursal.id_farm + ", " +
                            "nombre_farm = '" + objSucursal.nombre_farm + "', " +
                            "calle_farm = '" + objSucursal.calle_farm + "', " +
                            "no_exterior_farm = " + objSucursal.no_exterior_farm + ", " +
                            "no_interior_farm = '" + objSucursal.no_interior_farm + "', " +
                            "colonia_farm = '" + objSucursal.colonia_farm + "', " +
                            "CP_FARM = " + objSucursal.CP_farm + ", " +
                            "id_propietario = " + objSucursal.id_propi_farm + ", " +
                            "id_ciudad = '" + objSucursal.id_Ciudad_farm + "' " +
                            "WHERE id_farmacia =" + ID_Actual;

            conexion.Modificar_2(COMANDO);
            //if (conexion.Modificar(COMANDO))
            //{
            MessageBox.Show("La farmacia: " + ID_Actual + " de nombre: " + txtNombre.Text + " ha sido modificada", "REGISTRO MODIFICADO");

            //    Close();
            //}
            //else
            //{
            //    MessageBox.Show("Ha ocurrido un error.", "ERROR", MessageBoxButtons.OK);
            //}
        }


        //CERRAR FORMA 
        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            txtIdFarmacia.Clear();  txtNombre.Clear();  txtCalle.Clear();txtCP.Clear(); 
            txtNo_exte.Clear(); txtInterios.Clear(); txtcolonia.Clear();
            
            conexion.RellenarCB_1(cbCiudad, "SELECT * FROM CIUDAD", "-- Selecione Ciudad --");
            conexion.RellenarCB_2Palabras(cbPropietario, "SELECT * FROM PROPIETARIO", "-- Selecione Propietario --");
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        //CARGAR SELECCION DE COMBO BOX
        private void cbPropietario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPropietario.SelectedIndex > 0)
            {
                objSucursal.id_propi_farm = conexion.captar_info_2Palabras("SELECT * FROM PROPIETARIO WHERE a_paterno='" + conexion.SepararValores(cbPropietario.Text) + "'");

            }
        }

        private void cbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCiudad.SelectedIndex > 0)
            {
                objSucursal.id_Ciudad_farm = conexion.captar_info_2Palabras("SELECT * FROM CIUDAD WHERE nombre_ciudad='" + cbCiudad.Text + "'");

            }
        }

    }
}
