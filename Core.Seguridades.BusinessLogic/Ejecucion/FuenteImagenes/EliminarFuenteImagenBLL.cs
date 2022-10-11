using Core.Seguridades.DataAccess.FuenteImagenes;
using Core.Seguridades.Model.Transaccion.Transaccional.FuenteImagenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Ejecucion.FuenteImagenes
{
    public static class EliminarFuenteImagenBLL
    {
        public static void EliminarFuenteImagen(ImagenesTrx objetoTransaccional)
        {
            EliminarFuenteImagenDAL.Execute(objetoTransaccional);
        }
    }
}
