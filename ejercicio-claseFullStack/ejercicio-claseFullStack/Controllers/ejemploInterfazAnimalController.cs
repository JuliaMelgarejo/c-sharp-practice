using ejercicio_claseFullStack.ejemplointerface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ejercicio_claseFullStack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ejemploInterfazAnimalController : ControllerBase
    {
        [HttpGet]
        public string ejemploInterface()
        {
            Perro perro = new Perro();
            return perro.raza();
        }

    }
}
