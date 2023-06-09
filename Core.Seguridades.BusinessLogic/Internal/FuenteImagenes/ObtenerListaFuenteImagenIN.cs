﻿using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.FuenteImagenes;
using Core.Seguridades.Model.Transaccion.Response.FuenteImagenes;
using Core.Seguridades.Model.Transaccion.Transaccional.FuenteImagenes;

namespace Core.Seguridades.BusinessLogic.Internal.FuenteImagenes
{
    public class ObtenerListaFuenteImagenIN : IObtenerTodos<ImagenesTrx, ObtenerListaFuenteImagenResponse>
    {
        public void AgregarInformacion(ImagenesTrx objetoTransaccional)
        {
            ObtenerListaFuenteImagenBLL.ObtenerListaFuenteImagen(objetoTransaccional);
        }

        public void ValidarInformacion(ImagenesTrx objetoTransaccional)
        {
            
        }
    }
}
