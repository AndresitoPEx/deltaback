using loginapp.Models;
using Microsoft.AspNetCore.Mvc;

namespace loginapp.Controllers
{
    [ApiController]
    [Route("/api/Productos")]
    public class ProductosController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Producto>> ListarProductos()
        {
            List<Producto> productos = new List<Producto>();

            productos.Add( new Producto()
            {
                Id = 1,
                Nombre = "Chaleco Alfa A",
                Precio = 253.99m,
                Categoria = "Chaleco",
            } );

        

            return Ok(productos);
        }
        
    }
}
