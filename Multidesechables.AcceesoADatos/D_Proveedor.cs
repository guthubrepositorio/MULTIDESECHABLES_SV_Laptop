using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Configuration;
using Multidesechables.EntidadesDeNegocio;
using System.Data;
using System.Data.SqlClient;

namespace Multidesechables.AcceesoADatos
{
    public class D_Proveedor
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
      

        public List<E_Proveedor> Listar()
        {


            List<E_Proveedor> lista = new List<E_Proveedor>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select idproveedor,documento,razonSocial,Correo,telefono from Proveedor");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {

                            lista.Add(new E_Proveedor()
                            {
                                Idproveedor = Convert.ToInt32(dr["idproveedor"]),
                                Documento = dr["documento"].ToString(),
                                RazonSocial = dr["razonSocial"].ToString(),
                                Correo = dr["correo"].ToString(),
                                Telefono = dr["telefono"].ToString(),

                            });

                        }

                    }


                }
                catch (Exception ex)
                {

                    lista = new List<E_Proveedor>();
                }
            }

            return lista;

        }





    












        public DataTable ListarProveedor()
             
        {
            DataTable tabla = new DataTable();
            SqlDataReader Leerfilas;
            SqlCommand cmd = new SqlCommand("Sp_ListarProveedores", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            Leerfilas = cmd.ExecuteReader();
            tabla.Load(Leerfilas);

            conexion.Close();
            Leerfilas.Close();

            return tabla;
        }
     




        public DataTable BuscarProveedor(E_Proveedor proveedor)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_buscarProveedor", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@buscar", proveedor.Buscar);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;

        }


        public void BorrarProveedor(int idproveedor)
        {
            SqlCommand cmd = new SqlCommand("SP_borrarProveedor", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@idproveedor", idproveedor);
            cmd.ExecuteReader();
            conexion.Close();

        }


        public void CrearProveedor(E_Proveedor Proveedor)
        {

            SqlCommand cmd = new SqlCommand("SP_crearProveedor", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();


            cmd.Parameters.AddWithValue("@documento", Proveedor.Documento);
            cmd.Parameters.AddWithValue("@razonSocial ", Proveedor.RazonSocial);
            cmd.Parameters.AddWithValue("@correo", Proveedor.Correo);
            cmd.Parameters.AddWithValue("@telefono", Proveedor.Telefono);
          cmd.Parameters.AddWithValue("@fechaRegistro", Proveedor.FechaRegistro);
           
            cmd.ExecuteNonQuery();
            conexion.Close();


        }



        public void ActualizarProveedor(E_Proveedor Proveedor)
        {
            SqlCommand cmd = new SqlCommand("SP_actualizarProveedor", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@idproveedor", Proveedor.Idproveedor);
            cmd.Parameters.AddWithValue("@documento", Proveedor.Documento);
            cmd.Parameters.AddWithValue("@razonSocial ", Proveedor.RazonSocial);
            cmd.Parameters.AddWithValue("@correo", Proveedor.Correo);
            cmd.Parameters.AddWithValue("@telefono", Proveedor.Telefono);
            cmd.Parameters.AddWithValue("@fechaRegistro", Proveedor.FechaRegistro);
    

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void mostrarTotales(E_Proveedor Proveedor)
        {

            SqlCommand cmd = new SqlCommand("summryProveedor", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter totalProveedores = new SqlParameter("@totalproveedores", 0);
            totalProveedores.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(totalProveedores);
          
            conexion.Open();

            cmd.ExecuteNonQuery();

       
            Proveedor.Totalproveedores = cmd.Parameters["@totalproveedores"].Value.ToString();
           

            conexion.Close();
        }
    }
}
