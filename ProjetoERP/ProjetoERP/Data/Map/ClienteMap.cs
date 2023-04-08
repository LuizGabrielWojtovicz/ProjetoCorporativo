using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoErp.Models;

namespace ProjetoErp.Data.Map
{
    public class ClienteMap
    {
        public void Configure(EntityTypeBuilder<ClienteModel> builder)
        {
            builder.Property(x => x.nome_CT).IsRequired().HasMaxLength(250);
            builder.Property(x => x.enderecoEmail_CT).HasMaxLength(250);
            builder.Property(x => x.numeroTelefone_CT).HasMaxLength(250);
            builder.Property(x => x.enderecoLocal_CT).HasMaxLength(250);
        }
    }
}
