using loginapp.Db.Contexts;
using loginapp.Db.Tables;
using loginapp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace loginapp.Controllers
{

    [ApiController]
    [Route("/api/imagenes")]
    public class ImagenController : ControllerBase
    {
        private MiBDContext _db;
        public ImagenController(MiBDContext context) 
        { 
            _db = context;
        }

        //GET - Imagenes
        [HttpGet]
        [Route("")]
        public ActionResult<List<ImagenModel>> ListarImagen()
        {
            var imagenes = _db.Imagenes.ToList();
            return Ok(imagenes);
        }

        //POST - Imagenes
        [HttpPost]
        [Route("")]
        public ActionResult<ImagenModel> CrearImagen (
            [FromBody] ImagenModel imagen)
        {
            _db.Imagenes.Add(imagen);
            int imag = 0;
            try
            {
                imag = _db.SaveChanges();
            }catch(DbUpdateException ex)
            {
                return StatusCode(500, new CustomErrorResponse
                {
                    Codigo = "",
                    Error = "La imagen que intenta registrar ya existe"
                });
            }
            return Ok(imagen);
        }
    }
}
