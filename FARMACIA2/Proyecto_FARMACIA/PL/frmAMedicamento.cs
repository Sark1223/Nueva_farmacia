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
    public partial class frmAMedicamento : Form
    {
        public frmAMedicamento()
        {
            InitializeComponent();
        }
        /*CREATE TABLE MEDICAMENTO (
    id_medicamento VARCHAR(12) NOT NULL primary key,
    nombre         VARCHAR(50) NOT NULL,
    descripcion    VARCHAR(200) NOT NULL
);*/

        ///Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Objetos de clases
        Conexion conexion = new Conexion();
        MedicamentoBLL objMedicamento = new MedicamentoBLL();

        //variables auxiliares
        bool primeraApertura = true;

        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmAMedicamento_Load(object sender, EventArgs e)
        {

            if (lblTitle.Text == "AÑADIR MEDICAMENTO")
            {
                this.AcceptButton = cmdAgregar;
            }
            else
            {
                this.AcceptButton = cmdModificar;
            }

        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            primeraApertura = true;
            Close();
        }

        public void ObtenerValoresMedicamento()
        {
            objMedicamento.id_medicamento = int.Parse(txtId.Text);
            objMedicamento.nombre = txtNombre.Text;
            objMedicamento.descripcion = txtDescripcion.Text;
        }

        public bool ValoresVacios()
        {
            string valoresVacios = "";
            int no_vacios = 0;
            //VERIFICACION DE VALORES VACIOS
            {
                if (txtId.Text == "")
                {
                    valoresVacios += "id_medicamento, ";
                    no_vacios++;
                }
                if (txtNombre.Text == "")
                {
                    valoresVacios += "Nombre, ";
                    no_vacios++;
                }
                if (txtDescripcion.Text == "")
                {
                    valoresVacios += "Descripcion, ";
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
                ObtenerValoresMedicamento();

                if (conexion.AgregarMedicamento(objMedicamento))
                {
                    MessageBox.Show("El medicamento: " + txtId.Text + " de  nombre: " + txtNombre.Text + " se INGRESO correctamente", "REGISTRO AGREGADO", MessageBoxButtons.OK);
                    primeraApertura = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("NO se pudo AÑADIR el medicamento.", "ERROR", MessageBoxButtons.OK);
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

    }
}
