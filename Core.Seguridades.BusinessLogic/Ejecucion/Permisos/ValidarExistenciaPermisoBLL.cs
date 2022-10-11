using Core.Seguridades.Model.Entidad.Permisos;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Permisos;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Permisos
{
    public static class ValidarExistenciaPermisoBLL
    {
        public static void ExistenciaPermisoBaseDatos(PermisoTrx objetoTransaccional)
        {
            List<Permiso> ListaPermisosBaseDatos = objetoTransaccional.ListaPermisos.ToList();
            if(ListaPermisosBaseDatos.Count > 0)
            {
                try
                {
                    var permisoVerificado = ListaPermisosBaseDatos.Single(x => x.Codigo.ToString() == objetoTransaccional.PermisoRequest.Codigo.ToString());
                    objetoTransaccional.PermisoValido = permisoVerificado;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorPermiso.NoExistePermisoBaseDatos;
                }
            }
            else
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorPermiso.NoExistePermisoBaseDatos;
            }
        }
    }
}
