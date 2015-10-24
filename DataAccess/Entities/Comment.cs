using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Comment
    {
        public Comment()
        {

        }

        public virtual int Id { get; set; }
        public virtual int PostId { get; set; }
               
        public virtual User Author { get; set; }
        public virtual string Content { get; set; }
        public virtual string Title { get; set; }
               
        public virtual DateTime CreationDate { get; set; }
        public virtual DateTime ModificationDate { get; set; }
               
        public virtual Post Post { get; set; }
    }
}
