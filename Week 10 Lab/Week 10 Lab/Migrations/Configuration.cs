namespace Week_10_Lab.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Week_10_Lab.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Week_10_Lab.Models.ApplicationDbContext context)
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

                p => new { p.ImagePath, p.Url },

                    new Pin { ImagePath = "https://s-media-cache-ak0.pinimg.com/236x/7c/28/66/7c2866e76df2ae511ba732699cd609eb.jpg", Url = "http://www.bt-images.net/car-pictures/" },
                    new Pin { ImagePath = "https://s-media-cache-ak0.pinimg.com/736x/81/a7/0e/81a70e3bec4a6e3c7077d94b9ff5ca14.jpg", Url = "http://www.carhoots.com/blog" },
                    new Pin { ImagePath = "https://s-media-cache-ak0.pinimg.com/736x/c1/55/41/c1554173311218c1eae72994c1d18ece.jpg", Url = "https://instagram.com/p/73_HbvlUvl/" },
                    new Pin { ImagePath = "https://s-media-cache-ak0.pinimg.com/736x/0a/e4/e9/0ae4e92f9e26bcf39392995dc4d84131.jpg", Url = "http://thecuratedcars.tumblr.com/image/132947991418" },
                    new Pin { ImagePath = "https://s-media-cache-ak0.pinimg.com/736x/e7/06/6e/e7066ecd8ca30f83419c003de1b57f43.jpg", Url = "http://www.ebay.com/motors/garage?roken2=ta.p3hwzkq71.bdream-cars" },
                    new Pin { ImagePath = "https://s-media-cache-ak0.pinimg.com/736x/be/61/b1/be61b1987e4e55372bd82c4c8fc0200c.jpg", Url = "http://svpicks.com/breathtaking-ferrari-photos/" },
                    new Pin { ImagePath = "https://s-media-cache-ak0.pinimg.com/736x/38/ad/7f/38ad7f27d106266a682ecbd3220ebed8.jpg", Url = "http://www.bt-images.net/car-pictures/" }
                                    );
        }
    }
}
