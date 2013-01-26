using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstApp
{
    public class Post
    {
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
