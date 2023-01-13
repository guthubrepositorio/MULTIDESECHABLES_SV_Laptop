using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Multidesechables.EntidadesDeNegocio;

namespace Multidesechables.AcceesoADatos
{
    public class D_Usuario
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString); 


        public DataTable ListarUsuario()

        {
             DataTable tabla = new DataTable();
            SqlDataReader Leerfilas;
            SqlCommand cmd = new SqlCommand("Sp_ListarUsuarios", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            Leerfilas = cmd.ExecuteReader();
            tabla.Load(Leerfilas);

            conexion.Close();
            Leerfilas.Close();

            return tabla;
        }


        public List<E_Usuario> Listar()
        {
            List<E_Usuario> lista = new List<E_Usuario>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select u.idUsuario,u.documento,u.nombreCompleto,u.residencia,u.telefono,u.correo,u.clave,u.estado,r.idRol,r.descripcion from usuario u");
                    query.AppendLine("inner join rol r on r.idRol = u.idRol");


                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {

                            lista.Add(new E_Usuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["idUsuario"]),
                                Documento = dr["documento"].ToString(),
                                NombreCompleto = dr["nombreCompleto"].ToString(),
                                Residencia = dr["residencia"].ToString(),
                                Telefono = dr["telefono"].ToString(),
                                Correo = dr["correo"].ToString(),
                                Clave = dr["clave"].ToString(),
                                Estado = Convert.ToBoolean(dr["estado"]),
                                oRol = new E_Rol() { IdRol = Convert.ToInt32(dr["idRol"]), Descripcion = dr["descripcion"].ToString() }
                            });

                        }

                    }


                }
                catch (Exception ex)
                {

                    lista = new List<E_Usuario>();
                }
            }

            return lista;

        }

        public DataTable BuscarUsuario(E_Usuario Usuario)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_buscarUsuario", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@buscar", Usuario.Buscar);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;

        }


        public void Registrar(E_Usuario Usuario)
        {
   

         
                {

                    SqlCommand cmd = new SqlCommand("SP_REGISTRARUSUARIO", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();

                    cmd.Parameters.AddWithValue("@documento", Usuario.Documento);
                    cmd.Parameters.AddWithValue("@nombreCompleto", Usuario.NombreCompleto);
                    cmd.Parameters.AddWithValue("@residencia", Usuario.Residencia);
                    cmd.Parameters.AddWithValue("@telefono", Usuario.Telefono);
                    cmd.Parameters.AddWithValue("@correo", Usuario.Correo);
                    cmd.Parameters.AddWithValue("@clave", Usuario.Clave);
                    cmd.Parameters.AddWithValue("@idRol", Usuario.oRol.IdRol);
                    cmd.Parameters.AddWithValue("@estado", Usuario.Estado);




                  cmd.ExecuteNonQuery();
                  conexion.Close();


                }

            



            
        }



        public void Editar(E_Usuario Usuario)
        {



            SqlCommand cmd = new SqlCommand("SP_EDITARUSUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@idUsuario", Usuario.IdUsuario);
            cmd.Parameters.AddWithValue("@documento", Usuario.Documento);
            cmd.Parameters.AddWithValue("@nombreCompleto", Usuario.NombreCompleto);
            cmd.Parameters.AddWithValue("@residencia", Usuario.Residencia);
            cmd.Parameters.AddWithValue("@telefono", Usuario.Telefono);
            cmd.Parameters.AddWithValue("@correo", Usuario.Correo);
            cmd.Parameters.AddWithValue("@clave", Usuario.Clave);
            cmd.Parameters.AddWithValue("@idRol", Usuario.oRol.IdRol);
            cmd.Parameters.AddWithValue("@estado", Usuario.Estado);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }


        public bool Eliminar(E_Usuario obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;


            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {


                    SqlCommand cmd = new SqlCommand("SP_ELIMINARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("idUsuario", obj.IdUsuario);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }


        public void mostrarTotales(E_Usuario Usuario)
        {

            SqlCommand cmd = new SqlCommand("summryUsuario", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter totalUsuario = new SqlParameter("@totalUsuario", 0);
            totalUsuario.Direction = ParameterDirection.Output;


            SqlParameter totalAdministrador = new SqlParameter("@totaladministrador", 0);
            totalAdministrador.Direction = ParameterDirection.Output;

            SqlParameter totalEmpleados = new SqlParameter("@totalempleado", 0);
            totalEmpleados.Direction = ParameterDirection.Output;


            cmd.Parameters.Add(totalUsuario);
            cmd.Parameters.Add(totalAdministrador);
            cmd.Parameters.Add(totalEmpleados);
            conexion.Open();

            cmd.ExecuteNonQuery();

            Usuario.TotalUsuario = cmd.Parameters["@totalUsuario"].Value.ToString();
            Usuario.TotalAdministrador = cmd.Parameters["@totaladministrador"].Value.ToString();
            Usuario.TotalEmpleado = cmd.Parameters["@totalempleado"].Value.ToString();

            conexion.Close();

        }






    }
}
