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
    /// Lógica para validar información de la entidad credencial acceso
    /// </summary>
    public static class CredencialesAccesosValidarInformacionBLL
    {
        /// <summary>
        /// Valida si ya existe una entidad con los mismos datos
        /// </summary>
        public static void ValidarExisteCredencial(CredencialAccesoTrx objetoTransaccional)
        {
            ValidarCredencialAccesoExisteDAL.Execute(objetoTransaccional);
        }
    }
}
