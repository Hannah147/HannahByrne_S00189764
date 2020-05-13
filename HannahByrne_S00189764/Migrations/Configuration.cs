namespace HannahByrne_S00189764.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HannahByrne_S00189764.PhoneData>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "HannahByrne_S00189764.PhoneData";
        }

        protected override void Seed(HannahByrne_S00189764.PhoneData context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
