using Core.Seguridades.Adapter.Autenticacion.ActiveDirectory;
using Core.Seguridades.Model.Transaccion.Transaccional.Autenticacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Autenticacion
{
    public static class AutenticarActiveDirectoryBBL
    {
        public static void AutenticacionActiveDirectory (AutenticacionTrx objetoTransaccional)
        {
            AutenticarUsuarioActiveDirectoryADP.AutenticacionActiveDirectory(objetoTransaccional);
        }
    }
}
