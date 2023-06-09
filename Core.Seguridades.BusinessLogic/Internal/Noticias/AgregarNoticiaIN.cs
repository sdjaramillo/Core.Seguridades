﻿using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.Noticias;
using Core.Seguridades.Model.Transaccion.Response.Noticias;
using Core.Seguridades.Model.Transaccion.Transaccional.Noticias;

namespace Core.Seguridades.BusinessLogic.Internal.Noticias
{
    public class AgregarNoticiaIN : IInsertar<NoticiaTrx, AgregarNoticiaResponse>
    {
        public void AgregarInformacion(NoticiaTrx objetoTransaccional)
        {
            
        }

        public void HomologarInformacion(NoticiaTrx objetoTransaccional)
        {
            
        }

        public void InsertarInformacion(NoticiaTrx objetoTransaccional)
        {
            AgregarNoticiaBLL.AgregarNoticia(objetoTransaccional);
            ObtenerListaNoticiaBLL.ObtenerListaNoticia(objetoTransaccional);
        }

        public void ValidarInformacion(NoticiaTrx objetoTransaccional)
        {
            ValidarDatosNoticiaBLL.ValidarCamposVacioNoticia(objetoTransaccional);
        }
    }
}
