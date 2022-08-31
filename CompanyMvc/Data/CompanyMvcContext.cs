using Microsoft.EntityFrameworkCore;
using CompanyMvc.Models;

namespace CompanyMvc.Data
{
    public class CompanyMvcContext : DbContext
    {
        public CompanyMvcContext(DbContextOptions<CompanyMvcContext> options)
            : base(options)
        {
        }

        public DbSet<CompanyMvc.Models.Employee> Employee { get; set; }
        public DbSet<CompanyMvc.Models.Admin> Admin { get; set; }
        public DbSet<CompanyMvc.Models.DemandeDeCongé> DemandeDeCongé { get; set; }
    }
}
