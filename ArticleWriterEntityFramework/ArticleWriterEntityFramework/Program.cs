using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleWriterEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            DBContext db = new DBContext();
            Console.WriteLine(db.Writers.First().Name);
        }
    }
}
