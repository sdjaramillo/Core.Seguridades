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
    public class EliminarFuenteImagenIN : IEliminar<ImagenesTrx, EliminarFuenteImagenResponse>
    {
        public void AgregarInformacion(ImagenesTrx objetoTransaccional)
        {
            ObtenerTodaFuenteImagenBLL.ObtenerListaImagenes(objetoTransaccional);
        }

        public void Eliminarnformacion(ImagenesTrx objetoTransaccional)
        {
            EliminarFuenteImagenBLL.EliminarFuenteImagen(objetoTransaccional);
        }

        public void ValidarInformacion(ImagenesTrx objetoTransaccional)
        {
            ValidarExistenciaImagenBLL.ExistenciaImagenBaseDatos(objetoTransaccional);
        }
    }
}
