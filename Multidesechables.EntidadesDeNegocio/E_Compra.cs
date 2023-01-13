using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidesechables.EntidadesDeNegocio
{
    public class E_Compra
    {
      
        public int IdCompra { get; set; }
        public E_Usuario oUsuario { get; set; }
        public E_Proveedor oProveedor { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal MontoTotal { get; set; }
        public List<E_DetalleCompra> oDetalleCompra { get; set; }
        public DateTime FechaRegistro { get; set; }

    }
}


