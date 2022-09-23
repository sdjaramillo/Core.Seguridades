using Core.Common.Model.Transaccion;
using Core.Seguridades.Model.Entidad.Noticias;
using Core.Seguridades.Model.Transaccion.Request.Noticias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Transaccional.Noticias
{
    public class NoticiaTrx : TransaccionBase
    {
        public NoticiaTrx()
        {
            ListadoNoticias = new List<Noticia>();
            NombreRedRequest = "";
            CodigoNoticia = "";
            NoticiaRequest = new NoticiaRequest();
            NoticiaValida = new Noticia();
        }
        public List<Noticia> ListadoNoticias { get; set; }
        public string NombreRedRequest { get; set; }
        public NoticiaRequest NoticiaRequest { get; set; }
        public Noticia NoticiaValida { get; set; }
        public string CodigoNoticia { get; set; }
    }
}
