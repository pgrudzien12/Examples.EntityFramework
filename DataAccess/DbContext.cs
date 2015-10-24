using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

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
    }
}