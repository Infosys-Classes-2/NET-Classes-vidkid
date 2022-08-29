using HelloWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloWeb.Data
{
    public class DataEmployeeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=vidkidDB;Integrated Security=True;");
            
        }
            public DbSet<Employee> Employees { get; set; }
    }
}
