using Core.Seguridades.Model.Entidad.MenuDinamico;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.MenuDinamico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Ejecucion.MenuDinamico
{
    public static class ValidarExistenciaPermisoMenuBLL
    {
        public static void ExistenciaPermisoMenuBaseDatos(MenusTrx objetoTransaccional)
        {
            List<PermisoMenuRol> ListaPermisoMenuBaseDatos = objetoTransaccional.ListaPermisoMenu.ToList();
            if(ListaPermisoMenuBaseDatos.Count > 0)
            {
                try
                {
                    var PermisoVerificado = ListaPermisoMenuBaseDatos.Single(x => (
                                                                                x.MenuCodigo.ToString() == objetoTransaccional.PermisoMenuRequest.MenuCodigo.ToString() &&
                                                                                x.RolCodigo.ToString() == objetoTransaccional.PermisoMenuRequest.RolCodigo.ToString() &&
                                                                                x.OpcionMenuCodigo.ToString() == objetoTransaccional.PermisoMenuRequest.OpcionMenuCodigo.ToString()));
                    objetoTransaccional.PermisoMenuValido = PermisoVerificado;
                }catch(Exception e)
                {
                    Console.WriteLine(e.ToString());
                    objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorMenuRolOpcion.NoExisteOpcionMenuBaseDatos; ;
                }
            }
            else
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorMenuRolOpcion.NoExisteOpcionMenuBaseDatos; ;
            }
        }
    }
}
