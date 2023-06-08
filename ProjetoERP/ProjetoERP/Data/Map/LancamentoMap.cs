using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoErp.Models;

namespace ProjetoErp.Data.Map
{
    public class LancamentoContabilMap : IEntityTypeConfiguration<LancamentoContabil>
    {
        public void Configure(EntityTypeBuilder<LancamentoContabil> builder)
        {
            builder.HasKey(x => x.id);

            builder.Property(x => x.valor).IsRequired();

            // Relacionamento com a ContaModel
            builder.HasOne(x => x.conta)
                .WithMany(c => c.lancamentos)
                .HasForeignKey(x => x.conta.id)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Property(x => x.tipo).IsRequired().HasConversion<string>();

        }
    }
}
