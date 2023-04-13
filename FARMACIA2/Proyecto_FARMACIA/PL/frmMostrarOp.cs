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
    public partial class frmMostrarOp : Form
    {
        public frmMostrarOp()
        {
            InitializeComponent();
            
        }

        //OBJETOS DE CLASES Y FORMAS
        Conexion conectar = new Conexion();
        frmAPropietario aPropietario = new frmAPropietario();
        frmAciudad aciudad = new frmAciudad();
        frmASucursal aSucursal = new frmASucursal();


        //METODOS COMUNES DE LAS DIFERENTES OPCIONES
        private void AGREGAR_Click(object sender, EventArgs e)
        {
            if(lblOpcion.Text == "CIUDADES")
            {
                aciudad.lblTitle.Text = "AÑADIR CIUDAD";
                aciudad.lblTitle.Location = new Point(80, 6);
                aciudad.PanelModificar.Visible = false;
                aciudad.PanelAñadir.Visible = true;

                aciudad.ShowDialog();

                //Refrescar tabla
                dgvTablaDB.DataSource = conectar.MostrarCiudades().Tables[0];
            }
            else if (lblOpcion.Text == "PROPIETARIOS")
            {
                aPropietario.PanelModificar.Visible = false;
                aPropietario.PanelAñadir.Visible = true;
                aPropietario.txtCorreo.Width = 235;
                aPropietario.panel16.Width = 239;
                aPropietario.lblGmal.Visible = true;
                aPropietario.lblTitle.Text = "AÑADIR PROPIETARIO";
                aPropietario.lblTitle.Location = new Point((aPropietario.Title.Width / 2) - (aPropietario.lblTitle.Width / 2), 6);//Se ubica en diferente posicion

                aPropietario.ShowDialog();

                //Refrescar tabla
                dgvTablaDB.DataSource = conectar.MostrarPropietarios().Tables[0];
            }
            else if (lblOpcion.Text == "EMPLEADOS")
            {

            }
            else if (lblOpcion.Text == "SUCURSALES")
            {
                aSucursal.PanelModificar.Visible = false;
                aSucursal.PanelAñadir.Visible = true;
                aSucursal.lblTitle.Text = "AÑADIR SUCURSAL";
                aSucursal.lblTitle.Location = new Point((aSucursal.Title.Width / 2) - (aSucursal.lblTitle.Width / 2), 6);//Se ubica en diferente posicion

                aSucursal.ShowDialog();

                //Refrescar tabla
                dgvTablaDB.DataSource = conectar.MostrarSucursales().Tables[0];

            }
            else if (lblOpcion.Text == "VENTAS")
            {

            }
            else if (lblOpcion.Text == "MEDICAMENTOS")
            {

            }
            else
            {
                MessageBox.Show("error");
            }

        }

        private void REFRESCAR_Click(object sender, EventArgs e)
        {
            if (lblOpcion.Text == "CIUDADES")
            {
                dgvTablaDB.DataSource = conectar.MostrarCiudades().Tables[0];
            }
            else if (lblOpcion.Text == "PROPIETARIOS")
            {
                dgvTablaDB.DataSource = conectar.MostrarPropietarios().Tables[0];
            }
            else if (lblOpcion.Text == "EMPLEADOS")
            {

            }
            else if (lblOpcion.Text == "SUCURSALES")
            {

            }
            else if (lblOpcion.Text == "VENTAS")
            {

            }
            else if (lblOpcion.Text == "MEDICAMENTOS")
            {

            }
            else
            {
                MessageBox.Show("error");
            }

        }

        private void MODIFICAR_DobleClick_Registro(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (lblOpcion.Text == "CIUDADES")
            {
                //Modificar los valores para que La ventana cambie a Modificar
                aciudad.PanelModificar.Visible = true;
                aciudad.PanelAñadir.Visible = false;
                aciudad.lblTitle.Text = "MODIFICAR CIUDAD";
                aciudad.lblTitle.Location = new Point(60, 6);//Se ubica en diferente posicion

                //Obtener los valores de la tabla y agregarlos a los TextBox
                int indice = e.RowIndex;
                aciudad.txtId.Text = dgvTablaDB.Rows[indice].Cells[0].Value.ToString();
                aciudad.txtNombre.Text = dgvTablaDB.Rows[indice].Cells[1].Value.ToString();
                aciudad.txtEstado.Text = dgvTablaDB.Rows[indice].Cells[2].Value.ToString();
                aciudad.txtPais.Text = dgvTablaDB.Rows[indice].Cells[3].Value.ToString();
                aciudad.txtPoblacion.Text = dgvTablaDB.Rows[indice].Cells[4].Value.ToString();
                aciudad.txtTamaño.Text = dgvTablaDB.Rows[indice].Cells[5].Value.ToString();

                aciudad.ShowDialog();

                dgvTablaDB.DataSource = conectar.MostrarCiudades().Tables[0];
            }
            else if (lblOpcion.Text == "PROPIETARIOS")
            {
                //Modificar los valores para que La ventana cambie a Modificar
                aPropietario.PanelModificar.Visible = true;
                aPropietario.PanelAñadir.Visible = false;
                aPropietario.lblTitle.Text = "MODIFICAR PROPIETARIO";
                aPropietario.txtCorreo.Width = 320;
                aPropietario.panel16.Width = 324;
                aPropietario.lblGmal.Visible = false;
                aPropietario.lblTitle.Location = new Point((aPropietario.Title.Width / 2) - (aPropietario.lblTitle.Width / 2), 6);//Se ubica en diferente posicion

                //Obtener los valores de la tabla y agregarlos a los TextBox
                int indice = e.RowIndex;

                //DATOS PERSONALES
                aPropietario.txtIdPro.Text = dgvTablaDB.Rows[indice].Cells[0].Value.ToString();
                aPropietario.txtPaterno.Text = dgvTablaDB.Rows[indice].Cells[1].Value.ToString();
                aPropietario.txtMaterno.Text = dgvTablaDB.Rows[indice].Cells[2].Value.ToString();
                aPropietario.txtNombres.Text = dgvTablaDB.Rows[indice].Cells[3].Value.ToString();
                aPropietario.txtTelefono.Text = dgvTablaDB.Rows[indice].Cells[9].Value.ToString();
                aPropietario.txtCorreo.Text = dgvTablaDB.Rows[indice].Cells[10].Value.ToString();

                //DIRECCION PARTICULAR
                aPropietario.txtCalle.Text = dgvTablaDB.Rows[indice].Cells[4].Value.ToString();
                aPropietario.txtNo_exte.Text = dgvTablaDB.Rows[indice].Cells[5].Value.ToString();
                aPropietario.txtInterios.Text = dgvTablaDB.Rows[indice].Cells[6].Value.ToString();
                aPropietario.txtcolonia.Text = dgvTablaDB.Rows[indice].Cells[7].Value.ToString();
                aPropietario.txtCP.Text = dgvTablaDB.Rows[indice].Cells[8].Value.ToString();

                conectar.RellenarCB_1(aPropietario.cbCiudad, "SELECT * FROM CIUDAD", "-- Selecione Ciudad --");
                bool bandera = false;
                int i=0;
                string ciudad = conectar.Retornar_info_1("SELECT * FROM CIUDAD WHERE id_ciudad=" + dgvTablaDB.Rows[indice].Cells[11].Value);
                while (bandera== false)
                {
                    if ((aPropietario.cbCiudad.SelectedIndex = i.ToString()) == ciudad)
                    {

                    }
                }

                //aPropietario.cbCiudad.SelectedIndex = conectar.Retornar_info_1("SELECT * FROM CIUDAD WHERE id_ciudad=" + dgvTablaDB.Rows[indice].Cells[11].Value);
                //aPropietario.cbCiudad.Text = conectar.Retornar_info_1("SELECT * FROM CIUDAD WHERE id_ciudad=" + dgvTablaDB.Rows[indice].Cells[11].Value);

                aPropietario.ShowDialog();

                dgvTablaDB.DataSource = conectar.MostrarPropietarios().Tables[0];

            }
            else if (lblOpcion.Text == "EMPLEADOS")
            {

            }
            else if (lblOpcion.Text == "SUCURSALES")
            {
                

                //Modificar los valores para que La ventana cambie a Modificar
                aSucursal.PanelModificar.Visible = true;
                aSucursal.PanelAñadir.Visible = false;
                aSucursal.lblTitle.Text = "MODIFICAR SUCURSAL";
                aSucursal.lblTitle.Location = new Point((aSucursal.Title.Width / 2) - (aSucursal.lblTitle.Width / 2), 6);//Se ubica en diferente posicion

                //Obtener los valores de la tabla y agregarlos a los TextBox
                int indice = e.RowIndex;
                
                //DATOS PERSONALES
                aSucursal.txtIdFarmacia.Text = dgvTablaDB.Rows[indice].Cells[0].Value.ToString();
                aSucursal.txtNombre.Text = dgvTablaDB.Rows[indice].Cells[1].Value.ToString();
                conectar.RellenarCB_2Palabras(aSucursal.cbPropietario, "SELECT * FROM PROPIETARIO", conectar.Retornar_info_2("SELECT * FROM PROPIETARIO WHERE id_propietario=" + dgvTablaDB.Rows[indice].Cells[7].Value));

                //DIRECCION PARTICULAR
                aSucursal.txtCalle.Text = dgvTablaDB.Rows[indice].Cells[2].Value.ToString();
                aSucursal.txtNo_exte.Text = dgvTablaDB.Rows[indice].Cells[3].Value.ToString();
                aSucursal.txtInterios.Text = dgvTablaDB.Rows[indice].Cells[4].Value.ToString();
                aSucursal.txtcolonia.Text = dgvTablaDB.Rows[indice].Cells[5].Value.ToString();
                aSucursal.txtCP.Text = dgvTablaDB.Rows[indice].Cells[6].Value.ToString();

                //conectar.RellenarCB_1(aSucursal.cbCiudad, "SELECT * FROM CIUDAD", conectar.Retornar_info_1("SELECT * FROM CIUDAD WHERE id_ciudad=" + dgvTablaDB.Rows[indice].Cells[8].Value));

                //aPropietario.cbCiudad.Text = conectar.Retornar_info_2("SELECT * FROM CIUDAD WHERE id_ciudad=" + dgvTablaDB.Rows[indice].Cells[11].Value);

                aSucursal.ShowDialog();

                dgvTablaDB.DataSource = conectar.MostrarSucursales().Tables[0];
            }
            else if (lblOpcion.Text == "VENTAS")
            {

            }
            else if (lblOpcion.Text == "MEDICAMENTOS")
            {

            }
            else
            {
                MessageBox.Show("error");
            }
            
        }
        

        //Cerrar desde el icono predetermimnado para cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            lblOpcion.Location = new Point((panel1.Width / 2) - (lblOpcion.Width / 2), 6);
        }
    }
}
