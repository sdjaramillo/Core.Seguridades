using Core.Seguridades.DataAccess.FuenteImagenes;
using Core.Seguridades.Model.Transaccion.Transaccional.FuenteImagenes;

namespace Core.Seguridades.BusinessLogic.Ejecucion.FuenteImagenes
{
    public static class ObtenerTodaFuenteImagenBLL
    {
        public static void ObtenerListaImagenes(ImagenesTrx objetoTransaccional)
        {
            ObtenerTodaFuenteImagenDAL.Execute(objetoTransaccional);
        }
    }
}
