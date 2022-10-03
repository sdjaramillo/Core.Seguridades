using Core.Seguridades.Model.Entidad.Contactos;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Contactos;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Contactos
{
    public static class ValidarExistenciaContactoBLL
    {
        public static void ExistenciaContactoBaseDatos(ContactosTrx objetoTransaccional) 
        {
            List<Contacto> ListaContactoBaseDatos = objetoTransaccional.ListaContactos.ToList();
            if (ListaContactoBaseDatos.Count > 0)
            {
                try
                {
                    var contactoVerificado = ListaContactoBaseDatos.Single(x => x.NombreRed.ToString() == objetoTransaccional.ContactoRequest.NombreRed.ToString());
                    objetoTransaccional.ContactoValido = contactoVerificado;
                }catch(Exception e)
                {
                    Console.WriteLine(e.ToString());
                    objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorContacto.NoExisteContactoBaseDatos;
                }
            }
            else
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorContacto.NoExisteContactoBaseDatos;
            }
        }
    }
}
