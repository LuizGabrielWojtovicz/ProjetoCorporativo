using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoErp.Models;

namespace ProjetoErp.Data.Map
{
    public class ProdutoVendidoMap : IEntityTypeConfiguration<ProdutoVendidoModel>
    {
        public void Configure(EntityTypeBuilder<ProdutoVendidoModel> builder)
        {
            builder.HasKey(x => x.id_PV);
            builder.Property(x => x.quantidade_CR).IsRequired().HasMaxLength(250);
        }
    }
}
