using domus_deco_store.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace domus_deco_store.Data
{
    public class DomusDbContext:IdentityDbContext<Usuario>
    {
        public DomusDbContext(DbContextOptions<DomusDbContext> options):base (options)
        {
        }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoDetalle> PedidoDetalles { get; set; }
        public DbSet<FavoritoProducto> FavoritoProductos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Producto>()
                .Property(p => p.Precio)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Pedido>()
                .Property(p => p.Total)
                .HasPrecision(18, 2);

            modelBuilder.Entity<PedidoDetalle>()
                .Property(pd => pd.PrecioUnitario)
                .HasPrecision(18, 2);

            // Clave compuesta (opcional pero recomendada)
            modelBuilder.Entity<PedidoDetalle>()
                .HasKey(pd => new { pd.PedidoId, pd.ProductoId });
        }
    }
}
