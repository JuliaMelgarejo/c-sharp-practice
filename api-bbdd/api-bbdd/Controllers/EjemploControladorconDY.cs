using api_bbdd.ejemploSinDI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api_bbdd.ejemploConDI;

namespace api_bbdd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploControladorconDY : ControllerBase
    {

        private IEmailServiceConDY _emailServiceConDY;
        public EjemploControladorconDY(IEmailServiceConDY emailServiceConDY)
        {
            _emailServiceConDY = emailServiceConDY;
        }
        [HttpGet]
        public bool EnviarMail([FromQuery] string mail)
        {
            UsuarioServiceConDI usuarioServiceConDI = new UsuarioServiceConDI(_emailServiceConDY);
            usuarioServiceConDI.enviarNotificacionUsuarionconDY(mail);
            return true;
        }
    }
}
