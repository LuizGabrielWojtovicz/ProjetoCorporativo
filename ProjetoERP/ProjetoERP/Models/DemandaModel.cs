using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoErp.Models
{
    public class DemandaModel
    {

        [Key]
        public int id_DM { get; set; }

       
        public int id_FN { get; set; }

        
        public int id_PD { get; set;}
       
        public int quantidadeAdicionada { get; set; }
    
    }
}
