using Core.Seguridades.Model.Entidad.FuenteImagenes;

namespace Core.Seguridades.Model.Transaccion.Response.FuenteImagenes
{
    public class EliminarFuenteImagenResponse
    {
        public EliminarFuenteImagenResponse()
        {
            ImagenEliminada = new Imagen();
        }
        public Imagen ImagenEliminada;
    }
}
