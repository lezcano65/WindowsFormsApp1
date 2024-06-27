using Microsoft.EntityFrameworkCore;
using GestionStockWeb.Models;
namespace GestionStockWeb.Data
{
    public class StockDBContext: DbContext
    {
       
        public StockDBContext(DbContextOptions<StockDBContext> options): base(options) 
        {

        }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Compra> Compras { get; set; }

        public DbSet<Models.Producto> Productos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Venta> Ventas { get; set; }

        //define carateristicas de la tabla
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>(tb =>
            {
                tb.HasKey(col => col.UsuarioId);
                tb.Property(col => col.UsuarioId)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

                tb.Property(col => col.NombreU).HasMaxLength(50);
                tb.Property(col => col.HashU).HasMaxLength(50);
                tb.Property(col => col.Salt).HasMaxLength(50);

            });

            modelBuilder.Entity<Usuario>().ToTable("Usuario");
        }
    }
}
