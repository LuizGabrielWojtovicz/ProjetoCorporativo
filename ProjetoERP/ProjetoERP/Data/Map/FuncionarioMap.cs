using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoErp.Models;

namespace ProjetoErp.Data.Map
{
    public class FuncionarioMap : IEntityTypeConfiguration<FuncionarioModel>
    {
        public void Configure(EntityTypeBuilder<FuncionarioModel> builder)
        {
            builder.Property(x => x.nome_FN).IsRequired().HasMaxLength(250);
            builder.Property(x => x.cargo_FN).IsRequired().HasMaxLength(250);
            builder.Property(x => x.documentoCpf_FN).HasMaxLength(250);
            builder.Property(x => x.numeroTelefone_FN).HasMaxLength(250);
            builder.Property(x => x.anoContratacao_FN).HasMaxLength(250);
            builder.Property(x => x.salario_FN).HasMaxLength(250);
        }
    }
}
