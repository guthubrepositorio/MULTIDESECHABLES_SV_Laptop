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
    public class D_Rol
    {
        public List<E_Rol> Listar()
        {
            List<E_Rol> lista = new List<E_Rol>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select idRol,descripcion from Rol");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new E_Rol()
                            {
                                IdRol = Convert.ToInt32(dr["idRol"]),
                                Descripcion = dr["descripcion"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {

                    lista = new List<E_Rol>();
                }
            }

            return lista;

        }


    }
}
