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
    /// Lógica para insertar una nueva entidad credencial acceso
    /// </summary>
    public static class CredencialesAccesoInsertarBLL
    {
        public static void InsertarCredencialesAcceso(CredencialAccesoTrx objetoTransaccional)
        {
            InsertarCredencialesAccesoDAL.Execute(objetoTransaccional);
        }
    }
}
