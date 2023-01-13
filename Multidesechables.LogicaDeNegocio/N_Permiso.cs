using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multidesechables.AcceesoADatos;
using Multidesechables.EntidadesDeNegocio;


namespace Multidesechables.LogicaDeNegocio
{
    public class N_Permiso
    {

        private D_Permiso objcd_permiso = new D_Permiso();


        public List<E_Permiso> Listar(int IdUsuario)
        {
            return objcd_permiso.Listar(IdUsuario);
        }
    }
}
