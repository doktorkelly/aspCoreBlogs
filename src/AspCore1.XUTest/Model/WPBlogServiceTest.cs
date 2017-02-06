using AspCore1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AspCore1.XUTest.Model
{
    public class WPBlogServiceTest
    {
        [Fact]
        public void FindAll_x_y()
        {
            //arrange
            IBlogService service = new WPBlogService();

            //act
            IEnumerable<Blog> blogs = service.FindAll();

            //assert
            Assert.NotEmpty(blogs);
        }
    }
}
