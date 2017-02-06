using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WPClient;

namespace AspCore1.Model
{
    public class WPBlogService : IBlogService
    {
        public RestClient Client { get; }

        public WPBlogService()
        {
            string baseUrl = "http://vps323909.ovh.net";
            string ep = "sites/site2/index.php/wp-json/wp/v2";
            this.Client = new RestClient(baseUrl, ep);
        }

        public IEnumerable<Blog> FindAll()
        {
            IEnumerable<Blog> blogs = Client.GetBlogs()
                .Select(wpBlog => ToBlog(wpBlog))
                .ToList();
            return blogs;
        }

        public Blog FindByName(string name)
        {
            //TODO
            return null;
        }

        #region helper

        private Blog ToBlog(WPBlog wpBlog)
        {
            string title = wpBlog.Title;
            string text = wpBlog.Text;
            DateTime? created = wpBlog.CreatedAt;
            Blog blog = new Blog(title, text, created);
            return blog;
        }

        #endregion
    }
}
