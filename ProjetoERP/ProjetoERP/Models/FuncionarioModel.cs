
/*
*MT <=> MATERIAIS
*PD <=> PRODUTOS
*VD <=> VENDAS
*CT <=> CLIENTES
*FN <=> FUNCIONARIOS
*PV <=> PRODUTOS VENDIDOS
*/

using System.ComponentModel.DataAnnotations;

namespace ProjetoErp.Models
{
    public class FuncionarioModel
    {
        //Primary Key
        [Key]
        public int id_FN { get; set; }

        //Attributes
        public string? nome_FN { get; set; }
        public string? enderecoLocal_FN { get; set; }
        public string? numeroTelefone_FN { get; set; }
        public string? enderecoEmail_FN { get; set; }
        public string? cargo_FN { get; set; }
        public int? anoContratacao_FN { get; set; }
        public string? documentoCpf_FN { get; set; }
        public double salario_FN { get; set; }
    }
}
