using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoErp.Models;

namespace ProjetoErp.Data.Map
{
    public class ProdutoMap
    {
        public void Configure(EntityTypeBuilder<ProdutoModel> builder)
        {
            builder.Property(x => x.id_FN).IsRequired();
            builder.Property(x => x.nome_PD).IsRequired().HasMaxLength(250);
            builder.Property(x => x.quantidadeEstoque_PD).IsRequired();
            builder.Property(x => x.estoqueMinimo_PD).IsRequired();
            builder.Property(x => x.unidadeMedida_PD).HasMaxLength(250);
            builder.Property(x => x.estoqueMaximo_PD).IsRequired();
            builder.Property(x => x.precoCusto_PD).IsRequired();
            builder.Property(x => x.precoVenda_PD).IsRequired();
            builder.Property(x => x.dataVencimento_PD).IsRequired();
            builder.Property(x => x.importancia_PD).IsRequired();
            builder.Property(x => x.status_PD).IsRequired();
            builder.Property(x => x.descricao_PD).HasMaxLength(250);

        }
    }
}
