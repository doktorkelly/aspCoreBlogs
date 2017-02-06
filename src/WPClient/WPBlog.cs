using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WPClient
{
    public class WPBlog
    {
        public string Title { get; }
        public DateTime? CreatedAt { get; }
        public string Text { get; }

        public WPBlog(string title, DateTime? created, string text)
        {
            this.Title = title;
            this.CreatedAt = created;
            this.Text = text;
        }
    }
}
