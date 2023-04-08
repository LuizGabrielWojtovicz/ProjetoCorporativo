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

        public DbSet<FuncionarioModel> Funcionarios { get; set; }
        public DbSet<ClienteModel> Clientes { get; set; }

        public DbSet<ProdutoModel> Produtos { get; set; }

        public DbSet<FornecedorModel> Fornecedores{ get; set; }

        public DbSet<ProdutoVendidoModel> Carrinho { get; set; }

        public DbSet<VendaModel> Vendas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FuncionarioMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
