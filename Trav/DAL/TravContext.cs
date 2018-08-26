using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Trav.Models;

namespace Trav.DAL
{
    public class TravContext : DbContext
    {
        public TravContext() : base("TravContext")
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Trip> Trips { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}