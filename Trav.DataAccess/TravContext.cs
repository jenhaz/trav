using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Trav.DataAccess.Countries;
using Trav.DataAccess.Trips;

namespace Trav.DataAccess
{
    public class TravContext : DbContext
    {
        public TravContext() : base("TravContext")
        {
        }

        public DbSet<CountryDao> Countries { get; set; }
        public DbSet<Trip> Trips { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}