using ejercicio_claseFullStack.ejemplointerface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ejercicio_claseFullStack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseControllerAnimal : ControllerBase
    {
        [HttpGet]
        public BaseControllerAnimal()
        {
            BaseAnimal base = new BaseAnimal();
            Perro perro = new Perro();
            return BaseAnimal.raza();
        }
        
    }
}
