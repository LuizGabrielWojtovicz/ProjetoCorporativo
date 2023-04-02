using Microsoft.EntityFrameworkCore;
using ProjetoErp.Data.Map;
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
            modelBuilder.ApplyConfiguration(new FuncionarioMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
