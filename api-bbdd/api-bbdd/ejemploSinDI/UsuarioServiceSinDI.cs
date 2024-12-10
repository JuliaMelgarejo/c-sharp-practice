namespace api_bbdd.ejemploSinDI
{
    public class UsuarioServiceSinDI
    {
        public EmailServiceSInDY emailServiceSInDY { get; set; }

        public UsuarioServiceSinDI() {
            emailServiceSInDY = new EmailServiceSInDY();
        }
        public bool EnviarNotificacionUsuario(string email) {
            emailServiceSInDY.Enviar(email, "notificacion");
            return true;
        }
    }
}
