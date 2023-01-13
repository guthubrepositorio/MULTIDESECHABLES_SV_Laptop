using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidesechables.EntidadesDeNegocio
{
    public class E_Empleado
    {
        public int IdEmpleado { get; set; }
        public string NombreCompleto { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Residencia { get; set; }
        public string Dui { get; set; }
        public string Sexo { get; set; }
        public string HorarioEntrada { get; set; }
        public string HorarioSalida { get; set; }
        public string DiasDescanso { get; set; }
        public string EncargadoDe { get; set; }
        public decimal SalarioBruto { get; set; }
        public decimal Descuentos { get; set; }
        public decimal SueldoNeto { get; set; }
        public string Buscar { get ; set; }
        public string TotalEmpleado { get ; set;}

    }
}
