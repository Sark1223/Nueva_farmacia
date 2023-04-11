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
using Proyecto_FARMACIA.DAL;

namespace Proyecto_FARMACIA.PL
{
    public partial class frmMenuAdmin : Form
    {
        public frmMenuAdmin()
        {
            InitializeComponent();
            this.Size = new Size(1460, 860);
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
        frmMostrarOp opAdmin = new frmMostrarOp();

        //OBJETO CONEXION
        Conexion conectar = new Conexion();

        
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
            }
        }

        

        //CARGAR LA TABLA DEPENDIENDO DE LA OPCION SELECCIONADA
        public void CargarTabla(string forma)
        {
            if (forma == cmdciudad.Name)
            {
                opAdmin.lblOpcion.Text = "CIUDADES";
                opAdmin.dgvTablaDB.DataSource = conectar.MostrarCiudades().Tables[0];
            }
            else if (forma == cmdProp.Name)
            {
                opAdmin.lblOpcion.Text = "PROPIETARIOS";
                opAdmin.dgvTablaDB.DataSource = conectar.MostrarPropietarios().Tables[0];

            }
            else if (forma == cmdEmpleado.Name)
            {

            }
            else if (forma == cmdSucursales.Name)
            {

            }
            else if (forma == cmdVentas.Name)
            {

            }
            else if (forma == cmdMedi.Name)
            {

            }
            else
            {
                MessageBox.Show("error");
            }
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


        //CLICK EN LOS COMANDOS 
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

        private void pbCiudad_Click(object sender, EventArgs e)
        {
            CargarTabla(cmdciudad.Name);
            AbrirForm(opAdmin);
            PanelActual = cmdciudad;
            Ponerfoco();
        }

        private void pbPropi_Click(object sender, EventArgs e)
        {
            CargarTabla(cmdProp.Name);
            AbrirForm(opAdmin);
            PanelActual = cmdProp;
            Ponerfoco();
        }


        //ACCIONES CUANDO EL CURSOR ESTA FUERA DEL CONTROL
        public void FuncionLeave(Control control)
        {
            if (control != PanelActual)
            {
                control.BackColor = Color.FromArgb(27, 138, 158);
            }

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


        //ACCIONES CUANDO EL CURSOR ESTAR SOBRE EL CONTROL
        public void funcionHover(Control control)
        {
            control.BackColor = Color.FromArgb(7, 200, 216);
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
