using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.DataAccess.Entities;

namespace WebApplication.DataAccess
{
    public class SqlPostRepository : IPostRepository
    {
        private ApplicationDbContext context;

        public SqlPostRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Post Get(int id)
        {
            return context.Posts.Find(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return context.Posts;
        }
    }
}
