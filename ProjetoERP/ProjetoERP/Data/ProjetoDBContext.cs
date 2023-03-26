using Microsoft.EntityFrameworkCore;

namespace ProjetoErp.Data
{
    public class ProjetoDBContext : DbContext
    {

        public ProjetoDBContext(DbContextOptions<ProjetoDBContext> option)  
            :base(option);
        {
        }
    
}
