using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Proyecto_FARMACIA.PL;
using Proyecto_FARMACIA.BLL;
using System.Drawing;
using System.Runtime.Remoting.Messaging;

namespace Proyecto_FARMACIA.DAL
{
    internal class Conexion
    {
        private string CadenaConexion = @"server = ANVORGUEZA\SQLEXPRESS; Initial Catalog = DB_FARMACIA_TOPICOS; Integrated Security = true";
        SqlConnection conexion;

        //Objetos de formas
        frmAciudad Aciudad = new frmAciudad();

        public SqlConnection EstablecerConexion()
        {
            this.conexion = new SqlConnection(this.CadenaConexion);
            return this.conexion;
        }

        public DataSet EjecutarSentencia(SqlCommand comando)
        {
            DataSet DS = new DataSet();
            SqlDataAdapter adaptador  = new SqlDataAdapter();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = comando;
                cmd.Connection = EstablecerConexion();
                adaptador.SelectCommand = cmd;
                conexion.Open();
                adaptador.Fill(DS);
                conexion.Close();

                return DS;
            }
            catch
            {
                return DS;
            }
        }

        public void RellenarCB(ComboBox cb, string sentencia, string textoCB)
        {
            SqlCommand cmd = new SqlCommand(sentencia);
            cmd.Connection = EstablecerConexion();
            cb.Items.Clear();
            conexion.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr[1].ToString());
            }
            conexion.Close();
            cb.Items.Insert(0, textoCB);
            cb.SelectedIndex = 0;
        }

        public int captar_info(string sentencia)
        {
            SqlCommand cmd = new SqlCommand(sentencia);
            cmd.Connection = EstablecerConexion();
            conexion.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            int ID = 0;
            while (dr.Read())
            {
                ID = int.Parse(dr[0].ToString());
            }
            conexion.Close();
            return ID;
        }


        public bool AgregarCiudad(CiudadBLL ciudad)
        {
            try
            {
                SqlCommand agregar = new SqlCommand(
            "insert into CIUDAD(id_ciudad,nombre_ciudad,estado_ciudad,pais_ciudad,no_habitantes_ciudad,tama_superficie_ciudad)" +
            "values(@id,@nombre,@estado,@pais,@nohabitantes,@superficie)");

                agregar.Parameters.AddWithValue("id", ciudad.ID);
                agregar.Parameters.AddWithValue("nombre", ciudad.nombre);
                agregar.Parameters.AddWithValue("estado", ciudad.estado);
                agregar.Parameters.AddWithValue("pais", ciudad.pais);
                agregar.Parameters.AddWithValue("nohabitantes", ciudad.no_habitantes);
                agregar.Parameters.AddWithValue("superficie", ciudad.superficie);

                agregar.Connection = EstablecerConexion();
                conexion.Open();
                agregar.ExecuteNonQuery();
                conexion.Close();

                return true;
            }
            catch
            {
                return false;
            }
                
        }

        public bool AgregarPropietario(PropietarioBLL propietario)
        {
            try
            {
                SqlCommand agregar = new SqlCommand(
                "insert into PROPIETARIO(" +
                            "id_propietario," +
                            "a_paterno," +
                            "a_materno," +
                            "nombre_s," +
                            "calle," +
                            "no_exterior," +
                            "no_interior," +
                            "colonia," +
                            "CP," +
                            "telefono," +
                            "correo_e," +
                            "id_ciudad)" +
                "values(@id_propietario,@a_paterno,@a_materno,@nombre_s,@calle,@no_exterior,@no_interior,@colonia,@CP,@telefono,@correo,@id_ciudad)");

                agregar.Parameters.AddWithValue("id_propietario", propietario.ID);
                agregar.Parameters.AddWithValue("a_paterno", propietario.A_paterno);
                agregar.Parameters.AddWithValue("a_materno", propietario.A_materno);
                agregar.Parameters.AddWithValue("nombre_s", propietario.Nombre_s);
                agregar.Parameters.AddWithValue("calle", propietario.Calle);
                agregar.Parameters.AddWithValue("no_exterior", propietario.No_exterior);
                agregar.Parameters.AddWithValue("no_interior", propietario.No_interior);
                agregar.Parameters.AddWithValue("colonia", propietario.Colonia);
                agregar.Parameters.AddWithValue("CP", propietario.CP);
                agregar.Parameters.AddWithValue("telefono", propietario.telefono);
                agregar.Parameters.AddWithValue("correo", propietario.correo_e);
                agregar.Parameters.AddWithValue("id_ciudad", propietario.id_ciudad);

                agregar.Connection = EstablecerConexion();
                conexion.Open();
                agregar.ExecuteNonQuery();
                conexion.Close();

                return true;
            }
            catch
            {
                return false;
            }

        }

        public DataSet MostrarCiudades()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM CIUDAD");
            return EjecutarSentencia(sentencia);
        }

        public bool Eliminar(string codigoSQL)
        {
            try
            {
                //    MessageBox.Show("El registro sera eliminado permanente, ¿Desea CONTINUAR?", "ATENCION", MessageBoxButtons.OKCancel);
                //    if (MessageBox == DialogResult.Cancel)
                //    {

                //    }
                SqlCommand sentencia = new SqlCommand(codigoSQL);
                EjecutarSentencia(sentencia);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Modificar(string codigoSQL)
        {
            try
            {
                SqlCommand sentencia = new SqlCommand(codigoSQL);
                EjecutarSentencia(sentencia);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataSet MostrarPropietarios()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM PROPIETARIO");
            return EjecutarSentencia(sentencia);
        }

        //public 

    }
}
