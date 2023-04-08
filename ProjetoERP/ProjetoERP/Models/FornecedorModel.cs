using System.ComponentModel.DataAnnotations;

namespace ProjetoErp.Models
{
    public class FornecedorModel
    {
        //Primary Key FornecedorModel
        [Key]
        public int id_FN { get; set; }

        //Attributes
        public string? nome_FN { get; set; }
        public string? enderecoLocal_FN { get; set; }
        public string? numeroTelefone_FN { get; set; }
        public string? enderecoEmail_FN { get; set; }
        public string? documentoCnpj_FN { get; set; }
        public string? descricao_FN { get; set; }
    }
}
