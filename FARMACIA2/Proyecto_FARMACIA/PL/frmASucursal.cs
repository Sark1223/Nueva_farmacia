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
        string ID_Actual, id_propi;
        bool primeraApertura = true;

        /*CREATE TABLE FARMACIA (
    id_farmacia                CHAR(5) NOT NULL PRIMARY KEY,
    nombre_farm                VARCHAR(100) NOT NULL,
    calle_farm                 VARCHAR(100 ) NOT NULL,
    no_exterior_farm           VARCHAR(6) NOT NULL,
    no_interior_farm           VARCHAR(4 ),
    colonia_farm               VARCHAR(100 ) NOT NULL,
    CP_FARM					   VARCHAR(7 ) NOT NULL,
    id_propietario VARCHAR(10) NOT NULL FOREIGN KEY (id_propietario ) REFERENCES PROPIETARIO ( id_propietario ) unique,
    id_ciudad VARCHAR(10) NOT NULL FOREIGN KEY (id_ciudad ) REFERENCES CIUDAD ( id_ciudad )
);*/

        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmASucursal_Load(object sender, EventArgs e)
        {
            primeraApertura = false;

            if (lblTitle.Text == "AÑADIR SUCURSAL")
            {
                conexion.RellenarCB_1(cbCiudad, "SELECT * FROM CIUDAD", "-- Selecione Ciudad --");
                conexion.RellenarCB_2(cbPropietario, "SELECT * FROM PROPIETARIO", "-- Selecione Propietario --");
            }

            if (txtIdFarmacia.Text != "")
            {
                ID_Actual = txtIdFarmacia.Text;
            }

            if(cbPropietario.SelectedIndex != 0)
            {
                id_propi = conexion.SepararValores(cbPropietario.Text);
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
            if (!ValoresVacios())
            {
                ObtenerValoresSucursal();

                if (conexion.AgregarSucursal(objSucursal))
                {
                    MessageBox.Show("La sucursal " + txtNombre.Text + " de ID: " + txtIdFarmacia.Text + " se INGRESO correctamente", "REGISTRO AGREGADO", MessageBoxButtons.OK);
                    primeraApertura = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("NO se pudo AÑADIR la SUCURSAL.", "ERROR", MessageBoxButtons.OK);
                }
            }
            
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (conexion.Eliminar("DELETE FROM FARMACIA WHERE id_farmacia =" + txtIdFarmacia.Text))
            {
                MessageBox.Show("La farmacia: " + txtIdFarmacia.Text + " de nombre: " + txtNombre.Text + " ha sido eliminada", "REGISTRO ELIMINADO");

                primeraApertura = true;
                Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error.", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (!ValoresVacios())
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
                                 "id_ciudad = " + objSucursal.id_Ciudad_farm +
                                 "WHERE id_farmacia =" + ID_Actual;

                //conexion.Modificar_2(objSucursal, ID_Actual);
                if (conexion.Modificar(COMANDO))
                {
                    MessageBox.Show("La farmacia: " + ID_Actual + " de nombre: " + txtNombre.Text + " ha sido modificada", "REGISTRO MODIFICADO");

                    primeraApertura = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("NO se pudo MODIFICAR la SUCURSAL.", "ERROR", MessageBoxButtons.OK);
                }
            }
            
        }


        //CERRAR FORMA 
        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            primeraApertura = true;
            Close();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            txtIdFarmacia.Clear();  txtNombre.Clear();  txtCalle.Clear();txtCP.Clear(); 
            txtNo_exte.Clear(); txtInterios.Clear(); txtcolonia.Clear();
            
            conexion.RellenarCB_1(cbCiudad, "SELECT * FROM CIUDAD", "-- Selecione Ciudad --");
            conexion.RellenarCB_2(cbPropietario, "SELECT * FROM PROPIETARIO", "-- Selecione Propietario --");
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            primeraApertura = true;
            Close();
        }

        
        //CARGAR SELECCION DE COMBO BOX
        private void cbPropietario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (primeraApertura == false)
            {
                if (cbPropietario.SelectedIndex > 0)
                {
                    string id = conexion.SepararValores(cbPropietario.Text);
                    objSucursal.id_propi_farm = conexion.captar_info_2("SELECT * FROM PROPIETARIO WHERE id_propietario=" + id);

                    if (lblTitle.Text == "MODIFICAR SUCURSAL")
                    {
                        //VERIFICAR QUE LOS DATOS UNICOS NO SE REPITAN 
                        if (conexion.BuscarEnTabla_MODIFICAR("SELECT * FROM FARMACIA", id, 7, id_propi, lblPropietario.Text) < 1 && id != "-")
                        {
                            objSucursal.id_propi_farm = int.Parse(id);
                        }
                        else
                        {
                            cbPropietario.SelectedIndex = 0;
                        }

                    }
                    else
                    {
                        if (conexion.BuscarEnTabla_AGREGAR("SELECT * FROM FARMACIA", id, 7, lblPropietario.Text) && id != "-")
                        {
                            objSucursal.id_propi_farm = int.Parse(id);
                        }
                        else
                        {
                            cbPropietario.SelectedIndex = 0;
                        }
                    }
                }
            }


        }

        private void cbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCiudad.SelectedIndex > 0)
            {
                objSucursal.id_Ciudad_farm = conexion.captar_info_1("SELECT * FROM CIUDAD WHERE nombre_ciudad='" + cbCiudad.Text + "'");

            }
        }


        //VALIDACION DE VALORES INGRESADOS POR EL USUARIO
        public bool ValoresVacios()
        {
            string valoresVacios = "";
            int no_vacios = 0;
            //VERIFICACION DE VALORES VACIOS
            {
                if (txtIdFarmacia.Text == "")
                {
                    valoresVacios += "id_farmacia, ";
                    no_vacios++;
                }
                if (txtNombre.Text == "")
                {
                    valoresVacios += "Nombre farmacia, ";
                    no_vacios++;
                }
                if (cbPropietario.Text == "-- Selecione Propietario --")
                {
                    valoresVacios += "Propietario, ";
                    no_vacios++;
                }
                if (txtCalle.Text == "")
                {
                    valoresVacios += "Calle, ";
                    no_vacios++;
                }
                if (txtNo_exte.Text == "")
                {
                    valoresVacios += "No_exterior, ";
                    no_vacios++;
                }
                if (txtcolonia.Text == "")
                {
                    valoresVacios += "Colonia, ";
                    no_vacios++;
                }
                if (txtCP.Text == "")
                {
                    valoresVacios += "CP, ";
                    no_vacios++;
                }
                if (cbCiudad.Text == "-- Selecione Ciudad --")
                {
                    valoresVacios += "Ciudad, ";
                    no_vacios++;
                }
            }
            if (no_vacios > 0)
            {
                MessageBox.Show("No puede dejar información en blanco \r\n\r\n" +
                                "No. de valores vacios: " + no_vacios + "\r\n" +
                                "Valores vacios: " + valoresVacios, "ERROR AL INGRESAR VALORES");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtIdFarmacia_TextChanged(object sender, EventArgs e)
        {
            if (primeraApertura == false)
            {
                try
                {
                    if (lblTitle.Text == "MODIFICAR SUCURSAL")
                    {
                        //VERIFICAR QUE LOS DATOS UNICOS NO SE REPITAN 
                        if (conexion.BuscarEnTabla_MODIFICAR("SELECT * FROM FARMACIA", txtIdFarmacia.Text, 0, ID_Actual, lblFarmacia.Text) < 1 && txtIdFarmacia.Text != "")
                        {
                            objSucursal.id_propi_farm = int.Parse(txtIdFarmacia.Text);
                        }
                        else
                        {
                            txtIdFarmacia.SelectAll();
                        }

                    }
                    else
                    {
                        if (conexion.BuscarEnTabla_AGREGAR("SELECT * FROM FARMACIA", txtIdFarmacia.Text, 0, lblFarmacia.Text) && txtIdFarmacia.Text != "")
                        {
                            objSucursal.id_propi_farm = int.Parse(txtIdFarmacia.Text);
                        }
                        else
                        {
                            txtIdFarmacia.SelectAll();
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ingrese SOLO NUMEROS.", "ERROR DE FORMATO");
                    txtIdFarmacia.SelectAll();
                }
            }
        }

        private void txtNo_exte_TextChanged(object sender, EventArgs e)
        {
            if (primeraApertura == false)
            {
                try
                {
                    if (txtNo_exte.Text != "")
                    {
                        objSucursal.no_exterior_farm = int.Parse(txtNo_exte.Text);
                    }

                }
                catch (FormatException)
                {
                    MessageBox.Show("Ingrese SOLO NUMEROS.", "ERROR DE FORMATO");
                    txtNo_exte.SelectAll();
                }
            }
        }

        private void txtCP_TextChanged(object sender, EventArgs e)
        {
            if (primeraApertura == false)
            {
                try
                {
                    if (txtCP.Text != "")
                    {
                        objSucursal.CP_farm = int.Parse(txtCP.Text);
                    }

                }
                catch (FormatException)
                {
                    MessageBox.Show("Ingrese SOLO NUMEROS.", "ERROR DE FORMATO");
                    txtCP.SelectAll();
                }
            }
        }
    }
}
