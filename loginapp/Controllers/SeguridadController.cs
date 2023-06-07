using loginapp.Models;
using Microsoft.AspNetCore.Mvc;

namespace loginapp.Controllers
{
    [ApiController]
    [Route("/api/seguridad")]
    public class SeguridadController : ControllerBase
    {
        private string usuario = "superadmin@mimail.com";
        private string clave = "123456";


        [HttpPost]
        [Route("login")]
        public ActionResult< LoginResponse > Login(
            [FromBody] LoginRequest req) {

            // Mock -> doble de prueba
            // Mockear -> implementar dobles de prueba
            if ( req.Usuario == this.usuario && req.Contrasena == this.clave )
            {

                // Mock de datos del usuario
                DatosUsuarioLogeado datos = new DatosUsuarioLogeado()
                {
                    UsuarioId= 2,
                    Usuario = this.usuario,
                    Nombres = "Jose Roberto",
                    Rol = "superadmin"
                };


                LoginResponse response = new LoginResponse()
                {
                    Usuario = datos,
                    Token = "asdsadsa.asdsad.asdsd"
                };

                return Ok(response);
            } else
            {
                return BadRequest(new CustomErrorResponse()
                {
                    Codigo = "400",
                    Error = "Usuario o contraseña incorrecto.",
                    Detalle = ""
                });
            }


        }
    }
}
