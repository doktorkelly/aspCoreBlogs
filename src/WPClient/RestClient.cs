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
        public string RestEP { get; }

        public RestClient(string baseUrl, string ep, string mimeType = "application/json")
        {
            this.RestEP = ep;
            this.Client = new HttpClient();
            this.Client.BaseAddress = new Uri(baseUrl);
            this.Client.DefaultRequestHeaders.Accept.Clear();
            this.Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(mimeType));
        }

        public string GetBlogsAsString()
        {
            string requestUri = RestEP + "/posts";
            HttpResponseMessage response = Client.GetAsync(requestUri).Result;
            string result = response.Content.ReadAsStringAsync().Result;
            return result;
        }

        public IEnumerable<WPBlog> GetBlogs()
        {
            string requestUri = RestEP + "/posts";
            HttpResponseMessage response = Client.GetAsync(requestUri).Result;
            string jsonStr = response.Content.ReadAsStringAsync().Result;
            IEnumerable<WPBlog> wpBlogs = WPConverter.ToBlogs(jsonStr);
            return wpBlogs;
        }

    }
}
