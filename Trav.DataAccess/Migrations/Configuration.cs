using System.Data.Entity.Migrations;

namespace Trav.DataAccess.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<TravContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Trav.DAL.TravContext";
        }

        protected override void Seed(TravContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
