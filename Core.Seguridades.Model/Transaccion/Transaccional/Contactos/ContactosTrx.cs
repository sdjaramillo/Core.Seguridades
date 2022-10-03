using Core.Common.Model.Transaccion;
using Core.Seguridades.Model.Entidad.Contactos;
using Core.Seguridades.Model.Transaccion.Request.Contactos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Transaccional.Contactos
{
    public class ContactosTrx : TransaccionBase
    {
        public ContactosTrx()
        {
            ListaContactos = new List<Contacto>();
            ContactoRequest = new ContactoRequest();
            ContactoCodigo = "";
            NombreRed = "";
            ContactoValido = new Contacto();
        }
        public List<Contacto> ListaContactos { get; set; }
        public string ContactoCodigo { get; set; }
        public string NombreRed { get; set; }
        public ContactoRequest ContactoRequest { get; set; }
        public Contacto ContactoValido { get; set; }
    }
}
