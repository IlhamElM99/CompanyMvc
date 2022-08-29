using Microsoft.EntityFrameworkCore;

namespace CompanyMvc.Data
{
    public class CompanyMvcContext : DbContext
    {
        public CompanyMvcContext(DbContextOptions<CompanyMvcContext> options)
            : base(options)
        {
        }

        public DbSet<CompanyMvc.Models.Employee> Employee { get; set; }
    }
}
