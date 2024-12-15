using Newtonsoft.Json;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public static class DataSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.Articulos.Any())
            {
                var articulos = JsonConvert.DeserializeObject<List<Articulo>>(File.ReadAllText("JsonFiles/articulos.json"));
                context.Articulos.AddRange(articulos);
            }

            if (!context.Vendedores.Any())
            {
                var vendedores = JsonConvert.DeserializeObject<List<Vendedor>>(File.ReadAllText("JsonFiles/vendedores.json"));
                context.Vendedores.AddRange(vendedores);
            }

            context.SaveChanges();
        }
    }
}
