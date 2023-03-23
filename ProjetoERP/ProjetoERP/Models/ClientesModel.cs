
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
    public class ClientesModel
    {
        //Primary Key ClientesModel
        [Key]
        public int id_CT { get; set; }

        //Attributes
        public string? nome_CT { get; set; }
    }
}
