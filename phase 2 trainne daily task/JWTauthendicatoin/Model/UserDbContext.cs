using Microsoft.EntityFrameworkCore;

namespace JWTauthendicatoin.Model
{
    public class UserDbContext:DbContext
    {
        public DbSet<Student>? students { get; set; }
        public DbSet<User>? Users { get; set; }


        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)

        {

        }
    }
}

    


    

