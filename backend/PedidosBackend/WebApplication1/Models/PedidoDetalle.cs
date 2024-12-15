namespace WebApplication1.Models
{
    public class PedidoDetalle
    {
        public int Id { get; set; } // ID del detalle
        public string Codigo { get; set; } = string.Empty; // Código del producto
        public string Descripcion { get; set; } = string.Empty; // Descripción del producto
        public decimal Precio { get; set; } // Precio del producto
        public int Deposito { get; set; } // Depósito relacionado
    }

}
