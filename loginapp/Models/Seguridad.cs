namespace loginapp.Models
{
    public class DatosUsuarioLogeado
    {
        public int UsuarioId { get; set; }
        public string Usuario { get; set; }
        public string Nombres { get; set; }
        public string Rol { get; set; }
    }

    public class LoginRequest
    {
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
    }

    public class LoginResponse
    {
        public DatosUsuarioLogeado Usuario { get; set; }
        public string Token { get; set; }
    }
}
