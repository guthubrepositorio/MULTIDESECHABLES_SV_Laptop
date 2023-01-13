using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidesechables.EntidadesDeNegocio
{
    public class E_Usuario
    {
        public int IdUsuario { get; set; }
        public string Documento { get; set; }
        public string NombreCompleto { get; set; }
        public string Residencia { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public E_Rol oRol { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
        public string Buscar { get; set;  }

        public string TotalUsuario { get; set; }

        public string TotalAdministrador { get; set; }

        public string TotalEmpleado { get; set; }



    }
}
