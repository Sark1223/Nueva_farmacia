using Proyecto_FARMACIA.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_FARMACIA.PL
{
    public partial class frmPropietarios : Form
    {
        public frmPropietarios()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPropietarios_Load(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            //dgvPropietarios.DataSource = conectar.MostrarPropietarios().Tables[0];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAPropietario aPropietario = new frmAPropietario();
            aPropietario.ShowDialog();
        }

        private void pbRefrescar_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            dgvPropietarios.DataSource = conectar.MostrarPropietarios().Tables[0];
        }
    }
}
