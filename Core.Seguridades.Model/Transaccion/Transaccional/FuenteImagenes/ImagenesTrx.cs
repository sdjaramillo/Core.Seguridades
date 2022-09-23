using Core.Common.Model.Transaccion;
using Core.Seguridades.Model.Entidad.FuenteImagenes;
using Core.Seguridades.Model.Transaccion.Request.FuenteImagenes;

namespace Core.Seguridades.Model.Transaccion.Transaccional.FuenteImagenes
{
    public class ImagenesTrx : TransaccionBase
    {
        public ImagenesTrx()
        {
            ListaImagen = new List<Imagen>();
            NuevaImagenRequest = new AgregarActualizarFuenteImagenRequest();
            ImagenRequest = new ObtenerListaFuenteImagenRequest();
            ImagenValida = new Imagen();
            ListaImagenTotal = new List<Imagen>();
        }
        public List<Imagen> ListaImagen { get; set; }
        public ObtenerListaFuenteImagenRequest ImagenRequest { get; set; }
        public AgregarActualizarFuenteImagenRequest NuevaImagenRequest { get; set; }
        public string ImagenCodigo { get; set; }
        public Imagen ImagenValida { get; set; }
        public List<Imagen> ListaImagenTotal { get; set; }
    }
}
