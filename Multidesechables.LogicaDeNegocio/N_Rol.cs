using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Multidesechables.AcceesoADatos;
using Multidesechables.EntidadesDeNegocio;




namespace Multidesechables.LogicaDeNegocio
{
    public class N_Rol
    {

        private D_Rol objcd_rol = new D_Rol();


        public List<E_Rol> Listar()
        {
            return objcd_rol.Listar();
        }



    }
}
