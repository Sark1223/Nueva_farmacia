using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Proyecto_FARMACIA.PL
{
    public partial class frmMenuAdmin : Form
    {
        public frmMenuAdmin()
        {
            InitializeComponent();
        }

        private void pbSeemore_Click(object sender, EventArgs e)
        {

            //AbrirForm(new frmMasMenu());
            lblMenosMAs.Text = "Sirvoooo";
        }

        public void AbrirForm(object mas)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }

            Form admin = mas as Form;
            admin.TopLevel = false;
            admin.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(admin);
            this.PanelContenedor.Tag = admin;

            admin.Show();
        }


        //Cambiar de color cuando el cursor este sobre los controles
        
        private void pbCiudad_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmCiudad());
        }

        private void pbPropi_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmPropietarios());
        }

        private void cmdciudad_MouseHover(object sender, EventArgs e)
        {

            cmdciudad.BackColor = Color.FromArgb(7, 200, 216);
        }
    
        private void cmdProp_MouseHover(object sender, EventArgs e)
        {
            cmdProp.BackColor = Color.FromArgb(7, 200, 216);
        }

        private void cmdSucursales_MouseHover(object sender, EventArgs e)
        {
            cmdSucursales.BackColor = Color.FromArgb(7, 200, 216);
        }

        private void cmdVentas_MouseHover(object sender, EventArgs e)
        {
            cmdVentas.BackColor = Color.FromArgb(7, 200, 216);
        }

        private void cmdMedi_MouseHover(object sender, EventArgs e)
        {
            cmdMedi.BackColor = Color.FromArgb(7, 200, 216);
        }

        private void cmdEmpleado_MouseHover(object sender, EventArgs e)
        {
            cmdEmpleado.BackColor = Color.FromArgb(7, 200, 216);
        }

        private void cmdMedi_MouseLeave(object sender, EventArgs e)
        {
            cmdMedi.BackColor = Color.FromArgb(27, 138, 158);
        }

        private void cmdVentas_MouseLeave(object sender, EventArgs e)
        {
            cmdVentas.BackColor = Color.FromArgb(27, 138, 158);
        }

        private void cmdSucursales_MouseLeave(object sender, EventArgs e)
        {
            cmdSucursales.BackColor = Color.FromArgb(27, 138, 158);
        }

        private void cmdProp_MouseLeave(object sender, EventArgs e)
        {
            cmdProp.BackColor = Color.FromArgb(27, 138, 158);
        }

        private void cmdEmpleado_MouseLeave(object sender, EventArgs e)
        {
            cmdEmpleado.BackColor = Color.FromArgb(27, 138, 158);
        }

        private void cmdciudad_MouseLeave_1(object sender, EventArgs e)
        {
            cmdciudad.BackColor = Color.FromArgb(27, 138, 158);
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            //Cerrar
            this.Close();
            frmInicio inicio = new frmInicio();
            inicio.Show();
        }

        ///Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Encabezado_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pbMenosMas_Click(object sender, EventArgs e)
        {
            if (Menu.Width == 70)
            {
                Menu.Width = 185;

                pbMenosMas.Image = Properties.Resources.menos;
                name_usuario.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                name_usuario.Location = new Point(42, 37);
                avatar.Location = new Point(63, 4);
                MenosMas.Location = new Point(63, 465);
                lblMenosMAs.Text = "Menos";
                lblMenosMAs.Location = new Point(4, 37);
            }
            else
            {
                Menu.Width = 70;
                pbMenosMas.Image = Properties.Resources.mas;
                name_usuario.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                name_usuario.Location = new Point(-2, 37);
                avatar.Location = new Point(15, 3);
                MenosMas.Location = new Point(15, 465);
                lblMenosMAs.Location = new Point(9,37);
                lblMenosMAs.Text = "Mas";
            }
        }
    }
}
