using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multidesechables.EntidadesDeNegocio;
using Multidesechables.AcceesoADatos;

namespace Multidesechables.LogicaDeNegocio
{
    public class N_Reporte
    {
        private D_Reporte objcd_reporte = new D_Reporte();

        public List<E_ReporteCompra> Compra(string fechainicio, string fechafin, int idproveedor)
        {
            return objcd_reporte.Compra(fechainicio, fechafin, idproveedor);
        }


        public List<E_ReporteVenta> Venta(string fechainicio, string fechafin)
        {
            return objcd_reporte.Venta(fechainicio, fechafin);
        }
    }
}
