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
    public class D_Compra
    {

        
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString); 
        public int ObtenerCorrelativo()
        {
            int idcorrelativo = 0;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) +1 from Compra");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    idcorrelativo = Convert.ToInt32(cmd.ExecuteScalar());

                }
                catch (Exception ex)
                {
                    idcorrelativo = 0;
                }
            }
            return idcorrelativo;
        }


        public bool Registrar(E_Compra obj, DataTable DetalleCompra, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;


            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarCompra", oconexion);
                    cmd.Parameters.AddWithValue("IdUsuario", obj.oUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("idproveedor", obj.oProveedor.Idproveedor);
                    cmd.Parameters.AddWithValue("tipoDocumento", obj.TipoDocumento);
                    cmd.Parameters.AddWithValue("numeroDocumento", obj.NumeroDocumento);
                    cmd.Parameters.AddWithValue("montoTotal", obj.MontoTotal);
                    cmd.Parameters.AddWithValue("fechaRegistro", obj.FechaRegistro);
                   
                    cmd.Parameters.AddWithValue("DetalleCompra", DetalleCompra);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
                catch (Exception ex)
                {
                    Respuesta = false;
                    Mensaje = ex.Message;
                }
            }
            return Respuesta;
        }


        public E_Compra ObtenerCompra(string numero)
        {
            E_Compra obj = new E_Compra();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select c.idcompra,");
                    query.AppendLine("u.nombreCompleto,");
                    query.AppendLine("pr.documento , pr.razonSocial,");
                    query.AppendLine("c.tipoDocumento,c.numeroDocumento, c.montoTotal, convert(char(17) , c.fechaRegistro , 113)[fechaRegistro]");
                    query.AppendLine("from  Compra c");
                    query.AppendLine("inner join Usuario u on u.idUsuario = c.idUsuario");
                    query.AppendLine("inner join Proveedor pr on pr.idproveedor = c.idProveedor");
                    query.AppendLine("where c.numeroDocumento = @numero");
     
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new E_Compra()
                            {
                                IdCompra = Convert.ToInt32(dr["idcompra"]),
                                oUsuario = new E_Usuario() { NombreCompleto = dr["nombreCompleto"].ToString() },
                                oProveedor = new E_Proveedor() { Documento = dr["documento"].ToString(), RazonSocial = dr["RazonSocial"].ToString() },
                                TipoDocumento = dr["tipoDocumento"].ToString(),
                                NumeroDocumento = dr["numeroDocumento"].ToString(),
                                MontoTotal = Convert.ToDecimal(dr["montoTotal"].ToString()),
                                //FechaRegistro = dr["fechaRegistro"].ToString()
                               FechaRegistro = Convert.ToDateTime(dr["fechaRegistro"].ToString())
                            };
                        }

                    }


                }
                catch (Exception ex)
                {
                    obj = new E_Compra();
                }
            }
            return obj;
        }


        public List<E_DetalleCompra> ObtenerDetalleCompra(int idcompra)
        {
            List < E_DetalleCompra> oLista = new List<E_DetalleCompra>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select p.nombre , dc.precioCompra ,dc.cantidad ,dc.montoTotal from DetalleCompra dc");
                    query.AppendLine("inner join Producto p on p.idproducto = dc.idproducto");
                    query.AppendLine("where dc.idcompra = @idcompra");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idcompra", idcompra);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new E_DetalleCompra()
                            {
                                oProducto = new E_Producto() { Nombre = dr["nombre"].ToString() },
                                PrecioCompra = Convert.ToDecimal(dr["precioCompra"].ToString()),
                                Cantidad = Convert.ToInt32(dr["cantidad"].ToString()),
                                MontoTotal = Convert.ToDecimal(dr["montoTotal"].ToString()),
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<E_DetalleCompra>();
            }
            return oLista;
        }

    }
}
