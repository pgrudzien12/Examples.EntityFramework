using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.DataAccess.Entities;

namespace WebApplication.DataAccess
{
    public interface IPostRepository
    {
        Post Get(int id);
        IEnumerable<Post> GetAll();
    }
}
