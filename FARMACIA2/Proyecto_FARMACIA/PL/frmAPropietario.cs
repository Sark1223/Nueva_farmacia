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

        //ACTIVAR EL ENCABEZADO PARA QUE SE MUEVA
        private void Mover(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void cmdAgregar_Click(object sender, EventArgs e)
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
            OpropiBLL.telefono = int.Parse(txtTelefono.Text);
            OpropiBLL.correo_e = txtCorreo.Text+"@GMAIL.COM";

            
            MessageBox.Show("conexion = " + conexion.AgregarPropietario(OpropiBLL));
        }

        private void frmAPropietario_Load(object sender, EventArgs e)
        {
            conexion.RellenarCB(cbCiudad, "SELECT * FROM CIUDAD", "-- Selecione Ciudad --");
        }

        private void cbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCiudad.SelectedIndex > 0)
            {
                OpropiBLL.id_ciudad = conexion.captar_info("SELECT * FROM CIUDAD WHERE nombre_ciudad='" + cbCiudad.Text + "'") ;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            txtIdPro.Clear();txtMaterno.Clear();txtPaterno.Clear();
            txtCalle.Clear();txtcolonia.Clear();txtInterios.Clear();  
            txtNo_exte.Clear();txtCP.Clear();txtNombres.Clear();           
            txtCorreo.Clear();txtTelefono.Clear();
            conexion.RellenarCB(cbCiudad, "SELECT * FROM CIUDAD", "-- Selecione Ciudad --");


        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            
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

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
