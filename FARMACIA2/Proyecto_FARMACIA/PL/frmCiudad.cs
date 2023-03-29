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
            aciudad.ShowDialog();
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
            frmModifi_Ciudad modificar = new frmModifi_Ciudad();
            int indice = e.RowIndex;

            modificar.txtId.Text = dgvCiudades.Rows[indice].Cells[0].Value.ToString();
            modificar.txtNombre.Text = dgvCiudades.Rows[indice].Cells[1].Value.ToString();
            modificar.txtEstado.Text = dgvCiudades.Rows[indice].Cells[2].Value.ToString();
            modificar.txtPais.Text = dgvCiudades.Rows[indice].Cells[3].Value.ToString();
            modificar.txtPoblacion.Text = dgvCiudades.Rows[indice].Cells[4].Value.ToString();
            modificar.txtTamaño.Text = dgvCiudades.Rows[indice].Cells[5].Value.ToString();

            modificar.ShowDialog();

        }
    }
}
