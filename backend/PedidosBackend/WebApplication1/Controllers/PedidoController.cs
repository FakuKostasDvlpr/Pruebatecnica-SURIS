using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PedidoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetPedidos()
        {
            var pedidos = _context.Pedidos
                 .Include(p => p.Detalles)
                 .ToListAsync();
            return Ok(pedidos);
        }

        [HttpPost]
        public IActionResult CreatePedido([FromBody] Pedido pedido)
        {
            if (pedido == null || pedido.Detalles == null || pedido.Detalles.Count == 0)
            {
                return BadRequest("El pedido debe contener al menos un artículo.");
            }

            // Verificar existencia del vendedor
            var vendedor = _context.Vendedores.Find(pedido.VendedorId);
            if (vendedor == null)
            {
                return NotFound("El vendedor no existe.");
            }

            // Agregar el pedido
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();

            return Ok(new { message = "Pedido creado con éxito", pedidoId = pedido.Id });
        }
    }
}
