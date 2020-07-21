namespace codefirstapp.Migrations
{
    using codefirstapp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<codefirstapp.Data.PlayerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations";
        }

        protected override void Seed(codefirstapp.Data.PlayerContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Players.AddOrUpdate(p => p.Name, new Players { Name = "Venkatesh",City="Kurnool",District="Pembarthi",Pincode=515009 },
                                            new Players { Name = "latha", City = "Dhone", District = "Pembarthi", Pincode = 515679 });
            context.SaveChanges();
        }
    }
}
