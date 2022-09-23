using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.Noticias;
using Core.Seguridades.Model.Transaccion.Response.Noticias;
using Core.Seguridades.Model.Transaccion.Transaccional.Noticias;

namespace Core.Seguridades.BusinessLogic.Internal.Noticias
{
    public class ActualizarNoticiaIN : IActualizar<NoticiaTrx, ActualizarNoticiaResponse>
    {
        public void ActualizarInformacion(NoticiaTrx objetoTransaccional)
        {
            ActualizarNoticiaBLL.ActualizarNoticia(objetoTransaccional);
            ObtenerListaNoticiaBLL.ObtenerListaNoticia(objetoTransaccional);
        }

        public void AgregarInformacion(NoticiaTrx objetoTransaccional)
        {
            ObtenerTodaNoticiasBLL.ObtenerListaNoticias(objetoTransaccional);
        }

        public void HomologarInformacion(NoticiaTrx objetoTransaccional)
        {
            
        }

        public void ValidarInformacion(NoticiaTrx objetoTransaccional)
        {
            ValidarDatosNoticiaBLL.ValidarCamposVacioNoticia(objetoTransaccional);
            ValidarExistenciaNoticiaBLL.ExistenciaNoticiaBaseDatos(objetoTransaccional);
        }
    }
}
