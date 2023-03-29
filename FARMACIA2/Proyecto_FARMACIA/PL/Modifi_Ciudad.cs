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
    public partial class frmModifi_Ciudad : Form
    {
        public frmModifi_Ciudad()
        {
            InitializeComponent();
        }
        ///Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Mover(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cmdCancelar_MouseHover(object sender, EventArgs e)
        {
            cmdCancelar.ForeColor = Color.White;
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdCancelar_MouseLeave(object sender, EventArgs e)
        {
            cmdCancelar.ForeColor = Color.LightCoral;
        }
    }
}
