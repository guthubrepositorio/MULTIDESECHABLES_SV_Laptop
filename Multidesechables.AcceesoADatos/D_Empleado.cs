using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using Multidesechables.EntidadesDeNegocio;
using System.Data;
using System.Data.SqlClient;

namespace Multidesechables.AcceesoADatos
{
    public class D_Empleado
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public DataTable ListarEmpleado()
        {
            DataTable tabla = new DataTable();
            SqlDataReader Leerfilas;
            SqlCommand cmd = new SqlCommand("Sp_ListarEmpleado", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            Leerfilas = cmd.ExecuteReader();
            tabla.Load(Leerfilas);

            conexion.Close();
            Leerfilas.Close();

            return tabla;
        }


        public DataTable BuscarEmpleado(E_Empleado empleado)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_buscarEmpleado", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@buscar", empleado.Buscar);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;

        }


        public void BorrarEmpleado(int idempleado)
        {
            SqlCommand cmd = new SqlCommand("SP_borrarEmpleado", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@idempleado", idempleado);
            cmd.ExecuteReader();
            conexion.Close();

        }


        public void CrearEmpleado(E_Empleado Empleado)
        {

            SqlCommand cmd = new SqlCommand("SP_crearEmpleado", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();


            cmd.Parameters.AddWithValue("@nombreCompleto", Empleado.NombreCompleto);
            cmd.Parameters.AddWithValue("@telefono", Empleado.Telefono);
            cmd.Parameters.AddWithValue("@correo", Empleado.Correo);
            cmd.Parameters.AddWithValue("@residencia", Empleado.Residencia);
            cmd.Parameters.AddWithValue("@dui", Empleado.Dui);
            cmd.Parameters.AddWithValue("@sexo", Empleado.Sexo);
            cmd.Parameters.AddWithValue("@horarioEntrada", Empleado.HorarioEntrada);
            cmd.Parameters.AddWithValue("@horarioSalida", Empleado.HorarioSalida);
            cmd.Parameters.AddWithValue("@diasDescanso", Empleado.DiasDescanso);
            cmd.Parameters.AddWithValue("@encargadoDe", Empleado.EncargadoDe);
            cmd.Parameters.AddWithValue("@salarioBruto", Empleado.SalarioBruto);
            cmd.Parameters.AddWithValue("@descuentos", Empleado.Descuentos);
            cmd.Parameters.AddWithValue("@sueldoNeto", Empleado.SueldoNeto);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }



        public void ActualizarEmpleado(E_Empleado Empleado)
        {
            SqlCommand cmd = new SqlCommand("SP_actualizarEmpleado", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@idempleado", Empleado.IdEmpleado);
            cmd.Parameters.AddWithValue("@nombreCompleto", Empleado.NombreCompleto);
            cmd.Parameters.AddWithValue("@telefono", Empleado.Telefono);
            cmd.Parameters.AddWithValue("@correo", Empleado.Correo);
            cmd.Parameters.AddWithValue("@residencia", Empleado.Residencia);
            cmd.Parameters.AddWithValue("@dui", Empleado.Dui);
            cmd.Parameters.AddWithValue("@sexo", Empleado.Sexo);
            cmd.Parameters.AddWithValue("@horarioEntrada", Empleado.HorarioEntrada);
            cmd.Parameters.AddWithValue("@horarioSalida", Empleado.HorarioSalida);
            cmd.Parameters.AddWithValue("@diasDescanso", Empleado.DiasDescanso);
            cmd.Parameters.AddWithValue("@encargadoDe", Empleado.EncargadoDe);
            cmd.Parameters.AddWithValue("@salarioBruto", Empleado.SalarioBruto);
            cmd.Parameters.AddWithValue("@descuentos", Empleado.Descuentos);
            cmd.Parameters.AddWithValue("@sueldoNeto", Empleado.SueldoNeto);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void mostrarTotales(E_Empleado Empleado)
        {

            SqlCommand cmd = new SqlCommand("summryEmpleado", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter totalClientes = new SqlParameter("@totalempleados", 0);
            totalClientes.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(totalClientes);

            conexion.Open();

            cmd.ExecuteNonQuery();


            Empleado.TotalEmpleado = cmd.Parameters["@totalempleados"].Value.ToString();


            conexion.Close();
        }


    }
}
