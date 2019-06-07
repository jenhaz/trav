using System.ComponentModel.DataAnnotations.Schema;

namespace Trav.DataAccess.Countries
{
    [Table("Country")]
    public class CountryDao
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool Visited { get; set; }
    }
}