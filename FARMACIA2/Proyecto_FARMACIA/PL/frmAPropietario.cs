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


        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            PropietarioBLL OpropiBLL = new PropietarioBLL();
            OpropiBLL.ID = int.Parse(txtIdPro.Text);
            OpropiBLL.A_paterno = txtPaterno.Text;
            OpropiBLL.A_materno = txtMaterno.Text;
            OpropiBLL.Nombre_s = txtNombres.Text;
            OpropiBLL.Calle = txtCalle.Text;
            OpropiBLL.No_exterior = int.Parse(txtIdPro.Text);
            OpropiBLL.No_interior = txtInterios.Text;
            OpropiBLL.Colonia = txtcolonia.Text;
            OpropiBLL.CP = int.Parse(txtIdPro.Text);
            OpropiBLL.telefono = int.Parse(txtIdPro.Text);
            OpropiBLL.correo_e = txtCorreo.Text;
            OpropiBLL.id_ciudad = comboBox1.Text;

            Conexion conexion = new Conexion();
            MessageBox.Show("conexion = " + conexion.AgregarCiudad(ObjciudadBLL));
        }

        /*int ID;
         *string  
         *string  
         *string 
         *string Calle; 
         *int No_exterior; 
         *string No_interio 
         *string Colonia; 
         *int CP; 
         *long telefono; 
         *string correo_e; 
         *int id_ciudad; 
         * 
         * CREATE TABLE PROPIETARIO (
    id_propietario   VARCHAR(10) NOT NULL PRIMARY KEY,
    a_paterno        VARCHAR(50) NOT NULL,
    a_materno        VARCHAR(50) NOT NULL,
    nombre_s      VARCHAR(100) NOT NULL,
    calle            VARCHAR(100) NOT NULL,
    no_exterior      VARCHAR(6) NOT NULL,
    no_interior      VARCHAR(4),
    colonia          VARCHAR(100) NOT NULL,
    CP           VARCHAR(7) NOT NULL unique,
    telefono         varchar (15)  unique,
    correo_e         VARCHAR(100) unique,
    id_ciudad VARCHAR(10) NOT NULL 
*/
    }
}
