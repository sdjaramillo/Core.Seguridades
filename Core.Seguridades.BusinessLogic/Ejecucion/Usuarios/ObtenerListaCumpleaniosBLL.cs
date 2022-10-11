using Core.Seguridades.DataAccess.Usuarios;
using Core.Seguridades.Model.Entidad.Usuarios;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Usuarios
{
    public static class ObtenerListaCumpleaniosBLL
    {
        public static void ObtenerListaCumpleanios(UsuarioTrx objetoTransaccional)
        {
            ObtenerListaCumpleaniosDAL.Execute(objetoTransaccional);
        }
    }
}
