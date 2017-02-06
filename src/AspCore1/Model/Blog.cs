using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCore1.Model
{
    public class Blog
    {
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Text { get; set; }
        public string Short { get {
                int length = Math.Min(Text.Length, 40);
                return Text?.Substring(0, length);
            } }

        public Blog(string title, string text, DateTime? created = null)
        {
            this.Title = title;
            this.Text = text;
            this.CreatedAt = created ?? DateTime.Now;
        }
    }
}
