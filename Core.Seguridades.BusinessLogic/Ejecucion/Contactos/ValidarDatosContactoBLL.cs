using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Contactos;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Contactos
{
    public static class ValidarDatosContactoBLL
    {
        public static void ValidarCamposVaciosContactoRequest(ContactosTrx objetoTransaccional)
        {
            if(objetoTransaccional.ContactoRequest.NombreRed==null||
                objetoTransaccional.ContactoRequest.Cargo==null||
                objetoTransaccional.ContactoRequest.CorreoElectronico==null||
                objetoTransaccional.ContactoRequest.Extension==null||
                objetoTransaccional.ContactoRequest.NombreRed=="" ||
                objetoTransaccional.ContactoRequest.Cargo == "" ||
                objetoTransaccional.ContactoRequest.CorreoElectronico == "")
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorContacto.CamposVaciosContactoRequest;
                //throw new ExcepcionServicio((int)ErrorContacto.CamposVaciosContactoRequest);
            }
        }
    }
}
