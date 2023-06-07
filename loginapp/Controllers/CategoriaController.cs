using loginapp.Db.Contexts;
using loginapp.Db.Tables;
using loginapp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace loginapp.Controllers
{
    [ApiController]
    [Route("/api/categorias")]
    public class CategoriaController : ControllerBase
    {
        private MiBDContext _db;

        public CategoriaController(MiBDContext context)
        {
            _db = context;
        }

        //GET CATEGORIA
        [HttpGet]
        [Route("")]
        public ActionResult<List<CategoriaModel>> ListarCategoria()
        {
            var categorias = _db.Categorias.ToList();
            return Ok(categorias);
        }
        
        //POST CATEGORIA - CREAR CATEGORIA
        [HttpPost]
        [Route("")]
        public ActionResult<CategoriaModel> CrearCategoria(
            [FromBody] CategoriaModel categoria
            )
        {

                _db.Categorias.Add(categoria);
            int cat = 0;
            try
            {
                cat = _db.SaveChanges();
                //IDENTIFICAR ERROR Y MENCIONAR CREACION EXISTENTE
            }catch(DbUpdateException ex)
            {
                return StatusCode(500, new CustomErrorResponse
                {
                    Codigo = "",
                    Error = $"la categoria {categoria.Nombre} ya esxiste"
                });
            }
            catch(Exception ex)
            {
            }

            if (cat < 1)
            {
                return StatusCode(500, new CustomErrorResponse
                {
                    Codigo = "",
                    Error = "No se pudo crear"
                });
            }
 
            return Ok(categoria);
        }
            
    }
}
