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
    public class MigrarUsuariosActiveDirectoryIN : IProcesarTransaccionSimple<UsuarioTrx, MigrarUsuariosActiveDirectoryResponse>
    {
        public void AgregarInformacion(UsuarioTrx objetoTransaccional)
        {
            ObtenerUsuariosBLL.ObtenerListaUsuariosActiveDirectory(objetoTransaccional);
            ObtenerUsuariosBLL.ObtenerListaUsuarios(objetoTransaccional);

            ObtenerDatosUsuarioBLL.SicronizacionUsuariosActiveDirectoryBaseDatos(objetoTransaccional);
        }

        public void EjecutarTransaccion(UsuarioTrx objetoTransaccional)
        {
            AgregarUsuariosBLL.AgregarListaUsuariosNuevos(objetoTransaccional);
            EliminarUsuarioBLL.EliminarLogicoUsuario(objetoTransaccional);
        }     

        public void ValidarInformacion(UsuarioTrx objetoTransaccional)
        {
            ValidarDatosUsuarioBLL.ValidarParametrosVacios(objetoTransaccional);
            ValidarEmpresasSistemaBLL.ExistenciaEmpresasBaseDatos(objetoTransaccional);
        }
    }
}
