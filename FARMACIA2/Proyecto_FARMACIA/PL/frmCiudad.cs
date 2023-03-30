using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Proyecto_FARMACIA.DAL;
namespace Proyecto_FARMACIA.PL
{
    public partial class frmCiudad : Form
    {
        public frmCiudad()
        {
            InitializeComponent();

        }

        //OBJETOS DE CLASES Y FORMAS
        Conexion conectar = new Conexion();
        frmAciudad aciudad = new frmAciudad();

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            aciudad.lblTitle.Text = "AÑADIR CIUDAD";
            aciudad.lblTitle.Location = new Point(80, 6);
            aciudad.PanelModificar.Visible = false;
            aciudad.PanelAñadir.Visible = true;
            aciudad.ShowDialog();
            dgvCiudades.DataSource = conectar.MostrarCiudades().Tables[0];
        }

        private void frmCiudad_Load(object sender, EventArgs e)
        {
            dgvCiudades.DataSource = conectar.MostrarCiudades().Tables[0];
        }

        private void pbRefrescar_Click(object sender, EventArgs e)
        {
            dgvCiudades.DataSource = conectar.MostrarCiudades().Tables[0];
        }

        private void SeleccionarDK(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            aciudad.PanelModificar.Visible = true;
            aciudad.PanelAñadir.Visible = false;
            aciudad.lblTitle.Text = "MODIFICAR CIUDAD";
            aciudad.lblTitle.Location = new Point(60, 6);

            aciudad.txtId.Text = dgvCiudades.Rows[indice].Cells[0].Value.ToString();
            aciudad.txtNombre.Text = dgvCiudades.Rows[indice].Cells[1].Value.ToString();
            aciudad.txtEstado.Text = dgvCiudades.Rows[indice].Cells[2].Value.ToString();
            aciudad.txtPais.Text = dgvCiudades.Rows[indice].Cells[3].Value.ToString();
            aciudad.txtPoblacion.Text = dgvCiudades.Rows[indice].Cells[4].Value.ToString();
            aciudad.txtTamaño.Text = dgvCiudades.Rows[indice].Cells[5].Value.ToString();

            aciudad.ShowDialog();

            dgvCiudades.DataSource = conectar.MostrarCiudades().Tables[0];
        }
    }
}
