using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoErp.Models;

namespace ProjetoErp.Data.Map
{
    public class FuncionarioMap : IEntityTypeConfiguration<FuncionariosModel>
    {
        public void Configure(EntityTypeBuilder<FuncionariosModel> builder)
        {
            builder.HasKey(x => x.id_FN);
            builder.Property(x => x.nome_FN).IsRequired().HasMaxLength(250);
        }
    }
}
