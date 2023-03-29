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
    internal class ComboBoxConexion
    {
        SqlConnection con = new SqlConnection(@"server = ANVORGUEZA\SQLEXPRESS; Initial Catalog = DB_FARMACIA_TOPICOS; Integrated Security = true");

        public void SeleccionarDiudad(ComboBox cb)
        {
            cb.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM CIUDAD", con);
            SqlDataReader dr  = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr[1].ToString());
            }
            con.Close();
            cb.Items.Insert(0, "Seleccione Ciudad");
            cb.SelectedIndex = 0;
        }

        public int captar_info(string nombre)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM CIUDAD WHERE nombre_ciudad='"+nombre+"'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            //string[] res = null;
            int ID = 0;
            while (dr.Read())
            {
                //string[] valores =
                //{
                //    dr[0].ToString()
                //};
                //res = valores;
                ID = int.Parse(dr[0].ToString());
            }

            con.Close();
            return ID;
        }
    }
}
