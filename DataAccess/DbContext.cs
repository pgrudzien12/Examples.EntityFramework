using System.Data.Entity;
using WebApplication.DataAccess.Entities;

namespace WebApplication.DataAccess
{
    [DbConfigurationType(typeof(CodeConfig))]
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

    public class CodeConfig : DbConfiguration
    {
        public CodeConfig()
        {
            SetDefaultConnectionFactory(new System.Data.Entity.Infrastructure.SqlConnectionFactory());
            SetProviderServices("System.Data.SqlClient",
                        System.Data.Entity.SqlServer.SqlProviderServices.Instance);
        }
    }
}