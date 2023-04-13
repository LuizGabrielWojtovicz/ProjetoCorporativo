using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoErp.Models;

namespace ProjetoErp.Data.Map
{
    public class DemandaMap 
    {
        public void Configure(EntityTypeBuilder<DemandaModel> builder)
        {
            builder.HasKey(x => x.id_DM);
            builder.Property(x => x.id_FN).IsRequired();
            builder.Property(x => x.id_PD).IsRequired();
            builder.Property(x => x.quantidadeAdicionada).IsRequired();
        }
    }
}
