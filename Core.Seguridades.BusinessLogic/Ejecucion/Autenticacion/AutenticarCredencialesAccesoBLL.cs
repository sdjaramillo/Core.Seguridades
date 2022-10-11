using Core.Common.Model.ExcepcionServicio;
using Core.Seguridades.DataAccess.Autenticacion;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Autenticacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Autenticacion
{
    public static class AutenticarCredencialesAccesoBLL
    {
        public static void AutenticarCredencialesAcceso(AutenticacionTrx objetoTransaccional)
        {
            var credencial = AutenticarCredencialesAccesoDAL.ValidarCredencialesAcceso(objetoTransaccional);
            if (credencial != null)
            {
                objetoTransaccional.CredencialAcceso.Cat_id_tipo = credencial.Tipo;
                objetoTransaccional.CredencialAcceso.EntidadId = credencial.EntidadID;
            }
            else
            {
                throw new ExcepcionServicio((int)ErrorCredencialesAcceso.UsuarioClaveIncorrecto);
            }
        }
    }
}
