using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticuloController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ArticuloController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Articulo
        [HttpGet]
        public IActionResult GetArticulos()
        {
            // Filtrar los artículos del depósito 1
            var articulos = _context.Articulos.Where(a => a.Deposito == 1).ToList();
            return Ok(articulos);
        }
    }

}
