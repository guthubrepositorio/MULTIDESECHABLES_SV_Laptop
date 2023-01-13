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
    public class D_Cliente
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public DataTable ListarClientes()
        {
            DataTable tabla = new DataTable();
            SqlDataReader Leerfilas;
            SqlCommand cmd = new SqlCommand("Sp_ListarClientes", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            Leerfilas = cmd.ExecuteReader();
            tabla.Load(Leerfilas);

            conexion.Close();
            Leerfilas.Close();

            return tabla;
        }


        public DataTable BuscarClientes(E_Cliente cliente)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_buscarCliente", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@buscar", cliente.Buscar);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;

        }


        public void BorrarCliente(int idcliente)
        {
            SqlCommand cmd = new SqlCommand("SP_borrarCliente", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@idcliente", idcliente);
            cmd.ExecuteReader();
            conexion.Close();

        }


        public void CrearCliente(E_Cliente Cliente)
        {

            SqlCommand cmd = new SqlCommand("SP_crearCliente", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();


            cmd.Parameters.AddWithValue("@documento", Cliente.Documento);
            cmd.Parameters.AddWithValue("@nombre", Cliente.Nombre);
            cmd.Parameters.AddWithValue("@fechaRegistro", Cliente.FechaRegistro);


            cmd.ExecuteNonQuery();
            conexion.Close();
        }



        public void ActualizarCliente(E_Cliente Cliente)
        {
            SqlCommand cmd = new SqlCommand("SP_actualizarCliente", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@idcliente", Cliente.Idcliente);
            cmd.Parameters.AddWithValue("@documento", Cliente.Documento);
            cmd.Parameters.AddWithValue("@nombre", Cliente.Nombre);
            cmd.Parameters.AddWithValue("@fechaRegistro", Cliente.FechaRegistro);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void mostrarTotales(E_Cliente Cliente)
        {

            SqlCommand cmd = new SqlCommand("summryCliente", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter totalClientes = new SqlParameter("@totalclientes", 0);
            totalClientes.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(totalClientes);

            conexion.Open();

            cmd.ExecuteNonQuery();


            Cliente.TotalClientes = cmd.Parameters["@totalclientes"].Value.ToString();


            conexion.Close();
        }



    }
}
