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
    public class D_Permiso
    {

        public List<E_Permiso> Listar(int idusuario)
        {
            List<E_Permiso> lista = new List<E_Permiso>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.idRol,p.nombreMenu from Permiso p");
                    query.AppendLine("inner join Rol r on r.idRol = p.idRol");
                    query.AppendLine("inner join Usuario u on u.idRol = r.idRol");
                    query.AppendLine("where u.idUsuario = @idUsuario");


                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@idUsuario", idusuario);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {

                            lista.Add(new E_Permiso()
                            {
                                oRol = new E_Rol() { IdRol = Convert.ToInt32(dr["idRol"]) },
                                NombreMenu = dr["nombreMenu"].ToString(),
                            });

                        }

                    }


                }
                catch (Exception ex)
                {

                    lista = new List<E_Permiso>();
                }
            }

            return lista;

        }




    }
}
