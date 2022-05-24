using Microsoft.EntityFrameworkCore;

namespace Restaurant.Services.Product.DBContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {


        }
    }
}
