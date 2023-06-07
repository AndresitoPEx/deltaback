using loginapp.Db.Contexts;
using loginapp.Db.Tables;
using loginapp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace loginapp.Controllers
{
    [ApiController]
    [Route("/api/producto")]
    public class ProductoController : ControllerBase
    {
        private MiBDContext _db;

        public ProductoController(MiBDContext context)
        {
            _db = context;
        }

        //GET PRODUCTOS
        [HttpGet]
        [Route("")]
        public ActionResult<List<ProductoModel>> ListarProducto()
        {
            var productos = _db.Productos.ToList();
            return Ok(productos);
        }

        //POST PRODUCTOS - Creacion
        [HttpPost]
        [Route("")]
        public ActionResult<ProductoModel> CrearProducto([FromBody] ProductoModel producto) 
        {
            _db.Productos.Add(producto);
            int pro = 0;
            try
            {
                pro = _db.SaveChanges();
            } catch (DbUpdateException ex)
            {
                return StatusCode(500, new CustomErrorResponse
                {
                    Codigo = "",
                    Error = $"el producto {producto.Nombre} ya existe"
                });
            }
            return Ok(producto);
        }
    }
}
