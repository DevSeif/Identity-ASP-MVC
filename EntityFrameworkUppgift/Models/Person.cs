using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkUppgift.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }

        public List<Language> Languages { get; set; } = new List<Language>();

    }
}