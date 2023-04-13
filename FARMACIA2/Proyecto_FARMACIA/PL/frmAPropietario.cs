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
        bool datos_llenos = false;
        int ID_Actual;


        //ACTIVAR EL ENCABEZADO PARA QUE SE MUEVA
        private void Mover(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmAPropietario_Load(object sender, EventArgs e)
        {
            if (lblTitle.Text == "AÑADIR PROPIETARIO")
            {
                conexion.RellenarCB_1(cbCiudad, "SELECT * FROM CIUDAD", "-- Selecione Ciudad --");
            }

            if (txtIdPro.Text != "")
            {
                ID_Actual = int.Parse(txtIdPro.Text);
            }
            
        }

        public bool ObtenerValoresPropi()
        {
            bool completed = false;
            if (conexion.BuscarEnTabla("SELECT * FROM PROPIETARIO", txtIdPro.Text, 0))
            {
                OpropiBLL.ID = int.Parse(txtIdPro.Text);
                OpropiBLL.A_paterno = txtPaterno.Text;
                OpropiBLL.A_materno = txtMaterno.Text;
                OpropiBLL.Nombre_s = txtNombres.Text;
                OpropiBLL.Calle = txtCalle.Text;
                OpropiBLL.No_exterior = int.Parse(txtNo_exte.Text);
                OpropiBLL.No_interior = txtInterios.Text;
                OpropiBLL.Colonia = txtcolonia.Text;
                OpropiBLL.CP = int.Parse(txtCP.Text);
                if (conexion.BuscarEnTabla("SELECT * FROM PROPIETARIO", txtTelefono.Text, 9))
                {
                    OpropiBLL.telefono = long.Parse(txtTelefono.Text);
                }
                    
                if (conexion.BuscarEnTabla("SELECT * FROM PROPIETARIO", txtCorreo.Text + "@GMAIL.COM", 10))
                {
                    OpropiBLL.correo_e = txtCorreo.Text + "@GMAIL.COM";
                    completed = true;
                }

                return completed;
            }
            else
            {
                return completed;
            }
        }


        //METODO DE PROPIETARIO
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if (ObtenerValoresPropi())
            {
                /* if (*/
                conexion.AgregarPropietario(OpropiBLL);
                //{
                MessageBox.Show("El propietario: " + txtNombres.Text + " de ID: " + txtIdPro.Text + " se INGRESO correctamente", "REGISTRO AGREGADO", MessageBoxButtons.OK);
                Close();
                //}
                //else
                //{
                //    MessageBox.Show("Ha ocurrido un error.", "ERROR", MessageBoxButtons.OK);
                //}
            }
            else
            {
                MessageBox.Show("No se pudo agregar el nuevo propietario.", "ERROR");
            }


        }

        private void cmdModificar_Click(object sender, EventArgs e)
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

                Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error.", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (conexion.Eliminar("DELETE FROM PROPIETARIO WHERE id_propietario =" + txtIdPro.Text))
            {
                MessageBox.Show("El propietario " + txtPaterno.Text + " " + txtMaterno.Text + " " + txtNombres.Text + " de ID " + txtIdPro.Text + " ha sido eliminado", "REGISTRO ELIMINADO");

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
            if(cbCiudad.SelectedIndex > 0)
            {
                    OpropiBLL.id_ciudad = conexion.captar_info_1("SELECT * FROM CIUDAD WHERE nombre_ciudad='" + cbCiudad.Text + "'");
            }
            else
            {
                MessageBox.Show("Seleccione una ciudad", "ERROR");
            }
        }

        
        //METODOS PARA CERRAR
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //METODOS PARA LIMPIAR
        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            txtIdPro.Clear();txtMaterno.Clear();txtPaterno.Clear();
            txtCalle.Clear();txtcolonia.Clear();txtInterios.Clear();  
            txtNo_exte.Clear();txtCP.Clear();txtNombres.Clear();           
            txtCorreo.Clear();txtTelefono.Clear();
            conexion.RellenarCB_1(cbCiudad, "SELECT * FROM CIUDAD", "-- Selecione Ciudad --");
        }

    }
}
