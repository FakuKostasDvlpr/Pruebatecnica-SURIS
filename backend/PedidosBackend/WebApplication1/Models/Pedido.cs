namespace WebApplication1.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        // Relación con Vendedor
        public int VendedorId { get; set; } // Clave foránea

        // Relación con PedidoDetalle
        public List<PedidoDetalle> Detalles { get; set; } = new List<PedidoDetalle>();

        public DateTime Fecha { get; set; } = DateTime.Now;
    }


}
