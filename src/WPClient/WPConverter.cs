using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WPClient
{
    public class WPConverter
    {
        public static IEnumerable<WPBlog> ToBlogs(string jsonStr)
        {
            JArray jsonArray = JArray.Parse(jsonStr);
            IEnumerable<WPBlog> blogs = jsonArray
                .Select(jBlog => ToBlog(jBlog))
                .ToList();
            return blogs;
        }

        public static WPBlog ToBlog(JToken jBlog)
        {
            int id = (int)jBlog["id"];
            DateTime? date = (DateTime?)jBlog["date"];
            string title = (string)jBlog["title"]["rendered"];
            string content = (string)jBlog["content"]["rendered"];
            WPBlog blog = new WPBlog(title, date, content);
            return blog;
        }
    }
}
