using Microsoft.EntityFrameworkCore;
using SiteLanches.Models;

namespace SiteLanches.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Lanche> Lanches { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}