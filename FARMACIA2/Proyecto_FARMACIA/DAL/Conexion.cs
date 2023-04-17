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
        private string CadenaConexion = @"server = ANVORGUEZA\SQLEXPRESS; Initial Catalog = DB_FARMACIA; Integrated Security = true";
        SqlConnection conexion;

        //METODOS DE CONEXION
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


        //METODOS COMBO BOX - SIMPLE
        public void RellenarCB_1(ComboBox cb, string sentencia, string textoCB)
        {
            SqlCommand cmd = new SqlCommand(sentencia);
            cmd.Connection = EstablecerConexion();
            cb.Items.Clear();
            conexion.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if(dr[1].ToString() != textoCB)
                {
                    cb.Items.Add(dr[1].ToString());
                }
                
            }
            conexion.Close();
            cb.Items.Insert(0, textoCB);
            cb.SelectedIndex = 0;
        }

        public int captar_info_1(string sentencia)
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
        }//lo que se guarda en la tabla

        public string Retornar_info_1(string sentencia)
        {
            SqlCommand cmd = new SqlCommand(sentencia);
            cmd.Connection = EstablecerConexion();
            conexion.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            string nombre = "";
            while (dr.Read())
            {
                nombre =dr[1].ToString();
            }
            conexion.Close();
            return nombre;
        }//para el metodo modificar


        //METODOS COMBO BOX - COMPLEJO
        public void RellenarCB_2(ComboBox cb, string sentencia, string textoCB)
        {
            SqlCommand cmd = new SqlCommand(sentencia);
            cmd.Connection = EstablecerConexion();
            cb.Items.Clear();
            conexion.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if(dr[0].ToString() + "  " + dr[1].ToString() != textoCB)
                {
                    cb.Items.Add(dr[0].ToString() + "  " + dr[1].ToString());
                }
                
            }
            conexion.Close();
            cb.Items.Insert(0, textoCB);
            cb.SelectedIndex = 0;
        }

        public int captar_info_2(string sentencia)
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
        }//lo que se guarda en la tabla

        public string Retornar_info_2(string sentencia)
        {
            SqlCommand cmd = new SqlCommand(sentencia);
            cmd.Connection = EstablecerConexion();
            conexion.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            string nombre = "";
            while (dr.Read())
            {
                nombre = dr[0].ToString() + "  " + dr[1].ToString();
            }
            conexion.Close();
            return nombre;
        }//para el metodo modificar

        public string SepararValores(string seleccion)
        {
            //char[] characters = cuote.ToCharArray();
            string[] palabraClave = seleccion.Split();

            return palabraClave[0];
        }


        //Buscar valores en tabla
        public bool BuscarEnTabla_AGREGAR(string sentencia, string valor, int posicion, string tipoValor)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sentencia);
                cmd.Connection = EstablecerConexion();
                conexion.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[posicion].ToString() == valor)
                    {
                        MessageBox.Show("EL valor " + valor + " de "+tipoValor+" ya existe");
                        return false;
                    }

                }
                conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public int BuscarEnTabla_MODIFICAR(string sentencia, string valor, int posicion, string valorCarga, string tipoValor)
        {
            int vecesRepetido=0;
            try
            {
                if(valor == valorCarga)
                {
                    return 0;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand(sentencia);
                    cmd.Connection = EstablecerConexion();
                    conexion.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (dr[posicion].ToString() == valor)
                        {
                            MessageBox.Show("EL valor " + valor + " de " + tipoValor + " ya existe");
                            vecesRepetido++;
                        }

                    }
                    conexion.Close();
                    return vecesRepetido;
                }
                
            }
            catch
            {
                return 2;
            }

        }


        //METODOS GENERALES DE EDICION
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
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return false;
            //}
            //catch (SqlException ex)
            //{

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

        public void Modificar_2(SucursalBLL sucursal, int idAnterior)
        {
            
            try{
                SqlCommand modifi = new SqlCommand(
                         "update FARMACIA set id_farmacia =  @id, " +
                                           "nombre_farm = @nombre," +
                                           "calle_farm = @calle," +
                                           "no_exterior_farm = @no_exterior, " +
                                           "no_interior_farm = @no_interior, " +
                                           "colonia_farm = @colonia, " +
                                           "CP_FARM = @CP, " +
                                           "id_propietario = @id_propietario, " +
                                           "id_ciudad = @id_ciudad " +
                                           "WHERE id_farmacia =" + idAnterior);

                modifi.Parameters.AddWithValue("id", sucursal.id_farm);
                modifi.Parameters.AddWithValue("nombre", sucursal.nombre_farm);
                modifi.Parameters.AddWithValue("calle", sucursal.calle_farm);
                modifi.Parameters.AddWithValue("no_exterior", sucursal.no_exterior_farm);
                modifi.Parameters.AddWithValue("no_interior", sucursal.no_interior_farm);
                modifi.Parameters.AddWithValue("colonia", sucursal.colonia_farm);
                modifi.Parameters.AddWithValue("CP", sucursal.CP_farm);
                modifi.Parameters.AddWithValue("id_propietario", sucursal.id_propi_farm);
                modifi.Parameters.AddWithValue("id_ciudad", sucursal.id_Ciudad_farm);

                modifi.Connection = EstablecerConexion();
                conexion.Open();
                modifi.ExecuteNonQuery();
                conexion.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        //METODOS CIUDAD
        public bool AgregarCiudad(CiudadBLL ciudad)
        {
            //try
            //{
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
            //}
            //catch
            //{
            //    return false;
            //}
                
        }

        public DataSet MostrarCiudades()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM CIUDAD");
            return EjecutarSentencia(sentencia);
        }


        //METODOS PROPIETARIO
        public bool AgregarPropietario(PropietarioBLL propietario)
        {
            //try
            //{
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
            //}
            //catch
            //{
            //    return false;
            //}

        }

        public DataSet MostrarPropietarios()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM PROPIETARIO");
            return EjecutarSentencia(sentencia);
        }


        //METODOS SUCURSAL
        public bool AgregarSucursal(SucursalBLL sucursal)
        {
            try
            {
                SqlCommand agregar = new SqlCommand(
            "insert into FARMACIA(" +
                        "id_farmacia," +
                        "nombre_farm," +
                        "calle_farm," +
                        "no_exterior_farm," +
                        "no_interior_farm," +
                        "colonia_farm," +
                        "CP_FARM," +
                        "id_propietario," +
                        "id_ciudad)" +
            "values(@id,@nombre,@calle,@no_exterior,@no_interior,@colonia,@CP,@id_propietario,@id_ciudad)");

                agregar.Parameters.AddWithValue("id", sucursal.id_farm);
                agregar.Parameters.AddWithValue("nombre", sucursal.nombre_farm);
                agregar.Parameters.AddWithValue("calle", sucursal.calle_farm);
                agregar.Parameters.AddWithValue("no_exterior", sucursal.no_exterior_farm);
                agregar.Parameters.AddWithValue("no_interior", sucursal.no_interior_farm);
                agregar.Parameters.AddWithValue("colonia", sucursal.colonia_farm);
                agregar.Parameters.AddWithValue("CP", sucursal.CP_farm);
                agregar.Parameters.AddWithValue("id_propietario", sucursal.id_propi_farm);
                agregar.Parameters.AddWithValue("id_ciudad", sucursal.id_Ciudad_farm);

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

        public DataSet MostrarSucursales()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM FARMACIA");
            return EjecutarSentencia(sentencia);
        }


        //METODOS MEDICAMENTO

        public DataSet MostrarMedicamenntos()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM MEDICAMENTO");
            return EjecutarSentencia(sentencia);
        }

        public bool AgregarMedicamento (MedicamentoBLL medicamento)
        {
            try
            {
                SqlCommand agregar = new SqlCommand(
            "insert into MEDICAMENTO(" +
                        "id_medicamento," +
                        "nombre," +
                        "descripcion)" +
            "values(@id_medicametno,@nombre,@descripcion)");

                agregar.Parameters.AddWithValue("id_medicametno", medicamento.id_medicamento);
                agregar.Parameters.AddWithValue("nombre", medicamento.nombre);
                agregar.Parameters.AddWithValue("descripcion", medicamento.descripcion);
               
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

        public DataSet MostrarPrecio()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM MED_FARM");
            return EjecutarSentencia(sentencia);
        }

        public bool AgregarPrecio(MedFarmBLL medfarm)
        {
            try
            {
                SqlCommand agregar = new SqlCommand(
            "insert into MED_FARM(" +
                        "id_farmacia," +
                        "id_medicamento," +
                        "precio," +
                        "cantidad_existente)" +
            "values(@id_farmacia,@id_medicamento,@Precio,@cantidad_existente)");

                agregar.Parameters.AddWithValue("id_farmacia", medfarm.id_farmacia);
                agregar.Parameters.AddWithValue("id_medicamento", medfarm.id_medicamento);
                agregar.Parameters.AddWithValue("Precio", medfarm.precio);
                agregar.Parameters.AddWithValue("cantidad_existente", medfarm.cantidad_exitente);

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

        public void Mostrar_Precio_MedFarm(string valor, int posicion)
        {
            int vecesRepetido = 0;

            SqlCommand cmd = new SqlCommand("SELECT * FROM MED_FARM");
            cmd.Connection = EstablecerConexion();
            conexion.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            frmMedicamentos medi = new frmMedicamentos();
            medi.dgvPrecioMedi.Rows.Clear();
            medi.dgvPrecioMedi.Columns.Add("id_farmacia", "id_farmacia");
            medi.dgvPrecioMedi.Columns.Add("id_Medicamento", "id_Medicamento");
            medi.dgvPrecioMedi.Columns.Add("Precio", "Precio");
            medi.dgvPrecioMedi.Columns.Add("Cantidad_existente", "Cantidad_existente");

            while (dr.Read())
            {
                if (dr[posicion].ToString() == valor)
                {
                    medi.dgvPrecioMedi.Rows.Add();
                    medi.dgvPrecioMedi.Rows[vecesRepetido].Cells[0].Value = dr[0].ToString();
                    medi.dgvPrecioMedi.Rows[vecesRepetido].Cells[1].Value = dr[1].ToString();
                    medi.dgvPrecioMedi.Rows[vecesRepetido].Cells[2].Value = dr[2].ToString();
                    medi.dgvPrecioMedi.Rows[vecesRepetido].Cells[2].Value = dr[3].ToString();

                    vecesRepetido++;
                }

            }

        }


        //METODOS EMPLEADOS

        public DataSet MostrarEmpleados()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM EMPLEADO");
            return EjecutarSentencia(sentencia);
        }

    }
}
