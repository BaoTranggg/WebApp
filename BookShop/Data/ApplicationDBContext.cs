using Microsoft.EntityFrameworkCore;

namespace BookShop.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        {
            
        }
    }
}
