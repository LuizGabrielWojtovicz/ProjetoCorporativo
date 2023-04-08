using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoErp.Models;

namespace ProjetoErp.Data.Map
{
    public class FornecedorMap
    {
        public void Configure(EntityTypeBuilder<FornecedorModel> builder)
        {
            builder.Property(x => x.nome_FN).IsRequired().HasMaxLength(250);
            builder.Property(x => x.enderecoLocal_FN).HasMaxLength(250);
            builder.Property(x => x.numeroTelefone_FN).HasMaxLength(250);
            builder.Property(x => x.enderecoEmail_FN).HasMaxLength(250);
            builder.Property(x => x.documentoCnpj_FN).HasMaxLength(250);
            builder.Property(x => x.descricao_FN).HasMaxLength(500);
        }
    }
}
