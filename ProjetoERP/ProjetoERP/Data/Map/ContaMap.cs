using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoErp.Models;

namespace ProjetoErp.Data.Map
{
    public class ContaMap
    {
        public void Configure(EntityTypeBuilder<ContaModel> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.codigo).IsRequired();
            builder.Property(x => x.descricao).IsRequired().HasMaxLength(250);
            builder.Property(x => x.tipo).IsRequired().HasConversion<string>();
            builder.HasMany(x => x.lancamentos).WithOne(x => x.conta).HasForeignKey(x => x.conta.id);     
        }
    }
}
