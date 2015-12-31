namespace Week10Lab.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Week10Lab.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Week10Lab.Models.ApplicationDbContext context)
        {
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

            context.Pins.AddOrUpdate(

                p=> new { p.ImagePath, p.Url},
                    new Pin { ImagePath = "", Url = "" },
                    new Pin { ImagePath = "", Url = "" },
                    new Pin { ImagePath = "", Url = "" },
                    new Pin { ImagePath = "", Url = "" },
                    new Pin { ImagePath = "", Url = "" },
                    new Pin { ImagePath = "", Url = "" },
                    new Pin { ImagePath = "", Url = "" }
                );
        }
    }
}
