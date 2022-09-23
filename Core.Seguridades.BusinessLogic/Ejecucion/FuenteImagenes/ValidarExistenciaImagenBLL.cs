using Core.Seguridades.Model.Entidad.FuenteImagenes;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.FuenteImagenes;
using System.Drawing;

namespace Core.Seguridades.BusinessLogic.Ejecucion.FuenteImagenes
{
    public static class ValidarExistenciaImagenBLL
    {
        public static void ExistenciaImagenBaseDatos(ImagenesTrx objetoTransaccional)
        {
            List<Imagen> listaImagenesBaseDatos = objetoTransaccional.ListaImagenTotal.ToList();
            if(listaImagenesBaseDatos.Count > 0)
            {
                var imagenVerificado = listaImagenesBaseDatos.Single(x => x.Codigo.ToString() == objetoTransaccional.ImagenCodigo.ToString());
                objetoTransaccional.ImagenValida = imagenVerificado;
            }
            else
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorImagen.NoExisteImagenBaseDatos;
            }
        }
    }
}
