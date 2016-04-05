using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleWriterEntityFramework
{
    public class Article
    {
        public string Headline { get; set; }
        public string Text { get; set; }
        public int? WriterId { get; set; }
        public Writer Writer { get; set; }
    }
}
