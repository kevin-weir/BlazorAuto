using Microsoft.EntityFrameworkCore;

namespace BlazorAuto.API.Models
{
    public class APIContext(DbContextOptions<APIContext> options) : DbContext(options)
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {

            //base.OnModelCreating(modelBuilder);
        }
    }
}
