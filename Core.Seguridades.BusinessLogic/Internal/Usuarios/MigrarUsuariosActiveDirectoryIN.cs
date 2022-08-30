using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Common.Util.Helper;
using Core.Seguridades.BusinessLogic.Ejecucion.Usuarios;
using Core.Seguridades.Model.Transaccion.Response.Usuarios;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;

namespace Core.Seguridades.BusinessLogic.Internal.Usuarios
{
    /// <summary>
    /// Logica interna para el proceso de migrar usuarios de active directory a la BD
    /// </summary>
    public class MigrarUsuariosActiveDirectoryIN : IInsertar<UsuarioTrx, MigrarUsuariosActiveDirectoryResponse>
    {
        public void AgregarInformacion(UsuarioTrx objetoTransaccional)
        {
            ObtenerUsuariosBLL.ObtenerListaUsuariosActiveDirectory(objetoTransaccional);
            ObtenerUsuariosBLL.ObtenerListaUsuarios(objetoTransaccional);

            ObtenerDatosUsuarioBLL.SicronizacionUsuariosActiveDirectoryBaseDatos(objetoTransaccional);
            
        }

        public MigrarUsuariosActiveDirectoryResponse ArmaraPaginaRespuesta(UsuarioTrx objetoTransaccional)
        {
            return null;
        }

        //public MigrarUsuariosActiveDirectoryResponse ArmarObjetoRespuesta(UsuarioTrx objetoTransaccional)
        //{
        //    if (objetoTransaccional.Respuesta.CodigoRespuesta == 10000)
        //    {
        //        MigrarUsuariosActiveDirectoryResponse respuesta = new MigrarUsuariosActiveDirectoryResponse();
        //        var aux = MapHelper.MapeoDinamicoRespuesta(objetoTransaccional, respuesta, objetoTransaccional.DatosApi.LogicaInyectada);
        //        return aux;
        //    }
        //    return null;
        //}

        public void HomologarInformacion(UsuarioTrx objetoTransaccional)
        {
            
        }

        public void InsertarInformacion(UsuarioTrx objetoTransaccional)
        {
            AgregarUsuariosBLL.AgregarListaUsuariosNuevos(objetoTransaccional);
        }

        public void ValidarInformacion(UsuarioTrx objetoTransaccional)
        {
            ValidarDatosUsuarioBLL.ValidarParametrosVacios(objetoTransaccional);
        }
    }
}
