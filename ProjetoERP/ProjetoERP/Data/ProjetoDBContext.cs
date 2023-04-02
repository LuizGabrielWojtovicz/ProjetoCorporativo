using Microsoft.EntityFrameworkCore;
using ProjetoErp.Models;

namespace ProjetoErp.Data
{
    public class ProjetoDBContext : DbContext {

        public ProjetoDBContext(DbContextOptions<ProjetoDBContext> options)
            : base(options)
        {
        }

        public DbSet<FuncionariosModel> Funcionarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
