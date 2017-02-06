using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WPClient
{
    public class RestClient
    {
        public HttpClient Client { get; }

        public RestClient(string baseUrl, string mimeType = "application/json")
        {
            this.Client = new HttpClient();
            this.Client.BaseAddress = new Uri(baseUrl);
            this.Client.DefaultRequestHeaders.Accept.Clear();
            this.Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(mimeType));
        }

        public string GetBlogsAsString()
        {
            string requestUri = "sites/site2/index.php/wp-json/wp/v2/posts"; //todo
            HttpResponseMessage response = Client.GetAsync(requestUri).Result;
            string result = response.Content.ReadAsStringAsync().Result;
            return result;
        }

        public IEnumerable<WPBlog> GetBlogs()
        {
            string requestUri = "sites/site2/index.php/wp-json/wp/v2/posts"; //todo
            HttpResponseMessage response = Client.GetAsync(requestUri).Result;
            string jsonStr = response.Content.ReadAsStringAsync().Result;
            IEnumerable<WPBlog> wpBlogs = WPConverter.ToBlogs(jsonStr);
            return wpBlogs;
        }



        #region depracated methods

        public IEnumerable<WPBlog> GetBlogs_OFF()
        {
            //TODO
            //HttpResponseMessage response = Client.GetAsync(requestUri).Result;
            //IEnumerable<WPBlog> blogs = response.Content.ReadAsAsync<IEnumerable<WPBlog>>();
            //string requestUri = "api/blogs"; //todo
            //Stream respStream = Client.GetStreamAsync(requestUri).Result;
            //var serializer = new DataContractJsonSerializer(typeof(IEnumerable<WPBlog>));
            //IEnumerable<WPBlog> blogs = serializer.ReadObject(respStream) as IEnumerable<WPBlog>;
            //return blogs;
            return null;
        }

        //public IEnumerable<WPBlog> JsonToBlog(string jsonBlogs)
        //{
        //    JavaScriptSerializer
        //    var blogs = JsonConvert.DeserializeObject(jsonBlogs);
        //    return blogs;
        //}

        #endregion

    }
}
