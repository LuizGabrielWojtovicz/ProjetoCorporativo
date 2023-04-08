
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
    public class ClienteModel
    {
        //Primary Key ClientesModel
        [Key]
        public int id_CT { get; set; }

        //Attributes
        public string? nome_CT { get; set; }

        public string? enderecoLocal_CT { get; set; }
        public string? numeroTelefone_CT { get; set; }
        public string? enderecoEmail_CT { get; set; }
    }
}
