using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.FuenteImagenes;
using Core.Seguridades.Model.Transaccion.Response.FuenteImagenes;
using Core.Seguridades.Model.Transaccion.Transaccional.FuenteImagenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Internal.FuenteImagenes
{
    public class ActualizarFuenteImagenIN : IActualizar<ImagenesTrx, AgregarActualizarFuenteImagenResponse>
    {
        public void AgregarInformacion(ImagenesTrx objetoTransaccional)
        {
            ObtenerListaFuenteImagenBLL.ObtenerListaFuenteImagen(objetoTransaccional);
        }

        public void ValidarInformacion(ImagenesTrx objetoTransaccional)
        {
            
        }

        public void HomologarInformacion(ImagenesTrx objetoTransaccional)
        {
            
        }

        public void ActualizarInformacion(ImagenesTrx objetoTransaccional)
        {
            ActualizarFuenteImagenBLL.ActualizarFuenteImagen(objetoTransaccional);
        }
    }
}
