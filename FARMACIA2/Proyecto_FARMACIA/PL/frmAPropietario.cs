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
    public partial class frmAPropietario : Form
    {
        public frmAPropietario()
        {
            InitializeComponent();
        }

        ///Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //OBJETOS DE CLASES Y FORMAS
        Conexion conexion = new Conexion();
        PropietarioBLL OpropiBLL = new PropietarioBLL();

        //VARIABLES AUXILIARES
        string ID_Actual, telefono, correo;

        bool primeraApertura = true;



        //ACTIVAR EL ENCABEZADO PARA QUE SE MUEVA
        private void Mover(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmAPropietario_Load(object sender, EventArgs e)
        {
            primeraApertura = false;
            if (lblTitle.Text == "AÑADIR PROPIETARIO")
            {
                conexion.RellenarCB_1(cbCiudad, "SELECT * FROM CIUDAD", "-- Selecione Ciudad --");
                txtIdPro.Text = "0"; txtMaterno.Text = "A_MATERNO"; txtPaterno.Text = "A_PATERNO";
                txtNombres.Text = "NOMBRE(s)"; txtCorreo.Text = "CORRE"; txtTelefono.Text = "XXXXXXXXX"; 
                txtCalle.Text = "CALLE"; txtNo_exte.Text = "1"; txtInterios.Text = " "; txtCP.Text = "1";
                txtcolonia.Text = "COLONIA";
            }

            if (txtIdPro.Text != "")
            {
                ID_Actual = txtIdPro.Text;
            }
            if (txtTelefono.Text != "")
            {
                telefono = txtTelefono.Text;
            }
            if (txtCorreo.Text != "")
            {
                correo = txtCorreo.Text;
            }

        }

        public void ObtenerValoresPropi()
        {
            OpropiBLL.A_paterno = txtPaterno.Text;
            OpropiBLL.A_materno = txtMaterno.Text;
            OpropiBLL.Nombre_s = txtNombres.Text;
            OpropiBLL.Calle = txtCalle.Text;
            OpropiBLL.No_exterior = int.Parse(txtNo_exte.Text);
            OpropiBLL.No_interior = txtInterios.Text;
            OpropiBLL.Colonia = txtcolonia.Text;
            OpropiBLL.CP = int.Parse(txtCP.Text);
        }


        //METODO DE PROPIETARIO
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if (!ValoresVacios())
            {
                ObtenerValoresPropi();

                if (conexion.AgregarPropietario(OpropiBLL))
                {
                    MessageBox.Show("El propietario: " + txtNombres.Text + " de ID: " + txtIdPro.Text + " se INGRESO correctamente", "REGISTRO AGREGADO", MessageBoxButtons.OK);
                    primeraApertura = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el nuevo propietario.", "ERROR");
                }
            }
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (!ValoresVacios())
            {
                ObtenerValoresPropi();

                string COMANDO = "UPDATE PROPIETARIO SET " +
                                "id_propietario = " + OpropiBLL.ID + ", " +
                                "a_paterno = '" + OpropiBLL.A_paterno + "', " +
                                "a_materno = '" + OpropiBLL.A_materno + "', " +
                                "nombre_s = '" + OpropiBLL.Nombre_s + "', " +
                                "calle = '" + OpropiBLL.Calle + "', " +
                                "no_exterior = " + OpropiBLL.No_exterior + ", " +
                                "no_interior = '" + OpropiBLL.No_interior + "', " +
                                "colonia = '" + OpropiBLL.Colonia + "', " +
                                "CP = " + OpropiBLL.CP + ", " +
                                "telefono = " + OpropiBLL.telefono + ", " +
                                "correo_e = '" + OpropiBLL.correo_e + "', " +
                                "id_ciudad = " + OpropiBLL.id_ciudad +
                                "WHERE id_propietario = " + ID_Actual;

                if (conexion.Modificar(COMANDO))
                {
                    MessageBox.Show("El propietario " + txtNombres.Text + " de ID " + ID_Actual + " ha sido modificada", "REGISTRO MODIFICADO");

                    primeraApertura = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("No se pudo MODIFICAR el nuevo propietario.", "ERROR DE MODIFICACIÓN");
                }
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (conexion.Eliminar("DELETE FROM PROPIETARIO WHERE id_propietario =" + txtIdPro.Text))
            {
                MessageBox.Show("El propietario " + txtPaterno.Text + " " + txtMaterno.Text + " " + txtNombres.Text + " de ID " + txtIdPro.Text + " ha sido eliminado", "REGISTRO ELIMINADO");

                primeraApertura = true;
                Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error.", "ERROR", MessageBoxButtons.OK);
            }
        }


        //RELLENAR COMBOBOX CIUDADES - LLAVE FORANEA
        private void cbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCiudad.SelectedIndex > 0)
            {
                OpropiBLL.id_ciudad = conexion.captar_info_1("SELECT * FROM CIUDAD WHERE nombre_ciudad='" + cbCiudad.Text + "'");
            }
            //else
            //{
            //    MessageBox.Show("Seleccione una ciudad", "ERROR");
            //}
        }

        
        //METODOS PARA CERRAR //METODOS PARA LIMPIAR
        private void button1_Click(object sender, EventArgs e)
        {
            primeraApertura = true;
            Close();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            primeraApertura = true;
            Close();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            txtIdPro.Clear(); txtMaterno.Clear(); txtPaterno.Clear();
            txtCalle.Clear(); txtcolonia.Clear(); txtInterios.Clear();
            txtNo_exte.Clear(); txtCP.Clear(); txtNombres.Clear();
            txtCorreo.Clear(); txtTelefono.Clear();
            conexion.RellenarCB_1(cbCiudad, "SELECT * FROM CIUDAD", "-- Selecione Ciudad --");
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            primeraApertura = true;
            Close();
        }

       


        /*CREATE TABLE PROPIETARIO (
    id_propietario   VARCHAR(10) NOT NULL PRIMARY KEY,
    a_paterno        VARCHAR(50) NOT NULL,
    a_materno        VARCHAR(50) NOT NULL,
    nombre_s      VARCHAR(100) NOT NULL,
    calle            VARCHAR(100) NOT NULL,
    no_exterior      VARCHAR(6) NOT NULL,
    no_interior      VARCHAR(4),
    colonia          VARCHAR(100) NOT NULL,
    CP           VARCHAR(7) NOT NULL,
    telefono         varchar (15)  unique,
    correo_e         VARCHAR(100) unique,
    id_ciudad VARCHAR(10) NOT NULL FOREIGN KEY (id_ciudad ) REFERENCES CIUDAD ( id_ciudad ));*/

        //VALIDACION DE DATOS AGREGADOS POR EL USUARIO
        public bool ValoresVacios()
        {
            string valoresVacios = "";
            int no_vacios = 0;
            //VERIFICACION DE VALORES VACIOS
            {
                if (txtIdPro.Text == "")
                {
                    valoresVacios += "id_propietario, ";
                    no_vacios++;
                }
                if (txtPaterno.Text == "")
                {
                    valoresVacios += "Apellido paterno, ";
                    no_vacios++;
                }
                if (txtMaterno.Text == "")
                {
                    valoresVacios += "Apellido materno, ";
                    no_vacios++;
                }
                if (txtNombres.Text == "")
                {
                    valoresVacios += "Nombre(s), ";
                    no_vacios++;
                }
                if (txtCorreo.Text == "")
                {
                    valoresVacios += "Correo, ";
                    no_vacios++;
                }
                if (txtTelefono.Text == "")
                {
                    valoresVacios += "Telefono, ";
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

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (primeraApertura == false)
            {
                try
                {
                    if (lblTitle.Text == "MODIFICAR PROPIETARIO")
                    {
                        //VERIFICAR QUE LOS DATOS UNICOS NO SE REPITAN 
                        if (conexion.BuscarEnTabla_MODIFICAR("SELECT * FROM PROPIETARIO", txtTelefono.Text, 9, telefono, lblFon.Text) < 1 && txtTelefono.Text != "")
                        {
                            OpropiBLL.telefono = int.Parse(txtTelefono.Text);
                        }
                        else
                        {
                            txtTelefono.SelectAll();
                        }

                    }
                    else
                    {
                        if (conexion.BuscarEnTabla_AGREGAR("SELECT * FROM PROPIETARIO", txtTelefono.Text, 9, lblFon.Text) && txtTelefono.Text != "")
                        {
                            OpropiBLL.telefono = long.Parse(txtTelefono.Text);
                        }
                        else
                        {
                            txtTelefono.SelectAll();
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ingrese SOLO NUMEROS.", "ERROR DE FORMATO");
                    txtIdPro.SelectAll();
                }
            }
        }

        private void txtIdPro_TextChanged(object sender, EventArgs e)
        {
            if (primeraApertura == false)
            {
                try
                {
                    if (lblTitle.Text == "MODIFICAR PROPIETARIO")
                    {
                        //VERIFICAR QUE LOS DATOS UNICOS NO SE REPITAN 
                        if (conexion.BuscarEnTabla_MODIFICAR("SELECT * FROM PROPIETARIO", txtIdPro.Text, 0, ID_Actual, lblPropietario.Text) < 1 && txtIdPro.Text != "")
                        {
                            OpropiBLL.ID = int.Parse(txtIdPro.Text);
                        }
                        else
                        {
                            txtIdPro.SelectAll();
                        }

                    }
                    else
                    {
                        if (conexion.BuscarEnTabla_AGREGAR("SELECT * FROM PROPIETARIO", txtIdPro.Text, 0, lblPropietario.Text) && txtIdPro.Text != "")
                        {
                            OpropiBLL.ID = int.Parse(txtIdPro.Text);
                        }
                        else
                        {
                            txtIdPro.SelectAll();
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ingrese SOLO NUMEROS.", "ERROR DE FORMATO");
                    txtIdPro.SelectAll();
                }
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (primeraApertura == false)
            {
                if (lblTitle.Text == "MODIFICAR PROPIETARIO")
                {
                    //VERIFICAR QUE LOS DATOS UNICOS NO SE REPITAN 
                    if (conexion.BuscarEnTabla_MODIFICAR("SELECT * FROM PROPIETARIO", txtCorreo.Text, 10, correo, lblCorreoE.Text) < 1 && txtCorreo.Text != "")
                    {
                        OpropiBLL.correo_e = txtCorreo.Text;
                    }
                    else
                    {
                        txtCorreo.SelectAll();
                    }

                }
                else
                {
                    if (conexion.BuscarEnTabla_AGREGAR("SELECT * FROM PROPIETARIO", txtCorreo.Text, 10, lblCorreoE.Text) && txtCorreo.Text != "")
                    {
                        OpropiBLL.correo_e = txtCorreo.Text + "@gmail.com";
                    }
                    else
                    {
                        txtCorreo.SelectAll();
                    }
                }
            }
        }

    }
}
