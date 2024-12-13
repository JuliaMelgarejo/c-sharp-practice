using ejercicio_claseFullStack.EjemploClaseAbstracta;
using Microsoft.AspNetCore.Mvc;

namespace ejercicio_claseFullStack.Controllers
{
    public class EjemploClaseAbstractaController : Controller
    {
        [HttpGet]
        [Route("/EjemploAuto")]
        public string EjemploClaseAbstractaAuto()
        {
            Auto auto = new Auto("Toyota");
            return auto.DistanciaRecorrida();
            
        }

        [HttpGet]
        [Route("/EjemploMoto")]
        public string EjemploClaseAbstractaMoto()
        {
            Moto moto = new Moto("Honda");
            return moto.DistanciaRecorrida();

        }
    }
}
