using Core.Common.Model.Transaccion.Respuesta;
using Core.Common.ProcessTemplate.Helper;
using Core.Seguridades.BusinessLogic.Internal.Contactos;
using Core.Seguridades.Model.Transaccion.Request.Contactos;
using Core.Seguridades.Model.Transaccion.Response.Contactos;
using Core.Seguridades.Model.Transaccion.Transaccional.Contactos;
using Microsoft.AspNetCore.Mvc;

namespace Core.Seguridades.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactoController : ControllerBase
    {
        [HttpPost]
        [Route("ObtenerListaContactos")]
        [Produces(typeof(EstructuraBase<ObtenerListaContactosResponse>))]
        public IActionResult ObtenerListaContactos([FromBody] string nombreRed)
        {
            ContactosTrx transaccion = this.GenerarTransaccion<ContactosTrx>();
            transaccion.NombreRed = nombreRed;

            EstructuraBase<ObtenerListaContactosResponse> respuesta = this.ObtenerTodos<ContactosTrx, ObtenerListaContactosResponse, ObtenerListaContactosIN>(
                new ObtenerListaContactosIN(),
                transaccion);

            return Ok(respuesta);
        }

        [HttpPost]
        [Route("AgregarContacto")]
        [Produces(typeof(EstructuraBase<AgregarContactoResponse>))]
        public IActionResult AgregarContacto([FromBody] ContactoRequest ContactoNueva)
        {
            ContactosTrx transaccion = this.GenerarTransaccion<ContactosTrx>();
            transaccion.ContactoRequest = ContactoNueva;

            EstructuraBase<AgregarContactoResponse> respuesta = this.Insertar<ContactosTrx, AgregarContactoResponse, AgregarContactoIN>(
                new AgregarContactoIN(),
                transaccion);

            return Ok(respuesta);
        }

        [HttpPut]
        [Route("ActualizarContacto")]
        [Produces(typeof(EstructuraBase<ActualizarContactoResponse>))]
        public IActionResult ActualizarContacto([FromBody] ContactoRequest ContactoRequest)
        {
            ContactosTrx transaccion = this.GenerarTransaccion<ContactosTrx>();
            transaccion.ContactoRequest = ContactoRequest;

            EstructuraBase<ActualizarContactoResponse> respuesta = this.Actualizar<ContactosTrx, ActualizarContactoResponse, ActualizarContactoIN>(
                new ActualizarContactoIN(),
                transaccion);

            return Ok(respuesta);
        }

        [HttpDelete]
        [Route("EliminarContacto")]
        [Produces(typeof(EstructuraBase<EliminarContactoResponse>))]
        public IActionResult EliminarContacto([FromBody] string nombreRed)
        {
            ContactosTrx transaccion = this.GenerarTransaccion<ContactosTrx>();
            transaccion.ContactoRequest.NombreRed = nombreRed;

            EstructuraBase<EliminarContactoResponse> respuesta = this.Eliminar<ContactosTrx, EliminarContactoResponse, EliminarContactoIN>(
                new EliminarContactoIN(),
                transaccion);

            return Ok(respuesta);
        }
    }
}
