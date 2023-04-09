using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoErp.Models;

namespace ProjetoErp.Data.Map
{
    public class VendaMap : IEntityTypeConfiguration<VendaModel>
    {
        public void Configure(EntityTypeBuilder<VendaModel> builder)
        {
            builder.HasKey(x => x.id_VD);

            builder.Property(x => x.data_VD).IsRequired();
            builder.Property(x => x.status_VD).IsRequired();
            builder.Property(x => x.valorTotal_VD).IsRequired();
            builder.Property(x => x.desconto_VD).IsRequired();
            builder.Property(x => x.metodoPagamento_VD).IsRequired();
            builder.Property(x => x.tipoVenda_VD).IsRequired();
            builder.Property(x => x.descricao_VD).HasMaxLength(500);
            builder.Property(x => x.id_CT).IsRequired();
            builder.Property(x => x.id_FN).IsRequired();

           
        }
    }
}
