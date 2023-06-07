using loginapp.Db.Contexts;
using loginapp.Db.Tables;
using loginapp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace loginapp.Controllers
{
    [ApiController]
    [Route("/api/usuarios")]
    public class UsuarioController : ControllerBase
    {
        private MiBDContext _db;
        public UsuarioController(MiBDContext context)
        {
            _db = context;
        }

        [HttpGet]
        [Route("")]
        public ActionResult<List<UsuarioModel>> ListarUsuario()
        {
            var usuarios = _db.Usuarios.ToList();
            return Ok(usuarios);
        }

        [HttpPost]
        [Route("")]
        public ActionResult<UsuarioModel> CrearUsuario(
            [FromBody] UsuarioModel usuario)
        {
            _db.Usuarios.Add(usuario);
            int usu = 0;
            try
            {
                usu = _db.SaveChanges();
            } catch (DbUpdateException ex)
            {
                return StatusCode(500, new CustomErrorResponse
                {
                    Codigo = "",
                    Error = $"el usuario {usuario.nombre} ya existe"
                });
            }
            return Ok(usuario);
        }
    }
}
