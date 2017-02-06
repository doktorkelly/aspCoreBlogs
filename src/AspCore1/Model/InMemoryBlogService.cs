using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCore1.Model
{
    public class InMemoryBlogService : IBlogService
    {
        static IEnumerable<Blog> BlogList = new List<Blog>() {
            new Blog("blog1", "xxx xxx xxx"),
            new Blog("blog2", "xxx xxx xxx"),
            new Blog("blog3", "xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx xxx ")
        };

        public IEnumerable<Blog> FindAll()
        {
            return BlogList;
        }

        public Blog FindByName(string title)
        {
            Blog blog = BlogList
                .Where(bl => bl.Title == title)
                .FirstOrDefault();             
            return blog;
        }
    }
}
