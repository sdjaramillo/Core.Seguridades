using Core.Seguridades.DataAccess.CredencialesAccesos;
using Core.Seguridades.Model.Transaccion.Transaccional.CredencialesAccesos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Ejecucion.CredencialesAccesos
{
    /// <summary>
    /// Clase para gestionar metodos de actualización de las credenciales de acceso
    /// </summary>
    public static class CredencialesAccesosActualizarBLL
    {
        public static void ActualizarCredencialAcceso(CredencialAccesoTrx obetoTransaccional)
        {
            ActualizarCredencialAccesoDAL.Execute(obetoTransaccional);
        }

    }
}
