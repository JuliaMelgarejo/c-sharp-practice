namespace api_bbdd.ejemploConDI
{
    public class UsuarioServiceConDI
    {
        private IEmailServiceConDY _emailServiceConDY;
        public UsuarioServiceConDI(IEmailServiceConDY emailServiceConDY)
        {
            emailServiceConDY = _emailServiceConDY;
        }

        public bool enviarNotificacionUsuarionconDY(string email)
        {
        _emailServiceConDY.Enviar(email, "notificacion");
            return true;
        }
            
    }
}
