using ejercicio_claseFullStack.herencia;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace ejercicio_claseFullStack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class herenciaController : ControllerBase
    {
        [HttpGet]
        public String getperro()
        {
            Animal perro = new Perro();
            perro.raza = "beagle ";
            perro.comida();
            return perro.comida();
        }
    }
}
