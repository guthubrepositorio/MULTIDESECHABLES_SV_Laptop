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
    public class D_Venta
    {
        public int ObtenerCorrelativo()
        {
            int idcorrelativo = 0;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from Venta");
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

       


        public bool Registrar(E_Venta obj, DataTable DetalleVenta, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("usp_RegistrarVenta", oconexion);
                    cmd.Parameters.AddWithValue("idUsuario", obj.oUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("tipoDocumento", obj.TipoDocumento);
                    cmd.Parameters.AddWithValue("numeroDocumento", obj.NumeroDocumento);
                    cmd.Parameters.AddWithValue("documento", obj.DocumentoCliente);
                    cmd.Parameters.AddWithValue("nombre", obj.NombreCliente);
                    cmd.Parameters.AddWithValue("montoPago", obj.MontoPago);
                    cmd.Parameters.AddWithValue("montoCambio", obj.MontoCambio);
                    cmd.Parameters.AddWithValue("montoTotal", obj.MontoTotal);
                    cmd.Parameters.AddWithValue("fechaRegistro", obj.FechaRegistro);

                    cmd.Parameters.AddWithValue("DetalleVenta", DetalleVenta);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }

            return Respuesta;
        }


        public E_Venta ObtenerVenta(string numero)
        {

            E_Venta obj = new E_Venta();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select v.idventa,u.nombreCompleto,");
                    query.AppendLine("v.documento,v.nombre,");
                    query.AppendLine("v.tipoDocumento,v.numeroDocumento,");
                    query.AppendLine("v.montoPago,v.montoCambio,v.montoTotal,");
                    query.AppendLine("convert(char(17),v.fechaRegistro,113)[fechaRegistro]");
                    query.AppendLine("from Venta v");
                    query.AppendLine("inner join Usuario u on u.idUsuario = v.idUsuario");
                    query.AppendLine("where v.numeroDocumento = @numero");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            obj = new E_Venta()
                            {
                                IdVenta = int.Parse(dr["idventa"].ToString()),
                                oUsuario = new E_Usuario() { NombreCompleto = dr["nombreCompleto"].ToString() },
                                DocumentoCliente = dr["documento"].ToString(),
                                NombreCliente = dr["nombre"].ToString(),
                                TipoDocumento = dr["tipoDocumento"].ToString(),
                                NumeroDocumento = dr["numeroDocumento"].ToString(),
                                MontoPago = Convert.ToDecimal(dr["montoPago"].ToString()),
                                MontoCambio = Convert.ToDecimal(dr["montoCambio"].ToString()),
                                MontoTotal = Convert.ToDecimal(dr["montoTotal"].ToString()),
                                //FechaRegistro = dr["fechaRegistro"].ToString()
                                FechaRegistro = Convert.ToDateTime(dr["fechaRegistro"].ToString())
                            };
                        }
                    }

             


                }
                catch
                {
                    obj = new E_Venta();
                }

            }
            return obj;

        }


        public List<E_DetalleVenta> ObtenerDetalleVenta(int idVenta)
        {
            List<E_DetalleVenta> oLista = new List<E_DetalleVenta>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.nombre,dv.precioVenta,dv.cantidad,dv.SubTotal from DETALLEVENTA dv");
                    query.AppendLine("inner join Producto p on p.idproducto = dv.idproducto");
                    query.AppendLine(" where dv.idventa = @idventa");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idventa", idVenta);
                    cmd.CommandType = System.Data.CommandType.Text;


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new E_DetalleVenta()
                            {
                                oProducto = new E_Producto() { Nombre = dr["nombre"].ToString() },
                                PrecioVenta = Convert.ToDecimal(dr["precioVenta"].ToString()),
                                Cantidad = Convert.ToInt32(dr["cantidad"].ToString()),
                                SubTotal = Convert.ToDecimal(dr["SubTotal"].ToString()),


                               
                            });
                        }
                    }

                }
                catch
                {
                    oLista = new List<E_DetalleVenta>();
                }
            }
            return oLista;
        }




    }
}
