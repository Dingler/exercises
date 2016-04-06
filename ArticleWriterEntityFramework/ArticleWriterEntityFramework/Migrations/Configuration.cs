namespace ArticleWriterEntityFramework.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ArticleWriterEntityFramework.DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ArticleWriterEntityFramework.DBContext context)
        {
            context.Writers.AddOrUpdate(w => w.Name,
                new Writer { Name = "Andreas Blom Oredsen" },
                new Writer { Name = "Heine Kristen" });

            context.Articles.AddOrUpdate(a => a.Headline,
                new Article { Headline = "My First Article!" });

            context.Writers.AddOrUpdate(w => w.Name, new Writer { Name = "Claus Lortepik" }.Articles.Add(new Article { Headline = "This is serious!", Text = "Oh my!" }));
            

            context.Writers.First().Articles.Add(context.Articles.First());

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
