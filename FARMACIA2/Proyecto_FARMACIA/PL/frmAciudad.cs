﻿using Proyecto_FARMACIA.BLL;
using Proyecto_FARMACIA.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Proyecto_FARMACIA.PL
{
    public partial class frmAciudad : Form
    {
        public frmAciudad()
        {
            InitializeComponent();
        }

        ///Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Objetos de Clases
        Conexion conexion = new Conexion();
        CiudadBLL ObjciudadBLL = new CiudadBLL();
        string ID_Actual;
        bool primeraApertura = true;

        //Metodo para moer la ventana del marco superior
        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        //Operaciones que se realizan al cargar la forma
        private void frmAciudad_Load(object sender, EventArgs e)
        {
            primeraApertura = false;
            if(lblTitle.Text == "MODIFICAR CIUDAD")
            {
                this.AcceptButton = cmdModificar;
            }
            else
            {
                this.AcceptButton = cmdAgregar;
            }
            if(txtId.Text != "")
            {
                ID_Actual = txtId.Text;
            }
        }

        public void ObtenerValoresCiudad()
        {
            ObjciudadBLL.nombre = txtNombre.Text;
            ObjciudadBLL.estado = txtEstado.Text;
            ObjciudadBLL.pais = txtPais.Text;
        }


        //METODOS CIUDAD
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if (!ValoresVacios())
            {
                ObtenerValoresCiudad();
                if (conexion.AgregarCiudad(ObjciudadBLL))
                {
                    MessageBox.Show("La Ciudad: " + txtNombre.Text + " de ID: " + txtId.Text + " se INGRESO correctamente", "REGISTRO AGREGADO", MessageBoxButtons.OK);
                    primeraApertura = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error.", "ERROR", MessageBoxButtons.OK);
                }
            }
            
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (!ValoresVacios())
            {
                ObtenerValoresCiudad();

                string COMANDO = "UPDATE CIUDAD SET id_ciudad = " + ObjciudadBLL.ID + ", " +
                                             "nombre_ciudad = '" + ObjciudadBLL.nombre + "', " +
                                             "estado_ciudad = '" + ObjciudadBLL.estado + "'," +
                                             "pais_ciudad = '" + txtPais.Text + "'," +
                                             "no_habitantes_ciudad = " + ObjciudadBLL.no_habitantes + "," +
                                             "tama_superficie_ciudad = " + ObjciudadBLL.superficie +
                                             " WHERE id_ciudad =" + ID_Actual;

                if (conexion.Modificar(COMANDO))
                {
                    MessageBox.Show("La Ciudad " + txtNombre.Text + " de ID " + ID_Actual + " ha sido modificada", "REGISTRO MODIFICADO");
                    primeraApertura = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al intentra modificar CIUDAD.", "ERROR DE MODIFICACION", MessageBoxButtons.OK);
                }
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (conexion.Eliminar("DELETE FROM CIUDAD WHERE id_ciudad =" + txtId.Text))
            {
                MessageBox.Show("La ciudad " + txtNombre.Text + " de ID " + txtId.Text + " ha sido eliminada", "REGISTRO ELIMINADO");
                primeraApertura = true;
                Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error.", "ERROR", MessageBoxButtons.OK);
            }
        }


        //METODOS PARA CERRAR´y limpiar
        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            primeraApertura = true;
            Close();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Clear(); txtNombre.Clear(); txtEstado.Clear();
            txtPais.Clear(); txtPoblacion.Clear(); txtTamaño.Clear();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            primeraApertura = true;
            Close();
        }

        
        //CARACTCERISTICAS DE LOS BOTONES
        private void cmdAgregar_MouseDown(object sender, MouseEventArgs e)
        {
            cmdAgregar.ForeColor = Color.Maroon;
        }

        private void cmdAgregar_MouseHover(object sender, EventArgs e)
        {
            cmdAgregar.ForeColor = Color.White;
            cmdAgregar.BackColor = Color.LightCoral;
            
        }

        private void cmdAgregar_MouseLeave(object sender, EventArgs e)
        {
            cmdAgregar.ForeColor = Color.Maroon;
            cmdAgregar.BackColor = Color.FromArgb(255, 192, 192);
        }


        //validacion de valores agregados por el usuario
        public bool ValoresVacios()
        {
            string valoresVacios = "";
            int no_vacios = 0;

            //VERIFICACION DE VALORES VACIOS
            { 
            if(txtId.Text == "")
            {
                valoresVacios += "id_Ciudad, ";
                no_vacios++;
            }
            if (txtNombre.Text == "")
            {
                valoresVacios += "Nombre Ciudad, ";
                no_vacios++;
            }
            if (txtEstado.Text == "")
            {
                valoresVacios += "Estado, ";
                no_vacios++;
            }
            if (txtPais.Text == "")
            {
                valoresVacios += "Pais, ";
                no_vacios++;
            }
            if (txtPoblacion.Text == "")
            {
                valoresVacios += "Poblacion, ";
                no_vacios++;
            }
            if (txtTamaño.Text == "")
            {
                valoresVacios += "Tamaño, ";
                no_vacios++;
            }
            }
            if(no_vacios>0)
            {
                MessageBox.Show("No puede dejar informacin en blanco \r\n\r\n" +
                                "No. de valores vacios: "+ no_vacios+"\r\n" +
                                "Valores vacios: "+valoresVacios, "ERROR AL INGRESAR VALORES");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if(primeraApertura ==false)
            {
                try
                {
                    if (lblTitle.Text == "MODIFICAR CIUDAD")
                    {
                        //VERIFICAR QUE LOS DATOS UNICOS NO SE REPITAN 
                        if (conexion.BuscarEnTabla_MODIFICAR("SELECT * FROM CIUDAD", txtId.Text, 0, ID_Actual, lblCiudad.Text) < 1 && txtId.Text != "")
                        {
                            ObjciudadBLL.ID = int.Parse(txtId.Text);
                        }
                        else
                        {
                            txtId.SelectAll();
                        }

                    }
                    else
                    {
                        if (conexion.BuscarEnTabla_AGREGAR("SELECT * FROM CIUDAD", txtId.Text, 0, lblCiudad.Text) && txtId.Text != "")
                        {
                            ObjciudadBLL.ID = int.Parse(txtId.Text);
                        }
                        else
                        {
                            txtId.SelectAll();
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ingrese SOLO NUMEROS.", "ERROR DE FORMATO");
                    txtId.SelectAll();
                }
            }
        }

        private void txtPoblacion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtPoblacion.Text != "")
                {
                    ObjciudadBLL.no_habitantes = int.Parse(txtPoblacion.Text);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese SOLO NUMEROS.", "ERROR DE FORMATO");
                txtPoblacion.SelectAll();
            }
        }

        private void txtTamaño_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTamaño.Text != "")
                {
                    ObjciudadBLL.superficie = Double.Parse(txtTamaño.Text);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese SOLO NUMEROS.", "ERROR DE FORMATO");
                txtTamaño.SelectAll();
            }
            
        }

        /*CREATE TABLE CIUDAD (
    id_ciudad VARCHAR(10) NOT NULL,
    nombre_ciudad VARCHAR(100) NOT NULL,
    estado_ciudad  VARCHAR(100) NOT NULL,
    pais_ciudad VARCHAR(100) NOT NULL,
    no_habitantes_ciudad INTEGER NOT NULL,
    tama_superficie_ciudad REAL NOT NULL
);*/
    }
}
