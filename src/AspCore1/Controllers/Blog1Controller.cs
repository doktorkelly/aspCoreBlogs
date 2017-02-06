using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using AspCore1.Model;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AspCore1.Controllers
{
    public class Blog1Controller : Controller
    {
        private IBlogService BlogService { get; set; }

        public Blog1Controller(IBlogService blogService = null)
        {
            this.BlogService = blogService;
            //this.BlogService = blogService ?? new InMemoryBlogService();
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            IEnumerable<Blog> blogs = BlogService.FindAll();
            return View(blogs);
        }

        public IActionResult Detail(string ID)
        {
            Blog blog = BlogService.FindByName(ID);
            return View(blog);
        }

        #region off methods

        public IActionResult ListBlogs(string name, int num)
        {
            ViewData["name"] = name;
            ViewData["num"] = num;
            return View();
            //string result = $"ListBlogs with {name} and {num}";
            //return HtmlEncoder.Default.Encode(result);
        }

        #endregion
    }
}
