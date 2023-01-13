using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidesechables.EntidadesDeNegocio
{
    public class E_Rol
    {
        private int idRol;
        private string descripcion;
        private string fechaRegistro;

        public int IdRol { get => idRol; set => idRol = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
    }
}
