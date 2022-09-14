using Core.Seguridades.DataAccess.FuenteImagenes;
using Core.Seguridades.Model.Transaccion.Transaccional.FuenteImagenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Ejecucion.FuenteImagenes
{
    public static class ObtenerListaFuenteImagenBLL
    {
        public static void ObtenerListaFuenteImagen(ImagenesTrx objetoTransaccional)
        {
            ObtenerListaFuenteImagenDAL.Execute(objetoTransaccional);
        }
    }
}
