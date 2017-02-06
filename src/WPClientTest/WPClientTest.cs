using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using WPClient;

namespace WPClientTest
{
    [TestFixture]
    public class WPClientTest
    {
        [Test]
        public void GetBlogsAsString_x_y()
        {
            //arrange
            string baseUrl = ""; //todo
            RestClient client = new RestClient(baseUrl);

            //act
            string result = client.GetBlogsAsString();

            //assert
            Assert.IsNotNull(result);
        }
    }
}
