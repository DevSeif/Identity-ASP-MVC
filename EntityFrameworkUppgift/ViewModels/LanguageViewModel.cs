using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkUppgift.ViewModels
{
    public class LanguageViewModel
    {
        [Required]
        public string LanguageName { get; set; }

        public int LanguageId { get; set; }

        public int PersonId { get; set; }
    }
}
