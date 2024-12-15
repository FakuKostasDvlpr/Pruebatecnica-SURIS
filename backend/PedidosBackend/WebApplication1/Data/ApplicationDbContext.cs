using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoDetalle> PedidoDetalles { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    // Relación Pedido -> PedidoDetalle
        //    modelBuilder.Entity<Pedido>()
        //        .HasMany(p => p.Detalles)
        //        .WithOne(d => d.Pedido)
        //        .HasForeignKey(d => d.PedidoId)
        //        .OnDelete(DeleteBehavior.Cascade);

        //    // Relación Pedido -> Vendedor
        //    modelBuilder.Entity<Pedido>()
        //        .HasOne(p => p.Vendedor)
        //        .WithMany()
        //        .HasForeignKey(p => p.VendedorId)
        //        .OnDelete(DeleteBehavior.Restrict);
        //}
    }
}
