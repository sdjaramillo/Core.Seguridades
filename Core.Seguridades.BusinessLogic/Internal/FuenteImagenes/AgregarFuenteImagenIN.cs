using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.FuenteImagenes;
using Core.Seguridades.Model.Transaccion.Response.FuenteImagenes;
using Core.Seguridades.Model.Transaccion.Transaccional.FuenteImagenes;

namespace Core.Seguridades.BusinessLogic.Internal.FuenteImagenes
{
    public class AgregarFuenteImagenIN : IInsertar<ImagenesTrx, AgregarActualizarFuenteImagenResponse>
    {
        public void AgregarInformacion(ImagenesTrx objetoTransaccional)
        {
            
        }

        public void HomologarInformacion(ImagenesTrx objetoTransaccional)
        {
            
        }

        public void InsertarInformacion(ImagenesTrx objetoTransaccional)
        {
            AgregarFuenteImagenBLL.AgregarFuenteImagen(objetoTransaccional);
        }

        public void ValidarInformacion(ImagenesTrx objetoTransaccional)
        {
            ValidarDatosFuenteImagenBLL.ValidarCamposVaciosImagenRequest(objetoTransaccional);
        }
    }
}
