using Microsoft.EntityFrameworkCore;
using Projeto_1.Models;

namespace Projeto_1.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<LivroModel> Livro { get; set; }
        public DbSet<UsuarioModel> Usuario { get; set; }
    }
}
