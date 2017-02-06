using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCore1.Model
{
    public class WPBlogService : IBlogService
    {
        public IEnumerable<Blog> FindAll()
        {
            //TODO
            return new List<Blog>();
        }

        public Blog FindByName(string name)
        {
            //TODO
            return null;
        }
    }
}
