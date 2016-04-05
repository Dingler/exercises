using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ArticleWriterEntityFramework
{
    public class Writer
    {
        public Writer()
        {
            this.Articles = new HashSet<Article>();
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public int WriterId { get; set; }
        public virtual ICollection<Article> Articles { get; set; }

    }
}
