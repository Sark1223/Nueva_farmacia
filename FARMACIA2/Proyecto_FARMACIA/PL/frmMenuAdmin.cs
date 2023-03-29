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

        ///Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //VARIABLES AUXILIARES
        Panel PanelAnterior,PanelActual, Panel1cmd;
        bool primerCmd = true;

        //OBJETOS DE PANTALLAS
        frmCiudad frmCiudad = new frmCiudad();
        frmPropietarios frmPropietarios = new frmPropietarios();
        //frmCiudad frmCiudad = new frmCiudad();
        //frmCiudad frmCiudad = new frmCiudad();
        //frmCiudad frmCiudad = new frmCiudad();
        //frmCiudad frmCiudad = new frmCiudad();

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

        public void ComandoActivo(Panel panel)
        {
            panel.BackColor = Color.FromArgb(7, 200, 216);
        }

        public void ComandoSleep(Panel panel)
        {
            panel.BackColor = Color.FromArgb(27, 138, 158);
        }

        public void Ponerfoco()
        {
            if (primerCmd == true)
            {
                ComandoActivo(PanelActual);
                PanelAnterior = PanelActual;
                primerCmd = false;
            }
            else
            {
                ComandoSleep(PanelAnterior);
                ComandoActivo(PanelActual);
                PanelAnterior = PanelActual;
            }
            
        }


        private void cerrar_Click(object sender, EventArgs e)
        {
            //Cerrar
            this.Close();
            frmInicio inicio = new frmInicio();
            inicio.Show();
        }

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


                frmCiudad.panel1.Size = new Size(776, 509);

            }
            else
            {
                Menu.Width = 70;
                pbMenosMas.Image = Properties.Resources.mas;
                name_usuario.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                name_usuario.Location = new Point(-2, 37);
                avatar.Location = new Point(15, 3);
                MenosMas.Location = new Point(15, 465);
                lblMenosMAs.Location = new Point(9, 37);
                lblMenosMAs.Text = "Mas";

                frmCiudad.panel1.Size = new Size(776 + 115, 509);
                frmCiudad.panel1.BackColor = Color.Aquamarine;
            }
        }


        public void FuncionLeave(Control control)
        {
            if (control != PanelActual)
            {
                control.BackColor = Color.FromArgb(27, 138, 158);
            }
            
        }

        public void funcionHover(Control control)
        {
            control.BackColor = Color.FromArgb(7, 200, 216);
        }

        //Cambiar de color cuando el cursor este sobre los controles

        private void pbCiudad_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmCiudad());
            PanelActual = cmdciudad;
            Ponerfoco();
        }

        private void pbPropi_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmPropietarios());
            PanelActual = cmdProp;
            Ponerfoco();
        }
        
        private void cmdMedi_MouseLeave(object sender, EventArgs e)
        {
            FuncionLeave(cmdMedi);
        }

        private void cmdVentas_MouseLeave(object sender, EventArgs e)
        {
            FuncionLeave(cmdVentas);
        }

        private void cmdSucursales_MouseLeave(object sender, EventArgs e)
        {
            FuncionLeave(cmdSucursales);
        }

        private void cmdProp_MouseLeave(object sender, EventArgs e)
        {
            FuncionLeave(cmdProp);
        }

        private void cmdEmpleado_MouseLeave(object sender, EventArgs e)
        {
            FuncionLeave(cmdEmpleado);
        }

        private void cmdciudad_MouseLeave_1(object sender, EventArgs e)
        {
            FuncionLeave(cmdciudad);
        }

        private void cmdciudad_MouseHover(object sender, EventArgs e)
        {
            funcionHover(cmdciudad);
        }

        private void cmdProp_MouseHover(object sender, EventArgs e)
        {
            funcionHover(cmdProp);
        }

        private void cmdSucursales_MouseHover(object sender, EventArgs e)
        {
            funcionHover(cmdSucursales);
        }

        private void cmdVentas_MouseHover(object sender, EventArgs e)
        {
            funcionHover(cmdVentas);
        }

        private void cmdMedi_MouseHover(object sender, EventArgs e)
        {
            funcionHover(cmdMedi);
        }

        private void cmdEmpleado_MouseHover(object sender, EventArgs e)
        {
            funcionHover(cmdEmpleado);
        }


        
    }
}
