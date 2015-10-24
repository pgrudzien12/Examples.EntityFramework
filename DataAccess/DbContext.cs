using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApplication.DataAccess.Entities;

namespace WebApplication.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : this("DefaultConnection")
        {
        }

        private ApplicationDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public static ApplicationDbContext Create(string nameOrConnectionString)
        {
            return new ApplicationDbContext(nameOrConnectionString);
        }

        public DbSet<User> Users{ get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}