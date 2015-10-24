using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Post
    {
        public Post()
        {
            Comments = new List<Comment>();
        }

        public int Id { get; set; }

        public virtual User Author { get; set; }
        public virtual string Content { get; set; }
        public virtual string Title { get; set; }

        public virtual DateTime CreationDate { get; set; }
        public virtual DateTime ModificationDate { get; set; }

        public virtual List<Comment> Comments{ get; set; }
    }
}
