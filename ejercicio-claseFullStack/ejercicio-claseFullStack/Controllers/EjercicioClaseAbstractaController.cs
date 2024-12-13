using ejercicio_claseFullStack.EjemploClaseAbstracta;
using Microsoft.AspNetCore.Mvc;

namespace ejercicio_claseFullStack.Controllers
{
    public class EjercicioClaseAbstractaController : Controller
    {
        [HttpGet]
        [Route("/EjercicioPerro")]
        public string EjercicioPerroClaseAbstracta()
        {
            Perro perro = new Perro("beagle");
            return perro.Caracteristicas();

        }

        [HttpGet]
        [Route("/EjerccioGato")]
        public string EjercicioGatoClaseAbstracta()
        {
            Gato gato = new Gato("siames");
            return gato.Caracteristicas();

        }

    }
}
