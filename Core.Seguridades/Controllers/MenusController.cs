using Core.Common.Model.General;
using Core.Seguridades.Model.Transaccion.Response.Configuracion;
using Microsoft.AspNetCore.Mvc;

namespace Core.Seguridades.Controllers
{
    [Route("api/[menu]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public MenusController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
    }
}
