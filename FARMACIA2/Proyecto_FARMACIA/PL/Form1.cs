using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_FARMACIA.PL
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            Aparecer.Start();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmMenuAdmin menuAdmin = new frmMenuAdmin();
            menuAdmin.Show(new frmMenuAdmin());
        }

        int count = 0;
        frmInicio inicio = new frmInicio();

        private void Aparecer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }

            count += 1;

            if(count == 100) 
            {
                Aparecer.Stop();
                Desvanecer.Start();
            }
        }

        private void Desvanecer_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05;

            if (this.Opacity == 0)
            {
                Desvanecer.Stop();
                this.Close();

                frmMenuAdmin menuAdmin = new frmMenuAdmin();
                menuAdmin.ShowDialog();
            }
        }

        //private void btnCerrar_Click(object sender, EventArgs e)
        //{
        //    Close();
        //}

       

        //private void frmAdmin_Load(object sender, EventArgs e)
        //{
        //    AbrirForm(new frmMenuAdmin());
        //}

    }
}
