using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Core.Seguridades.Controllers
{
    [Route("api/Core.Seguridades")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {

        //[HttpPost]
        //[Route("RegistrarSolicitudCredito/{nombreConcesionario}")]
        //[Produces(typeof(EstructuraBase<RegistrarSolicitudCreditoResponse>))]
        //public IActionResult ObtenerUsuario()
        //{

        //    Usuario transaccion = this.GenerarTransaccion<Usuario>();

        //    EstructuraBase<TestResponse> respue = this.Obtener<TestTrx, TestResponse, TestInsertarObjetoIN>(
        //        new TestInsertarObjetoIN(), 
        //        transaccion);


        //    return ObjectResult(HttpStatusCode.Created.ToString(), respuesta);
        //}



    }
}
