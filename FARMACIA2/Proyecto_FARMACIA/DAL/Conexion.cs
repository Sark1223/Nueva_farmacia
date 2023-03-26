using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_FARMACIA.DAL
{
    internal class Conexion
    {
        public bool Conectar()
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source = perro\\SQLEXPRESS; Initial Catalog=DB_FARMACIA_TOPICOS; Integrated Security = true");
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "SELECT * FROM CIUDAD";
                comando.Connection = connection;
                comando.ExecuteNonQuery();
                connection.Close();
                
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
