using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Multidesechables.AcceesoADatos;
using Multidesechables.EntidadesDeNegocio;

namespace Multidesechables.LogicaDeNegocio
{
    public class N_Empleado
    {
        D_Empleado objDato = new D_Empleado();
        E_Empleado objNegocio = new E_Empleado();
        public DataTable ListandoEmpleado()
        {
            return objDato.ListarEmpleado();
        }


        public DataTable BuscandoEmpleado(string buscar)
        {
            objNegocio.Buscar = buscar;
            return objDato.BuscarEmpleado(objNegocio);
        }

        public void CreandoEmpleado(E_Empleado Empleado)
        {
            objDato.CrearEmpleado(Empleado);
        }

        public void ActualizandoEmpleado(E_Empleado Empleado)
        {
            objDato.ActualizarEmpleado(Empleado);
        }

        public void BorrandoEmpleado(int idempleado)
        {
            objDato.BorrarEmpleado(idempleado);
        }

        public void MostrandoTotales(E_Empleado Empleado)
        {
            objDato.mostrarTotales(Empleado);
        }



    }
}
