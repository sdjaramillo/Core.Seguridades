using Core.Common.BusinessLogic.ProcessTemplate;
using Core.Common.Model.General;
using Core.Common.Util.Helper;
using Core.Seguridades.Model.Transaccion.Response.Usuarios;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;

namespace Core.Seguridades.BusinessLogic.Internal.Usuarios
{
    /// <summary>
    /// Logica interna para el proceso de agregar usuarios
    /// </summary>
    public class AgregarUsuarioIN : IInsertar<UsuarioTrx, AgregarUsuarioResponse>
    {
        public void AgregarInformacion(UsuarioTrx objetoTransaccional)
        {
            //objetoTransaccional.ListaUsuarios =  ObtenerListaUsuarios.Execute();
        }

        public AgregarUsuarioResponse ArmaraPaginaRespuesta(UsuarioTrx objetoTransaccional)
        {
            throw new NotImplementedException();
        }

        public AgregarUsuarioResponse ArmarObjetoRespuesta(UsuarioTrx objetoTransaccional)
        {
            if (objetoTransaccional.Resultado.CodigoRespuesta == (int)Error.OperacionExitosa)
            {
                AgregarUsuarioResponse respuesta = new AgregarUsuarioResponse();
                return MapHelper.MapeoDinamicoRespuesta(objetoTransaccional, respuesta);
            }
            else
                return null;
        }


        public void HomologarInformacion(UsuarioTrx objetoTransaccional)
        {
           //
        }

        public void ValidarInformacion(UsuarioTrx objetoTransaccional)
        {
           //
        }

        public void InsertarInformacion(UsuarioTrx objetoTransaccional)
        {
            //
        }

    }
}
