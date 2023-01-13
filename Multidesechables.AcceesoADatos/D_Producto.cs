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
   public class D_Producto
    {
        public List<E_Producto> Listar()
        {
            List<E_Producto> lista = new List<E_Producto>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdProducto,p.Codigo, p.Nombre, p.Descripcion,c.IdCategoria,c.Descripcion[DescripcionCategoria],Stock,Stockminimo,Stockmaximo,PrecioCompra,PrecioVenta from PRODUCTO p");
                    query.AppendLine("inner join CATEGORIA c on c.IdCategoria = p.IdCategoria");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new E_Producto()
                            {
                                Idproducto = Convert.ToInt32(dr["IdProducto"]),
                                Codigo = dr["Codigo"].ToString(),
                                Nombre = dr["Nombre"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),
                                oCategoria = new E_Categoria() { Idcategoria = Convert.ToInt32(dr["IdCategoria"]), Descripcion = dr["DescripcionCategoria"].ToString() },
                                Stock = Convert.ToInt32(dr["Stock"].ToString()),
                               //
                                Stockminimo = Convert.ToInt32(dr["Stockminimo"].ToString()),
                                Stockmaximo = Convert.ToInt32(dr["Stockmaximo"].ToString()),
                               
                                //
                                PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"].ToString()),
                                PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"].ToString()),
                                //Estado = dr["Estado"].ToString(),

                            });

                        }

                    }


                }
                catch (Exception ex)
                {

                    lista = new List<E_Producto>();
                }
            }

            return lista;

        }







        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
       public DataTable ListarProductos()
        {
            DataTable tabla = new DataTable();
            SqlDataReader Leerfilas;
            SqlCommand cmd = new SqlCommand("Sp_ListarProductos" ,conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            Leerfilas = cmd.ExecuteReader();
            tabla.Load(Leerfilas);

            conexion.Close();
            Leerfilas.Close();

            return tabla;
        }


        public DataTable BuscarProductos(E_Producto producto)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_buscarProducto", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@buscar" , producto.Buscar);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;

        }


        public void BorrarProductos(int idproducto)
        {
            SqlCommand cmd = new SqlCommand("SP_borrarProducto", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@idproducto" , idproducto);
            cmd.ExecuteReader();
            conexion.Close();

        }


        public void CrearProductos(E_Producto Producto)
        {

            SqlCommand cmd = new SqlCommand("SP_crearProductos", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@codigo", Producto.Codigo);
            cmd.Parameters.AddWithValue("@nombre", Producto.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", Producto.Descripcion);
            cmd.Parameters.AddWithValue("@fechaRegistro", Producto.FechaRegistro);
            cmd.Parameters.AddWithValue("@idcategoria", Producto.Idcategoria);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }



        public void ActualizarProducto(E_Producto Producto)
        {
            SqlCommand cmd = new SqlCommand("SP_actualizarProducto", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@idproducto", Producto.Idproducto);
            cmd.Parameters.AddWithValue("@codigo", Producto.Codigo);
            cmd.Parameters.AddWithValue("@nombre", Producto.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", Producto.Descripcion);
            cmd.Parameters.AddWithValue("@fechaRegistro", Producto.FechaRegistro);
            cmd.Parameters.AddWithValue("@idcategoria", Producto.Idcategoria);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }


        public void CrearProductosEstado(E_Producto Producto)
        {

            SqlCommand cmd = new SqlCommand("SP_crearProductoEstado", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@codigo", Producto.Codigo);
            cmd.Parameters.AddWithValue("@nombre", Producto.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", Producto.Descripcion);
            cmd.Parameters.AddWithValue("@fechaRegistro", Producto.FechaRegistro);
            cmd.Parameters.AddWithValue("@idcategoria", Producto.Idcategoria);
            cmd.Parameters.AddWithValue("@preciocompra", Producto.PrecioCompra);
            cmd.Parameters.AddWithValue("@precioventa", Producto.PrecioVenta);
            cmd.Parameters.AddWithValue("@stockminimo", Producto.Stockminimo);
            cmd.Parameters.AddWithValue("@stockmaximo", Producto.Stockmaximo);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }



        public void ActualizarProductoEstado(E_Producto Producto)
        {
            SqlCommand cmd = new SqlCommand("SP_actualizarProductoEstado", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@idproducto", Producto.Idproducto);
            cmd.Parameters.AddWithValue("@codigo", Producto.Codigo);
            cmd.Parameters.AddWithValue("@nombre", Producto.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", Producto.Descripcion);
            cmd.Parameters.AddWithValue("@fechaRegistro", Producto.FechaRegistro);
            cmd.Parameters.AddWithValue("@idcategoria", Producto.Idcategoria);
            cmd.Parameters.AddWithValue("@preciocompra", Producto.PrecioCompra);
            cmd.Parameters.AddWithValue("@precioventa", Producto.PrecioVenta);
            cmd.Parameters.AddWithValue("stockminimo", Producto.Stockminimo);
            cmd.Parameters.AddWithValue("@stockmaximo", Producto.Stockmaximo);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }



        public void mostrarTotales(E_Producto Producto)
        {

            SqlCommand cmd = new SqlCommand("summryProductos", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter totalCategorias = new SqlParameter("@totalcategorias", 0);
            totalCategorias.Direction = ParameterDirection.Output;

     
            SqlParameter totalProductos = new SqlParameter("@totalproductos", 0);
            totalProductos.Direction = ParameterDirection.Output;

            SqlParameter totalStock = new SqlParameter("@sumStock", 0);
            totalStock.Direction = ParameterDirection.Output;


            cmd.Parameters.Add(totalCategorias);
            cmd.Parameters.Add(totalProductos);
            cmd.Parameters.Add(totalStock);
            conexion.Open();

            cmd.ExecuteNonQuery();

            Producto.Totalcategorias = cmd.Parameters["@totalcategorias"].Value.ToString();
            Producto.Totalproductos = cmd.Parameters["@totalproductos"].Value.ToString();
            Producto.SumStock = cmd.Parameters["@sumStock"].Value.ToString();

            conexion.Close();

        }

    }
}
