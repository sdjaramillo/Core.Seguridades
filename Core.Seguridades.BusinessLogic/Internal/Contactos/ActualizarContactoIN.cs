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
    public class ActualizarContactoIN : IActualizar<ContactosTrx, ActualizarContactoResponse>
    {
        public void ActualizarInformacion(ContactosTrx objetoTransaccional)
        {
            ActualizarContactoBLL.ActualizarContacto(objetoTransaccional);
        }

        public void AgregarInformacion(ContactosTrx objetoTransaccional)
        {
            ObtenerListaContactosBLL.ObtenerListaContactos(objetoTransaccional);
        }

        public void HomologarInformacion(ContactosTrx objetoTransaccional)
        {
            
        }

        public void ValidarInformacion(ContactosTrx objetoTransaccional)
        {
            ValidarDatosContactoBLL.ValidarCamposVaciosContactoRequest(objetoTransaccional);
            ValidarExistenciaContactoBLL.ExistenciaContactoBaseDatos(objetoTransaccional);
        }
    }
}
