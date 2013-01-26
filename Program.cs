using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var oBlog = new Blog {BlogId=1,BlogName="Ibrahim Code book",BlogUrl="www.ibrahimcodebook.blogspot.com"};
            var oMyContext = new MyContext();
            oMyContext.Blogs.Add(oBlog);
            oMyContext.SaveChanges();
        }
    }
}
