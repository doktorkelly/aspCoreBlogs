using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace WPClient.XUTest
{
    public class RestClientTest
    {
        [Fact]
        public void GetBlogsAsString_x_y()
        {
            //arrange
            //string baseUrl = "http://vps323909.ovh.net/sites/site2/index.php/wp-json/wp/v2";
            string baseUrl = "http://vps323909.ovh.net";
            RestClient client = new RestClient(baseUrl);

            //act
            string result = client.GetBlogsAsString();

            //assert
            Assert.NotNull(result);
        }

        [Fact]
        public void GetBlogs_x_y()
        {
            //arrange
            string baseUrl = "http://vps323909.ovh.net";
            RestClient client = new RestClient(baseUrl);

            //act
            IEnumerable<WPBlog> result = client.GetBlogs();

            //assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.True(result.Count() >= 5, "result.count > 5");
        }

    }
}
