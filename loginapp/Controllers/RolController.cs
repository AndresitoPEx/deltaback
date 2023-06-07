using loginapp.Db.Contexts;
using loginapp.Db.Tables;
using Microsoft.AspNetCore.Mvc;

namespace loginapp.Controllers
{
    [ApiController]
    [Route("/api/roles")]
    public class RolController : ControllerBase
    {
        private MiBDContext _db;

        public RolController(MiBDContext context)
        {
            _db = context;
        }

        [HttpGet]
        [Route("")]
        public ActionResult<List<RolModel>> ListarRol()
        {
            var roles = _db.Roles.ToList();
            return Ok(roles);
        }
    }
}
