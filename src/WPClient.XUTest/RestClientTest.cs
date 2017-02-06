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
            string baseUrl = "http://vps323909.ovh.net";
            string endpoint = "sites/site2/index.php/wp-json/wp/v2";
            RestClient client = new RestClient(baseUrl, endpoint);

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
            string endpoint = "sites/site2/index.php/wp-json/wp/v2";
            RestClient client = new RestClient(baseUrl, endpoint);

            //act
            IEnumerable<WPBlog> result = client.GetBlogs();

            //assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.True(result.Count() >= 5, "result.count > 5");
        }

    }
}
