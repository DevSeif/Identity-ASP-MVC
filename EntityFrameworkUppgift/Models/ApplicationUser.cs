using Microsoft.AspNetCore.Identity;

namespace EntityFrameworkUppgift.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public bool CheckAdmin { get; set; }
    }
}
