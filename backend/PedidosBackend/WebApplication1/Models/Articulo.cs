namespace WebApplication1.Models
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; } // Agregado según tu JSON
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Deposito { get; set; } // Cambiado a int
    }
}
