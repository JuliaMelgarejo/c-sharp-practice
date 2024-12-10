using api_bbdd.ejemploSinDI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_bbdd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploSinDYController : ControllerBase
    {
        [HttpGet]
        public bool EnviarMail([FromQuery]string mail)
        {
            UsuarioServiceSinDI usuarioServiceSinDI = new UsuarioServiceSinDI();
            usuarioServiceSinDI.EnviarNotificacionUsuario(mail);
        return true ;
        }

        // new UsuarioServiceSinSY --> new EmailserviceSin>Dy --> enviar...
    }
}
