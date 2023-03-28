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

        //SqlConnection conexion = new SqlConnection(@"server = ANVORGUEZA\\SQLEXPRESS; Initial Catalog=DB_FARMACIA_TOPICOS; Integrated Security = true");

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAciudad aciudad = new frmAciudad();
            aciudad.ShowDialog();
        }

        private void frmCiudad_Load(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            dgvCiudades.DataSource = conectar.MostrarCiudades().Tables[0];
        }

        private void pbRefrescar_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            dgvCiudades.DataSource = conectar.MostrarCiudades().Tables[0];
        }
    }
}
