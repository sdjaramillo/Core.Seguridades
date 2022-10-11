using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Permisos;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Permisos
{
    public static class ValidarDatosPermisoBLL
    {
        public static void ValidarCamposVaciosPermisosRequest(PermisoTrx objetoTransaccional)
        {
            if (objetoTransaccional.PermisoRequest.Codigo == null ||
                objetoTransaccional.PermisoRequest.RolCodigo == null ||
                objetoTransaccional.PermisoRequest.ProyectoCodigo == null ||
                objetoTransaccional.PermisoRequest.NombreRed == null ||
                objetoTransaccional.PermisoRequest.Nombre == null ||
                objetoTransaccional.PermisoRequest.Descripcion == null ||
                objetoTransaccional.PermisoRequest.Codigo == "" ||
                objetoTransaccional.PermisoRequest.RolCodigo == "" ||
                objetoTransaccional.PermisoRequest.ProyectoCodigo == "" ||
                objetoTransaccional.PermisoRequest.NombreRed == "" ||
                objetoTransaccional.PermisoRequest.Nombre == "" ||
                objetoTransaccional.PermisoRequest.Descripcion == ""
                )
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorPermiso.CamposVaciosPermisoRequest;
                //throw new ExcepcionServicio((int)ErrorPermiso.CamposVaciosPermisoRequest);
            }
        }
    }
}
