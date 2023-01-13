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
    public class D_Categoria

    { 
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public List<E_Categoria>ListarCategorias(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_buscarCategories", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@buscar", buscar);
            LeerFilas = cmd.ExecuteReader();

            List<E_Categoria> Listar = new List<E_Categoria>();
            while(LeerFilas.Read())
            {
                Listar.Add(new E_Categoria
                {
                    Idcategoria= LeerFilas.GetInt32(0),
                    Codigo = LeerFilas.GetString(1),
                    Descripcion = LeerFilas.GetString(2),
                 

                }) ;
            }

            conexion.Close();
            LeerFilas.Close();

            return Listar;


        }
        public void InsertarCategoria(E_Categoria Categoria)
        {
            SqlCommand cmd = new SqlCommand("SP_crearCategories", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@codigo", Categoria.Codigo);
            cmd.Parameters.AddWithValue("@descripcion",Categoria.Descripcion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarCategoria(E_Categoria Categoria)
        {
            SqlCommand cmd = new SqlCommand("SP_actualizarCategories", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@idcategoria",Categoria.Idcategoria);
            cmd.Parameters.AddWithValue("@codigo", Categoria.Codigo);
            cmd.Parameters.AddWithValue("@descripcion", Categoria.Descripcion);
            
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public  void EliminarCategoria (E_Categoria Categoria)
        {
            SqlCommand cmd = new SqlCommand("SP_borrarCategories", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@idcategoria", Categoria.Idcategoria);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        


    }
}
