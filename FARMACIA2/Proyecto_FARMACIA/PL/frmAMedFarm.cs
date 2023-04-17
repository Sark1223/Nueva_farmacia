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
        /*CREATE TABLE MED_FARM (
   id_farmacia       VARCHAR(5) NOT NULL FOREIGN KEY (id_farmacia ) REFERENCES FARMACIA ( id_farmacia ),
   id_medicamento VARCHAR(12) NOT NULL FOREIGN KEY (id_medicamento ) REFERENCES MEDICAMENTO ( id_medicamento ),
   precio                     Numeric(7, 2) NOT NULL,
   cantidad_existente         VARCHAR(4) NOT NULL
);
*/
      
    public partial class frmAMedFarm : Form
    {
        public frmAMedFarm()
        {
            InitializeComponent();
        }

        ///Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //objetos de clase
        Conexion conexion = new Conexion();
        MedFarmBLL objMedfarm = new MedFarmBLL();

        //variables auxiliares 
        bool primeraApertura=true;
        string id_farmacia, id_medicamento;

        private void frmAMedFarm_Load(object sender, EventArgs e)
        {
            primeraApertura = false;
            if (lblTitle.Text == "AÑADIR PRECIO")
            {
                conexion.RellenarCB_2(cbFarmacia, "SELECT * FROM FARMACIA", "-- Selecione Sucursal --");
                conexion.RellenarCB_2(cbMedicamento, "SELECT * FROM MEDICAMENTO", "-- Selecione Medicamento --");

                this.AcceptButton = cmdAgregar;
            }
            else
            {
                this.AcceptButton = cmdModificar;
            }

            if (cbFarmacia.SelectedIndex != 0)
            {
                id_farmacia = conexion.SepararValores(cbFarmacia.Text);
            }
            if (cbMedicamento.SelectedIndex != 0)
            {
                id_medicamento = conexion.SepararValores(cbMedicamento.Text);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ObtenerValoresMed_farm()
        {
            //objMedfarm.id_farmacia = int.Parse(txtIdFarmacia.Text);
            //objMedfarm.id_medicamento = int.Parse(txtIdFarmacia.Text);
            objMedfarm.precio = float.Parse(txtPrecio.Text);
            objMedfarm.cantidad_exitente = int.Parse(txtCantidadE.Text);
        }

        public bool ValoresVacios()
        {
            string valoresVacios = "";
            int no_vacios = 0;
            //VERIFICACION DE VALORES VACIOS
            {
                if (cbFarmacia.Text == "-- Selecione Sucursal --")
                {
                    valoresVacios += "Sucursal, ";
                    no_vacios++;
                }
                if (cbMedicamento.Text == "-- Selecione Medicamento --")
                {
                    valoresVacios += "Medicamento, ";
                    no_vacios++;
                }
                if (txtPrecio.Text == "")
                {
                    valoresVacios += "CP, ";
                    no_vacios++;
                }
                if (txtCantidadE.Text == "-- Selecione Ciudad --")
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

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if (!ValoresVacios())
            {
                ObtenerValoresMed_farm();

                if (conexion.AgregarPrecio(objMedfarm))
                {
                    MessageBox.Show("El precio del medicamento: " + cbMedicamento.Text + " en la farmacia: " + cbFarmacia.Text + " se INGRESO correctamente", "REGISTRO AGREGADO", MessageBoxButtons.OK);
                    primeraApertura = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("NO se pudo AÑADIR precio al medicamento.", "ERROR", MessageBoxButtons.OK);
                }
            }
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {

        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {

        }

        private void cbMedicamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (primeraApertura == false)
            {
                if (cbMedicamento.SelectedIndex > 0)
                {
                    string id = conexion.SepararValores(cbMedicamento.Text);
                    objMedfarm.id_medicamento = conexion.captar_info_2("SELECT * FROM PROPIETARIO WHERE id_propietario=" + id);

                    if (lblTitle.Text == "MODIFICAR PRECIO")
                    {
                        //VERIFICAR QUE LOS DATOS UNICOS NO SE REPITAN 
                        if (conexion.BuscarEnTabla_MODIFICAR("SELECT * FROM FARMACIA", id, 1, id_medicamento, lblMedicamento.Text) < 1 && id != "-")
                        {
                            objMedfarm.id_medicamento = int.Parse(id);
                        }
                        else
                        {
                            cbFarmacia.SelectedIndex = 0;
                        }

                    }
                    else
                    {
                        if (conexion.BuscarEnTabla_AGREGAR("SELECT * FROM FARMACIA", id, 1, lblMedicamento.Text) && id != "-")
                        {
                            objMedfarm.id_medicamento = int.Parse(id);
                        }
                        else
                        {
                            cbFarmacia.SelectedIndex = 0;
                        }
                    }
                }
            }
        }

        private void cbFarmacia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (primeraApertura == false)
            {
                if (cbFarmacia.SelectedIndex > 0)
                {
                    string id = conexion.SepararValores(cbFarmacia.Text);
                    objMedfarm.id_farmacia = conexion.captar_info_2("SELECT * FROM PROPIETARIO WHERE id_propietario=" + id);

                    if (lblTitle.Text == "MODIFICAR PRECIO")
                    {
                        //VERIFICAR QUE LOS DATOS UNICOS NO SE REPITAN 
                        if (conexion.BuscarEnTabla_MODIFICAR("SELECT * FROM FARMACIA", id, 0, id_farmacia, lblFarmacia.Text) < 1 && id != "-")
                        {

                            objMedfarm.id_farmacia = int.Parse(id);
                        }
                        else
                        {
                            cbFarmacia.SelectedIndex = 0;
                        }

                    }
                    else
                    {
                        if (conexion.BuscarEnTabla_AGREGAR("SELECT * FROM FARMACIA", id, 0, lblFarmacia.Text) && id != "-")
                        {
                            objMedfarm.id_farmacia = int.Parse(id);
                        }
                        else
                        {
                            cbFarmacia.SelectedIndex = 0;
                        }
                    }
                }
            }
        }
    }
}
