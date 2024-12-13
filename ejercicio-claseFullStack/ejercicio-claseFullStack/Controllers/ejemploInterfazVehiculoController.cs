using ejercicio_claseFullStack.ejemplointerface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ejercicio_claseFullStack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ejemploInterfazVehiculoController : ControllerBase
    {
        [HttpGet]
        public string ejemplointerfaz()
        {
            Moto moto = new Moto();
            return moto.Acelerar();
        }
    }
}
