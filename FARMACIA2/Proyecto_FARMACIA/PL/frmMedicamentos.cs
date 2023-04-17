using Proyecto_FARMACIA.BLL;
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
    public partial class frmMedicamentos : Form
    {
        public frmMedicamentos()
        {
            InitializeComponent();
        }
        //objetos de clases
        Conexion conexion = new Conexion();
        frmAMedFarm aMedFarm = new frmAMedFarm();
        frmAMedicamento aMedicamento = new frmAMedicamento();

        private void frmMedicamentos_Load(object sender, EventArgs e)
        {
            conexion.RellenarCB_2(cbFarmacia, "SELECT * FROM FARMACIA", "-- Selecione Farmacia --");
        }

        private void cbPropietario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFarmacia.SelectedIndex > 0) 
            {
                string id = conexion.SepararValores(cbFarmacia.Text);
                conexion.Mostrar_Precio_MedFarm(id, 0);

                dgvPrecioMedi.Update();
                //objMedFarm.id_Sucursal = conexion.captar_info_2("SELECT * FROM SUCURSAL WHERE id_propietario=" + id);
            }
        }

        private void cmdAgregarMedi_Click(object sender, EventArgs e)
        {
            aMedicamento.PanelModificar.Visible = false;
            aMedicamento.PanelAñadir.Visible = true;
            aMedicamento.lblTitle.Text = "AÑADIR MEDICAMENTO";
            aMedicamento.lblTitle.Location = new Point((aMedicamento.Title.Width / 2) - (aMedicamento.lblTitle.Width / 2), 3);//Se ubica en diferente posicion

            aMedicamento.ShowDialog();

            //Refrescar tabla
            dgvMedicamentos.DataSource = conexion.MostrarMedicamenntos().Tables[0];

        }

        private void cmdAgregarPrecio_Click(object sender, EventArgs e)
        {
            aMedFarm.PanelModificar.Visible = false;
            aMedFarm.PanelAñadir.Visible = true;
            aMedFarm.lblTitle.Text = "AÑADIR PRECIO";
            aMedFarm.lblTitle.Location = new Point((aMedFarm.Title.Width / 2) - (aMedFarm.lblTitle.Width / 2), 3);//Se ubica en diferente posicion

            aMedFarm.ShowDialog();

            //Refrescar tabla
            dgvPrecioMedi.DataSource = conexion.MostrarPrecio().Tables[0];
        }

        private void ModificarMedicamento_DobleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            aMedFarm.PanelModificar.Visible = true;
            aMedFarm.PanelAñadir.Visible = false;
            aMedFarm.lblTitle.Text = "MODIFICAR MEDICAMENTO";
            aMedFarm.lblTitle.Location = new Point((aMedFarm.Title.Width / 2) - (aMedFarm.lblTitle.Width / 2), 3);//Se ubica en diferente posicion

            aMedicamento.ShowDialog();

            //Refrescar tabla
            dgvMedicamentos.DataSource = conexion.MostrarPrecio().Tables[0];
        }

        private void ModificarPrecio_DobleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            aMedicamento.PanelModificar.Visible = true;
            aMedicamento.PanelAñadir.Visible = false;
            aMedicamento.lblTitle.Text = "MODIFICAR PRECIO";
            aMedicamento.lblTitle.Location = new Point((aMedicamento.Title.Width / 2) - (aMedicamento.lblTitle.Width / 2), 3);//Se ubica en diferente posicion

            aMedicamento.ShowDialog();

            //Refrescar tabla
            dgvMedicamentos.DataSource = conexion.MostrarMedicamenntos().Tables[0];
        }
    }
}
