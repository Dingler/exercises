using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleWriterEntityFramework
{
    public class DBContext : DbContext
    {
        public DBContext() : base("Name=AZUREDB")
        {

        }

        public DbSet<Writer> Writers { get; set; }
        public DbSet<Article> Articles { get; set; }

    }
}
