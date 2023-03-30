using Proyecto_FARMACIA.BLL;
using Proyecto_FARMACIA.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Proyecto_FARMACIA.PL
{
    public partial class frmAciudad : Form
    {
        public frmAciudad()
        {
            InitializeComponent();
        }

        ///Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        Conexion conexion = new Conexion();

        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            cmdAgregar.ForeColor = Color.Maroon;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            cmdAgregar.ForeColor = Color.White;
            cmdAgregar.BackColor = Color.LightCoral;
            
        }

        private void cmdAgregar_MouseLeave(object sender, EventArgs e)
        {
            cmdAgregar.ForeColor = Color.Maroon;
            cmdAgregar.BackColor = Color.FromArgb(255, 192, 192);
        }

       private void cmdAgregar_Click(object sender, EventArgs e)
        {
            CiudadBLL ObjciudadBLL = new CiudadBLL();
            ObjciudadBLL.ID = int.Parse(txtId.Text);
            ObjciudadBLL.nombre = txtNombre.Text;
            ObjciudadBLL.estado = txtEstado.Text ;
            ObjciudadBLL.pais = txtPais.Text;
            ObjciudadBLL.no_habitantes = int.Parse(txtPoblacion.Text);
            ObjciudadBLL.superficie = Double.Parse(txtTamaño.Text);
            
            if (conexion.AgregarCiudad(ObjciudadBLL))
            {
                MessageBox.Show("La ciudad " + txtNombre.Text + " de ID " + txtId.Text + " se INGRESO correctamente", "REGISTRO AGREGADO", MessageBoxButtons.OK);
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

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (conexion.Eliminar("DELETE FROM CIUDAD WHERE id_ciudad =" + txtId.Text))
            {
                MessageBox.Show("La ciudad " + txtNombre.Text + " de ID " + txtId.Text + " ha sido eliminada", "REGISTRO ELIMINADO");

                Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error.", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            CiudadBLL ObjciudadBLL = new CiudadBLL();
            ObjciudadBLL.ID = int.Parse(txtId.Text);
            ObjciudadBLL.nombre = txtNombre.Text;
            ObjciudadBLL.estado = txtEstado.Text;
            ObjciudadBLL.pais = txtPais.Text;
            ObjciudadBLL.no_habitantes = int.Parse(txtPoblacion.Text);
            ObjciudadBLL.superficie = Double.Parse(txtTamaño.Text);
            //id_ciudad,nombre_ciudad,estado_ciudad,pais_ciudad,no_habitantes_ciudad,tama_superficie_ciudad
            if (conexion.Modificar("UPDATE CIUDAD SET id_ciudad = "+ObjciudadBLL.ID+", nombre_ciudad = '" + ObjciudadBLL.nombre + "', " +
                "estado_ciudad = '" + ObjciudadBLL.estado + "',pais_ciudad = '" + txtPais.Text + "'," +
                "no_habitantes_ciudad = " + ObjciudadBLL.no_habitantes + ",tama_superficie_ciudad = " + ObjciudadBLL.superficie +
                " WHERE id_ciudad =" + ObjciudadBLL.ID))
            {
                MessageBox.Show("La ciudad " + txtNombre.Text + " de ID " + txtId.Text + " ha sido modificada", "REGISTRO MODIFICADO");

                Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error.", "ERROR", MessageBoxButtons.OK);
            }
        }
    }
}
