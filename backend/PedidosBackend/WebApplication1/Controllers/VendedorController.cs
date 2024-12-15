using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedorController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VendedorController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetVendedores()
        {
            var Vendedores = _context.Vendedores.ToList();
            return Ok(Vendedores);
        }
    }

}
