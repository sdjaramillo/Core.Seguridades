using Core.Seguridades.Model.Transaccion.Request.Contactos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Response.Contactos
{
    public class AgregarContactoResponse
    {
        public AgregarContactoResponse()
        {
            NuevoContacto = new ContactoRequest();
        }
        public ContactoRequest NuevoContacto { get; set; }
    }
}
