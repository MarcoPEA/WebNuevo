using Microsoft.EntityFrameworkCore;
using ProyectoW.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ProyectoW.Data
{
    public class SpContext : IdentityDbContext<IdentityUser>
    {
        public SpContext(DbContextOptions<SpContext> options)
            : base(options)
        {
        }

        public DbSet<Categorias> categorias { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Detalle> DetallePs { get; set; }
    }
}