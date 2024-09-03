using Microsoft.EntityFrameworkCore;
using product.Controllers;

namespace product.Models
{
    public class EmployeeDbContext : DbContext
    { 
        public DbSet<Employeecs> Employee1 { get; set; }
       
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {

        }
    }       
}

           
        

        

    



