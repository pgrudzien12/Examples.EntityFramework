using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace WebApplication.DataAccess.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : this("DefaultConnection")
        {
        }

        public ApplicationDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public DbSet<User> Users{ get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}