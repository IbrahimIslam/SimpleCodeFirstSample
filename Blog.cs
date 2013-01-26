using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstApp
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string BlogName { get; set; }
        public string BlogUrl { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
}
