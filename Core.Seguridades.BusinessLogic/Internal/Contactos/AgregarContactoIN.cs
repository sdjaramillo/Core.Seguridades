using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.Contactos;
using Core.Seguridades.Model.Transaccion.Response.Contactos;
using Core.Seguridades.Model.Transaccion.Transaccional.Contactos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Internal.Contactos
{
    public class AgregarContactoIN : IInsertar<ContactosTrx, AgregarContactoResponse>
    {
        public void AgregarInformacion(ContactosTrx objetoTransaccional)
        {
            
        }

        public void HomologarInformacion(ContactosTrx objetoTransaccional)
        {
            
        }

        public void InsertarInformacion(ContactosTrx objetoTransaccional)
        {
            AgregarContactoBLL.AgregarContacto(objetoTransaccional);
        }

        public void ValidarInformacion(ContactosTrx objetoTransaccional)
        {
            ValidarDatosContactoBLL.ValidarCamposVaciosContactoRequest(objetoTransaccional);
        }
    }
}
