using Core.Seguridades.Model.Transaccion.Request.Noticias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Response.Noticias
{
    public class AgregarNoticiaResponse
    {
        public AgregarNoticiaResponse()
        {
            NuevaNotica=new NoticiaRequest();
        }
        public NoticiaRequest NuevaNotica { get; set; }
    }
}
