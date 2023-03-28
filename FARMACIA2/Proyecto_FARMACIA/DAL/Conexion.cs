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
    
        public DataSet MostrarCiudades()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM CIUDAD");
            return EjecutarSentencia(sentencia);
        }

        public DataSet MostrarPropietarios()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM PROPIETARIO");
            return EjecutarSentencia(sentencia);
        }
    }
}
